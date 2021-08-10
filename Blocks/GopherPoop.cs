using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;

namespace GopherHeaven.Blocks
{
	public class GopherPoop : ModTile
	{
		public override void SetDefaults()
		{
			Main.tileSolid[Type] = true;
			Main.tileMergeDirt[Type] = true;
			Main.tileBlockLight[Type] = true;
			Main.tileLighted[Type] = true;
			drop = mod.ItemType("GopherPoop");
			AddMapEntry(new Color(135, 15, 15));
		}
	}
}