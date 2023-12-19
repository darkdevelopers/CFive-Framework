using System;
using System.Threading.Tasks;
using CitizenFX.Core;
using static CitizenFX.Core.Native.API;
namespace CFive_Framework.Client.Controller
{
    public class NpcController : BaseScript
    {
        public NpcController()
        {
            Tick += NpcControlle;
        }

        private static async Task NpcControlle()
        {
            int player = GetPlayerPed(-1);
            Vector3 playerPosition = GetEntityCoords(player, true);
            
            NpcController.SetDensity(0.0f);
            RemoveVehiclesFromGeneratorsInArea(playerPosition.X - 500.0f, playerPosition.Y - 500.0f, playerPosition.Z - 500.0f, playerPosition.X + 500.0f, playerPosition.Y + 500.0f, playerPosition.Z + 500.0f, 0);
            SetRandomBoats(false);
            SetGarbageTrucks(false);
            SetRandomTrains(false);
        }

        private static void SetDensity(float multiplier = 1.0f)
        {
            NpcController.SetVehicleDensity(multiplier);
            NpcController.SetPedDensity(multiplier);
            NpcController.SetRandomVehicleDensity(multiplier);
            NpcController.SetParkedVehicleDensity(multiplier);
            NpcController.SetScenarioPedDensity(multiplier, multiplier);
        }

        /// <summary>
        /// Set the density for the vehicls
        /// </summary>
        /// <param name="multipliter">float default 1.0</param>
        private static void SetVehicleDensity(float multipliter = 1.0f)
        {
            SetVehicleDensityMultiplierThisFrame(multiplier: multipliter);
        }
        
        /// <summary>
        /// Set the density for the Peds
        /// </summary>
        /// <param name="multipliter">float default 1.0</param>
        private static void SetPedDensity(float multipliter = 1.0f)
        {
            SetPedDensityMultiplierThisFrame(multiplier: multipliter);
        }
        
        /// <summary>
        /// Set the density for the random vehicle
        /// </summary>
        /// <param name="multipliter">float default 1.0</param>
        private static void SetRandomVehicleDensity(float multipliter = 1.0f)
        {
            SetRandomVehicleDensityMultiplierThisFrame(multiplier: multipliter);
        }
        
        /// <summary>
        /// Set the density for the parked vehicle
        /// </summary>
        /// <param name="multipliter">float default 1.0</param>
        private static void SetParkedVehicleDensity(float multipliter = 1.0f)
        {
            SetParkedVehicleDensityMultiplierThisFrame(multiplier: multipliter);
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="p0"></param>
        /// <param name="p1"></param>
        private static void SetScenarioPedDensity(float p0 = 1.0f, float p1 = 1.0f)
        {
            SetScenarioPedDensityMultiplierThisFrame(p0: p0, p1: p1);
        }
    }
}