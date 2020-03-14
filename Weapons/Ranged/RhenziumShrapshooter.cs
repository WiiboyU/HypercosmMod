using Terraria.ID;
using Terraria.ModLoader;

namespace HypercosmMod.Items.Weapons.Ranged
{
	public class RhenziumShrapshooter : ModItem
	{
		public override void SetStaticDefaults() {
			Tooltip.SetDefault("");
		}

		public override void SetDefaults() {
			item.damage = 22;
			item.ranged = true;
			item.width = 20;
			item.height = 40;
			item.useTime = 20;
			item.useAnimation = 20;
			item.useStyle = 5;
			item.noMelee = true; //so the item's animation doesn't do damage
			item.knockBack = 4;
			item.value = 10000;
			item.rare = 2;
			item.UseSound = SoundID.Item11;
			item.autoReuse = true;
			item.shoot = 10; //idk why but all the guns in the vanilla source have this
			item.shootSpeed = 16f;
			item.useAmmo = AmmoID.Bullet;
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