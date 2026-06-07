using MelonLoader;
using Il2CppScheduleOne.Vehicles;
using UnityEngine.Playables;

namespace Schedule1_Test_Mod
{
    public class VehicleModifier
    {
        public LandVehicle? CurrentVehicle { get; set; }
        public static VehicleModifier? Instance { get; private set; }

        public VehicleModifier() 
            {
                Instance = this;
            }
        public void SetTopSpeed(LandVehicle vehicle, float TopSpeed)
        {
            if (vehicle != null)
            {
                vehicle.TopSpeed = TopSpeed;
                   
            }

        }
    }
}
