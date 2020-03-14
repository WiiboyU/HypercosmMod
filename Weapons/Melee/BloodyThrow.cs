using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace HypercosmMod.Items.Weapons.Melee
{
    public class BloodyThrow : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Bloody Throw");
            Tooltip.SetDefault("");
        }

        public override void SetDefaults()
        {
            item.useStyle = 5; // The style used for YoYos.
            item.width = 36;
            item.height = 46;
            item.noUseGraphic = true; // Doesn't show Item in Hand.
            item.thrown = true; // YoYos are a melee item.
            item.noMelee = true; // Don't damage enemies with the hand hitbox.
            item.channel = true; // ???
            item.UseSound = SoundID.Item1;
            item.useAnimation = 25;
            item.useTime = 25;
            item.shoot = mod.ProjectileType("BloodyThrowProjectile");
            item.shootSpeed = 16f; // How fast the projectile is shot.
            item.knockBack = 2.5f;
            item.damage = 22;
            item.value = Item.buyPrice(gold: 1);
            item.rare = 2;
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