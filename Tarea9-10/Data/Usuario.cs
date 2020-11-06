using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tarea9_10.Data
{
    // modelo para crear una tabla que tiene una relacion de uno a uno con la tabla personas.
    public class Usuario
    {
        public int UsuarioId { get; set; }
        public string Nombre_Usuario { get; set; }
        public string Clave { get; set; }

        public int PersonaId { get; set; }
    }
}
