using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace HypercosmMod.Items.Weapons.Ranged
{
	public class MoonstrikerArrowAmmo : ModItem
	{
		public override void SetStaticDefaults() 
		{
			Tooltip.SetDefault("Nowhere to run, nowhere to hide!");
			DisplayName.SetDefault("Moonstriker Arrow");
		}

		public override void SetDefaults() {
			item.damage = 14;
			item.ranged = true;
			item.width = 14;
			item.height = 32;
			item.maxStack = 999;
			item.consumable = true;
			item.knockBack = 1.5f;
			item.value = 25;
			item.rare = 4;
			item.shoot = mod.ProjectileType("MoonstrikerArrow");
			item.shootSpeed = 18f;
			item.ammo = AmmoID.Arrow;
		}

		public override void AddRecipes() {
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod.ItemType("ConcentratedMoonstone"), 1);
			recipe.AddTile(134);
			recipe.SetResult(this, 150);
			recipe.AddRecipe();
		}
	}
}