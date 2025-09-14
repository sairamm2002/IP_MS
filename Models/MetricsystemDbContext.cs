using Microsoft.EntityFrameworkCore;
using MetricSystem.Models;

namespace MetricSystem.Data
{
    public class MetricSystemDbContext : DbContext
    {
        public MetricSystemDbContext(DbContextOptions<MetricSystemDbContext> options) : base(options) { }

        public DbSet<TempConversion> TempConversion => Set<TempConversion>();
    }
}
