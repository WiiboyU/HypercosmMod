using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace HypercosmMod.Projectiles
{ 

    public class DylanBolt : ModProjectile
    {
        public override void SetStaticDefaults()
        {
            
            DisplayName.SetDefault("Reaper Scythe Bolt");
        }
        public override void SetDefaults()
        {
            
            projectile.width = 32;                   			 
            projectile.height = 68;          
   	    projectile.friendly = true;                
            projectile.melee = true;                   			  		
            projectile.tileCollide = false;
            projectile.penetrate = -1;                  					
            projectile.timeLeft = 200;   
                          			 	
            projectile.extraUpdates = 1;
            projectile.ignoreWater = false;
        }
	public override void AI()
        {
        if (Main.rand.NextBool()) 
        {
	Dust dust = Dust.NewDustDirect(projectile.position, projectile.width, projectile.height, mod.DustType("ScytheDust"));
        dust.noGravity = true;
	dust.scale = 1.6f;
        }
        projectile.rotation += 0.4f * (float)projectile.direction;
        Lighting.AddLight(projectile.Center, 1f, 0.6f, 0.6f);
        
        }
        public override void OnHitNPC(NPC target, int damage, float knockback, bool crit) 
        {
        target.immune[projectile.owner] = 7;
            
        }
    }
}
     
          






