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
	public class Slimer : ModItem
	{
		public override void SetStaticDefaults() {
			Tooltip.SetDefault("No-one expects the Vietcong!");
		}

		public override void SetDefaults() {
			item.damage = 58;
			item.ranged = true;
			item.width = 68;
			item.height = 36;
			item.useTime = 10;
			item.useAnimation = 20;
			item.useStyle = 5;
			item.noMelee = true;
			item.knockBack = 5;
			item.value = 2800;
			item.rare = 4;
			item.UseSound = SoundID.Item10;
			item.autoReuse = true;
			item.shoot = mod.ProjectileType("SlimerProjectile");
			item.shootSpeed = 6f;
                        item.useAmmo = AmmoID.Gel;
		}

        public override Vector2? HoldoutOffset()

        {

            return new Vector2(0, 0);

        }

		public override void AddRecipes() {
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.SlimeGun);
			recipe.AddIngredient(ItemID.HallowedBar);
			recipe.AddIngredient(ItemID.SoulofMight);
			recipe.AddTile(134);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}