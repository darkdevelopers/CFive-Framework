using System;
using System.Collections.Generic;
using CitizenFX.Core;
using static CitizenFX.Core.Native.API;

namespace CFive_Framework.Client.Handlers
{
    public class CommandsHandler : BaseScript
    {
        public CommandsHandler()
        {
            EventHandlers.Add("onClientResourceStart", new Action<string>(OnClientResourceStart));
        }

        private static void OnClientResourceStart(string resourceName)
        {
            if (GetCurrentResourceName() != resourceName)
                return;
            
            RegisterCommand("spawnVehicle",new Action<int, List<object>, string>(CarHandler.CreateVehicle), false);
        }
        
    }
    
}