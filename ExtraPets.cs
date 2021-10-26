using System;
using Terraria;
using Terraria.Graphics.Effects;
using Terraria.Graphics.Shaders;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace ExampleMod
{
	public class ExampleMod : Mod
	{
		public ExampleMod()
		{
			Properties = new ModProperties()
			{
				Autoload = true,
				AutoloadGores = true,
				AutoloadSounds = true,
				AutoloadBackgrounds = true
			};
		}

		public override void Load()
		{
			
		}

		public override void Unload()
		{
			
		}

		public override void AddRecipeGroups()
		{
			
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(this);
		}
	}
}

