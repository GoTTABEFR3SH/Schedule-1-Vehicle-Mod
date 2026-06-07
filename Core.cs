using MelonLoader;
using UnityEngine;
using HarmonyLib;

[assembly: MelonInfo(typeof(Schedule1_Test_Mod.Core), "Schedule1_Test_Mod", "1.0.0", "GBF")]
[assembly: MelonGame("TVGS", "Schedule I")]

namespace Schedule1_Test_Mod

{
    
    public class Core : MelonMod
    {
        private DebugGUI _debugGUI = new DebugGUI();
        public override void OnInitializeMelon()
        {
            LoggerInstance.Msg("Holy shit we fucking did it boys");
            new VehicleModifier();
            new DebugGUI();
            HarmonyInstance.PatchAll(System.Reflection.Assembly.GetExecutingAssembly());
            MelonLogger.Msg("Harmony patches applied");


        }

        public override void OnUpdate()
        {
            _debugGUI.OnUpdate();
        }

        public override void OnGUI()
        {
            _debugGUI.OnGUI();
        }
    }
}
