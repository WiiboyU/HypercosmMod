using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
namespace HypercosmMod.Items.Weapons.Melee
{
    public class StarBaton : ModItem
    {
        public override void SetDefaults()
        {
            item.damage = 14;           
            item.melee = true;
            item.width = 52;
            item.height = 52;
            item.useTime = 10;
            item.useAnimation = 20;
            item.noUseGraphic = true;
            item.useStyle = 1;
            item.knockBack = 5;
            item.value = Item.buyPrice(silver: 30);
            item.rare = 3;
            item.shootSpeed = 8f;
            item.shoot = mod.ProjectileType ("StarBatonProjectile");
            item.UseSound = SoundID.Item1;
            item.autoReuse = true;
	}

		public override void AddRecipes() {
			ModRecipe recipe = new ModRecipe(mod);
                        recipe.AddIngredient(ItemID.FallenStar, 14);
			recipe.AddTile(16);
			recipe.SetResult(this);
			recipe.AddRecipe();}

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