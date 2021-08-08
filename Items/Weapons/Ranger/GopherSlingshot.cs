using Microsoft.Xna.Framework;
using Terraria.ID;
using Terraria.ModLoader;

namespace GopherHeaven.Items.Weapons.Ranger
{
    public class GopherSlingshot : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("This is what happens when you put wild gopher on steroids\nEye protection strongly advised\nSmall parts, not for children under 18 years");
        }

        public override void SetDefaults()
        {
            item.damage = 16;
            item.ranged = true;
            item.width = 64;
            item.height = 82;
            item.useTime = 10;
            item.useAnimation = 10;
            item.useStyle = ItemUseStyleID.HoldingOut;
            item.noMelee = true; //so the item's animation doesn't do damage
            item.knockBack = 4;
            item.value = 10000;
            item.rare = ItemRarityID.Green;
            item.UseSound = SoundID.Item11;
            item.autoReuse = true;
            item.shoot = mod.ProjectileType("Gopher");
            item.shoot = mod.ProjectileType("Nukopher");
            item.shootSpeed = 6f;
            item.useAmmo = mod.ItemType("Gopher");
            item.useAmmo = mod.ItemType("Nukopher");
            item.scale = 1f;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(null, "SoulOfGopher", 20);
            recipe.AddIngredient(ItemID.Wood, 10);
            recipe.AddIngredient(ItemID.StoneBlock, 10);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }

        public override Vector2? HoldoutOffset()
        {
            return new Vector2(-8, 0);
        }
    }
}
