using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AccountApi.Models
{
    public class AccountsDbContext : DbContext
    {
        private IConfigurationRoot configuration;

        public AccountsDbContext(IConfigurationRoot configuration, DbContextOptions options)
            : base(options)
        {
            this.configuration = configuration;
        }

        public DbSet<User> Users { get; set; }
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(configuration["ConnectionString:AccountsDbConnectionString"]);
            base.OnConfiguring(optionsBuilder);
        }
    }
}
