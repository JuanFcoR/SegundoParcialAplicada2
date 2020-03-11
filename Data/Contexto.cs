using Microsoft.EntityFrameworkCore;
using SegundoParcialAplicada2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SegundoParcialAplicada2.Data
{
    public class Contexto : DbContext
    {
        public DbSet<Llamadas> Llamadas { get; set; }
        public DbSet<LlamadaDetalle> LlamadaDetalle { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"Data Source=Database/Data.db");
        }
    }
}
