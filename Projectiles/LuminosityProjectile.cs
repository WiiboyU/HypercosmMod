using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
 
namespace HypercosmMod.Projectiles
{
    public class LuminosityProjectile : ModProjectile
    {
        public override void SetStaticDefaults()
        {
            
            DisplayName.SetDefault("Luminosity");
        }
        public override void SetDefaults()
        {
            
            projectile.width = 15;
            projectile.height = 20;
            projectile.friendly = true;
            projectile.aiStyle = 1;
            projectile.thrown = true;
            projectile.penetrate = 3;      
            projectile.extraUpdates = 1;
            projectile.friendly = true;
            projectile.hostile = false;
            aiType = ProjectileID.BoneJavelin;
       }

        public override void AI()
        {            
                        Dust dust = Dust.NewDustDirect(projectile.position, projectile.width, projectile.height, 
                        mod.DustType("StarlightDust"));
                        dust.noGravity = true;
                        dust.scale = 1f;
{
  Lighting.AddLight(projectile.position, 0.224f, 0.149f, 0.229f);

{
                projectile.ai[0] += 1f;
            if (projectile.ai[0] >= 50f)       //how much time the projectile can travel before landing
            {
                projectile.velocity.Y = projectile.velocity.Y + 0.15f;    // projectile fall velocity
                projectile.velocity.X = projectile.velocity.X * 0.99f;    // projectile velocity
     }
		}
}
}
        public override bool OnTileCollide(Vector2 oldVelocity)
        {                                                           // sound that the projectile make when hiting the terrain
            {
                projectile.Kill();
 
                Main.PlaySound(2, (int)projectile.position.X, (int)projectile.position.Y, 10);
            }
            return false;
        }
}
        }