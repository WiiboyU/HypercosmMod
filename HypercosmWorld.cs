using System.IO;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.World.Generation;
using Microsoft.Xna.Framework;
using Terraria.GameContent.Generation;
using System.Linq;
using System; 
 
namespace HypercosmMod
{
    public class HypercosmWorld : ModWorld
    {
        
        
        public static int LunarSoilTile;
        

   
	public override void Initialize() {


			LunarSoilTile = 0;
                        
 
		}	
        
        public override void ResetNearbyTileEffects() {
			HypercosmPlayer modPlayer = Main.LocalPlayer.GetModPlayer<HypercosmPlayer>();
			
			
		
                        
			
			LunarSoilTile = 0;
		}
		public override void TileCountsAvailable(int[] tileCounts) {
			
		
                        LunarSoilTile = tileCounts[mod.TileType("LunarSoilTile")];
		}
        
        }
        
}
    
