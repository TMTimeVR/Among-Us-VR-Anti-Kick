using HarmonyLib;
using MelonLoader;
using Il2CppSG.Airlock.Network;

namespace AUVRKickIm.src.Utils
{
    public static class KickImmunity
    {
        public static bool Enabled = false;
        public static bool AntiRename = false;
        public static bool AntiCosmetic = false;
        public static bool AntiForceRole = false;
        public static bool AntiKill = false;
        public static bool AntiSpectate = false;
        public static bool AntiColorChange = false;
        public static bool AntiMute = false;

        public static int LocalPlayerId = -1;

        /*Please ignore these bools. I took a privatee version of this mod that protects me from exploiters force changing my color, name, cosmetics, roles, etc and cut it down.*/

        private static void Log(string s)
        {
            MelonLogger.Msg("[Protection] " + s);
        }

        [HarmonyPatch(typeof(AirlockPeer), nameof(AirlockPeer.PlayerIsKicked))]
        public static class PlayerIsKicked_Patch
        {
            public static bool Prefix()
            {
                Log("ignored AirlockPeer.PlayerIsKicked()");
                return false;
            }
        }

        [HarmonyPatch(typeof(ModerationManager), nameof(ModerationManager.KickSelf))]
        public static class KickSelf_Patch
        {
            public static bool Prefix()
            {
                Log("ignored ModerationManager.KickSelf()");
                return false;
            }
        }
    }
}
