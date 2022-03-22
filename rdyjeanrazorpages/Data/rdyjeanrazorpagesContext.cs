#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using rdyjeanrazorpages.Pages.Jane;

namespace rdyjeanrazorpages.Data
{
    public class rdyjeanrazorpagesContext : DbContext
    {
        public rdyjeanrazorpagesContext(DbContextOptions<rdyjeanrazorpagesContext> options)
            : base(options)
        {
        }

        public DbSet<rdyjeanrazorpages.Pages.Jane.Music> Class { get; set; }
    }
}
