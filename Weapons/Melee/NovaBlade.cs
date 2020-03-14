using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace HypercosmMod.Items.Weapons.Melee
{
public class NovaBlade : ModItem
{
public override void SetStaticDefaults() 
{
DisplayName.SetDefault("Nova Blade");
Tooltip.SetDefault("Supposed to generate explosions upon hit, but uncoded as of right now");
}

public override void SetDefaults() 
{
item.damage = 38;
item.melee = true;
item.width = 46;
item.height = 46;
item.useTime = 25;
item.useAnimation = 19;
item.useStyle = 1;
item.knockBack = 4;
item.value = Item.buyPrice(gold: 1);
item.rare = 3;
item.UseSound = SoundID.Item9;
item.autoReuse = false;
}
}
}