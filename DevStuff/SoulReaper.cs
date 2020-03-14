using Microsoft.Xna.Framework;
using System.Collections.Generic;
using System.Linq;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace HypercosmMod.DevStuff
{
	public class SoulReaper : ModItem
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Soul Reaper's Scythe");
                        Tooltip.SetDefault("Left click to swing the scythe and shoot a spinning blade projectile\nRight click to throw homing images of the scythe");
		}

		public override void SetDefaults() 
                {
			
                        
            item.value = Item.buyPrice(platinum: 2);
            item.damage = 180;
			item.melee = true;
			item.width = 40;
			item.height = 40;
			item.useTime = 20;
			item.useAnimation = 20;
			item.useStyle = 1;
			item.knockBack = 6;
			
			item.rare = 9;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
			item.shoot = mod.ProjectileType("DylanBolt");
			
            item.shootSpeed = 1f;
		}
                
        public override bool AltFunctionUse(Player player) {
			return true;
		}

		public override bool CanUseItem(Player player) {
			if (player.altFunctionUse == 2) {
				item.noUseGraphic = true;
                                item.melee = true;
                                
                                item.useStyle = 1;
				item.useTime = 25;
				item.useAnimation = 25;
				item.damage = 180;
				item.shoot = mod.ProjectileType("DylanScythe");
			        item.shootSpeed = 16f;


                                
			}
			else {
				item.noUseGraphic = false;
                                item.melee = true;
                                item.useStyle = 1;
				item.useTime = 15;
				item.useAnimation = 15;
				item.damage = 180;
				item.shoot = mod.ProjectileType("DylanBolt");
			        item.shootSpeed = 12f;
                                
                        }
                        return base.CanUseItem(player);
		
                        
			
                        
            
                
			
		

		
		}
	}
}