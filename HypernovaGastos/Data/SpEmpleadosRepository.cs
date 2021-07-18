using HypernovaGastos.Models;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HypernovaGastos.Data
{
    public class SpEmpleadosRepository
    {
        private readonly string _connetionString;
        public SpEmpleadosRepository(IConfiguration configuration)
        {
            _connetionString = configuration.GetConnectionString("HypernovaLabsConection");
        }
        public async Task<List<sp_Listado_Empleados>> GetEmpleados()
        {
            using (SqlConnection sql = new SqlConnection(_connetionString))
            {
                using (SqlCommand cmd = new SqlCommand("sp_Listado_Empleados", sql))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    var response = new List<sp_Listado_Empleados>();
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
        public sp_Listado_Empleados MapToValue(SqlDataReader reader)
        {
            return new sp_Listado_Empleados()
            {
                Id_Empleado = (int)reader["Id_Empleado"],
                Nombre = reader["Nombre"].ToString(),
                Apellido = reader["Apellido"].ToString(),
                Id_Puesto = (int)reader["Id_Puesto"],
                Puesto =reader["Puesto"].ToString(),
                Supervisor = (bool)reader["Supervisor"],
                Aprueba = (bool)reader["Aprueba"],
                Id_Departamento = (int)reader["Id_Departamento"],
                Departamento = reader["Departamento"].ToString(),

            };
        }
    }
}
