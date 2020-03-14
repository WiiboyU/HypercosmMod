using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace HypercosmMod.Projectiles
{
	public class MoonstrikerArrow : ModProjectile
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Moonstriker Arrow");     //The English name of the projectile
            ProjectileID.Sets.Homing[projectile.type] = true; 
		}
        public override void SetDefaults() 
{
            projectile.width = 12;  //Set the hitbox width
            projectile.height = 25;  //Set the hitbox height
            projectile.aiStyle = 1; //How the projectile works
            projectile.friendly = true;  //Tells the game whether it is friendly to players/friendly npcs or not
            projectile.hostile = false; //Tells the game whether it is hostile to players or not
            projectile.tileCollide = true; //Tells the game whether or not it can collide with a tile
            projectile.ignoreWater = true; //Tells the game whether or not projectile will be affected by water
            projectile.ranged = true;   //Tells the game whether it is a ranged projectile or not
            projectile.penetrate = 1; //Tells the game how many enemies it can hit before being destroyed
            projectile.timeLeft = 400; //The amount of time the projectile is alive for
            projectile.light = 2f; //This defines the projectile light
            aiType = 1; // this is the projectile ai style . 1 is for arrows style
        }
		public override void AI()
		{
                        Dust dust = Dust.NewDustDirect(projectile.position, projectile.width, projectile.height, 
                        mod.DustType("MoonCrystalDust"));
                        dust.noGravity = true;
                        dust.scale = 1f;
		}
		
		public override void Kill(int timeLeft)
        {
            Main.PlaySound(SoundID.Item10, projectile.position);
                        Dust dust = Dust.NewDustDirect(projectile.position, projectile.width, projectile.height, 
                        mod.DustType("MoonCrystalDust"));
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