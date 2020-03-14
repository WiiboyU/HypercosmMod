using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace HypercosmMod.Items.Energy.EnergyDrops
{
    public class BlessedEnergyDrop: GlobalNPC
    {
        public override void NPCLoot(NPC npc) {
            if (Main.player[(int)Player.FindClosest(npc.position, npc.width, npc.height)].ZoneHoly)
                {
                    if (Main.rand.Next(20) == 0)
                    Item.NewItem(npc.getRect(), mod.ItemType("BlessedEnergy"));
            }
        }
    }
}