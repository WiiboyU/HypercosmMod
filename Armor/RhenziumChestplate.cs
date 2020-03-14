using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace HypercosmMod.Items.Armor
{
	[AutoloadEquip(EquipType.Body)]
	public class RhenziumChestplate : ModItem
	{
		public override void SetStaticDefaults() {
			base.SetStaticDefaults();
			DisplayName.SetDefault("Rhenzium Chestplate");

		}

		public override void SetDefaults() {
			item.width = 24;
			item.height = 20;
			item.value = 10000;
			item.rare = 3;
			item.defense = 10;
		}

		public override void AddRecipes() {
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod.ItemType("RhenziumScraps"), 20);
			recipe.AddTile(16);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}