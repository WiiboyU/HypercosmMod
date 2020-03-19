using Microsoft.Xna.Framework;
using System.Collections.Generic;
using System.Linq;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;
using System.Diagnostics;
using System;

namespace HypercosmMod.Items.Materials
{
    public class StarlightPlating: ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("StarlightPlating");
            Tooltip.SetDefault("");
        }

        public override void SetDefaults()
        {
            item.width = 24; // Hitbox Width
            item.height = 24; // Hitbox Height
            item.value = Item.buyPrice(silver: 25, copper:10);
            item.rare = 3; // Item Tier
            item.maxStack = 999; // The maximum number you can have of this item.
        }
    }
}