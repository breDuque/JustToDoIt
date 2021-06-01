using JustToDoIt.MVVM.Model;
using Microsoft.EntityFrameworkCore;

namespace JustToDoIt.EntityFramework
{
    public class JustToDoItDbContext : DbContext
    {

        public DbSet<User> Users { get; set; }
        public DbSet<Tasks> Tasks { get; set; }

        public JustToDoItDbContext(DbContextOptions options) : base(options) { }
    }
}
