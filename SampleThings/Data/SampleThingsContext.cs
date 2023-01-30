using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SampleThings.Models;

namespace SampleThings.Data
{
    public class SampleThingsContext : DbContext
    {
        public SampleThingsContext (DbContextOptions<SampleThingsContext> options)
            : base(options)
        {
        }

        public DbSet<SampleThings.Models.CargoType> CargoType { get; set; }
    }
}
