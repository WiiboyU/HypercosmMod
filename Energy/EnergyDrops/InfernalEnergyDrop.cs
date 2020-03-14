using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace HypercosmMod.Items.Energy.EnergyDrops
{
    public class InfernalEnergyDrop: GlobalNPC
    {
        public override void NPCLoot(NPC npc) {
            if (Main.player[(int)Player.FindClosest(npc.position, npc.width, npc.height)].ZoneUnderworldHeight)
                {
                    if (Main.rand.Next(16) == 0)
                    Item.NewItem(npc.getRect(), mod.ItemType("InfernalEnergy"));
            }
        }
    }
}