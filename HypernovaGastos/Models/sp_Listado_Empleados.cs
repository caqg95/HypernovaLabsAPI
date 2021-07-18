using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HypernovaGastos.Models
{
    public class sp_Listado_Empleados
    {
        public int Id_Empleado { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Id_Puesto { get; set; }
        public string Puesto { get; set; }
        public bool Supervisor { get; set; }
        public bool Aprueba { get; set; }
        public int Id_Departamento { get; set; }
        public string Departamento { get; set; }
    
    }
}
