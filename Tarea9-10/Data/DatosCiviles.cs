using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tarea9_10.Data
{
    // modelo para crear una tabla que tiene una relacion de uno a uno con la tabla personas.
    public class DatosCiviles
    {
        public int DatosCivilesId { get; set; }
        public string Estado_Civil { get; set; }
        public string Nombre_Pareja { get; set; }
        public string Tienes_Hijos { get; set; }
        public int Cantidad_Hijos { get; set; }
        public string Nivel_Estudio { get; set; }
        public string Suspension_institucion { get; set; }
        public string Razon_Suspension { get; set; }
        public string Profesion { get; set; }
        public string Nombre_Empresa { get; set; }
        public string Ocupacion_Actual { get; set; }
        public string Telefono_Trabajo { get; set; }

        public int PersonaId { get; set; }
    }
}
