using Terraria;
using Terraria.Localization;
using Terraria.ModLoader;

namespace HypercosmMod.DevStuff
{
    [AutoloadEquip(EquipType.Head)]
    public class SoulReaperHood : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("");
        }
        public override void SetDefaults()
        {
            item.width = 24;
            item.height = 24;
            item.value = 10000;
            item.rare = 7;
            item.vanity = true;
        }
    }
}