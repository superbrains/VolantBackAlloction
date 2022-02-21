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
    }
}
