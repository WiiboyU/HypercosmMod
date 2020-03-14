using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using Microsoft.Xna;
using System;

namespace HypercosmMod.Projectiles
{
    public class RhenzLaser : ModProjectile
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Rhenzium Laser");
        }

        public override void SetDefaults()
        {
            projectile.width = 48;
            projectile.height = 42;
            projectile.aiStyle = 18;
            projectile.friendly = false;
            projectile.hostile = true;
            projectile.melee = true;
            projectile.penetrate = -1;
            projectile.tileCollide = true;
            projectile.timeLeft = 50;
            projectile.CloneDefaults(ProjectileID.EyeLaser);
            aiType = ProjectileID.EyeLaser;
        }    
    }
}