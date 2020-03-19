using Terraria.ModLoader;
using Terraria.ID;
using Terraria;

namespace HypercosmMod.Items.Blocks
{
    public class  Moonchocolate : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Moonplate");
           
        }

        public override void SetDefaults()
        {
            item.width = 16; // Hitbox Width
            item.height = 16; // Hitbox Height
            item.useTime = 14; // Speed before reuse
            item.useAnimation = 14; // Animation Speed
            item.useStyle = 1; // 1 = Broadsword 
            item.value = Item.buyPrice(silver: 10);
            item.rare = 4; // Item Tier
            item.UseSound = SoundID.Item1; // Sound effect of item on use 
            item.autoReuse = true; // Do you want to torture people with clicking? Set to false
            item.consumable = true; // Will consume the item when placed.
            item.createTile = mod.TileType("MoonchocolateTile");
            item.maxStack = 999; // The maximum number you can have of this item.
        }
    }
}