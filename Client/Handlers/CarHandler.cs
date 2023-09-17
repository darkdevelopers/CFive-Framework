using System;
using System.Collections.Generic;
using CitizenFX.Core;
using static CitizenFX.Core.Native.API;

namespace CFive_Framework.Client.Handlers
{
	public class CarHandler : BaseScript
	{
		#region [CarSpawner]
		public static async void CreateVehicle(int source, List<object> args, string raw)
		{
			if (args.Count < 1)
			{
				TriggerEvent("chat:addMessage", new
				{
					color = new[] { 255, 0, 0 },
					args = new[] { "[CarSpawner]", "No arguments provided!"}
				});
				return;
			}
            
			var vehicleModel = (string)args[0];
			var vehicleHash = (uint)GetHashKey(vehicleModel);
			if (!IsModelInCdimage(vehicleHash) || !IsModelAVehicle(vehicleHash))
			{
				TriggerEvent("chat:addMessage", new
				{
					color = new[] { 255, 0, 0 },
					args = new[] { "[CarSpawner]", $"Vehicle: {vehicleModel} was not found!" }
				});
				return;
			}

			var vehicle = await World.CreateVehicle(vehicleModel, Game.PlayerPed.Position, Game.PlayerPed.Heading);
			vehicle.Mods.LicensePlate = " CFive";
			Game.PlayerPed.SetIntoVehicle(vehicle, VehicleSeat.Driver);

			TriggerEvent("chat:addMessage", new
			{
				color = new[] { 0, 255, 0 },
				args = new[] { "[CarSpawner]", $"Vehicle: {vehicleModel} created successfully!" }
			});
            
		}
		#endregion
		
	}
	
}