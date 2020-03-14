using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using System;

namespace HypercosmMod.NPCs.Moon
{
    public class MichaelJackson : ModNPC
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Moonwalker");
        }

        public override void SetDefaults()
        {
            npc.aiStyle = 1; //Slime AI, i would like to know king slimes AI but this works just the same.
            npc.lifeMax = 250;
            npc.HitSound = SoundID.NPCHit4;
            npc.DeathSound = SoundID.NPCDeath37;
            npc.damage = 15;
            npc.defense = 40;
            npc.knockBackResist = 1;
            npc.width = 64;
            npc.height = 36;
            animationType = NPCID.ToxicSludge; //Animation type.
            Main.npcFrameCount[npc.type] = 3; //The king slime has a frame count of 6.
            aiType = NPCID.ToxicSludge; //AI type
            npc.npcSlots = 1f;
            npc.boss = false;
            npc.lavaImmune = true;
            npc.noGravity = false;
            npc.noTileCollide = false;
            npc.netAlways = true;

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


        public override void ScaleExpertStats(int numPlayers, float bossLifeScale)
        {

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