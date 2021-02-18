using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MyWeb.Models;


namespace MyWeb.Data
{
    public class Info : DbContext
    {
        public Info(DbContextOptions<Info> options)
            : base(options)
        {
        }

        public DbSet<Geekration> Geekration { get; set; }
        

    }
}
