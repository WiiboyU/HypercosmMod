using Terraria.ID;
using Terraria.ModLoader;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace HypercosmMod.Items.Weapons.Magic
{
	public class Corona : ModItem
	{
		public override void SetStaticDefaults() {
			Tooltip.SetDefault("Shoots a ball of fire that erupts with the force of a star");
			Item.staff[item.type] = true; //this makes the useStyle animate as a staff instead of as a gun
		}

		public override void SetDefaults() {
			item.damage = 20;
			item.magic = true;
			item.mana = 18;
			item.width = 32;
			item.height = 42;
			item.useTime = 25;
			item.useAnimation = 25;
			item.useStyle = 5;
			item.noMelee = true; //so the item's animation doesn't do damage
			item.knockBack = 5;
			item.value = 10000;
			item.rare = 3;
			item.UseSound = SoundID.Item20;
			item.autoReuse = true;
			item.shoot = ProjectileID.InfernoFriendlyBolt;
			item.shootSpeed = 13f;
}

		public override void AddRecipes() {
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod.ItemType("BlazeRune"), 3);
                        recipe.AddIngredient(ItemID.HellstoneBar, 7);
			recipe.AddTile(16);
			recipe.SetResult(this);
			recipe.AddRecipe();}
		}
	}