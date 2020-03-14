using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace HypercosmMod.Projectiles
{
    public class StarBatonProjectile : ModProjectile
    {
        public override void SetDefaults()
        {
            projectile.width = 40;
            projectile.height = 40;
            projectile.aiStyle = 3;
            projectile.friendly = true;
            projectile.ranged = true;
            projectile.magic = false;
            projectile.penetrate = 5;
            projectile.timeLeft = 600;
            projectile.light = 0.5f;
            projectile.extraUpdates = 1;
           
           
        }
		public override void AI()
		{
                        Dust dust = Dust.NewDustDirect(projectile.position, projectile.width, projectile.height, 
                        mod.DustType("StardustDust"));
                        dust.noGravity = true;
                        dust.scale = 1f;
		}
		
		public override void Kill(int timeLeft)
        {
            Main.PlaySound(SoundID.Item10, projectile.position);
                        Dust dust = Dust.NewDustDirect(projectile.position, projectile.width, projectile.height, 
                        mod.DustType("StardustDust"));
                        dust.noGravity = true;
                        dust.scale = 1f;
			Vector2 usePos = projectile.position; 
												  
			Vector2 rotVector =
				(projectile.rotation - MathHelper.ToRadians(90f)).ToRotationVector2();
			usePos += rotVector * 16f;

			for (int i = 0; i < 20; i++) {
		        usePos -= rotVector * 8f;
			}
        }
    }
}