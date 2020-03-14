using Microsoft.Xna.Framework;
using System.Collections.Generic;
using System.Linq;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;
using System.Diagnostics;
using System;

namespace HypercosmMod.DevStuff
{
	[AutoloadEquip(EquipType.Wings)]
	public class DylanWings : ModItem
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Reaper's Wings");
                        Tooltip.SetDefault("Gives 260 wing time, 11 Flight speed, and 9 acceleration");
		}

		public override void SetDefaults() {
			item.width = 22;
			item.height = 20;
			item.value = 10000;
			item.rare = 11;
			item.accessory = true;
		}
		public override void ModifyTooltips(List<TooltipLine> tooltips) {

			// Here we add a tooltipline that will later be removed, showcasing how to remove tooltips from an item

			var line = new TooltipLine(mod, "Verbose:RemoveMe", "");

			tooltips.Add(line);



			line = new TooltipLine(mod, "", "") {

				overrideColor = new Color(100, 100, 255)

			};

			tooltips.Add(line);

			foreach (TooltipLine line2 in tooltips) {

				if (line2.mod == "Terraria" && line2.Name == "ItemName") {

					line2.overrideColor = new Color(0, 255, 190);

				}

			}	
                }
		public override void UpdateAccessory(Player player, bool hideVisual) {
			player.wingTimeMax = 260;
		}

		public override void VerticalWingSpeeds(Player player, ref float ascentWhenFalling, ref float ascentWhenRising,
			ref float maxCanAscendMultiplier, ref float maxAscentMultiplier, ref float constantAscend) {
			ascentWhenFalling = 0.85f;
                        ascentWhenRising = 0.15f;
                        maxCanAscendMultiplier = 1.1f;
                        maxAscentMultiplier = 3f;
                        constantAscend = 0.095f;
		}
                public override void HorizontalWingSpeeds(Player player, ref float speed, ref float acceleration)
                {
                speed = 11f;
                acceleration *= 9f;
  	        }
       }
} 