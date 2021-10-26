using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ExtraPets.Projectiles.Pets
{
	public class StarShine : ModProjectile
	{
		public override void SetDefaults()
		{
			projectile.CloneDefaults(ProjectileID.Wisp);
			aiType = ProjectileID.Wisp;
			projectile.name = "Shining Star";
			Main.projFrames[projectile.type] = 10;
			ProjectileID.Sets.LightPet[projectile.type] = true;
			Main.projPet[projectile.type] = true;
		}
	}
}