using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using System;

namespace HypercosmMod.NPCs.Microcosmic
{
	public class Chonkrosm : ModNPC
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Cosmic Observer");
		}

		public override void SetDefaults() 
		{
			npc.height = 68;
                        npc.width = 36;
			npc.damage = 35;
			npc.noGravity = true;
			npc.defense = 12;
			npc.lifeMax = 175;
			npc.HitSound = SoundID.NPCHit30;
			npc.DeathSound = SoundID.NPCDeath6;
			npc.knockBackResist = 1f;
			npc.spriteDirection = npc.direction;
			npc.aiStyle = 22;
			aiType = NPCID.Wraith; 
                        animationType = NPCID.FlyingFish;
                        Main.npcFrameCount[npc.type] = 4;
                        npc.npcSlots = 1f;
                        npc.boss = false;
                        npc.lavaImmune = false;
                        npc.noTileCollide = true;
                        npc.netAlways = true;
		}
		
		public override void HitEffect(int hitDirection, double damage) 
		{
			if(npc.life >= 0)
			{
			Dust.NewDust(npc.position + npc.velocity, npc.width, npc.height, 191, npc.velocity.X * -0.5f, npc.velocity.Y * -0.5f);
			Dust.NewDust(npc.position + npc.velocity, npc.width, npc.height, 191, npc.velocity.X * -0.5f, npc.velocity.Y * -0.5f);
			Dust.NewDust(npc.position + npc.velocity, npc.width, npc.height, 191, npc.velocity.X * -0.5f, npc.velocity.Y * -0.5f);
			Dust.NewDust(npc.position + npc.velocity, npc.width, npc.height, 191, npc.velocity.X * -0.5f, npc.velocity.Y * -0.5f);
			}
			else
			{
				Dust.NewDust(npc.position + npc.velocity, npc.width, npc.height, 191, npc.velocity.X * -0.5f, npc.velocity.Y * -0.5f);
				Dust.NewDust(npc.position + npc.velocity, npc.width, npc.height, 191, npc.velocity.X * -0.5f, npc.velocity.Y * -0.5f);
				Dust.NewDust(npc.position + npc.velocity, npc.width, npc.height, 191, npc.velocity.X * -0.5f, npc.velocity.Y * -0.5f);
				Dust.NewDust(npc.position + npc.velocity, npc.width, npc.height, 191, npc.velocity.X * -0.5f, npc.velocity.Y * -0.5f);
				Dust.NewDust(npc.position + npc.velocity, npc.width, npc.height, 191, npc.velocity.X * -0.5f, npc.velocity.Y * -0.5f);
			}
		}
		
		public override void AI()
		{
			Dust.NewDust(npc.position + npc.velocity, npc.width, npc.height, 191, npc.velocity.X * -0.5f, npc.velocity.Y * -0.5f, 191, default(Color), 0.5f);
		}
		
		public override void FindFrame(int frameHeight)
		{
			npc.spriteDirection = npc.direction;
		}

        public override float SpawnChance(NPCSpawnInfo spawnInfo)
        {
            if (spawnInfo.player.ZoneOverworldHeight && NPC.downedBoss3)
            {
                return 0.1f;
            }
            else
            {
                return 0f;
            }
        }

        public override void ScaleExpertStats(int numPlayers, float bossLifeScale) {

			npc.lifeMax = (int)(npc.lifeMax * 0.625f);

			npc.damage = (int)(npc.damage * 0.6f);

		}
		
		public override void NPCLoot()
        {
			if (Main.rand.NextBool(100)) 
			{
			Item.NewItem(npc.getRect(), mod.ItemType("ObserverMembrane"), Main.rand.Next(2, 4));
			}
        }
		
	}
}
