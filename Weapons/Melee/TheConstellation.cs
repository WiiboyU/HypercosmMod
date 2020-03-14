using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace HypercosmMod.Items.Weapons.Melee
{
    public class TheConstellation : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("The Constellation");
            Tooltip.SetDefault("");
        }

        public override void SetDefaults()
        {
            item.useStyle = 5; // The style used for YoYos.
            item.width = 34;
            item.height = 42;
            item.noUseGraphic = true; // Doesn't show Item in Hand.
            item.thrown = true; // YoYos are a melee item.
            item.noMelee = true; // Don't damage enemies with the hand hitbox.
            item.channel = true; // ???
            item.UseSound = SoundID.Item1;
            item.useAnimation = 25;
            item.useTime = 25;
            item.shoot = mod.ProjectileType("ConstellationProjectile");
            item.shootSpeed = 16f; // How fast the projectile is shot.
            item.knockBack = 2.5f;
            item.damage = 60;
            item.value = Item.buyPrice(gold: 3);
            item.rare = 7;
        }
		public override void AddRecipes() {
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod.ItemType("ConcentratedMoonstone"), 4);
                        recipe.AddIngredient(mod.ItemType("MoonlitCrystal"),4);
			recipe.AddTile(134);
			recipe.SetResult(this);
			recipe.AddRecipe();
        }
    }
}