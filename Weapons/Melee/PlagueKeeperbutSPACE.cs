using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace HypercosmMod.Items.Weapons.Melee
{
public class PlagueKeeperbutSPACE : ModItem
{
public override void SetStaticDefaults() 
{
DisplayName.SetDefault("Space Keeper");
Tooltip.SetDefault("Light the fires of the universe");
}

public override void SetDefaults() 
{
item.damage = 55;
item.melee = true;
item.width = 80;
item.height = 80;
item.useTime = 35;
item.crit = 4;
item.useAnimation = 19;
item.useStyle = 1;
item.knockBack = 6f;
item.value = Item.buyPrice(gold: 3);
item.rare = 4;
item.UseSound = SoundID.Item1;
item.autoReuse = true;
}

		public override void AddRecipes() {
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod.ItemType("NovaBlade"), 1);
                        recipe.AddIngredient(ItemID.BeeKeeper, 1);
			recipe.AddTile(134);
			recipe.SetResult(this);
			recipe.AddRecipe();
}
}
}