using System;
using System.Collections.Generic;
using System.IO;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.World.Generation;
using Terraria.GameContent.Generation;


namespace HypercosmMod.NPCs.Bosses
{
	[AutoloadBossHead]
	public class StarChaserHead : ModNPC
	{
		public static int _type;

		int timer = 20;
		public bool flies = true;
		public bool directional = false;
		public float speed = 12f;
		public float turnSpeed = 0.26f;
		public bool tail = true;
		public int minLength = 16;
		public int maxLength = 16;

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Star Chaser");
		}

		public override void SetDefaults()
		{
			npc.scale = 1f;
			npc.damage = 27; 
			npc.npcSlots = 5f;
			bossBag = mod.ItemType("StarChaserBossBag");
			npc.width = 60; 
			npc.height = 66; 
			npc.defense = 15;
			npc.lifeMax = 5540; 
			npc.aiStyle = 6; 
			Main.npcFrameCount[npc.type] = 1; 
			aiType = -1; 
			animationType = 10; 
			npc.knockBackResist = 0f;
			npc.boss = true;
			npc.value = Item.buyPrice(0, 5, 25, 0);
			npc.alpha = 255;
			npc.behindTiles = true;
			npc.noGravity = true;
			npc.noTileCollide = true;
			npc.HitSound = SoundID.NPCHit4;
            npc.DeathSound = mod.GetLegacySoundSlot(SoundType.Custom, "Sounds/NPCnoises/StarChaserDeath").WithVolume(.7f).WithPitchVariance(.5f);
			npc.netAlways = true;
			music = MusicID.Boss3;
			for (int k = 0; k < npc.buffImmune.Length; k++)
			{
				npc.buffImmune[k] = true;
			}
		}
        public override void ScaleExpertStats(int numPlayers, float bossLifeScale)
        {
            npc.lifeMax = 6065;
            npc.defense = 20;
            npc.damage = 48;
        }
		
		
		public override void BossHeadRotation(ref float rotation)
        {
            rotation = npc.rotation;
        }
		public override void AI()
		{
			Player player = Main.player[npc.target];
			bool expertMode = Main.expertMode;
			timer++;
			
			if (timer == 300 || timer == 600 || timer == 900)
			{
				Vector2 direction = Main.player[npc.target].Center - npc.Center;
				direction.Normalize();
				direction.X *= 10f;
				direction.Y *= 10f;

				int amountOfProjectiles = Main.rand.Next(2, 3);
				for (int i = 0; i < amountOfProjectiles; ++i)
				{
				
					float A = (float)Main.rand.Next(-150, 150) * 0.03f;
					float B = (float)Main.rand.Next(-150, 150) * 0.03f;
					int dmg = expertMode ? 7 : 10;
					Projectile.NewProjectile(npc.Center.X, npc.Center.Y, direction.X + A, direction.Y + B, mod.ProjectileType("SmallStarComet"), 16, 1, Main.myPlayer, 0, 0);
				}
			}
			
			if (timer == 600)
		    {
					
				NPC.NewNPC((int)npc.Center.X, (int)npc.Center.Y, mod.NPCType("StarRaiderHead"), npc.whoAmI, 0f, 0f, 0f, 0f, 0);
					
				
			}
			if (timer == 1200)
			{
				Vector2 direction = Main.player[npc.target].Center - npc.Center;
				direction.Normalize();
				direction.X *= 7f;
				direction.Y *= 7f;

				int amountOfProjectiles = Main.rand.Next(1, 1);
				for (int i = 0; i < amountOfProjectiles; ++i)
				{
				
					float A = (float)Main.rand.Next(-150, 150) * 0.03f;
					float B = (float)Main.rand.Next(-150, 150) * 0.03f;
					int dmg = expertMode ? 7 : 10;
					Projectile.NewProjectile(npc.Center.X, npc.Center.Y, direction.X + A, direction.Y + B, mod.ProjectileType("BigStarComet"), 16, 1, Main.myPlayer, 0, 0);
				}
			}
			
			if (timer == 1200)
				timer = 0;
			
			
			
			
			if (npc.ai[3] > 0f)
				npc.realLife = (int)npc.ai[3];

			if (npc.target < 0 || npc.target == 255 || player.dead)
				npc.TargetClosest(true);

			npc.velocity.Length();
			
			npc.alpha -= 12;
			if (npc.alpha < 0)
				npc.alpha = 0;

			
			if (Main.netMode != 1)
            {

                if (npc.ai[0] == 0)
                {


                    npc.realLife = npc.whoAmI;

                    int latestNPC = npc.whoAmI;


                    int randomWormLength = Main.rand.Next(20, 20);
                    for (int i = 0; i < randomWormLength; ++i)
                    {

                        latestNPC = NPC.NewNPC((int)npc.Center.X, (int)npc.Center.Y, mod.NPCType("StarChaserBody"), npc.whoAmI, 0, latestNPC);
                        Main.npc[(int)latestNPC].realLife = npc.whoAmI;
                        Main.npc[(int)latestNPC].ai[3] = npc.whoAmI;
                    }

                    latestNPC = NPC.NewNPC((int)npc.Center.X, (int)npc.Center.Y, mod.NPCType("StarChaserTail"), npc.whoAmI, 0, latestNPC);
                    Main.npc[(int)latestNPC].realLife = npc.whoAmI;
                    Main.npc[(int)latestNPC].ai[3] = npc.whoAmI;


                    npc.ai[0] = 1;
                    npc.netUpdate = true;
                }
            }
            
			int num180 = (int)(npc.position.X / 16f) - 1;
			int num181 = (int)((npc.position.X + (float)npc.width) / 16f) + 2;
			int num182 = (int)(npc.position.Y / 16f) - 1;
			int num183 = (int)((npc.position.Y + (float)npc.height) / 16f) + 2;
			if (num180 < 0)
				num180 = 0;

			if (num181 > Main.maxTilesX)
				num181 = Main.maxTilesX;

			if (num182 < 0)
				num182 = 0;

			if (num183 > Main.maxTilesY)
				num183 = Main.maxTilesY;

			bool flag94 = flies;
			npc.localAI[1] = 0f;
			if (directional)
			{
				if (npc.velocity.X < 0f)
					npc.spriteDirection = 1;

				else if (npc.velocity.X > 0f)
					npc.spriteDirection = -1;
			}
			if (player.dead)
			{
				npc.TargetClosest(false);
				flag94 = false;
				npc.velocity.Y = npc.velocity.Y + 10f;
				if ((double)npc.position.Y > Main.worldSurface * 16.0)
					npc.velocity.Y = npc.velocity.Y + 10f;

				if ((double)npc.position.Y > Main.rockLayer * 16.0)
				{
					for (int num957 = 0; num957 < 200; num957++)
					{
						if (Main.npc[num957].aiStyle == npc.aiStyle)
							Main.npc[num957].active = false;
					}
				}
			}
			Vector2 value = npc.Center + (npc.rotation - 1.57079637f).ToRotationVector2() * 8f;
			Vector2 value2 = npc.rotation.ToRotationVector2() * 16f;
			
			
			
			float num188 = speed;
			float num189 = turnSpeed;
			Vector2 vector18 = new Vector2(npc.position.X + (float)npc.width * 0.5f, npc.position.Y + (float)npc.height * 0.5f);
			float num191 = player.position.X + (float)(player.width / 2);
			float num192 = player.position.Y + (float)(player.height / 2);
			int num42 = -1;
			int num43 = (int)(player.Center.X / 16f);
			int num44 = (int)(player.Center.Y / 16f);
			for (int num45 = num43 - 2; num45 <= num43 + 2; num45++)
			{
				for (int num46 = num44; num46 <= num44 + 15; num46++)
				{
					if (WorldGen.SolidTile2(num45, num46))
					{
						num42 = num46;
						break;
					}
				}
				if (num42 > 0)
					break;
			}
			if (num42 > 0)
			{
				npc.defense = 15;
				num42 *= 16;
				float num47 = (float)(num42 - 400); //was 800
				if (player.position.Y > num47)
				{
					num192 = num47;
					if (Math.Abs(npc.Center.X - player.Center.X) < 250f) //was 500
					{
						if (npc.velocity.X > 0f)
							num191 = player.Center.X + 300f; //was 600
						else
							num191 = player.Center.X - 300f; //was 600
					}
				}
			}
			else
			{
				npc.defense = 0;
				num188 = expertMode ? 12.5f : 10f; //added 2.5
				num189 = expertMode ? 0.25f : 0.2f; //added 0.05
			}
			float num48 = num188 * 1.3f;
			float num49 = num188 * 0.7f;
			float num50 = npc.velocity.Length();
			if (num50 > 0f)
			{
				if (num50 > num48)
				{
					npc.velocity.Normalize();
					npc.velocity *= num48;
				}
				else if (num50 < num49)
				{
					npc.velocity.Normalize();
					npc.velocity *= num49;
				}
			}
			if (num42 > 0)
			{
				for (int num51 = 0; num51 < 200; num51++)
				{
					if (Main.npc[num51].active && Main.npc[num51].type == npc.type && num51 != npc.whoAmI)
					{
						Vector2 vector3 = Main.npc[num51].Center - npc.Center;
						if (vector3.Length() < 400f)
						{
							vector3.Normalize();
							vector3 *= 1000f;
							num191 -= vector3.X;
							num192 -= vector3.Y;
						}
					}
				}
			}
			else
			{
				for (int num52 = 0; num52 < 200; num52++)
				{
					if (Main.npc[num52].active && Main.npc[num52].type == npc.type && num52 != npc.whoAmI)
					{
						Vector2 vector4 = Main.npc[num52].Center - npc.Center;
						if (vector4.Length() < 60f)
						{
							vector4.Normalize();
							vector4 *= 200f;
							num191 -= vector4.X;
							num192 -= vector4.Y;
						}
					}
				}
			}
			num191 = (float)((int)(num191 / 16f) * 16);
			num192 = (float)((int)(num192 / 16f) * 16);
			vector18.X = (float)((int)(vector18.X / 16f) * 16);
			vector18.Y = (float)((int)(vector18.Y / 16f) * 16);
			num191 -= vector18.X;
			num192 -= vector18.Y;
			float num193 = (float)System.Math.Sqrt((double)(num191 * num191 + num192 * num192));
			if (npc.ai[1] > 0f && npc.ai[1] < (float)Main.npc.Length)
			{
				try
				{
					vector18 = new Vector2(npc.position.X + (float)npc.width * 0.5f, npc.position.Y + (float)npc.height * 0.5f);
					num191 = Main.npc[(int)npc.ai[1]].position.X + (float)(Main.npc[(int)npc.ai[1]].width / 2) - vector18.X;
					num192 = Main.npc[(int)npc.ai[1]].position.Y + (float)(Main.npc[(int)npc.ai[1]].height / 2) - vector18.Y;
				}
				catch
				{
				}
				npc.rotation = (float)Math.Atan2(num192, num191) + 1.57f;
				num193 = (float)Math.Sqrt(num191 * num191 + num192 * num192);
				int num194 = npc.width;
				num193 = (num193 - num194) / num193;
				num191 *= num193;
				num192 *= num193;
				npc.velocity = Vector2.Zero;
				npc.position.X = npc.position.X + num191;
				npc.position.Y = npc.position.Y + num192;
				if (directional)
				{
					if (num191 < 0f)
						npc.spriteDirection = 1;

					if (num191 > 0f)
						npc.spriteDirection = -1;
				}
			}
			else
			{
				num193 = (float)System.Math.Sqrt((double)(num191 * num191 + num192 * num192));
				float num196 = System.Math.Abs(num191);
				float num197 = System.Math.Abs(num192);
				float num198 = num188 / num193;
				num191 *= num198;
				num192 *= num198;
				bool flag21 = false;
				if (!flag21)
				{
					if ((npc.velocity.X > 0f && num191 > 0f) || (npc.velocity.X < 0f && num191 < 0f) || (npc.velocity.Y > 0f && num192 > 0f) || (npc.velocity.Y < 0f && num192 < 0f))
					{
						if (npc.velocity.X < num191)
							npc.velocity.X = npc.velocity.X + num189;
						else
						{
							if (npc.velocity.X > num191)
								npc.velocity.X = npc.velocity.X - num189;
						}

						if (npc.velocity.Y < num192)
							npc.velocity.Y = npc.velocity.Y + num189;
						else
						{
							if (npc.velocity.Y > num192)
							{
								npc.velocity.Y = npc.velocity.Y - num189;
							}
						}

						if ((double)System.Math.Abs(num192) < (double)num188 * 0.2 && ((npc.velocity.X > 0f && num191 < 0f) || (npc.velocity.X < 0f && num191 > 0f)))
						{
							if (npc.velocity.Y > 0f)
								npc.velocity.Y = npc.velocity.Y + num189 * 2f;
							else
								npc.velocity.Y = npc.velocity.Y - num189 * 2f;
						}
						if ((double)System.Math.Abs(num191) < (double)num188 * 0.2 && ((npc.velocity.Y > 0f && num192 < 0f) || (npc.velocity.Y < 0f && num192 > 0f)))
						{
							if (npc.velocity.X > 0f)
								npc.velocity.X = npc.velocity.X + num189 * 2f; //changed from 2
							else
								npc.velocity.X = npc.velocity.X - num189 * 2f; //changed from 2
						}
					}
					else
					{
						if (num196 > num197)
						{
							if (npc.velocity.X < num191)
								npc.velocity.X = npc.velocity.X + num189 * 1.1f; //changed from 1.1
							else if (npc.velocity.X > num191)
								npc.velocity.X = npc.velocity.X - num189 * 1.1f; //changed from 1.1

							if ((double)(System.Math.Abs(npc.velocity.X) + System.Math.Abs(npc.velocity.Y)) < (double)num188 * 0.5)
							{
								if (npc.velocity.Y > 0f)
									npc.velocity.Y = npc.velocity.Y + num189;
								else
									npc.velocity.Y = npc.velocity.Y - num189;
							}
						}
						else
						{
							if (npc.velocity.Y < num192)
								npc.velocity.Y = npc.velocity.Y + num189 * 1.1f;
							else if (npc.velocity.Y > num192)
								npc.velocity.Y = npc.velocity.Y - num189 * 1.1f;
							if ((double)(System.Math.Abs(npc.velocity.X) + System.Math.Abs(npc.velocity.Y)) < (double)num188 * 0.5)
							{
								if (npc.velocity.X > 0f)
									npc.velocity.X = npc.velocity.X + num189;
								else
									npc.velocity.X = npc.velocity.X - num189;
							}
						}
					}
				}
			}
		}
        
        
        public override void NPCLoot()
        {
            if (Main.expertMode)
            {
                npc.DropBossBags();
            }
            else
            {
                if (Main.rand.Next(7) == 0)
                {
                    Item.NewItem(npc.getRect(), mod.ItemType("StarChaserMask"), Main.rand.Next(1, 1));
                }
                if (Main.rand.NextBool(20))
                {
                    Item.NewItem(npc.getRect(), mod.ItemType("MilkywayReaper"), Main.rand.Next(1, 1));
                }
                int choice = Main.rand.Next(3);
                if (choice == 0)
                {
                    Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("ShootingStar"));
                }
                if (choice == 1)
                {
                    Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("StellarWand"));
                }
                if (choice == 2)
                {
                    Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("NovaBlade"));
                }
                if (Main.rand.NextBool(1))
                {
                Item.NewItem(npc.getRect(), mod.ItemType("StarlightPlating"), Main.rand.Next(13, 17));
                Item.NewItem(npc.getRect(), ItemID.GoldCoin, 12);
                Item.NewItem(npc.getRect(), ItemID.FallenStar, Main.rand.Next(12, 16));
                }
            }
        }


        public override bool CheckDead()
        {
            Gore.NewGore(npc.position, npc.velocity, mod.GetGoreSlot("Gores/StarChaserHeadGore"), 1f);
            Gore.NewGore(npc.position, npc.velocity, mod.GetGoreSlot("Gores/StarChaserBodyGore"), 1f);
            Gore.NewGore(npc.position, npc.velocity, mod.GetGoreSlot("Gores/StarChaserBodyGore"), 1f);
            Gore.NewGore(npc.position, npc.velocity, mod.GetGoreSlot("Gores/StarChaserBodyGore"), 1f);
            Gore.NewGore(npc.position, npc.velocity, mod.GetGoreSlot("Gores/StarChaserTailGore"), 1f);


            return true;
        }
        public override bool PreDraw(Microsoft.Xna.Framework.Graphics.SpriteBatch spriteBatch, Color drawColor)
        {
            Texture2D texture = Main.npcTexture[npc.type];
            Vector2 origin = new Vector2(texture.Width * 0.5f, texture.Height * 0.5f);
            Main.spriteBatch.Draw(texture, npc.Center - Main.screenPosition, new Rectangle?(), drawColor, npc.rotation, origin, npc.scale, SpriteEffects.None, 0);
            return false;

        }

        public override bool? DrawHealthBar(byte hbPosition, ref float scale, ref Vector2 position)
        {
            scale = 1.9f;   //this make the NPC Health Bar biger
            return null;
        }

        public override void PostDraw(SpriteBatch spriteBatch, Color lightColor)
        {
            Texture2D texture = mod.GetTexture("NPCs/Bosses/StarChaserHeadGlowmask");
            spriteBatch.Draw
            (
                texture,
                new Vector2
                (
                    npc.position.X - Main.screenPosition.X + npc.width * 0.5f,
                    npc.position.Y - Main.screenPosition.Y + npc.height - texture.Height * 0.5f + 2f
                ),
                new Rectangle(0, 0, texture.Width, texture.Height),
                new Color(255 - npc.alpha, 255 - npc.alpha, 255 - npc.alpha),
                npc.rotation,
                texture.Size() * 0.5f,
                npc.scale,
                SpriteEffects.None,
                0f
            );
        }

    }
}