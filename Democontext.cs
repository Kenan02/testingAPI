using Microsoft.EntityFrameworkCore;

namespace testing
{
    public class Democontext : DbContext
    {
        public DbSet<testarUser> Users { get; set; }
       

        protected override void OnConfiguring(DbContextOptionsBuilder options) => options.UseSqlite(@"Data Source=C:\temps\demo.db");
        



    }
}
