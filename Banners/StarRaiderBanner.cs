using Terraria;
using Terraria.ModLoader;

namespace HypercosmMod.Items.Banners
{
	public class StarRaiderBanner : ModItem
	{
		public override void SetDefaults()
		{
			item.width = 12;
			item.height = 28;
			item.maxStack = 99;
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 10;
			item.useStyle = 1;
			item.consumable = true;
			item.rare = 1;
			item.createTile = mod.TileType("StarRaiderRhenzDroneBanner");
			item.placeStyle = 1;
		}
	}
}