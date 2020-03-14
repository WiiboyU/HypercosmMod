using Terraria.ModLoader;

namespace HypercosmMod.Items.Equipable
{
	[AutoloadEquip(EquipType.Head)]
	public class StarChaserMask : ModItem
	{
		public override void SetDefaults() 
		{
			item.width = 26;
			item.height = 26;
			item.rare = 1;
			item.vanity = true;
		}
		
		public override bool DrawHead() {
			return false;
		}
	}
}