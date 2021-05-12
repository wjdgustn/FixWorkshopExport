using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Configuration;
using ADOFAI;
using HarmonyLib;
using UnityEngine;
using UnityModManagerNet;

namespace FixWorkshopExport.MainPatch {
    [HarmonyPatch(typeof(LevelEvent), "GetString")]

    internal static class FixDecoration {
        private static bool Prefix(ref string __result, LevelEvent __instance, string key) {
            __result = (string) __instance.data[key == "decorationImage" ? "decText" : key];
            return false;
        }
    }
}