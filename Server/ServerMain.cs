using System;
using System.Threading.Tasks;
using CFive_Framework.Server.Configuration;
using CFive_Framework.Server.Database;
using CitizenFX.Core;

namespace CFive_Framework.Server
{
    public class ServerMain : BaseScript
    {
        private LoadConfiguration _config = null;
        private CFiveFrameworkDatabaseContext _databaseContext = null;
        public ServerMain()
        {
            Debug.WriteLine("Hi from CFive_Framework.Server!");
            this._config = LoadConfiguration.getInstance();
            this._databaseContext = CFiveFrameworkDatabaseContext.getInstance(); 
        }

        [Command("hello_server")]
        public void HelloServer()
        {
            Debug.WriteLine("Sure, hello.");
        }
    }
}