using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Facultate.Models;
using System.IO;

namespace Facultate.Data
{
    public class UniversityContext : DbContext
    {
        private readonly string _connectionString;

        public UniversityContext()
        {
            var config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .Build();

            _connectionString = config.GetConnectionString("DefaultConnection");
        }

        public DbSet<Professor> Professors { get; set; }
        public DbSet<Student> Students { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlServer(_connectionString);

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // aici pui check constraints și relațiile cu Fluent API
        }
    }
}
