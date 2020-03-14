using Terraria.ID;
using Terraria.ModLoader;
using Terraria;

namespace HypercosmMod.Items.Weapons.Magic
{
	public class Twinkleburst : ModItem
	{
		public override void SetStaticDefaults() {
			Tooltip.SetDefault("Launches massive galaxies at your enemies");
			Item.staff[item.type] = false; //this makes the useStyle animate as a staff instead of as a gun
		}

		public override void SetDefaults() {
			item.damage = 42;
			item.magic = true;
			item.mana = 13;
			item.width = 38;
			item.height = 38;
			item.useTime = 20;
			item.useAnimation = 25;
			item.useStyle = 5;
			item.noMelee = true; //so the item's animation doesn't do damage
			item.knockBack = 5;
			item.value = 10000;
			item.rare = 3;
			item.UseSound = SoundID.Item20;
			item.autoReuse = true;
			item.shoot = mod.ProjectileType("GalaxyBurst");
			item.shootSpeed = 10f;
}

		public override void AddRecipes() {
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod.ItemType("StarlightPlating"), 5);
                        recipe.AddIngredient(ItemID.FallenStar, 5);
			recipe.AddTile(16);
			recipe.SetResult(this);
			recipe.AddRecipe();}
		}
	}