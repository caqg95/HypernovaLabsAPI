using System;
using System.Collections.Generic;

#nullable disable

namespace HypernovaGastos.Models
{
    public partial class Gasto
    {
        public Gasto()
        {
            GastoDetalles = new HashSet<GastoDetalle>();
        }

        public int IdGasto { get; set; }
        public int IdEmpleado { get; set; }
        public int CantidadItem { get; set; }
        public decimal MontoTotal { get; set; }
        public DateTime FechaDesde { get; set; }
        public DateTime FechaHasta { get; set; }
        public int IdConcepto { get; set; }
        public int IdEmpleadoAprueba { get; set; }
        public int? IdEmpleadoSuperviso { get; set; }
        public bool Activo { get; set; }
        public DateTime FechaRegistro { get; set; }
        public string UsuarioRegistro { get; set; }
        public DateTime? FechaActualizo { get; set; }
        public string UsuarioActualizo { get; set; }
        public DateTime? FechaBaja { get; set; }
        public string UsuarioBaja { get; set; }

        public virtual Concepto IdConceptoNavigation { get; set; }
        public virtual Empleado IdEmpleadoNavigation { get; set; }
        public virtual ICollection<GastoDetalle> GastoDetalles { get; set; }
    }
}
