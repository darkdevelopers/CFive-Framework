using CitizenFX.Core;

namespace CFive_Framework.Client
{
	public class Client : BaseScript
	{
		
		public Client()
		{
			Debug.WriteLine($"{Game.PlayerPed.Model.Hash.GetHashCode()}");
			Exports["spawnmanager"].setAutoSpawn(false);
			var spawn = "{\"x\": \"466.8401\", \"y\": \"197.7201\", \"z\": \"111.5291\", \"heading\": \"291.71\", \"model\": \"a_m_m_farmer_01\"}";
			Exports["spawnmanager"].addSpawnPoint(spawn);
			Debug.WriteLine("Hi from CFive_Framework.Client!");
		}
	}
}