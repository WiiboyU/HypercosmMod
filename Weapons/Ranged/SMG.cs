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
	public class SMG : ModItem
	{
		public override void SetStaticDefaults() {
	                DisplayName.SetDefault("SMG");
			Tooltip.SetDefault("");
		}

		public override void SetDefaults() {
			item.damage = 43;
			item.ranged = true;
			item.width = 72;
			item.height = 30;
			item.useTime = 7;
			item.useAnimation = 20;
			item.useStyle = 5;
			item.noMelee = true; //so the item's animation doesn't do damage
			item.knockBack = 4;
            item.value = Item.buyPrice(gold: 14);
            item.rare = 5;
			item.UseSound = SoundID.Item11;
			item.autoReuse = true;
			item.shoot = 10; //idk why but all the guns in the vanilla source have this
			item.shootSpeed = 16f;
			item.useAmmo = AmmoID.Bullet;
        }

        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
            if (type == ProjectileID.Bullet) 
                        {
                        type = ProjectileID.BulletHighVelocity;

			}

			 
        
		

            int numberOfProjectiles = Main.rand.Next(1, 4); 
            for(int i =0; i < numberOfProjectiles; i++)
            {
                Projectile.NewProjectile(position, new Vector2(speedX, speedY).RotatedByRandom((float)Math.PI/16f), type, damage, knockBack, player.whoAmI);
            }
            return false;
        
        }

		
                        
        public override Vector2? HoldoutOffset()

		{

			return new Vector2(0, 0);

		}
		public override void AddRecipes() 
{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Uzi);
			recipe.AddIngredient(ItemID.SoulofMight, 5);
			recipe.AddIngredient(ItemID.SoulofSight, 5);
			recipe.AddIngredient(ItemID.SoulofFright, 5);
			recipe.AddTile(134);
			recipe.SetResult(this);
			recipe.AddRecipe();
        }
    }
}