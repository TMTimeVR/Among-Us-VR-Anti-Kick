using MelonLoader;

namespace AUVRKickIm.Main
{
    public class ModEntry : MelonMod
    {
        public static ModEntry Instance { get; private set; }

        public override void OnInitializeMelon()
        {
            MelonLogger.Msg("Anti-Kick loaded. Source code: https://github.com/TMTimeVR/Among-Us-VR-Anti-Kick");
            Instance = this;
        }
    }
}