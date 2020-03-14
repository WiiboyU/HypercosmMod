using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;
 
namespace HypercosmMod.Items.Weapons.Ranged   
{
    public class Spacethrower : ModItem
    {
        public override void SetDefaults()
        {
            item.damage = 19;  //The damage stat for the Weapon.
            item.ranged = true;    //This defines if it does Ranged damage and if its effected by Ranged increasing Armor/Accessories.
            item.width = 66;  //The size of the width of the hitbox in pixels.
            item.height = 20;    //The size of the height of the hitbox in pixels.
            item.useTime = 6;   //How fast the Weapon is used.
            item.useAnimation = 20;     //How long the Weapon is used for.
            item.useStyle = 5;   //The way your Weapon will be used, 1 is the regular sword swing for example
            item.noMelee = true; //so the item's animation doesn't do damage
            item.knockBack = 0f;  //The knockback stat of your Weapon.
            item.UseSound = SoundID.Item34; //The sound played when using your Weapon
            item.value = Item.buyPrice(0, 1, 0, 0); // How much the item is worth, in copper coins, when you sell it to a merchant. It costs 1/5th of this to buy it back from them. An easy way to remember the value is platinum, gold, silver, copper or PPGGSSCC (so this item price is 10gold)
            item.rare = 3;   //The color the title of your Weapon when hovering over it ingame  
            item.autoReuse = true;   //Weather your Weapon will be used again after use while holding down, if false you will need to click again after use to use it again.
            item.shoot = mod.ProjectileType("SpacethrowerProjectile");   //This defines what type of projectile this weapon will shot
            item.shootSpeed = 4.5f; //This defines the projectile speed when shoot , for flamethrower this make how far the flames can go
            item.useAmmo = AmmoID.Gel; //This defines what ammo this weapon should use.
	}

		public override void AddRecipes() {
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod.ItemType("StarlightPlating"), 4);
                        recipe.AddIngredient(ItemID.FallenStar, 5);
			recipe.AddTile(16);
			recipe.SetResult(this);
			recipe.AddRecipe();}

        public override bool ConsumeAmmo(Player player) //this is where you can modify the ammo consuming
        {
            return Main.rand.NextFloat(50) > .75f;//this make so the weapon has 50% chance to not consume ammo, in this case gel
        }
    }
}