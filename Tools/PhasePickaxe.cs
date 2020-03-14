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
    public class PhasePickaxe : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Phase Pickaxe");
            Tooltip.SetDefault("");
        }

        public override void SetDefaults()
        {
            item.value = Item.buyPrice(gold: 3);
            item.damage = 35; 
            item.melee = true;
            item.width = 48; 
            item.height = 48; 
            item.useTime = 18;
            item.useAnimation = 15; 
            item.useStyle = 1;
            item.knockBack = 5;
            item.value = Item.buyPrice(gold: 15);
            item.rare = 7; 
            item.UseSound = SoundID.Item1; 
            item.autoReuse = true; 
            item.pick = 200; 
        }
		public override void AddRecipes() {
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod.ItemType("ConcentratedMoonstone"), 8);
                        recipe.AddIngredient(mod.ItemType("MoonlitCrystal"),4);
			recipe.AddTile(134);
			recipe.SetResult(this);
			recipe.AddRecipe();
        }
    }
}