using System;
using System.Collections.Generic;
using CitizenFX.Core;
using static CitizenFX.Core.Native.API;

namespace CFive_Framework.Client.Controller
{
	public class CommandsController : BaseScript
	{
		public CommandsController()
		{
			EventHandlers.Add("onClientResourceStart", new Action<string>(OnClientResourceStart));
		}

		private static void OnClientResourceStart(string resourceName)
		{
			if (GetCurrentResourceName() != resourceName)
				return;

			RegisterCommand("car", new Action<int, List<object>, string>(VehicleController.CreateVehicle), false);
			RegisterCommand("gps", new Action(GpsController.GetCoords), false);
		}

	}
}