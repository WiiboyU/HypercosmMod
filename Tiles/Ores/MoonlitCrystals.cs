using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace HypercosmMod.Tiles.Ores
{
	public class MoonlitCrystals : ModTile
	{
		public override void SetDefaults()                                                
		{
			
                        TileID.Sets.Ore[Type] = true;
			Main.tileSpelunker[Type] = true; // The tile will be affected by spelunker highlighting
			Main.tileValue[Type] = 340; // Metal Detector value, see https://terraria.gamepedia.com/Metal_Detector
			Main.tileShine2[Type] = true; // Modifies the draw color slightly.
			Main.tileShine[Type] = 400; // How often tiny dust appear off this tile. Larger is less frequently
			Main.tileMergeDirt[Type] = true;
			Main.tileSolid[Type] = true;
			Main.tileBlockLight[Type] = true;
                        ModTranslation name = CreateMapEntryName();
			name.SetDefault("MoonlitCrystal");
			AddMapEntry(new Color(135, 135, 147), name);

			dustType = 84;
			drop = mod.ItemType("MoonlitCrystal");
			soundType = 21;
			soundStyle = 1;
			mineResist = 10f;
			minPick = 100;
		}
	}
}
