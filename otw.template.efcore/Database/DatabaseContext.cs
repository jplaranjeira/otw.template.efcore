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
            optionsBuilder.UseMySQL(_configuration.GetConnectionString("DefaultConnection"));
        }

        public DbSet<Person> Person { get; set; }

        public DbSet<Country> Country { get; set; }
    }
}

