using System;
using System.Collections.Generic;
using System.Text;
using HarmonyLib;

namespace GorillaTagModTemplateProject.Patches
{
	[HarmonyPatch(typeof(GorillaLocomotion.GTPlayer), "Awake")]
	internal class ExamplePatch
	{
		private static void Postfix(GorillaLocomotion.GTPlayer __instance)
		{
			Console.WriteLine("Player Has Spawned");
		}
	}
}
