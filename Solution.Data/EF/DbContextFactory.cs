using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Solution.Data.EF
{
    class DbContextFactory : IDesignTimeDbContextFactory<clsDbContext>
    {
        public clsDbContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsetting.json")
                .Build();
            var connectionstring = configuration.GetConnectionString("ShopDb");

            var optionsBuilder = new DbContextOptionsBuilder<clsDbContext>();
            optionsBuilder.UseSqlServer(connectionstring)
                .UseLazyLoadingProxies();

            return new clsDbContext(optionsBuilder.Options);
        }
    }
}
