using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using System;

namespace HypercosmMod.NPCs.Rhenzium
{
    public class BigLipsSlime : ModNPC
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Rhenzium Leaper");
        }

        public override void SetDefaults()
        {
            npc.aiStyle = 1; //Slime AI, i would like to know king slimes AI but this works just the same.
            npc.lifeMax = 50;
            npc.HitSound = SoundID.NPCHit4;
            npc.DeathSound = SoundID.NPCDeath37;
            npc.damage = 9;
            npc.defense = 20;
            npc.knockBackResist = 1;
            npc.width = 52;
            npc.height = 28;
            animationType = NPCID.BlueSlime; //Animation type.
            Main.npcFrameCount[npc.type] = 2; //The king slime has a frame count of 6.
            aiType = NPCID.GreenSlime; //AI type
            npc.npcSlots = 1f;
            npc.boss = false;
            npc.lavaImmune = true;
            npc.noGravity = false;
            npc.noTileCollide = false;
            npc.netAlways = true;
		}
		
		public override void HitEffect(int hitDirection, double damage) 
		{
			if(npc.life >= 0)
			{
			Dust.NewDust(npc.position + npc.velocity, npc.width, npc.height, 219, npc.velocity.X * -0.5f, npc.velocity.Y * -0.5f);
			Dust.NewDust(npc.position + npc.velocity, npc.width, npc.height, 219, npc.velocity.X * -0.5f, npc.velocity.Y * -0.5f);
			Dust.NewDust(npc.position + npc.velocity, npc.width, npc.height, 219, npc.velocity.X * -0.5f, npc.velocity.Y * -0.5f);
			Dust.NewDust(npc.position + npc.velocity, npc.width, npc.height, 219, npc.velocity.X * -0.5f, npc.velocity.Y * -0.5f);
			}
			else
			{
				Dust.NewDust(npc.position + npc.velocity, npc.width, npc.height, 219, npc.velocity.X * -0.5f, npc.velocity.Y * -0.5f);
				Dust.NewDust(npc.position + npc.velocity, npc.width, npc.height, 219, npc.velocity.X * -0.5f, npc.velocity.Y * -0.5f);
				Dust.NewDust(npc.position + npc.velocity, npc.width, npc.height, 219, npc.velocity.X * -0.5f, npc.velocity.Y * -0.5f);
				Dust.NewDust(npc.position + npc.velocity, npc.width, npc.height, 219, npc.velocity.X * -0.5f, npc.velocity.Y * -0.5f);
				Dust.NewDust(npc.position + npc.velocity, npc.width, npc.height, 219, npc.velocity.X * -0.5f, npc.velocity.Y * -0.5f);
				Gore.NewGore(npc.position, npc.velocity, mod.GetGoreSlot("Gores/BigLips"), 1f);
				Gore.NewGore(npc.position, npc.velocity, mod.GetGoreSlot("Gores/BigLipsSlimeGore"), 1f);
			}
		}
		
		public override void AI()
		{
			Dust.NewDust(npc.position + npc.velocity, npc.width, npc.height, 244, npc.velocity.X * -0.5f, npc.velocity.Y * -0.5f, 255, default(Color), 0.5f);
		}
		
		public override void FindFrame(int frameHeight)
		{
			npc.spriteDirection = npc.direction;
		}

        public override float SpawnChance(NPCSpawnInfo spawnInfo)
        {
            return SpawnCondition.OverworldDaySlime.Chance * 0.5f;
            {
                if (spawnInfo.player.ZoneOverworldHeight && NPC.downedBoss1)
                {
                    return 0.1f;
                }
                else
                {
                    return 0f;
                }
            }
        }

        public override void ScaleExpertStats(int numPlayers, float bossLifeScale) {

			npc.lifeMax = (int)(npc.lifeMax * 0.625f);

			npc.damage = (int)(npc.damage * 0.6f);

		}
		
		public override void NPCLoot()
        {
			if (Main.rand.NextBool(2)) 
			{
			Item.NewItem(npc.getRect(), mod.ItemType("RhenziumScraps"), Main.rand.Next(8, 10));
			}
			if (Main.rand.NextBool(2)) 
			{
			Item.NewItem(npc.getRect(), mod.ItemType("RhenziumShrapnel"), Main.rand.Next(25, 50));
			}
        }
		
	}
}