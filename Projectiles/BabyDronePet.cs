using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace HypercosmMod.Projectiles
{
	public class BabyDronePet : ModProjectile
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Baby Drone");
			Main.projFrames[projectile.type] = 1;
			Main.projPet[projectile.type] = true;
		}

		public override void SetDefaults()
		{
			projectile.CloneDefaults(ProjectileID.ZephyrFish);
			aiType = ProjectileID.ZephyrFish;
			projectile.scale = 1.3f;
		}

		public override bool PreAI()
		{
			Player player = Main.player[projectile.owner];
			player.zephyrfish = false;
			return true;
		}

		public override void AI()
		{
			Dust.NewDust(projectile.position, projectile.width, projectile.height, 244, 0f, 0f, 200, default(Color), 0.2f);
			Player player = Main.player[projectile.owner];
			HypercosmPlayer modPlayer = player.GetModPlayer<HypercosmPlayer>();
			if (player.dead)
			{
				modPlayer.babyDrone = false;
			}
			if (modPlayer.babyDrone)
			{
				projectile.timeLeft = 2;
			}
		}
	}
}