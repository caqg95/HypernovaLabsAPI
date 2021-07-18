using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HypernovaGastos.Models
{
    public class sp_Listado_Gastos
    {
        public int Id_Gasto { get; set; }
        public int Id_Empleado_Gasto { get; set; }
        public string Nombre_Empleado_Gasto { get; set; }
        public int Cantidad_Item { get; set; }
        public decimal Monto_Total { get; set; }
        public DateTime Fecha_Desde { get; set; }
        public DateTime Fecha_Hasta { get; set; }
        public int Id_Concepto { get; set; }
        public string Concepto { get; set; }
        public int Id_Empleado_Aprueba { get; set; }
        public string Nombre_Empleado_Aprueba { get; set; }
        public Nullable<int> Id_Empleado_Superviso { get; set; }
        public string Nombre_Empleado_Superviso { get; set; }
       
    }
}
