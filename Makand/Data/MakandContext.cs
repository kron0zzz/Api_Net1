using Microsoft.EntityFrameworkCore;
using Makand.Models;

namespace Makand.Data
{
    public class MakandContext: DbContext
    {
        public MakandContext(DbContextOptions<MakandContext> options) : base(options) { }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Empleado> Empleados { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configuración del modelo Empleado
            modelBuilder.Entity<Empleado>()
                // 1. Especifica la clave primaria
                .HasKey(e => e.Nro_documento);

            // 2. IMPORTANTE: Indica que el valor de Nro_documento NO es generado por la DB.
            // Esto significa que el usuario debe proporcionar un valor único en el POST.
            modelBuilder.Entity<Empleado>()
                .Property(e => e.Nro_documento)
                .ValueGeneratedNever();
        }
    }
}
