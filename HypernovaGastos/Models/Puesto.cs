using System;
using System.Collections.Generic;

#nullable disable

namespace HypernovaGastos.Models
{
    public partial class Puesto
    {
        public Puesto()
        {
            Empleados = new HashSet<Empleado>();
        }

        public int IdPuesto { get; set; }
        public string Descripcion { get; set; }
        public int CantidadPuesto { get; set; }
        public bool Supervisor { get; set; }
        public bool Aprueba { get; set; }
        public int IdDepartamento { get; set; }
        public int? IdSupervisor { get; set; }
        public bool Activo { get; set; }
        public DateTime FechaRegistro { get; set; }
        public string UsuarioRegistro { get; set; }
        public DateTime? FechaActualizo { get; set; }
        public string UsuarioActualizo { get; set; }
        public DateTime? FechaBaja { get; set; }
        public string UsuarioBaja { get; set; }

        public virtual Departamento IdDepartamentoNavigation { get; set; }
        public virtual ICollection<Empleado> Empleados { get; set; }
    }
}
