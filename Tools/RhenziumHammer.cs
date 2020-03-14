using Microsoft.Xna.Framework;
using System.Collections.Generic;
using System.Linq;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;
using System.Diagnostics;
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
    public class RhenziumHammer : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Rhenzium Hammer");
            Tooltip.SetDefault("");
        }

        public override void SetDefaults()
        {
            item.value = Item.buyPrice(silver: 50);
            item.damage = 10; 
            item.melee = true;
            item.width = 34; 
            item.height = 36; 
            item.useTime = 18;
            item.useAnimation = 15; 
            item.useStyle = 1;
            item.knockBack = 5; 
            item.value = 5500; 
            item.rare = 7; 
            item.UseSound = SoundID.Item1; 
            item.autoReuse = true; 
            item.hammer = 50; 
        }

		public override void AddRecipes() {
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod.ItemType("RhenziumScraps"), 9);
			recipe.AddTile(16);
			recipe.SetResult(this);
			recipe.AddRecipe();
        }
    }
}