using System;
using System.Collections.Generic;
using System.Text;

namespace CFive_Framework.Server.Configuration.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class Database
    {
        public string Host { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string DatabaseName { get; set; }
        public int Port { get; set; }
    }
}
