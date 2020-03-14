using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
namespace HypercosmMod.Items.Weapons.Melee
{
    public class IronCore : ModItem
    {
        public override void SetDefaults()
        {
            item.damage = 36;           
            item.melee = true;
            item.width = 16;
            item.height = 22;
            item.useTime = 60;
            item.useAnimation = 20;
            item.noUseGraphic = true;
            item.useStyle = 1;
            item.knockBack = 1;
            item.consumable = true;
            item.value = Item.buyPrice(silver: 2, copper: 57);
            item.rare = 1;
            item.shootSpeed = 3f;
            item.shoot = mod.ProjectileType ("IronCoreProjectile");
            item.UseSound = SoundID.Item1;
            item.autoReuse = false;
            item.maxStack = 64; // The maximum number you can have of this item.
        }

		public override void AddRecipes() {
			ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.IronBar, 1);
			recipe.AddTile(16);
			recipe.SetResult(this, 4);
			recipe.AddRecipe();}
        }
    }