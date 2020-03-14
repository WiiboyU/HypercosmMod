using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace HypercosmMod.Tiles.Blocks
{
	public class XenostoneTile : ModTile
	{
		public override void SetDefaults()                                                
		{
			
                        TileID.Sets.Ore[Type] = false;
			Main.tileSpelunker[Type] = false; // The tile will be affected by spelunker highlighting
			Main.tileValue[Type] = 0; // Metal Detector value, see https://terraria.gamepedia.com/Metal_Detector
			Main.tileShine2[Type] = true; // Modifies the draw color slightly.
			Main.tileShine[Type] = 10000; // How often tiny dust appear off this tile. Larger is less frequently
			Main.tileMergeDirt[Type] = true;
			Main.tileSolid[Type] = true;
			Main.tileBlockLight[Type] = true;
                        ModTranslation name = CreateMapEntryName();
			name.SetDefault("Xenostone");
			AddMapEntry(new Color(158, 255, 92), name);

			dustType = 84;
			drop = mod.ItemType("Xenostone");
			soundType = 21;
			soundStyle = 1;
			mineResist = 15f;
			minPick = 60;
		}
	}
}
