using Terraria.ID;
using Terraria.ModLoader;
using Terraria;

namespace HypercosmMod.Items.Weapons.Ranged
{
	public class PaleBlaster : ModItem
	{
		public override void SetStaticDefaults() {
			Tooltip.SetDefault("");
		}

		public override void SetDefaults() {
			item.damage = 26;
			item.ranged = true;
			item.width = 46;
			item.height = 22;
			item.useTime = 8;
			item.useAnimation = 12;
			item.useStyle = 5;
			item.noMelee = true;
			item.knockBack = 4;
            item.value = Item.buyPrice(silver: 45);
            item.rare = 2;
			item.UseSound = SoundID.Item11;
			item.autoReuse = true;
			item.shoot = ProjectileID.SpectreWrath;
			item.shootSpeed = 2f;
		}
	}
}