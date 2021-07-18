using System;
using System.Collections.Generic;

#nullable disable

namespace HypernovaGastos.Models
{
    public partial class Empleado
    {
        public Empleado()
        {
            Gastos = new HashSet<Gasto>();
        }

        public int IdEmpleado { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int IdPuesto { get; set; }
        public bool Activo { get; set; }
        public DateTime FechaRegistro { get; set; }
        public string UsuarioRegistro { get; set; }
        public DateTime? FechaActualizo { get; set; }
        public string UsuarioActualizo { get; set; }
        public DateTime? FechaBaja { get; set; }
        public string UsuarioBaja { get; set; }

        public virtual Puesto IdPuestoNavigation { get; set; }
        public virtual ICollection<Gasto> Gastos { get; set; }
    }
}
