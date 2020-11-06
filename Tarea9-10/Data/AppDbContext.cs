using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tarea9_10.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext (DbContextOptions<AppDbContext> options): base(options) { }

        public DbSet<Persona> Personas { get; set; }
        public DbSet<DatosCiviles> DatosCivileses { get; set; }
        public DbSet<DatosEclesiasticos> DatosEclesiasticoses { get; set; }
        public DbSet<Ocupacion> Ocupaciones { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }

    }
}
