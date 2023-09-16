using System;
using System.Collections.Generic;
using System.Text;

namespace CFive_Framework.Server.Configuration.Models
{
    public class CFiveFrameworkConfiguration
    {
        public Database CFiveDatabase { get; set; }
        public Discord CFiveDiscord { get; set; }
    }
}
