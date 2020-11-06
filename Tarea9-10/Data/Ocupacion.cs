using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tarea9_10.Data
{
    // modelo para crear la tabla que tiene una relacion de uno a mucho con la tabla personas.
    public class Ocupacion
    {
        public int OcupacionId { get; set; }
        public string Nombre { get; set; }

        public Persona Persona { get; set; }
        public int PersonaId { get; set; }

    }
}
