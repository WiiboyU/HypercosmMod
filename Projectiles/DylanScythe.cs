using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
 
namespace HypercosmMod.Projectiles
{
    public class DylanScythe : ModProjectile
    {
        public override void SetStaticDefaults()
        {
            
            DisplayName.SetDefault("Reaper Scythe");
        }
        public override void SetDefaults()
        {
            projectile.tileCollide = false;
            projectile.width = 78;
            projectile.height = 86;
            projectile.aiStyle = 3;
            projectile.friendly = true;
            projectile.thrown = true;
            projectile.magic = false;
            projectile.penetrate = -1;
            projectile.timeLeft = 600;
            projectile.light = 0.0f;
            projectile.extraUpdates = 1;
        }
        public override void OnHitNPC(NPC target, int damage, float knockback, bool crit) 
        
        {
        target.immune[projectile.owner] = 8;
        }
        public override void AI()
        {
        Lighting.AddLight(projectile.Center, 1f, 0.6f, 0.6f);;
        
        if (Main.rand.NextBool()) 
        {
	Dust dust = Dust.NewDustDirect(projectile.position, projectile.width, projectile.height, mod.DustType("ScytheDust"));
        dust.noGravity = true;
	dust.scale = 1.6f;
        }
        
        for(int i = 0; i < 200; i++)
        {
        NPC target = Main.npc[i];
        
        if(!target.friendly)
        {
           
           float shootToX = target.position.X + (float)target.width * 0.5f - projectile.Center.X;
           float shootToY = target.position.Y - projectile.Center.Y;
           float distance = (float)System.Math.Sqrt((double)(shootToX * shootToX + shootToY * shootToY));

           
           if(distance < 480f && target.CanBeChasedBy(this))
           {
               
               distance = 3f / distance;
   
               
               shootToX *= distance * 5;
               shootToY *= distance * 5;

           
               projectile.velocity.X = shootToX;
               projectile.velocity.Y = shootToY;
         } }}
       }
    }
}
         
       

  
          






