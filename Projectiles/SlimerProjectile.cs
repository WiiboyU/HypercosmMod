using System;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using System.Collections.Generic;

namespace HypercosmMod.Projectiles
{
	
	public class SlimerProjectile : ModProjectile
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Slimer");
		}
		
		public override void SetDefaults()
		{
			projectile.width = 40;
			projectile.height = 36;
			projectile.friendly = true;
			projectile.ranged = true;
			projectile.tileCollide = true;
			projectile.penetrate = 2;
			projectile.timeLeft = 400;
			projectile.alpha = 255;
			projectile.light = 0.25f;
			projectile.extraUpdates = 1;
			projectile.ignoreWater = true;
			projectile.alpha = 0;
		}
		public override void AI()
		{
                        Dust dust = Dust.NewDustDirect(projectile.position, projectile.width, projectile.height, 
                        mod.DustType("SlimerDust"));
                        dust.noGravity = true;
                        dust.scale = 1f;
                        projectile.rotation = projectile.velocity.ToRotation();
		}
		
		public override void Kill(int timeLeft)
        {
            Main.PlaySound(SoundID.Item10, projectile.position);
                        Dust dust = Dust.NewDustDirect(projectile.position, projectile.width, projectile.height, 
                        mod.DustType("SlimerDust"));
                        dust.noGravity = true;
                        dust.scale = 1.75f;
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