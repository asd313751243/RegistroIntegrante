using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tarea9_10.Data
{
    public class DatosCivilesServices
    {
        private AppDbContext dbContext;
        public DatosCivilesServices(AppDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        // lista para guardar todos los datos de la tabla DatosCiviles.
        public List<DatosCiviles> _datosCiviles = new List<DatosCiviles>();


        // metodo para llenar la lista _datosCiviles.
        public async Task<List<DatosCiviles>> GetDatosCivilesAsync()
        {
            return await dbContext.DatosCivileses.ToListAsync();
        }

    }
}
