using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace HypercosmMod.Items.Weapons.Melee
{
	public class LunaBlade : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Luna Blade");
		}
		public override void SetDefaults()
		{
			item.damage = 60;
			item.melee = true;
			item.width = 50;
			item.height = 64;
			item.useTime = 20;
			item.useAnimation = 19;
			item.useStyle = 1;
			item.knockBack = 6;
			item.value = Item.buyPrice(gold: 4);
			item.rare = 7;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}

		public override void AddRecipes() {
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod.ItemType("ConcentratedMoonstone"), 8);
                        recipe.AddIngredient(mod.ItemType("MoonlitCrystal"),10);
			recipe.AddTile(134);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}