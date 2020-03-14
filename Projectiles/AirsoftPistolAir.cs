using System;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using System.Collections.Generic;

namespace HypercosmMod.Projectiles
{
	
	public class AirsoftPistolAir : ModProjectile
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Airsoft Pistol");
		}
		
		public override void SetDefaults()
		{
			projectile.width = 20;
			projectile.height = 20;
			projectile.friendly = true;
			projectile.ranged = true;
			projectile.tileCollide = true;
			projectile.penetrate = 1;
			projectile.timeLeft = 400;
			projectile.alpha = 255;
			projectile.light = 0.25f;
			projectile.extraUpdates = 1;
			projectile.ignoreWater = true;
		}
		public override void AI()
		{
			projectile.rotation = (float)Math.Atan2((double)projectile.velocity.Y, (double)projectile.velocity.X) + 1.57f;
		}
	}
}
