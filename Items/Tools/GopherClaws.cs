using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace GopherHeaven.Items.Tools
{
	public class GopherClaws : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("Relatively good pickaxe, when you realize that it is nearly 100% made of earth");
		}

		public override void SetDefaults()
		{
			item.damage = 20;
			item.melee = true;
			item.width = 40;
			item.height = 40;
			item.useTime = 3;
			item.useAnimation = 10;
			item.pick = 300;
			item.axe = 30;
			item.hammer = 300;
			item.useStyle = ItemUseStyleID.SwingThrow;
			item.knockBack = 6;
			item.value = 10000;
			item.rare = ItemRarityID.Green;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "SoulOfGopher", 48);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
