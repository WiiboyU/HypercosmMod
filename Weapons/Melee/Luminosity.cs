using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.Graphics.Effects;
using Terraria.Graphics.Shaders;
using Terraria.ID;
using Terraria.ModLoader;
 
namespace HypercosmMod.Items.Weapons.Melee
{
    public class Luminosity : ModItem
    {
        public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Luminosity");
                        Tooltip.SetDefault("");  //The (English) text shown below your weapon's name
		}
        public override void SetDefaults()
        {
            
            item.damage = 24;           //this is the item damage
            item.thrown = true;             //this make the item do throwing damage
            item.width = 22;
            item.height = 60;
            item.useTime = 28;       //this is how fast you use the item
            item.useAnimation = 28;   //this is how fast the animation when the item is used
            item.useStyle = 1;      
            item.knockBack = 6;
            item.value = Item.buyPrice(gold: 2, silver: 73);
            item.rare = 3;
            item.autoReuse = true;       
            item.shoot = mod.ProjectileType("LuminosityProjectile");  
            item.shootSpeed = 8f;     
            item.useTurn = true;
            item.maxStack = 1;       
            item.noUseGraphic = true;
                       
        }

		public override void AddRecipes() {
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod.ItemType("StarPiercer"), 1);
			recipe.AddIngredient(mod.ItemType("StarlightPlating"), 4);
                        recipe.AddIngredient(ItemID.FallenStar, 6);
			recipe.AddTile(16);
			recipe.SetResult(this);
			recipe.AddRecipe();

        }
    }
}