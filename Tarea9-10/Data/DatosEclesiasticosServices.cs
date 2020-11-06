using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tarea9_10.Data
{
    public class DatosEclesiasticosServices
    {
        private AppDbContext dbContext;
        public DatosEclesiasticosServices(AppDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        // lista para guardar todos los datos de la tabla DatosEclesiasticos.
        public List<DatosEclesiasticos> _datosEclesiasticos = new List<DatosEclesiasticos>();


        // metodo para llenar la lista _datosEclesiasticos.
        //get
        public async Task<List<DatosEclesiasticos>> GetDatosEclesiasticosAsync()
        {
            return await dbContext.DatosEclesiasticoses.ToListAsync();
        }
    }
}
