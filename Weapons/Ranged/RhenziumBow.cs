using Microsoft.Xna.Framework;
using System.Collections.Generic;
using System.Linq;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;
using System.Diagnostics;
using System;

namespace HypercosmMod.Items.Weapons.Ranged
{
    public class RhenziumBow : ModItem
    {
        public override void SetStaticDefaults()
        {
	   DisplayName.SetDefault("Rhenzium Bow");
	    Tooltip.SetDefault("");
	}
        public override void SetDefaults()
        {
            item.value = Item.buyPrice(gold: 2);
            item.damage = 26;
            item.noMelee = true;
            item.ranged = true;
            item.width = 24;
            item.height = 34;
            item.useTime = 21;
            item.useAnimation = 18;
            item.useStyle = 5;
            item.knockBack = 1;
            item.value = 1000;
            item.rare = 2;
            item.UseSound = SoundID.Item5;
            item.autoReuse = true;
            item.shootSpeed = 15f;
            item.shoot = 1;
            item.useAmmo = AmmoID.Arrow;
            item.shootSpeed = 8f;

        }
    }
}