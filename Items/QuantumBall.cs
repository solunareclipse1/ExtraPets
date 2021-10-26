using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ExtraPets.Items
{
	public class QuantumBall : ModItem
	{
		public override void SetDefaults()
		{
			item.damage = 0;
			item.useStyle = 1;
			item.name = "Quantum Ball";
			item.shoot = mod.ProjectileType("Quantum Ball");
			item.width = 16;
			item.height = 30;
			item.useSound = 2;
			item.useAnimation = 20;
			item.useTime = 20;
			item.rare = 8;
			item.noMelee = true;
			item.toolTip = "Summons a ball of Quantum energy to guide you";
			item.value = Item.sellPrice(0, 5, 50, 0);
			item.buffType = mod.BuffType("QuantumBall");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.SuspiciousLookingTentacle, 1);
			recipe.AddIngredient(ItemID.Cog, 30);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(this);
			recipe.AddRecipe();
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