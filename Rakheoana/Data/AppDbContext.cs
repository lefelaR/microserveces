using Microsoft.EntityFrameworkCore;
using Rakheoana.Models;

namespace Rakheoana.Data
{

    public class AppDbContext :  DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> opt) :base(opt)
        {
        
        }

            public DbSet<Platform> Platforms { get; set; }

        internal int SavingChanges()
        {
            throw new NotImplementedException();
        }
    }
}