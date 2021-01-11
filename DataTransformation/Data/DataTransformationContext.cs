using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using DataTransformation.Models;

namespace DataTransformation.Data
{
    public class DataTransformationContext : DbContext
    {
        public DataTransformationContext (DbContextOptions<DataTransformationContext> options)
            : base(options)
        {
        }

        public DbSet<DataTransformation.Models.VendorMapping> VendorMapping { get; set; }
    }
}
