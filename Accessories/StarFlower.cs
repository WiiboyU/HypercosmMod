using Terraria;
using Terraria.Localization;
using Terraria.ModLoader;

namespace HypercosmMod.Items.Accessories
{
	public class StarFlower : ModItem
	{
		public override void SetStaticDefaults() {
			Tooltip.SetDefault("10% increased magic damage"
				+ "\n12% reduced mana usage"
					+ "\nIncreases max mana by 65");
		}

		public override void SetDefaults() {
			item.width = 62;
			item.height = 42;
			item.value = 40000;
			item.rare = -12;
			item.expert = true;
			item.accessory = true;
		}

		public override void UpdateAccessory(Player player, bool hideVisual) 
		{
			player.magicDamage += 0.1f;
			player.manaCost -= 0.12f;
			player.statManaMax2 += 65;
		}
	}
}