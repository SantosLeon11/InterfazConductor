using AppPrueba.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppPrueba.Context
{
    public class ApplicationDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseMySQL("server = localhost;database = Conductor; user = root; password =");
        }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Conductor> Conductores { get; set; }
        //public DbSet<Reservas> Reservas { get; set; }
        //public DbSet<Sistemas> Sistemas { get; set; }
    }
}
