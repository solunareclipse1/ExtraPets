using System;
using System.Collections.Generic;
using System.IO;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace ExtraPets
{
	public class ExamplePlayer : ModPlayer
	{
		private const int saveVersion = 0;
		public bool examplePet = false;
		public bool ZoneExample = false;
		public bool quantumBall = false;
		public bool starShine = false;

		public override void ResetEffects()
		{
			examplePet = false;
			quantumBall = false;
			starShine = false;
		}

		public override void SaveCustomData(BinaryWriter writer)
		{
			writer.Write(saveVersion);
		}

		public override void LoadCustomData(BinaryReader reader)
		{
			int loadVersion = reader.ReadInt32();
		}
	}
}
