using System;
using System.IO;
using BepInEx;
using BepInEx.Bootstrap;
using BepInEx.Configuration;
using BepInEx.Logging;
using HarmonyLib;
using UnityEngine;

namespace AdvanceFeatures
{
    [BepInPlugin("com.example.yourmod", "yourmod", "1.0.0")]
    public class Plugin : BaseUnityPlugin
    {

        public static ConfigEntry<bool> EnableDebug;
        internal static ManualLogSource Log;
        private Harmony _harmony;
        private AssetBundle _assetBundle;

        private void Awake()
        {
            Log = Logger;
            Log.LogInfo("Initializing Advance Features plugin");

            EnableDebug = Config.Bind(
                "General",
                "EnableDebug",
                true,
                "Toggle the debug stuff"
            );

            _harmony = new Harmony("com.example.advancefeatures");
            _harmony.PatchAll();
            Log.LogInfo("Harmony patches applied");

            string bundlePath = Path.Combine(Path.GetDirectoryName(Info.Location)!, "assetbundle");
        }
    }
}