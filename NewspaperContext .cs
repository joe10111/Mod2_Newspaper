using Microsoft.EntityFrameworkCore;
using Newspaper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Newspaper
{
    public class NewspaperContext : DbContext
    {
        public DbSet<Reporter> Reporters { get; set; }
        public DbSet<Article> Articles { get; set; }
        public DbSet<Issue> Issue { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Username=postgres;Password=samjoeben3;Database=Newspaper");
        }
    }
}
