using CFive_Framework.Server.Configurations;
using CFive_Framework.Server.Database.Models;
using Microsoft.EntityFrameworkCore;
using Pomelo.EntityFrameworkCore.MySql.Storage;
using System;

namespace CFive_Framework.Server
{
	public class CFiveFrameworkDatabaseContext : DbContext
	{
		private string DbPath { get; set; }
		public DbSet<User> Users { get; set; }

		public CFiveFrameworkDatabaseContext()
		{
		}

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			this.DbPath =
				$"Server = {LoadConfiguration.getInstance().CFiveFrameworkConfiguration.CFiveDatabase.Host}; " +
				$"Port = {LoadConfiguration.getInstance().CFiveFrameworkConfiguration.CFiveDatabase.Port}; " +
				$"User ID = {LoadConfiguration.getInstance().CFiveFrameworkConfiguration.CFiveDatabase.Username}; " +
				$"Password = {LoadConfiguration.getInstance().CFiveFrameworkConfiguration.CFiveDatabase.Password}; " +
				$"Database = {LoadConfiguration.getInstance().CFiveFrameworkConfiguration.CFiveDatabase.DatabaseName}";

			optionsBuilder.UseMySql(this.DbPath);
		}
	}
}