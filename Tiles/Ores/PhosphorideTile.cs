using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace HypercosmMod.Tiles.Ores
{
	public class PhosphorideTile : ModTile
	{
		public override void SetDefaults()                                                
		{
			
                        TileID.Sets.Ore[Type] = true;
			Main.tileSpelunker[Type] = true; // The tile will be affected by spelunker highlighting
			Main.tileValue[Type] = 700; // Metal Detector value, see https://terraria.gamepedia.com/Metal_Detector
			Main.tileShine2[Type] = true; // Modifies the draw color slightly.
			Main.tileShine[Type] = 200; // How often tiny dust appear off this tile. Larger is less frequently
			Main.tileMergeDirt[Type] = true;
			Main.tileSolid[Type] = true;
			Main.tileBlockLight[Type] = false;
                        ModTranslation name = CreateMapEntryName();
			name.SetDefault("Phosphoride");
			AddMapEntry(new Color(158, 255, 92), name);

			dustType = 84;
			drop = mod.ItemType("PhosphorideChunk");
			soundType = 21;
			soundStyle = 1;
			mineResist = 15f;
			minPick = 200;
		}
	}
}
