using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace HypercosmMod.Items.Weapons.Melee
{
	public class SkyShredder : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Sky Shredder");
			Tooltip.SetDefault("Slice through all entities with ease");
		}
		public override void SetDefaults()
		{
			item.damage = 55;
			item.melee = true;
			item.width = 50;
			item.height = 66;
			item.useTime = 19;
			item.useAnimation = 19;
			item.useStyle = 1;
			item.knockBack = 5;
            item.value = Item.buyPrice(gold: 14);
            item.rare = 5;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
			item.shoot = mod.ProjectileType("SkyBeam");
			item.shootSpeed = 6.5f;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Cloud, 50);
			recipe.AddIngredient(ItemID.RainCloud, 20);
			recipe.AddIngredient(ItemID.SoulofMight, 10);
			recipe.AddTile(134);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}