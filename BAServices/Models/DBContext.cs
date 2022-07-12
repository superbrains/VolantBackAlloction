using BAServices.Models;
using Microsoft.EntityFrameworkCore;

namespace VolantBackAlloction.Models
{
    public class DBContext : DbContext
    {
        public DBContext()
        {

        }

        public DBContext(DbContextOptions<DBContext> options) : base(options)
        {

        }
        public DbSet<Tenants> Tenants { get; set; }
        public DbSet<Well> Well { get; set; }
        public DbSet<Facilities> Facilities { get; set; }
        public DbSet<Field> Field { get; set; }
        public DbSet<Operators> Operators { get; set; }
        public DbSet<Pipelines> Pipelines { get; set; }
        public DbSet<POS> POS { get; set; }
        public DbSet<Meters> Meters { get; set; }

        public DbSet<Links> Links { get; set; }
        public DbSet<Nodes> Nodes { get; set; }
        public DbSet<LACTUnitConfiguration> LACTUnitConfiguration { get; set; }
    }
}
