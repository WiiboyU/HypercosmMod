using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace HypercosmMod.Items.Weapons.Melee
{
public class RhenziumBlade : ModItem
{
public override void SetStaticDefaults() 
{
DisplayName.SetDefault("Rhenzium Blade");
Tooltip.SetDefault("");
}

public override void SetDefaults() 
{
item.damage = 24;
item.melee = true;
item.width = 34;
item.height = 38;
item.useTime = 25;
item.useAnimation = 19;
item.useStyle = 1;
item.knockBack = 4;
item.value = Item.buyPrice(silver: 50);
item.rare = 2;
item.UseSound = SoundID.Item1;
item.autoReuse = false;
}

		public override void AddRecipes() {
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod.ItemType("RhenziumScraps"), 7);
			recipe.AddTile(16);
			recipe.SetResult(this);
			recipe.AddRecipe();
}
}
}