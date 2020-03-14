using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace HypercosmMod.Items.Weapons.Melee
{
public class AetherBlade : ModItem
{
public override void SetStaticDefaults() 
{
DisplayName.SetDefault("Aether Blade");
Tooltip.SetDefault("Releases aether blasts upon killing an enemy");
}

public override void SetDefaults() 
{
item.damage = 65;
item.melee = true;
item.width = 46;
item.height = 46;
item.useTime = 25;
item.crit = 4;
item.useAnimation = 19;
item.useStyle = 1;
item.knockBack = 6.5f;
item.value = Item.buyPrice(gold: 4);
item.rare = 4;
item.UseSound = SoundID.Item1;
item.autoReuse = false;
}
}
}