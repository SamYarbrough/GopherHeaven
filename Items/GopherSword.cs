using Terraria.ID;
using Terraria.ModLoader;

namespace GopherHeaven.Items
{
	public class GopherSword : ModItem
	{
		public override void SetStaticDefaults() 
		{
			// DisplayName.SetDefault("GopherSword"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("This sword is kinda OP, IDK why I added it.");
		}

		public override void SetDefaults() 
		{
			item.damage = 24;
			item.melee = true;
			item.width = 100;
			item.height = 100;
			item.useTime = 15;
			item.useAnimation = 15;
			item.useStyle = 1;
			item.knockBack = 5;
			item.value = 10000;
			item.rare = 1;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
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
	}
}