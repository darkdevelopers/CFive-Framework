using System;
using System.Dynamic;
using CFive_Framework.Client.Controller;
using CitizenFX.Core;
using Mono.CSharp;

namespace CFive_Framework.Client
{
	public class Client : BaseScript
	{
		public Client()
		{
			
			dynamic spawnObject = new ExpandoObject();
			spawnObject.x = -1038.012;
			spawnObject.y = -2737.956;
			spawnObject.z = 20.16927;
			spawnObject.heading = 0.0;
			spawnObject.model = "a_m_m_farmer_01";
			
			Exports["spawnmanager"].setAutoSpawn(false);
			Exports["spawnmanager"].setAutoSpawnCallback(Exports["spawnmanager"].spawnPlayer(spawnObject));
			Exports["spawnmanager"].forceRespawn();
			
			Debug.WriteLine($"{Game.PlayerPed.Model.Hash.GetHashCode()}");
			Debug.WriteLine("Hi from CFive_Framework.Client!");
		}
	}
}