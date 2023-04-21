using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using GG_Ejercicio2tablas.Models;

namespace GG_Ejercicio2tablas.Data
{
    public class GG_Ejercicio2tablasContext : DbContext
    {
        public GG_Ejercicio2tablasContext (DbContextOptions<GG_Ejercicio2tablasContext> options)
            : base(options)
        {
        }

        public DbSet<GG_Ejercicio2tablas.Models.Burger> Burger { get; set; } = default!;

        public DbSet<GG_Ejercicio2tablas.Models.Promo>? Promo { get; set; }
    }
}
