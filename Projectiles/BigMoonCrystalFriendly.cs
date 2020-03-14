using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using Microsoft.Xna;
using System;

namespace HypercosmMod.Projectiles
{
    public class BigMoonCrystalFriendly : ModProjectile
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
            projectile.friendly = true;
            projectile.hostile = false;
            projectile.melee = true;
            projectile.penetrate = 1000000;
            projectile.tileCollide = true;
            projectile.timeLeft = 50;
            projectile.CloneDefaults(ProjectileID.DD2BetsyArrow);
            aiType = ProjectileID.DD2BetsyArrow;
        }    

    }
}