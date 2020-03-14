using Terraria;
using Terraria.Localization;
using Terraria.ModLoader;

namespace HypercosmMod.DevStuff
{
    [AutoloadEquip(EquipType.Head)]
    public class WiisBeanie : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Looks like a leading developer.");
        }
        public override void SetDefaults()
        {
            item.width = 22;
            item.height = 26;
            item.value = 10000;
            item.rare = 7;
            item.vanity = true;
        }
    }
}