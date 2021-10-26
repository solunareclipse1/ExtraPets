using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ExtraPets.Items
{
	public class TuxCat : ModItem
	{
		public override void SetDefaults()
		{
			item.CloneDefaults(ItemID.UnluckyYarn);
			item.name = "Sharp Looking Cat";
			item.toolTip = "Summons a tuxedo cat to follow you!";
			item.shoot = mod.ProjectileType("TuxCat");
			item.buffType = mod.BuffType("TuxCat");
		}

		public override void UseStyle(Player player)
		{
			if (player.whoAmI == Main.myPlayer && player.itemTime == 0)
			{
				player.AddBuff(item.buffType, 3600, true);
			}
		}
	}
}