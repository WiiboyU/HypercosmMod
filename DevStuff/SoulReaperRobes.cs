using Terraria;
using Terraria.ModLoader;

namespace HypercosmMod.DevStuff
{
	[AutoloadEquip(EquipType.Legs)]
	public class SoulReaperRobes : ModItem
	{
		public override void SetStaticDefaults() {
			base.SetStaticDefaults();
			DisplayName.SetDefault("Soul Reaper Robes");

		}
		public override void SetDefaults() {
			item.width = 22;
			item.height = 18;
			item.value = 10000;
			item.rare = 7;
                        item.vanity = true;
		}
	}
}