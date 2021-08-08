using Terraria.ID;
using Terraria.ModLoader;

namespace GopherHeaven.Items.Weapons.Ranger.Ammo
{
    public class Gopher : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Powerful ammo for a powerful weapon\nSmall parts, not for children under 18 years");
        }
        public override void SetDefaults()
        {
            item.damage = 16;
            item.ranged = true;
            item.width = 1;
            item.height = 1;
            item.maxStack = 9999;
            item.consumable = true; //You need to set the item consumable so that the ammo would automatically consumed
            item.knockBack = 1.5f;
            item.value = 10;
            item.rare = 2;
            item.shoot = mod.ProjectileType("Gopher"); //The projectile shoot when your weapon using this ammo
            item.shootSpeed = 12f; //The speed of the projectile
            item.ammo = item.type; //The ammo class this ammo belongs to.
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(null, "SoulOfGopher", 1);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(this, 50);
            recipe.AddRecipe();
        }
    }
}