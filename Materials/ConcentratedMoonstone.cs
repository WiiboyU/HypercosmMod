using Terraria.ModLoader;
using Terraria.ID;
using Terraria;

namespace HypercosmMod.Items.Materials
{
    public class ConcentratedMoonstone: ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("ConcentratedMoonstone");
            Tooltip.SetDefault("");
        }

        public override void SetDefaults()
        {
            item.width = 38; // Hitbox Width
            item.height = 36; // Hitbox Height
            item.value = Item.buyPrice(silver: 90, copper: 10);
            item.rare = 3; // Item Tier
            item.UseSound = SoundID.Item1; // Sound effect of item on use 
            item.autoReuse = true; // Do you want to torture people with clicking? Set to false
            item.consumable = true; // Will consume the item when placed.
            item.createTile = mod.TileType("ConcentratedMoonstoneTile");
            item.maxStack = 999; // The maximum number you can have of this item.
}

		public override void AddRecipes() {
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod.ItemType("Moonstone"), 4);
			recipe.AddTile(134);
			recipe.SetResult(this);
			recipe.AddRecipe();}
        
        }
    }