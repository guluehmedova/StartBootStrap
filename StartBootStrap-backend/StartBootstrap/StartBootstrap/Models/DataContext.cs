using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StartBootstrap.Models
{
    public class DataContext:DbContext
    {
        public DataContext(DbContextOptions<DataContext>options):base(options)
        {

        }
        public DbSet<Setting> Settings { get; set; }
        public DbSet<Portfolio> Portfolios { get; set; }
        public DbSet<SosialMedia> SosialMedias { get; set; }
    }
}
