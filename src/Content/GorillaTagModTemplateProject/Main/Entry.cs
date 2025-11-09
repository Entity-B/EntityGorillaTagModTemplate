using System;
using BepInEx;
using Photon.Pun;
using UnityEngine;
using GorillaTagModTemplateProject.Helpful;
using HarmonyLib;

namespace GorillaTagModTemplateProject.Main
{
	[BepInPlugin(BepinexEntry.GUID, BepinexEntry.Name, BepinexEntry.Version)]
	public class Entry : BaseUnityPlugin
	{
		bool inRoom => PhotonNetwork.InRoom;

		void Start()
		{
			CosmeticsV2Spawner_Dirty.OnPostInstantiateAllPrefabs += OnCosmeticsInitialized;
			GorillaTagger.OnPlayerSpawned(OnGameInitialized());
			GTLogger.SetupLogger(Logger);
			Harmony harm = new Harmony(BepinexEntry.GUID);
			harm.PatchAll();
        }

		void OnGameInitialized()
		{

		}

		void OnCosmeticsInitialized()
		{

		}


        void Update()
		{

		}
	}
    class BepinexEntry
    {
        public const string GUID = "com.AuthorLowerName.GorillaTagLowerModTemplateProject";
        public const string Name = "GorillaTagModTemplateProject";
        public const string Version = "1.0.0";
    }
}
