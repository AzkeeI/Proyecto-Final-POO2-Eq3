using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProyectoFinalPOO2.Entities;

namespace ProyectoFinalPOO2
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }
         public DbSet<LoginEncargado> LoginEncargados { get; set;}
         public DbSet<RegEmpleado> RegEmpleados { get; set;}
          public DbSet<Jefe> Jefes { get; set;}
    }
}