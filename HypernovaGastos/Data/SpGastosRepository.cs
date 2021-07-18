using HypernovaGastos.Models;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HypernovaGastos.Data
{
    public class SpGastosRepository
    {
        private readonly string _connetionString;
        public SpGastosRepository(IConfiguration configuration)
        {
            _connetionString = configuration.GetConnectionString("HypernovaLabsConection");
        }
        public async Task<List<sp_Listado_Gastos>> GetGastos()
        {
            using (SqlConnection sql = new SqlConnection(_connetionString))
            {
                using (SqlCommand cmd = new SqlCommand("sp_Listado_Gastos", sql))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    var response = new List<sp_Listado_Gastos>();
                    await sql.OpenAsync();

                    using (var reader = await cmd.ExecuteReaderAsync())
                    {
                        while (await reader.ReadAsync())
                        {
                            response.Add(MapToValue(reader));
                        }
                    }

                    return response;
                }
            }

        }
        public sp_Listado_Gastos MapToValue(SqlDataReader reader)
        {
            return new sp_Listado_Gastos()
            {
                Id_Gasto = (int)reader["Id_Gasto"],
                Id_Empleado_Gasto = (int)reader["Id_Empleado_Gasto"],
                Nombre_Empleado_Gasto = reader["Nombre_Empleado_Gasto"].ToString(),
                Cantidad_Item = (int)reader["Cantidad_Item"],
                Monto_Total = (decimal)reader["Monto_Total"],
                Fecha_Desde =(DateTime) reader["Fecha_Desde"],
                Fecha_Hasta = (DateTime)reader["Fecha_Hasta"],
                Id_Concepto = (int)reader["Id_Concepto"],
                Concepto = reader["Concepto"].ToString(),
                Id_Empleado_Aprueba = (int)reader["Id_Empleado_Aprueba"],
                Nombre_Empleado_Aprueba = reader["Nombre_Empleado_Aprueba"].ToString(),
                Id_Empleado_Superviso = Convert.IsDBNull(reader["Id_Empleado_Superviso"]) ? null : (int?)reader["Id_Empleado_Superviso"],
                Nombre_Empleado_Superviso = reader["Nombre_Empleado_Superviso"].ToString(),
               

            };
        }
    }
}
