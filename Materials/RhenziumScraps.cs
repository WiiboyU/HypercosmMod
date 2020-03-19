using Terraria.ID;
using Terraria.ModLoader;

namespace HypercosmMod.Items.Materials
{
	public class RhenziumScraps : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Rhenzium Scraps");
			Tooltip.SetDefault("Salvaged from chunks of failed metal");
		}

		public override void SetDefaults()
		{
			item.width = 30;
			item.height = 22;
                        item.useTime = 14;
                        item.useAnimation = 14; // Animation Speed
                        item.useStyle = 1; // 1 = Broadsword 
                        item.value = 50; // 10 | 00 | 00 | 00 : Platinum | Gold | Silver | Bronze
                        item.rare = 4; // Item Tier
                        item.UseSound = SoundID.Item1; // Sound effect of item on use 
                        item.autoReuse = true; // Do you want to torture people with clicking? Set to false
                        item.consumable = true; // Will consume the item when placed.
                        item.createTile = mod.TileType("RhenziumBarTile");
			item.maxStack = 999;
			item.rare = 1;
		}
	}
}
