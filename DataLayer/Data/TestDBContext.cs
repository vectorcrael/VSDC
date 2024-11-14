using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace DataLayer.Data
{
	public class TestDBContext : DbContext
	{
        public IConfiguration _config { get; set; }

        public TestDBContext(IConfiguration config)
        {
            _config = config;
        }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_config
                .GetConnectionString("DatabaseConneciton")); // should this not be DefaultConnection?
        }
    }
}

