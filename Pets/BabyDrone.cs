using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace HypercosmMod.Items.Pets
{
	public class BabyDrone : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Baby Drone");
			Tooltip.SetDefault("Summons a Baby Drone to provide light");
		}

		public override void SetDefaults()
		{
			item.damage = 0;
			item.useStyle = 1;
			item.shoot = mod.ProjectileType("BabyDronePet");
			item.width = 22;
			item.height = 26;
			item.UseSound = SoundID.Item2;
			item.useAnimation = 20;
			item.useTime = 20;
			item.rare = 3;
			item.noMelee = true;
			item.value = 35000;
			item.buffType = mod.BuffType("BabyDroneBuff");
		}

		public override void UseStyle(Player player)
		{
			if (player.whoAmI == Main.myPlayer && player.itemTime == 0)
			{
				player.AddBuff(item.buffType, 3600, true);
			}
		}
	}
}