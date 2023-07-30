using System;
using Microsoft.EntityFrameworkCore;
using otw.template.efcore.Models;

namespace otw.template.efcore.Database
{
	public class DatabaseContext : DbContext
	{
        private readonly IConfiguration _configuration;

        public DatabaseContext(DbContextOptions<DatabaseContext> options, IConfiguration configuration) : base(options)
        {
            _configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL("Server=162.144.176.146;Database=beatyou4_beatyou4_otw_clubs_mgt_members_dev;uid=beatyou4_clubsmgt_dev;password=bu[7jCi-JgCK");
        }

        public DbSet<Person> Person { get; set; }

        public DbSet<Country> Country { get; set; }
    }
}

