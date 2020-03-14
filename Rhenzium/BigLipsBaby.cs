using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using System;

namespace HypercosmMod.NPCs.Rhenzium
{
	public class BigLipsBaby : ModNPC
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Rhenzium Floater");
		}

		public override void SetDefaults() 
		{
            npc.width = 37;
			npc.height = 42;
			npc.damage = 10;
			npc.noGravity = false;
			npc.defense = 9;
			npc.lifeMax = 60;
			npc.HitSound = SoundID.NPCHit4;
			npc.DeathSound = SoundID.NPCDeath14;
			npc.knockBackResist = 0.6f;
			npc.spriteDirection = npc.direction;
	    npc.aiStyle = 109;
            aiType = NPCID.DD2KoboldFlyerT2;
            npc.noGravity = true;    
            animationType = NPCID.DD2WyvernT1;
            Main.npcFrameCount[npc.type] = 5;
            npc.npcSlots = 1f;
            npc.boss = false;
            npc.lavaImmune = false;
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
				Gore.NewGore(npc.position, npc.velocity, mod.GetGoreSlot("Gores/BigLipsBabyGore"), 1f);
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
			Item.NewItem(npc.getRect(), mod.ItemType("RhenziumBar"), Main.rand.Next(3, 6));
			}
			if (Main.rand.NextBool(2)) 
			{
			Item.NewItem(npc.getRect(), mod.ItemType("RhenziumShrapnel"), Main.rand.Next(25, 50));
			}
        }
		
	}
}