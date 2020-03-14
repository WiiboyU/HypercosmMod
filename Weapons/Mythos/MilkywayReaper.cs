using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
namespace HypercosmMod.Items.Weapons.Mythos
{
    public class MilkywayReaper : ModItem
    {
        public override void SetDefaults()
        {
            item.value = Item.buyPrice(platinum: 2);
            item.damage = 46;           
            item.melee = true;
            item.width = 78;
            item.height = 88;
            item.useTime = 10;
            item.useAnimation = 20;
            item.noUseGraphic = true;
            item.useStyle = 1;
            item.knockBack = 5;
            item.value = 8;
            item.rare = 3;
            item.shootSpeed = 12f;
            item.shoot = mod.ProjectileType ("MilkywayReaperProjectile");
            item.UseSound = SoundID.Item9;
            item.autoReuse = true;
	}

        public override bool CanUseItem(Player player)       //this make that you can shoot only 1 boomerang at once
        {
            for (int i = 0; i < 1000; ++i)
            {
                if (Main.projectile[i].active && Main.projectile[i].owner == Main.myPlayer && Main.projectile[i].type == item.shoot)
                {
                    return false;
                }
            }
            return true;
        }
    }
}