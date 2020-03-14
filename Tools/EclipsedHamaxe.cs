using Microsoft.Xna.Framework;
using System.Collections.Generic;
using System.Linq;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;
using System.Diagnostics;
using System;

namespace HypercosmMod.Items.Tools
{
    public class EclipsedHamaxe : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Eclipse Hamaxe");
            Tooltip.SetDefault("");
        }

        public override void SetDefaults()
        {
            item.value = Item.buyPrice(gold: 2);
            item.damage = 48; 
            item.melee = true;
            item.width = 62; 
            item.height = 60; 
            item.useTime = 18;
            item.useAnimation = 15; 
            item.useStyle = 1;
            item.knockBack = 5;
            item.value = Item.buyPrice(gold: 16);
            item.rare = 7; 
            item.UseSound = SoundID.Item1; 
            item.autoReuse = true; 
            item.axe = 75; 
        }

		public override void AddRecipes() {
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod.ItemType("ConcentratedMoonstone"), 6);
                        recipe.AddIngredient(mod.ItemType("MoonlitCrystal"),4);
			recipe.AddTile(134);
			recipe.SetResult(this);
			recipe.AddRecipe();
        }
    }
}