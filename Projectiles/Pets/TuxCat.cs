using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ExtraPets.Projectiles.Pets
{
	public class TuxCat : ModProjectile
	{
		public override void SetDefaults()
		{
			projectile.CloneDefaults(ProjectileID.BlackCat);
			projectile.name = "TuxCat";
			aiType = ProjectileID.BlackCat;
			Main.projFrames[projectile.type] = 11;
			Main.projPet[projectile.type] = true;
			drawOffsetX = 0;
			drawOriginOffsetY = 2;
			drawOriginOffsetX = 0;
			projectile.height = 24;
		}

		public override bool PreAI()
		{
			Player player = Main.player[projectile.owner];
			return true;
		}

		public override void AI()
		{
			Player player = Main.player[projectile.owner];
			ExamplePlayer modPlayer = player.GetModPlayer<ExamplePlayer>(mod);
			if (player.dead)
			{
				modPlayer.examplePet = false;
			}
			if (modPlayer.examplePet)
			{
				projectile.timeLeft = 2;
			}
		}
	}
}