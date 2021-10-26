using Terraria;
using Terraria.ModLoader;
namespace ExtraPets.Buffs
{
	public class TuxCat : ModBuff
	{
		public override void SetDefaults()
		{
			Main.buffName[Type] = "Tuxedo Cat";
			Main.buffTip[Type] = "A black and white kitten is following you...";
			Main.buffNoTimeDisplay[Type] = true;
			Main.vanityPet[Type] = true;
		}

		public override void Update(Player player, ref int buffIndex)
		{
			player.buffTime[buffIndex] = 18000;
            player.GetModPlayer<ExamplePlayer>(mod).examplePet = true;
			bool petProjectileNotSpawned = player.ownedProjectileCounts[mod.ProjectileType("TuxCat")] <= 0;
			if (petProjectileNotSpawned && player.whoAmI == Main.myPlayer)
			{
				Projectile.NewProjectile(player.position.X + (float)(player.width / 2), player.position.Y + (float)(player.height / 2), 0f, 0f, mod.ProjectileType("TuxCat"), 0, 0f, player.whoAmI, 0f, 0f);
			}
		}
	}
}