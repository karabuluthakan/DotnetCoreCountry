using DotnetCoreCountry.Models;
using Microsoft.EntityFrameworkCore;

namespace DotnetCoreCountry.Data
{
    public class CountryDbContext : DbContext
    {
        public CountryDbContext(DbContextOptions<CountryDbContext> options) : base(options)
        {
        }

        public DbSet<Continental> Continentals { get; set; }
        public DbSet<Region> Regions { get; set; }
        public DbSet<Country> Countries { get; set; }
    }
}