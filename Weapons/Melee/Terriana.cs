using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
 
namespace HypercosmMod.Items.Weapons.Melee
{
    public class Terriana : ModItem
    {
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Terriana");
			Tooltip.SetDefault("A lump of terrainous remnant");
		}
        public override void SetDefaults()
        {
            item.damage = 15;            
            item.melee = true;
            item.width = 26;
            item.height = 52;
            item.useTime = 16;
            item.useAnimation = 16;
            item.noUseGraphic = true;
            item.useStyle = 1;
            item.knockBack = 8;
            item.value = 8;
            item.rare = 2;
            item.shootSpeed = 11f;
            item.shoot = mod.ProjectileType ("TerrianaProjectile");
            item.UseSound = SoundID.Item1;
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
        public override void AddRecipes()
        {
                ModRecipe recipe = new ModRecipe(mod);
                recipe.AddIngredient(ItemID.DirtBlock, 30);
				recipe.AddIngredient(mod.ItemType("TerraRune"), 4);
				recipe.AddTile(16);
                recipe.SetResult(this);
                recipe.AddRecipe();
				recipe = new ModRecipe(mod);
                recipe.AddIngredient(ItemID.MudBlock, 30);
				recipe.AddIngredient(mod.ItemType("TerraRune"), 4);
				recipe.AddTile(16);
                recipe.SetResult(this);
                recipe.AddRecipe();
        }
    }
}