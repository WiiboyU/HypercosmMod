using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using System;

namespace HypercosmMod.NPCs.Moon
{
    public class Orbiter : ModNPC
    {
        public override void SetStaticDefaults() {
            DisplayName.SetDefault("Orbiter");
        }

        public override void SetDefaults()
        {
            npc.width = 37;
            npc.height = 44;
            npc.damage = 26;
            npc.noGravity = true;
            npc.defense = 40;
            npc.lifeMax = 275;
            npc.HitSound = SoundID.NPCHit4;
            npc.DeathSound = SoundID.NPCDeath37;
            npc.knockBackResist = 0f;
            npc.spriteDirection = npc.direction;
            npc.aiStyle = 5;
            aiType = NPCID.Crimera;
        }

        public override void HitEffect(int hitDirection, double damage)
        {
            if (npc.life >= 0)
            {
                Dust.NewDust(npc.position + npc.velocity, npc.width, npc.height, 15, npc.velocity.X * -0.5f, npc.velocity.Y * -0.5f);
                Dust.NewDust(npc.position + npc.velocity, npc.width, npc.height, 15, npc.velocity.X * -0.5f, npc.velocity.Y * -0.5f);
                Dust.NewDust(npc.position + npc.velocity, npc.width, npc.height, 15, npc.velocity.X * -0.5f, npc.velocity.Y * -0.5f);
                Dust.NewDust(npc.position + npc.velocity, npc.width, npc.height, 15, npc.velocity.X * -0.5f, npc.velocity.Y * -0.5f);
            }
            else
            {
                Dust.NewDust(npc.position + npc.velocity, npc.width, npc.height, 15, npc.velocity.X * -0.5f, npc.velocity.Y * -0.5f);
                Dust.NewDust(npc.position + npc.velocity, npc.width, npc.height, 15, npc.velocity.X * -0.5f, npc.velocity.Y * -0.5f);
                Dust.NewDust(npc.position + npc.velocity, npc.width, npc.height, 15, npc.velocity.X * -0.5f, npc.velocity.Y * -0.5f);
                Dust.NewDust(npc.position + npc.velocity, npc.width, npc.height, 15, npc.velocity.X * -0.5f, npc.velocity.Y * -0.5f);
                Dust.NewDust(npc.position + npc.velocity, npc.width, npc.height, 15, npc.velocity.X * -0.5f, npc.velocity.Y * -0.5f);
            }
        }

        public override void AI()
        {
            Dust.NewDust(npc.position + npc.velocity, npc.width, npc.height, 15, npc.velocity.X * -0.5f, npc.velocity.Y * -0.5f, 255, default(Color), 0.5f);
        }

        public override void FindFrame(int frameHeight)
        {
            npc.spriteDirection = npc.direction;
        }

        public override float SpawnChance(NPCSpawnInfo spawnInfo)
        {
            return spawnInfo.spawnTileType == ModContent.TileType<Tiles.Blocks.LunarSoilTile>() ? 1f : 0f;

        }
		
		public override void ScaleExpertStats(int numPlayers, float bossLifeScale) {

			npc.lifeMax = (int)(npc.lifeMax * 0.625f);

			npc.damage = (int)(npc.damage * 0.6f);

		}
		
		public override void NPCLoot()
        {
			if (Main.rand.NextBool(2)) 
			{
			Item.NewItem(npc.getRect(), mod.ItemType("MoonlitCrystal"), Main.rand.Next(1, 3));
        }
    }
}
}