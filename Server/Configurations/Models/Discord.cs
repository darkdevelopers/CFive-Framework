using System;
using System.Collections.Generic;
using System.Text;

namespace CFive_Framework.Server.Configurations.Models
{
    public class Discord
    {
        public long DiscordServerId { get; set; }
        public long DiscordRoleId { get; set; }
        public long BotChannelId { get; set; }
        public string BotToken { get; set; }
        public bool LogEnable { get; set; }
        public string LogLevel { get; set; }
    }
}
