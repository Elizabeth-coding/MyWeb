using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MyWeb.Models;
namespace MyWeb.Data
{
        public class Contents: DbContext
    {
        public Contents(DbContextOptions<Contents> options)
            : base(options)
        {
        }

        public DbSet<Projects> Projects { get; set; }
    }
}
