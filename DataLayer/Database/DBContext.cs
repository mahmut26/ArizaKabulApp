using Domain.DatabaseClass;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Database
{
    public class DBContext : DbContext
    {
        public DbSet<CihazKayit> cihazs { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer
            ("Server=DESKTOP-S5AKNFC;Database=arizacihaz;User Id=sa;Password=2626;TrustServerCertificate=true");
        }

    }
}
