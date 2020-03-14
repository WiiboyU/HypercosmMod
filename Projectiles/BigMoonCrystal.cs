using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using Microsoft.Xna;
using System;

namespace HypercosmMod.Projectiles
{
    public class BigMoonCrystal : ModProjectile
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Large Moonlit Crystal");
        }

        public override void SetDefaults()
        {
            projectile.width = 22;
            projectile.height = 52;
            projectile.aiStyle = 18;
            projectile.friendly = false;
            projectile.hostile = true;
            projectile.melee = true;
            projectile.penetrate = -1;
            projectile.tileCollide = true;
            projectile.timeLeft = 50;
            projectile.CloneDefaults(ProjectileID.DD2BetsyFireball);
            aiType = ProjectileID.DD2BetsyFireball;
        }    

    }
}