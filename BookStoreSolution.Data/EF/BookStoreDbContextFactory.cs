using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace BookStoreSolution.Data.EF
{
    public class BookStoreDbContextFactory : IDesignTimeDbContextFactory<BookStoreDbContext>
    {
        public BookStoreDbContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
               .SetBasePath(Directory.GetCurrentDirectory())
               .AddJsonFile("appsetting.json")
               .Build();

            var connectionString = configuration.GetConnectionString("BookStoreSolutionDb");

            var optionsBuilder = new DbContextOptionsBuilder<BookStoreDbContext>();
            optionsBuilder.UseSqlServer(connectionString);

            return new BookStoreDbContext(optionsBuilder.Options);
        }
    }
}
