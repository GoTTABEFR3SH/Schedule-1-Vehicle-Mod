using MelonLoader;
using UnityEngine;


namespace Schedule1_Test_Mod
{
    public class DebugGUI
    {
        private bool _showGUI = false;
        private float _pollTimer = 0f;
        private const float _pollInterval = 0.25f;

        private float _topSpeed = 0f;
        private float _diffGearing = 0f;
        private float _handBrakeForce = 0f;
        private float _brakeForceMultiplier = 0f;
        private float _downForce = 0f;


        public void OnUpdate()
        {
            if (Input.GetKeyDown(KeyCode.F4))
            {
                _showGUI = !_showGUI;
            }

            if (!_showGUI) return;
            if (VehicleModifier.Instance?.CurrentVehicle == null) {

                OnGUIEmpty();
                return;
            }

            _pollTimer += Time.deltaTime;

            if (_pollTimer >= _pollInterval)
            {
                _pollTimer = 0f;

                _topSpeed = VehicleModifier.Instance.CurrentVehicle.TopSpeed;
                _diffGearing = VehicleModifier.Instance.CurrentVehicle.diffGearing;
                _handBrakeForce = VehicleModifier.Instance.CurrentVehicle.handBrakeForce;
                _brakeForceMultiplier = VehicleModifier.Instance.CurrentVehicle.BrakeForceMultiplier;
                _downForce = VehicleModifier.Instance.CurrentVehicle.downforce;

            }


        }

        public void OnGUI()
        {
            if (!_showGUI) return;
            if (VehicleModifier.Instance?.CurrentVehicle == null)
            {
                OnGUIEmpty();
            }
            else
            {
                GUI.Box(new Rect(20, 20, 250, 200), "Vehicle Inspector");
                GUI.Label(new Rect(30, 40, 230, 20), "Top Speed: " + _topSpeed);
                GUI.Label(new Rect(30, 60, 230, 20), "Diff Gearing: " + _diffGearing);
                GUI.Label(new Rect(30, 80, 230, 20), "Hand Brake Force: " + _handBrakeForce);
                GUI.Label(new Rect(30, 100, 230, 20), "Brake Force Multiplier: " + _brakeForceMultiplier);
                GUI.Label(new Rect(30, 120, 230, 20), "Down Force: " + _downForce);
            }
        }

        private void OnGUIEmpty()
        {
           
            GUI.Box(new Rect(20, 20, 250, 80), "Vehicle Inspector");
            GUI.Label(new Rect(30, 40, 230, 20), "Player not in Vehicle");
            
        }


    }
}
