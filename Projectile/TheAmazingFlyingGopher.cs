﻿using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace GopherHeaven.Projectile
{
    public class TheAmazingFlyingGopher : ModProjectile
    {
        public override void SetStaticDefaults()
        {

            // The following sets are only applicable to yoyo that use aiStyle 99.
            // YoyosLifeTimeMultiplier is how long in seconds the yoyo will stay out before automatically returning to the player. 
            // Vanilla values range from 3f(Wood) to 16f(Chik), and defaults to -1f. Leaving as -1 will make the time infinite.
            ProjectileID.Sets.YoyosLifeTimeMultiplier[projectile.type] = -1f;

            // YoyosMaximumRange is the maximum distance the yoyo sleep away from the player. 
            // Vanilla values range from 130f(Wood) to 400f(Terrarian), and defaults to 200f
            ProjectileID.Sets.YoyosMaximumRange[projectile.type] = 400f;

            // YoyosTopSpeed is top speed of the yoyo projectile. 
            // Vanilla values range from 9f(Wood) to 17.5f(Terrarian), and defaults to 10f
            ProjectileID.Sets.YoyosTopSpeed[projectile.type] = 17.5f;
        }

        public override void SetDefaults()
        {
            projectile.extraUpdates = 0;
            projectile.width = 16;
            projectile.height = 16;

            // aiStyle 99 is used for all yoyos, and is Extremely suggested, as yoyo are extremely difficult without them
            projectile.aiStyle = 99;
            projectile.friendly = true;
            projectile.penetrate = -1;
            projectile.melee = true;
            projectile.scale = 1f;
        }

        public override void OnHitNPC(NPC n, int damage, float knockback, bool crit)
        {

            Player owner = Main.player[projectile.owner];
            int rand = Main.rand.Next(10); //Generates an integer from 0 to 1
            if (rand == 0)
            {
                n.AddBuff(69, 180); //Ichor debuff for 3 seconds
            }
            else if (rand == 1)
            {
                owner.statLife += 15; //Gives 15 Health
                owner.HealEffect(15, true); //Shows you have healed by 5 health
            }
        }

        // notes for aiStyle 99: 
        // localAI[0] is used for timing up to YoyosLifeTimeMultiplier
        // localAI[1] can be used freely by specific types
        // ai[0] and ai[1] usually point towards the x and y world coordinate hover point
        // ai[0] is -1f once YoyosLifeTimeMultiplier is reached, when the player is stoned/frozen, when the yoyo is too far away, or the player is no longer clicking the shoot button.
        // ai[0] being negative makes the yoyo move back towards the player
        // Any AI method can be used for dust, spawning projectiles, etc specific to your yoyo.

        public override void PostAI()
        {
            if (Main.rand.Next(2) == 0)
            {
                Dust dust = Dust.NewDustDirect(projectile.position, projectile.width, projectile.height, 16);
                dust.noGravity = true;
                dust.scale = 1.6f;
            }


        }
    }
}
