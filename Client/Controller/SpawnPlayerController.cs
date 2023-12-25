using System;
using System.Dynamic;
using CitizenFX.Core;

namespace CFive_Framework.Client.Controller
{
    public class SpawnPlayerController : BaseScript
    {
        public SpawnPlayerController()
        {
            EventHandlers.Add("playerSpawned", new Action(OnPlayerSpawned));
        }
        
        private static void OnPlayerSpawned()
        {
            Debug.WriteLine("playerSpawned Triggered!");
        }
    }
}