using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JetBrains.Annotations;
using Microsoft.Extensions.Configuration;

namespace AccountApi.Models
{
    public class TitlePageContext : DbContext
    {
        private IConfigurationRoot configuration;
        public TitlePageContext(IConfigurationRoot configuration, DbContextOptions<TitlePageContext> options) 
        :base(options)
        {
            this.configuration = configuration;
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //opt =>opt.UseInMemoryDatabase("TitlePage")
            optionsBuilder.UseInMemoryDatabase("TitlePage");
            base.OnConfiguring(optionsBuilder);
        }
        public DbSet<TitlePage> titlePage { get; set; }
    }
}
