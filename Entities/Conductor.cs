using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppPrueba.Entities
{
    public class Conductor:Empleado
    {
        public string NumeroLicencia { get; set; }
        public string FechaRegistro { get; set; }
        public string Disponibilidad { get; set; }
        public int? Calificaciones { get; set; }
    }
}
