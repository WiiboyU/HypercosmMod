using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace HypercosmMod.Projectiles
{
	public class BigStarComet : ModProjectile
	{
		int target;
		

		public override void SetStaticDefaults()
		{
			ProjectileID.Sets.TrailCacheLength[projectile.type] = 6;
            ProjectileID.Sets.TrailingMode[projectile.type] = 0;
			DisplayName.SetDefault("Giga Comet Blast");
		}

		public override void SetDefaults()
		{
			projectile.width = 12;
            projectile.height = 12;
            
			projectile.hostile = true;
			projectile.ignoreWater = true;
			projectile.tileCollide = false;
            projectile.scale = 1f;
			projectile.penetrate = 1;

			projectile.timeLeft = 180;
		}
        public override Color? GetAlpha(Color lightColor)
        {
            return Color.White;
        }
		public override bool PreDraw(SpriteBatch spriteBatch, Color lightColor)
        {
            Vector2 drawOrigin = new Vector2(Main.projectileTexture[projectile.type].Width * 0.5f, projectile.height * 0.5f);
            for (int k = 0; k < projectile.oldPos.Length; k++)
            {
                Vector2 drawPos = projectile.oldPos[k] - Main.screenPosition + drawOrigin + new Vector2(0f, projectile.gfxOffY);
                Color color = projectile.GetAlpha(lightColor) * ((float)(projectile.oldPos.Length - k) / (float)projectile.oldPos.Length);
                spriteBatch.Draw(Main.projectileTexture[projectile.type], drawPos, null, color, projectile.rotation, drawOrigin, projectile.scale, SpriteEffects.None, 0f);
            }
            return true;
        }
		public override bool PreAI()
		{
			projectile.rotation = projectile.velocity.ToRotation() + 1.27F;

			if (projectile.ai[0] == 0 && Main.netMode != 1)
			{
				target = -1;
				float distance = 2000f;
				for (int k = 0; k < 255; k++)
				{
					if (Main.player[k].active && !Main.player[k].dead)
					{
						Vector2 center = Main.player[k].Center;
						float currentDistance = Vector2.Distance(center, projectile.Center);
						if (currentDistance < distance || target == -1)
						{
							distance = currentDistance;
							target = k;
						}
					}
				}
				if (target != -1)
				{
					projectile.ai[0] = 1;
					projectile.netUpdate = true;
				}
			}
			else
			{
				Player targetPlayer = Main.player[this.target];
				if (!targetPlayer.active || targetPlayer.dead)
				{
					this.target = -1;
					projectile.ai[0] = 0;
					projectile.netUpdate = true;
				}
				else
				{
					float currentRot = projectile.velocity.ToRotation();
					Vector2 direction = targetPlayer.Center - projectile.Center;
					float targetAngle = direction.ToRotation();
					if (direction == Vector2.Zero)
					{
						targetAngle = currentRot;
					}

					float desiredRot = currentRot.AngleLerp(targetAngle, 0.1f);
					projectile.velocity = new Vector2(projectile.velocity.Length(), 0f).RotatedBy(desiredRot, default(Vector2));
				}
			}

			if (projectile.timeLeft <= 60)
			{
				projectile.alpha -= 4;
			}

			return false;
		}
        
		

		public override void SendExtraAI(System.IO.BinaryWriter writer)
		{
			writer.Write(this.target);
		}

		public override void ReceiveExtraAI(System.IO.BinaryReader reader)
		{
			this.target = reader.Read();
		}

	    public override void Kill(int timeLeft)
        {
            Main.PlaySound(2, (int)projectile.position.X, (int)projectile.position.Y, 14);
			


        }
	}
}