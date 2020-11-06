using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tarea9_10.Data
{
    public class OcupacionServices
    {
        private AppDbContext dbContext;
        public OcupacionServices(AppDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        // lista para guardar todos los datos de la tabla Ocupaciones.
        public List<Ocupacion> _ocupaciones = new List<Ocupacion>();

        // metodo para llenar la lista _ocupaciones.
        //get
        public async Task<List<Ocupacion>> GetOcupacionsAsync()
        {
            return await dbContext.Ocupaciones.ToListAsync();
        }
    }
}
