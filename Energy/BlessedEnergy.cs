using Terraria.ID;
using Terraria.ModLoader;

namespace HypercosmMod.Items.Energy
{
	public class BlessedEnergy : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("The mark of the heavens");
		}

		public override void SetDefaults()
		{
			item.width = 24;
			item.height = 36;
			item.maxStack = 99;
			item.rare = 3;
		}
	}
}
