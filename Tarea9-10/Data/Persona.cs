using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tarea9_10.Data
{
    
    // modelo para crear la talba principal de la base de datos, cual tiene llave foranea en todas las otras tablas.
    public class Persona
    {
        public int PersonaId { get; set; }
        public string Sexo { get; set; }
        public string Apellidos { get; set; }
        public string Nombres { get; set; }
        public DateTime Fecha_Nacimiento { get; set; }
        public string Pais_Nacimiento { get; set; }
        public string Ciudad_Nacimiento { get; set; }
        public string Pais_Actual { get; set; }
        public string Ciudad_Actual { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string Celular { get; set; }
        public string Correo_Electronico { get; set; }
        public string Documento_Identidad { get; set; }
        public string Numero_Identidad { get; set; }
        public byte[] Foto { get; set; }

        public DatosCiviles DatosCiviles { get; set; }
        public DatosEclesiasticos DatosEclesiasticos { get; set; }
        public Usuario Usuarios { get; set; }

        public List<Ocupacion> _Ocupaciones { get; set; } = new List<Ocupacion>();
    }
}