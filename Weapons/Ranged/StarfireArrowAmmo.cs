using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace HypercosmMod.Items.Weapons.Ranged
{
	public class StarfireArrowAmmo : ModItem
	{
		public override void SetStaticDefaults() 
		{
			Tooltip.SetDefault("Pew pew!");
			DisplayName.SetDefault("Starfire Arrow");
		}

		public override void SetDefaults() {
			item.damage = 8;
			item.ranged = true;
			item.width = 18;
			item.height = 34;
			item.maxStack = 999;
			item.consumable = true;
			item.knockBack = 1.5f;
            item.value = Item.buyPrice(silver: 15);
            item.rare = 3;
			item.shoot = mod.ProjectileType("StarfireArrow");
			item.shootSpeed = 18f;
			item.ammo = AmmoID.Arrow;
		}

		public override void AddRecipes() {
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod.ItemType("StarlightPlating"), 1);
			recipe.AddTile(16);
			recipe.SetResult(this, 50);
			recipe.AddRecipe();
		}
	}
}