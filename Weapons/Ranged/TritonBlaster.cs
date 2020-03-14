using Microsoft.Xna.Framework;
using System.Collections.Generic;
using System.Linq;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;
using System.Diagnostics;
using System;

namespace HypercosmMod.Items.Weapons.Ranged
{
	public class TritonBlaster : ModItem
	{
		public override void SetStaticDefaults() {
			Tooltip.SetDefault("Lobs arcing large moonlit crystals at a short range");
		}

		public override void SetDefaults() {
			item.damage = 68;
			item.ranged = true;
			item.width = 64;
			item.height = 28;
			item.useTime = 10;
			item.useAnimation = 20;
			item.useStyle = 5;
			item.noMelee = true;
			item.knockBack = 5;
            item.value = Item.buyPrice(silver: 54);
            item.rare = 4;
			item.UseSound = SoundID.Item9;
			item.autoReuse = true;
			item.shoot = mod.ProjectileType("BigMoonCrystalFriendly");
			item.shootSpeed = 6f;
		}

        public override Vector2? HoldoutOffset()

        {

            return new Vector2(0, 0);

        }

		public override void AddRecipes() {
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod.ItemType("ConcentratedMoonstone"), 12);
                        recipe.AddIngredient(mod.ItemType("MoonlitCrystal"),6);
			recipe.AddTile(134);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}