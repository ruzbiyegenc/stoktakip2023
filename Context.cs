
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace DataAccessLayer.Concrete
{
    public class Context:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=(localdb)\\MSSQLLocalDB;database=DBStokTakip2023; integrated security=true;MultipleActiveResultSets = True;");
            //optionsBuilder.UseSqlServer("server=; User ID=;Password=;database=;MultipleActiveResultSets = True;");
        }
        public DbSet<UserTable> UserTables { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<StockAssignment> StockAssignments { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            foreach (var relationship in modelBuilder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys()))
            {
                relationship.DeleteBehavior = DeleteBehavior.Restrict;
            }
            modelBuilder.Entity<UserTable>().HasData(
                   new UserTable { UserID = 1, UserName = "admin",Name="Admin",Password = "admin1", Role = "Admin" }
                );
        }
    }
}
