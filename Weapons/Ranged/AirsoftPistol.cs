using Terraria.ID;
using Terraria.ModLoader;

namespace HypercosmMod.Items.Weapons.Ranged
{
	public class AirsoftPistol : ModItem
	{
		public override void SetStaticDefaults() {
			Tooltip.SetDefault("Shoots a powerful burst of pressurised air");
		}

		public override void SetDefaults() {
			item.damage = 8;
			item.ranged = true;
			item.width = 46;
			item.height = 22;
			item.useTime = 12;
			item.useAnimation = 12;
			item.useStyle = 5;
			item.noMelee = true;
			item.knockBack = 20;
			item.value = 2800;
			item.rare = 2;
			item.UseSound = SoundID.Item11;
			item.autoReuse = true;
			item.shoot = mod.ProjectileType("AirsoftPistolAir");
			item.shootSpeed = 8f;
		}

		public override void AddRecipes() {
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.FlintlockPistol);
			recipe.AddIngredient(ItemID.SunplateBlock, 15);
			recipe.AddIngredient(ItemID.IllegalGunParts);
			recipe.AddTile(16);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}