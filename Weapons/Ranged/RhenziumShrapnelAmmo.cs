using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace HypercosmMod.Items.Weapons.Ranged
{
	public class RhenziumShrapnelAmmo : ModItem
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Rhenzium Shrapnel");
			Tooltip.SetDefault("");
		}

		public override void SetDefaults() {
			item.damage = 5;
			item.ranged = true;
			item.width = 8;
			item.height = 8;
			item.maxStack = 999;
			item.consumable = true;             //You need to set the item consumable so that the ammo would automatically consumed
			item.knockBack = 1.5f;
			item.value = 10;
			item.rare = 2;
			item.shoot = mod.ProjectileType("RhenziumShrapnel");   //The projectile shoot when your weapon using this ammo
			item.shootSpeed = 16f;                  //The speed of the projectile
			item.ammo = AmmoID.Bullet;              //The ammo class this ammo belongs to.

		}
	}
}