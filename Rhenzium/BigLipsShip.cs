using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.IO;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace HypercosmMod.NPCs.Rhenzium
{
   
    public class BigLipsShip : ModNPC
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Rhenzium Ship");
        }

        public override void SetDefaults()
        {
            npc.width = 56;
            npc.height = 52;
            npc.damage = 20;
            npc.defense = 12;
            npc.lifeMax = 70;
            npc.HitSound = SoundID.NPCHit4;
            npc.DeathSound = SoundID.NPCDeath37;
            npc.value = 60f;
            npc.knockBackResist = 1f;
 	    npc.spriteDirection = npc.direction;
            npc.aiStyle = 10;
            aiType = NPCID.CursedSkull;
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
				Gore.NewGore(npc.position, npc.velocity, mod.GetGoreSlot("Gores/BigLipsShipGore2"), 1f);
				Gore.NewGore(npc.position, npc.velocity, mod.GetGoreSlot("Gores/BigLipsShipGore"), 1f);
			}
}

        public override void AI()
        {
            npc.ai[0]++;
            Player P = Main.player[npc.target];
            if (npc.target < 0 || npc.target == 255 || Main.player[npc.target].dead || !Main.player[npc.target].active)
            {
                npc.TargetClosest(true);
            }
            npc.netUpdate = true;

            npc.ai[1]++;
            if (npc.ai[1] >= 180)
            {
                float Speed = 3f;
                Vector2 vector8 = new Vector2(npc.position.X + (npc.width / 2), npc.position.Y + (npc.height / 2));
                int damage = 20;
                int type = mod.ProjectileType("RhenzLaser");
                Main.PlaySound(23, (int)npc.position.X, (int)npc.position.Y, 17);
                float rotation = (float)Math.Atan2(vector8.Y - (P.position.Y + (P.height * 0.5f)), vector8.X - (P.position.X + (P.width * 0.5f)));
                int num54 = Projectile.NewProjectile(vector8.X, vector8.Y, (float)((Math.Cos(rotation) * Speed) * -1), (float)((Math.Sin(rotation) * Speed) * -1), type, damage, 0f, 0);
                npc.ai[1] = 0;

		Dust.NewDust(npc.position + npc.velocity, npc.width, npc.height, 244, npc.velocity.X * -0.5f, npc.velocity.Y * -0.5f, 255, default(Color), 0.5f);
		}
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
			Item.NewItem(npc.getRect(), mod.ItemType("RhenziumScraps"), Main.rand.Next(3, 6));
			}
			if (Main.rand.NextBool(2)) 
			{
			Item.NewItem(npc.getRect(), mod.ItemType("RhenziumShrapnel"), Main.rand.Next(25, 50));
	}
}
}
}