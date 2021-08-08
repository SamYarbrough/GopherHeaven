using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using static Terraria.ModLoader.ModContent;

namespace GopherHeaven.Items.Armor
{
    [AutoloadEquip(EquipType.Head)]
    public class GopherHelmet : ModItem
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
            item.defense = 32;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(null, "SoulOfGopher", 24);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }

        public override bool IsArmorSet(Item head, Item body, Item legs)
        {
            return body.type == ItemType<GopherChestplate>() && legs.type == ItemType<GopherGreaves>();
        }

        public override void UpdateArmorSet(Player player)
        {
            player.moveSpeed += 7f;
            player.noFallDmg = true;
            player.statLifeMax2 += 100;
            player.maxMinions += 5;
            player.buffImmune[BuffID.OnFire] = true;
            player.statManaMax2 += 200;
            if (player.velocity.X == 0 && player.velocity.Y == 0) {
                player.meleeDamage += 0.5f;
                player.rangedDamage += 0.5f;
                player.magicDamage += 0.5f;
                player.minionDamage += 0.5f;
                player.thrownDamage += 0.5f;
                player.statDefense += 24;
            }
            player.setBonus = "Greatly increases movement speed\n" +
                              "Negates fall damage\n" +
                              "Provides immunity to the \"On Fire!\" debuff\n" +
                              "Increases max minions by 5\n" +
                              "Increases max mana by 200\n" +
                              "Increases max life by 100\n" +
                              "When staying still:\n" +
                              "- All damage types increased\n" + 
                              "- Defense increased by 24"; 
        }
    }
}
