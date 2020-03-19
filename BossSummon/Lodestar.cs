using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace HypercosmMod.Items.BossSummon
{
    
    public class Lodestar : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Lodestar");
            Tooltip.SetDefault("Guides the galactic beast");
        }

        public override void SetDefaults()
        {
            item.width = 20;
            item.height = 20;
            item.maxStack = 20;
            item.rare = 1;
            item.useAnimation = 45;
            item.useTime = 45;
            item.useStyle = 4;
            item.UseSound = SoundID.Item44;
            item.consumable = true;
        }

        // We use the CanUseItem hook to prevent a player from using this item while the boss is present in the world.
        public override bool CanUseItem(Player player)
        {
            // "player.ZoneOverworldHeight" could also be written as "player.position.Y / 16f > Main.maxTilesY - 200"
 	return player.ZoneOverworldHeight && !Main.dayTime && !NPC.AnyNPCs(mod.NPCType("StarChaserHead"));
        }

        public override bool UseItem(Player player)
        {
            NPC.SpawnOnPlayer(player.whoAmI, mod.NPCType("StarChaserHead"));
            Main.PlaySound(SoundID.Roar, player.position, 0);
            return true;
        }

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.FallenStar, 15);
			recipe.AddIngredient(mod.ItemType("RhenziumScraps"), 8);
			recipe.AddTile(26);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}