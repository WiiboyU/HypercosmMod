using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.IO;
using Terraria;
using Terraria.GameContent.Dyes;
using Terraria.GameContent.UI;
using Terraria.Graphics.Effects;
using Terraria.Graphics.Shaders;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;
using Terraria.UI;

namespace HypercosmMod
{
	
        class HypercosmMod : Mod
	{
		
                public HypercosmMod()
		{
                        }
                        
                        

                        public override void UpdateMusic(ref int music, ref MusicPriority priority) 
                        {

			if (Main.myPlayer == -1 || Main.gameMenu || !Main.LocalPlayer.active)  
                        {

				return;

			}

			

			if (Main.LocalPlayer.GetModPlayer<HypercosmPlayer>().ZoneMoon) 
                        {

				music = GetSoundSlot(SoundType.Music, "Sounds/Music/MoonBiome");

				priority = MusicPriority.BiomeHigh;

			
                        }
		



			
                 }


		
       
                
                
	}
}