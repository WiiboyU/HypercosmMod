using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
namespace HypercosmMod.Items.Weapons.Melee
{
    public class ShinyHammer : ModItem
    {
        public override void SetDefaults()
        {
            item.damage = 28;           
            item.melee = true;
            item.width = 40;
            item.height = 40;
            item.useTime = 20;
            item.useAnimation = 20;
            item.noUseGraphic = true;
            item.useStyle = 1;
            item.knockBack = 5;
            item.value = Item.buyPrice(silver: 50, copper:18);
            item.rare = 3;
            item.shootSpeed = 8f;
            item.shoot = mod.ProjectileType ("ShinyHammerProjectile");
            item.UseSound = SoundID.Item1;
            item.autoReuse = true;
	}

		public override void AddRecipes() {
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod.ItemType("StarlightPlating"), 6);
                        recipe.AddIngredient(ItemID.FallenStar, 4);
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