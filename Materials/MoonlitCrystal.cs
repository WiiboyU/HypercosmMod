using Terraria.ID;
using Terraria.ModLoader;
using Terraria;

namespace HypercosmMod.Items.Materials
{
	public class MoonlitCrystal : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Moonlit Crystal");
		}

		public override void SetDefaults()
		{
			item.width = 26;
			item.height = 30;
			item.maxStack = 999;
			item.rare = 3;
            item.value = Item.buyPrice(copper: 80);
            item.autoReuse = true; // Do you want to torture people with clicking? Set to false
            item.consumable = true; // Will consume the item when placed.
            item.createTile = mod.TileType("MoonlitCrystals");
		}
	}
}
