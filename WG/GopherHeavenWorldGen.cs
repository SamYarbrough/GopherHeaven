using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using Terraria.World.Generation;
using Microsoft.Xna.Framework;
using System.Collections.Generic;
using Terraria.GameContent.Generation;

namespace GopherHeaven.WG
{
    public class GopherHeavenWorldGen : ModWorld
    {
        public override void ModifyWorldGenTasks(List<GenPass> tasks, ref float totalWeight)
        {
            int shiniesIndex = tasks.FindIndex(genpass => genpass.Name.Equals("Shinies"));
            if (shiniesIndex != -1) {
                tasks.Insert(shiniesIndex + 1, new PassLegacy("Gopher Heaven Ore Generation", OreGeneration));
            }
        }




        private void OreGeneration(GenerationProgress progress) {
            progress.Message = "Generating Ancient Gopher Feces";
            // 7E-04 = 0.0007
            // This is so that ores are not generating for every single point in the world
            // This and ore vein sizes determine how much is in the world
            // It scales for medium and large worlds too, but to make it not dependent on
            //     world size, delete (Main.maxTilesX*Main.maxTilesY) * 6E-05 and replace
            //     with the number of veins you want.

            for (var i = 0; i < (int)((double)(Main.maxTilesX * Main.maxTilesY) * 7E-04); i++) {
                int x = WorldGen.genRand.Next(0, Main.maxTilesX);
                // any x value in the world
                int y = WorldGen.genRand.Next((int)WorldGen.worldSurfaceHigh, Main.maxTilesY);
                // surface to hell (y value is higher the deeper you go)

                WorldGen.TileRunner(
                    x, //xpos
                    y, //ypos
                    (double)WorldGen.genRand.Next(3, 6), //Strength
                    WorldGen.genRand.Next(2, 6), //Steps
                    mod.TileType("GopherPoop"), //Block
                    false, //If true then the ore can replace air...
                    0f, //idk
                    0f, //idk
                    false, //settle block (like sand)
                    true //replace other existing tiles
                );
            }

        }



    }
}
