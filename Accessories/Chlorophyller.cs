using Terraria.ID;
using Terraria;
using Terraria.Localization;
using Terraria.ModLoader;

namespace HypercosmMod.Items.Accessories
{
    public class Chlorophyller : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Increases life regeneration"
                + "\nWhen standing still, gives the Well Fed buff");
        }

        public override void SetDefaults()
        {
            item.width = 24;
            item.height = 54;
            item.value = 40000;
            item.rare = 7;
            item.expert = false;
            item.accessory = true;
        }

        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            if (Main.dayTime)
            {

                player.lifeRegen += 1;
                player.AddBuff(BuffID.WellFed, 2);
            }
        }
    }
}