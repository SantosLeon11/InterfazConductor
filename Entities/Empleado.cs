using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace AppPrueba.Entities
{
    public class Empleado
    {
        [Key]
        public int Matricula { get; set; }
        public string Nombre { get; set; }
        public string Puesto { get; set; }
        public string Correo {get; set; }
        public string sexo { get; set; }
    }
}
