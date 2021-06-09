using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JustToDoIt.EntityFramework
{
    public class JustToDoItDbContextFactory : IDesignTimeDbContextFactory<JustToDoItDbContext>
    {
        public JustToDoItDbContext CreateDbContext(string[] args)
        {
            var options = new DbContextOptionsBuilder<JustToDoItDbContext>();
            options.UseSqlServer("Data Source=BRENOPC\\SQLEXPRESS;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False;Database=JustToDoItDB");
            return new JustToDoItDbContext(options.Options);
        }
    }
}