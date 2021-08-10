using Terraria.ID;
using Terraria.ModLoader;

namespace GopherHeaven.Items.Weapons.Ranger.Ammo
{
    public class Nukopher : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Big Boi Bullet");
        }
        public override void SetDefaults()
        {
            item.damage = 64;
            item.ranged = true;
            item.width = 1000;
            item.height = 1091;
            item.maxStack = 9999;
            item.consumable = true; //You need to set the item consumable so that the ammo would automatically consumed
            item.knockBack = 1.5f;
            item.value = 10;
            item.rare = 2;
            item.shoot = mod.ProjectileType("Nukopher"); //The projectile shoot when your weapon using this ammo
            item.shootSpeed = 0.5f; //The speed of the projectile
            item.ammo = item.type; //The ammo class this ammo belongs to.
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(null, "Gopher", 20);
            recipe.AddIngredient(null, "GopherPoop", 1);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(this, 5);
            recipe.AddRecipe();
        }
    }
}