using System.Collections.Generic;
using System.Threading.Tasks;
using CitizenFX.Core;
using static CitizenFX.Core.Native.API;
using static CitizenFX.Core.UI.Screen;

namespace CFive_Framework.Client.Controller
{
	public class VehicleController : BaseScript
	{
		public VehicleController()
		{
			Tick += VehicleControlle;
		}

		#region [CarSpawner]

		public static async void CreateVehicle(int source, List<object> args, string raw)
		{
			if (args.Count < 1)
			{
				ShowNotification($"[CarSpawner] /car 1 parameter required but you gave 0");
				return;
			}

			var vehicleModel = (string)args[0];
			var vehicleHash = (uint)GetHashKey(vehicleModel);
			if (!IsModelInCdimage(vehicleHash) || !IsModelAVehicle(vehicleHash))
			{
				ShowNotification($"[CarSpawner]Vehicle: {vehicleModel} was not found!");
				return;
			}

			var vehicle = await World.CreateVehicle(vehicleModel, Game.PlayerPed.Position, Game.PlayerPed.Heading);
			vehicle.Mods.LicensePlate = "CFive";
			Game.PlayerPed.SetIntoVehicle(vehicle, VehicleSeat.Driver);

			ShowNotification($"[CarSpawner] Vehicle: {vehicleModel} created successfully!", true);
		}

		#endregion

		#region [CarControll]

		private static async Task VehicleControlle()
		{
			var cPlayer = GetPlayerPed(-1);
			var vehicle = GetVehiclePedIsIn(cPlayer, false);
			if (vehicle > 0 && GetPedInVehicleSeat(vehicle, (int)VehicleSeat.Driver) == cPlayer)

				// Open Hood
				if (IsControlJustReleased(0, 208))
				{
					if (GetVehicleDoorAngleRatio(vehicle, 4) > 0.1)
					{
						SetVehicleDoorShut(vehicle, 4, false);
					}
					else
					{
						SetVehicleDoorOpen(vehicle, 4, false, false);
					}
				}

			// Open Trunk
			if (IsControlJustReleased(0, 207))
			{
				if (GetVehicleDoorAngleRatio(vehicle, 5) > 0.1)
				{
					SetVehicleDoorShut(vehicle, 5, false);
				}
				else
				{
					SetVehicleDoorOpen(vehicle, 5, false, false);
				}
			}
		}

		#endregion
	}
}