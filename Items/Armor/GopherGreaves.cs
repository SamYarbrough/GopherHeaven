﻿using Microsoft.Xna.Framework;
using Terraria.ModLoader;
using Terraria.ID;

namespace GopherHeaven.Items.Armor
{
    [AutoloadEquip(EquipType.Legs)]
    public class GopherGreaves : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Fits only the most worthy gophers\nAble to withstand powerful attacks using something known as: \"decent engineering\"");
        }

        public override void SetDefaults()
        {
            item.Size = new Vector2(18);
            item.value = 10000;
            item.rare = 2;
            item.defense = 48;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(null, "SoulOfGopher", 72);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
