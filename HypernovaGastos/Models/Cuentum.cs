using System;
using System.Collections.Generic;

#nullable disable

namespace HypernovaGastos.Models
{
    public partial class Cuentum
    {
        public Cuentum()
        {
            GastoDetalles = new HashSet<GastoDetalle>();
        }

        public int IdCuenta { get; set; }
        public string Descripcion { get; set; }
        public bool Activo { get; set; }
        public DateTime FechaRegistro { get; set; }
        public string UsuarioRegistro { get; set; }
        public DateTime? FechaActualizo { get; set; }
        public string UsuarioActualizo { get; set; }
        public DateTime? FechaBaja { get; set; }
        public string UsuarioBaja { get; set; }

        public virtual ICollection<GastoDetalle> GastoDetalles { get; set; }
    }
}
