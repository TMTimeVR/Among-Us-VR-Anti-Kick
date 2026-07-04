using System;
using MelonLoader;
using UnityEngine;
using Il2CppFusion;
using Il2CppSG.Airlock.Network;
using Exception = System.Exception;
using Il2CppSG.Airlock;
using Il2CppSG.Airlock.Roles;
using AmongUsHacks.Data;
using AmongUsHacks.Utils;

namespace AmongUsHacks.Features
{
    public static class ForceImposter
    {
        public static void Execute()
        {
            Helpers.RefreshKillManager();
            PlayerRef playerRef = Helpers.GetSelfPlayerRef();
            try
            {
                Globals.killManager.AlterRole(GameRole.Impostor, playerRef);
            }
            catch (Exception e)
            {
                Debug.LogError("Error occurred when changing to imposter: " + e.ToString());
                MelonLogger.Msg($"Successfully forced imposter.");
            }
            try
            {
                Globals.killManager.AlterRole(GameRole.Vigilante, playerRef);
                MelonLogger.Msg($"Successfully forced vigilante.");
            }
            catch (Exception e)
            {
                Debug.LogError("Error occurred when changing to vigilante: " + e.ToString());
            }
        }
    }
}