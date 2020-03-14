using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace HypercosmMod.Tiles.Blocks
{
	public class LunarSoilTile : ModTile
	{
		public override void SetDefaults()                                                
		{
			
                        TileID.Sets.Ore[Type] = false;
			Main.tileSpelunker[Type] = false; // The tile will be affected by spelunker highlighting
			Main.tileValue[Type] = 0; // Metal Detector value, see https://terraria.gamepedia.com/Metal_Detector
			Main.tileShine2[Type] = false; // Modifies the draw color slightly.
			Main.tileMergeDirt[Type] = true;
			Main.tileSolid[Type] = true;
			Main.tileBlockLight[Type] = true;
                        ModTranslation name = CreateMapEntryName();
			name.SetDefault("Lunar Soil");
			AddMapEntry(new Color(71, 64, 91), name);

			dustType = 15;
			drop = mod.ItemType("Lunar Soil");
			soundType = 21;
			soundStyle = 1;
			mineResist = 5f;
			minPick = 100;
		}
	}
}
