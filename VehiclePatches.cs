using HarmonyLib;
using Il2CppFishNet.Connection;
using Il2CppScheduleOne.Vehicles;
using MelonLoader;

namespace Schedule1_Test_Mod
{
    [HarmonyPatch(typeof(LandVehicle), "SetSeatOccupant")]
    public class VehiclePatches
    {
        public static void Postfix(LandVehicle __instance, NetworkConnection conn, int seatIndex, NetworkConnection occupant)
        {
            if (seatIndex == 0)
            {
                VehicleModifier.Instance!.CurrentVehicle = __instance;
               // MelonLogger.Msg("PostFix fired on: " + __instance.name);
                if (VehicleModifier.Instance == null) return;
               // VehicleModifier.Instance.SetTopSpeed(__instance, 500f);
            }
        }
    }
}
