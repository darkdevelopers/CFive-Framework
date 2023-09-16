using CFive_Framework.Server.Configuration;
using CFive_Framework.Server.Database.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace CFive_Framework.Server.Database
{
    public class CFiveFrameworkDatabaseContext : DbContext
    {
        private static CFiveFrameworkDatabaseContext _cFiveFrameworkDatabaseContext = null;
        private string DbPath { get; set; }
        public DbSet<Users> Users { get; set; }
        private CFiveFrameworkDatabaseContext()
        {
            LoadConfiguration _config = LoadConfiguration.getInstance();
            DbPath = $"server = {_config.CFiveFrameworkConfiguration.CFiveDatabase.Host}; " +
                $"port = {_config.CFiveFrameworkConfiguration.CFiveDatabase.Port}; " +
                $"user = {_config.CFiveFrameworkConfiguration.CFiveDatabase.Username}; " +
                $"password = {_config.CFiveFrameworkConfiguration.CFiveDatabase.Password}; " +
                $"database = {_config.CFiveFrameworkConfiguration.CFiveDatabase.DatabaseName};";
        }

        public static CFiveFrameworkDatabaseContext getInstance()
        {
            if(CFiveFrameworkDatabaseContext._cFiveFrameworkDatabaseContext == null)
            {
                CFiveFrameworkDatabaseContext._cFiveFrameworkDatabaseContext = new CFiveFrameworkDatabaseContext();
            }

            return CFiveFrameworkDatabaseContext._cFiveFrameworkDatabaseContext;
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) => optionsBuilder.UseSqlServer($"Data Source={DbPath}");
    }
}
