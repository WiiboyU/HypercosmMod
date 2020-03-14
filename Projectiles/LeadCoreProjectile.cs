using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace HypercosmMod.Projectiles
{
	public class LeadCoreProjectile : ModProjectile
	{
		int target;
		

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Lead Core");
		}

		public override void SetDefaults()
		{
			projectile.width = 16;
            projectile.height = 16;
			projectile.ignoreWater = true;
			projectile.tileCollide = false;
            projectile.scale = 1f;
			projectile.penetrate = -1;
			projectile.timeLeft = 30;
            projectile.friendly = true;
            projectile.CloneDefaults(ProjectileID.SpikyBall);
            aiType = ProjectileID.SpikyBall;
        }
	}
}