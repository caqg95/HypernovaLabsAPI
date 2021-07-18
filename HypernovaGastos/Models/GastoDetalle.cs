using System;
using System.Collections.Generic;

#nullable disable

namespace HypernovaGastos.Models
{
    public partial class GastoDetalle
    {
        public int IdGastoDetalle { get; set; }
        public int IdGasto { get; set; }
        public int IdCuenta { get; set; }
        public DateTime FechaCompra { get; set; }
        public string Descripcion { get; set; }
        public int Cantidad { get; set; }
        public decimal Precio { get; set; }
        public decimal Total { get; set; }
        public bool Activo { get; set; }
        public DateTime FechaRegistro { get; set; }
        public string UsuarioRegistro { get; set; }
        public DateTime? FechaActualizo { get; set; }
        public string UsuarioActualizo { get; set; }
        public DateTime? FechaBaja { get; set; }
        public string UsuarioBaja { get; set; }

        public virtual Cuentum IdCuentaNavigation { get; set; }
        public virtual Gasto IdGastoNavigation { get; set; }
    }
}
