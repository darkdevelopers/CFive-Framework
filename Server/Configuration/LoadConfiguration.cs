using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using CFive_Framework.Server.Configuration.Models;
using CitizenFX.Core;
using Microsoft.Extensions.Configuration;
using System.Reflection;

namespace CFive_Framework.Server.Configuration
{
    public class LoadConfiguration
    {
        private static LoadConfiguration _instance { get; set; }
        public CFiveFrameworkConfiguration CFiveFrameworkConfiguration { get; set; }
        private string _resourceName = "CFive_Framework.Server.appsettings.json";
        private LoadConfiguration()
        {
            Stream resourceStream = Assembly.GetExecutingAssembly().GetManifestResourceStream(this._resourceName);
            if(resourceStream == null)
            {
                throw new Exception("Can't load appsettings.json file...");
            }

            var config = new ConfigurationBuilder().AddJsonStream(resourceStream).Build();
            var section = config.GetSection(nameof(CFiveFrameworkConfiguration));
            this.CFiveFrameworkConfiguration = section.Get<CFiveFrameworkConfiguration>();
        }

        public static LoadConfiguration getInstance() { 
            if(LoadConfiguration._instance == null)
            {
                LoadConfiguration._instance = new LoadConfiguration();
            }

            return LoadConfiguration._instance;
        }
    }
}
