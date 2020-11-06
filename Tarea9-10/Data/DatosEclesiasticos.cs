using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tarea9_10.Data
{
    // modelo para crear una tabla que tiene una relacion de uno a uno con la tabla personas
    public class DatosEclesiasticos
    {
        public int DatosEclesiasticosId { get; set; }
        public DateTime Fecha_Conversion { get; set; }
        public DateTime Fecha_Bautismo { get; set; }
        public DateTime Fecha_Aceptado { get; set; }
        public string Denominacion { get; set; }
        public string Iglesia_Actual { get; set; }
        public string Iglesia_Antes { get; set; }
        public string Nombre_Pastor { get; set; }
        public string Ha_Disiciplinado { get; set; }
        public int Cantidad_Disciplinado { get; set; }
        public string Causas_Disciplinado { get; set; }
        public string Ministerios_Servido { get; set; }
        public string Ministerio_Fruto { get; set; }
        public string Razon_Fruto { get; set; }
        public string Ministerio_Llamando { get; set; }
        public string Meta { get; set; }
        public string Estas_Consciente { get; set; }

        public int PersonaId { get; set; }

    }
}
