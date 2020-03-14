using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;

namespace HypercosmMod.Dusts
{
    public class ScytheDust : ModDust
	{
		
                public override void OnSpawn(Dust dust)
		{
			dust.velocity.Y *= 1f;
			dust.velocity.X *= 1f;
			dust.scale *= 1f;
			dust.noGravity = true;
			dust.noLight = false;
		}
                
                
                
	}
}