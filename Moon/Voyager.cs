using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using System;

namespace HypercosmMod.NPCs.Moon
{
	public class Voyager : ModNPC
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Voyager");
		}

		public override void SetDefaults() 
		{
            npc.aiStyle = 3;
            npc.lifeMax = 300;
	    npc.HitSound = SoundID.NPCHit4;
	    npc.DeathSound = SoundID.NPCDeath37;
            npc.damage = 46;
            npc.defense = 40;
            npc.knockBackResist = 1;
            npc.width = 70;
            npc.height = 55;
            animationType = NPCID.Crab; //Animation type.
            Main.npcFrameCount[npc.type] = 8;
            aiType = NPCID.Crab; //AI type
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
            npc.ai[0]++;
            Player P = Main.player[npc.target];
            if (npc.target < 0 || npc.target == 255 || Main.player[npc.target].dead || !Main.player[npc.target].active)
            {
                npc.TargetClosest(true);
            }
            npc.netUpdate = true;

            npc.ai[1]++;
            if (npc.ai[1] >= 230)
            {
                float Speed = 5f;
                Vector2 vector8 = new Vector2(npc.position.X + (npc.width / 2), npc.position.Y + (npc.height / 2));
                int damage = 35;
                int type = mod.ProjectileType("BigMoonCrystal");
                Main.PlaySound(23, (int)npc.position.X, (int)npc.position.Y, 17);
                float rotation = (float)Math.Atan2(vector8.Y - (P.position.Y + (P.height * 0.5f)), vector8.X - (P.position.X + (P.width * 0.5f)));
                int num54 = Projectile.NewProjectile(vector8.X, vector8.Y, (float)((Math.Cos(rotation) * Speed) * -1), (float)((Math.Sin(rotation) * Speed) * -1), type, damage, 0f, 0);
                npc.ai[1] = 0;
            }
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