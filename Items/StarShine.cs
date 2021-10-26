using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ExtraPets.Items
{
	public class StarShine : ModItem
	{
		public override void SetDefaults()
		{
			item.damage = 0;
			item.useStyle = 1;
			item.name = "Shining Star";
			item.shoot = mod.ProjectileType("StarShine");
			item.width = 16;
			item.height = 30;
			item.useSound = 2;
			item.useAnimation = 20;
			item.useTime = 20;
			item.rare = 8;
			item.noMelee = true;
			item.toolTip = "The cosmos have given you..... this. Credit to Starshine for the idea! :)";
			item.value = Item.sellPrice(0, 5, 50, 0);
			item.buffType = mod.BuffType("StarShine");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.FallenStar, 20);
			recipe.AddIngredient(ItemID.LifeCrystal, 1);
			recipe.AddTile(TileID.DemonAltar);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}