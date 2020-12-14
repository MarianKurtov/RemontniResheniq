using dim.Data;
using System;
using System.Threading.Tasks;

namespace dim.SeedData
{
    public class ApplicationDbContextSeeder
    {
        private readonly IServiceProvider serviceProvider;
        private readonly ApplicationDbContext dbContext;

        public ApplicationDbContextSeeder(IServiceProvider serviceProvider,ApplicationDbContext dbContext)
        {
            this.serviceProvider = serviceProvider;
            this.dbContext = dbContext;
        }

    }
}
