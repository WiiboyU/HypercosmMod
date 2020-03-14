using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace HypercosmMod.Items.Weapons.Melee
{
public class Estrella : ModItem
{
public override void SetStaticDefaults() 
{
DisplayName.SetDefault("Estrella");
Tooltip.SetDefault("A slow swinging yet powerful sword");
}

public override void SetDefaults() 
{
item.damage = 44;
item.melee = true;
item.width = 72;
item.height = 72;
item.useTime = 120;
item.useAnimation = 19;
item.useStyle = 1;
item.knockBack = 7f;
item.value = Item.buyPrice(gold: 1);
item.rare = 3;
item.UseSound = SoundID.Item9;
item.autoReuse = false;
}
}
}