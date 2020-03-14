using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace HypercosmMod.Projectiles
{
	public class StellarStar : ModProjectile
	{
		public override void SetDefaults() {
			projectile.width = 30;
			projectile.height = 32;
			projectile.friendly = true;
			projectile.magic = true;
			projectile.penetrate = 3;
			projectile.timeLeft = 600;
            projectile.CloneDefaults(ProjectileID.Starfury);
            aiType = ProjectileID.Starfury;
            projectile.friendly = true;
        }
		public override void AI()
		{
                        projectile.rotation += 0.4f * (float)projectile.direction;
                        Dust dust = Dust.NewDustDirect(projectile.position, projectile.width, projectile.height, 
                        mod.DustType("StarlightDust"));
                        dust.noGravity = true;
                        dust.scale = 1.5f;
        }
		
		public override void Kill(int timeLeft)
        {
            Main.PlaySound(SoundID.Item10, projectile.position);
                        Dust dust = Dust.NewDustDirect(projectile.position, projectile.width, projectile.height, 
                        mod.DustType("StarlightDust"));
                        dust.noGravity = true;
                        dust.scale = 2f;
			Vector2 usePos = projectile.position; 									
			}

public override void PostDraw(SpriteBatch spriteBatch, Color lightColor)
        {
            Texture2D texture = mod.GetTexture("Projectiles/StellarStar_Glowmask");
            spriteBatch.Draw
            (
                texture,
                new Vector2
                (
                    projectile.position.X - Main.screenPosition.X + projectile.width * 0.5f,
                    projectile.position.Y - Main.screenPosition.Y + projectile.height - texture.Height * 0.5f + 2f
                ),
                new Rectangle(0, 0, texture.Width, texture.Height),
                new Color(255 - projectile.alpha, 255 - projectile.alpha, 255 - projectile.alpha),
                projectile.rotation,
                texture.Size() * 0.5f,
                projectile.scale,
                SpriteEffects.None,
                0f
            );
        }
}
        }