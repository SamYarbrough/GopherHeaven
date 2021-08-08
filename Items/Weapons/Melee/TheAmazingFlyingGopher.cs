using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace GopherHeaven.Items.Weapons.Melee
{
    public class TheAmazingFlyingGopher : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("This gopher has claws sharper than knives, and spins with unbelievable power\nSharp and small parts, not for children under 18 years of age");

            // These are all related to gamepad controls and don't seem to affect anything else
            ItemID.Sets.Yoyo[item.type] = true;
            ItemID.Sets.GamepadExtraRange[item.type] = 15;
            ItemID.Sets.GamepadSmartQuickReach[item.type] = true;
        }

        public override void SetDefaults()
        {
            item.useStyle = ItemUseStyleID.HoldingOut;
            item.width = 24;
            item.height = 24;
            item.useAnimation = 10;
            item.useTime = 10;
            item.shootSpeed = 16f;
            item.knockBack = 2.5f;
            item.damage = 24;
            item.rare = ItemRarityID.Green;

            item.melee = true;
            item.channel = true;
            item.noMelee = true;
            item.noUseGraphic = true;

            item.UseSound = SoundID.Item1;
            item.value = Item.sellPrice(platinum: 2);
            item.shoot = mod.ProjectileType("TheAmazingFlyingGopher");
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(null, "SoulOfGopher", 16);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
