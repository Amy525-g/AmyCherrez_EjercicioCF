using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using AmyCherrez_EjercicioCF.Models;

namespace AmyCherrez_EjercicioCF.Data
{
    public class AmyCherrez_EjercicioCFContext : DbContext
    {
        public AmyCherrez_EjercicioCFContext (DbContextOptions<AmyCherrez_EjercicioCFContext> options)
            : base(options)
        {
        }

        public DbSet<AmyCherrez_EjercicioCF.Models.Burgeer> Burger { get; set; } = default!;

        public DbSet<AmyCherrez_EjercicioCF.Models.Promo>? Promo { get; set; }
    }
}
