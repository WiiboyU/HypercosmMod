using System;
using System.Collections.Generic;
using System.IO;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ModLoader.IO;
using Terraria.GameInput;

namespace HypercosmMod
{
	public class HypercosmPlayer : ModPlayer
	{
		public bool ZoneMoon;
                public bool babyDrone = false;
	
		public override void UpdateBiomes() 
        {

		
       
	
                ZoneMoon = HypercosmWorld.LunarSoilTile > 50;

	}
        
        public override void CopyCustomBiomesTo(Player other) {

			HypercosmPlayer modOther = other.GetModPlayer<HypercosmPlayer>();
                        

		
                        
                        
			modOther.ZoneMoon = ZoneMoon;

		}
                
                public override void SendCustomBiomes(BinaryWriter writer) {

			BitsByte flags = new BitsByte();

			
                        flags[0] = ZoneMoon;
			writer.Write(flags);

		
                      

			
                        
			

                }
		public override void ReceiveCustomBiomes(BinaryReader reader) {

			BitsByte flags = reader.ReadByte();

			
		
                        

			ZoneMoon = flags[0];

		}
                public override Texture2D GetMapBackgroundImage() {

			if (ZoneMoon) {

				return mod.GetTexture("Backgrounds/MoonMapBG");

			}

			return null;

		}
                public override void ResetEffects()
		{
			babyDrone = false;
		}
	}
}