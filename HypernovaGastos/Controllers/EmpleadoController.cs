using HypernovaGastos.Data;
using HypernovaGastos.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HypernovaGastos.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class EmpleadoController : ControllerBase
    {
        private readonly HYPERNOVALABSContext _context;
        private readonly SpEmpleadosRepository _repository;
        public EmpleadoController(HYPERNOVALABSContext context, SpEmpleadosRepository repository)
        {
            _context = context;
            _repository = repository;
        }
        [HttpGet("ObtenerEmpleados/")]
        public async Task<ActionResult<IEnumerable<sp_Listado_Empleados>>> ObtenerEmpleados()
        {
            var listEmpleados = await _repository.GetEmpleados();
            return Ok(listEmpleados);
        }

        [HttpGet("ObtenerEmpleadosSupervisor/")]
        public async Task<ActionResult<IEnumerable<sp_Listado_Empleados>>> ObtenerEmpleadosSupervisor()
        {
            var listEmpleados = await _repository.GetEmpleados();
            return Ok(listEmpleados.Where(x => x.Supervisor == true));
        }
        [HttpGet("ObtenerEmpleadosAprueba/")]
        public async Task<ActionResult<IEnumerable<sp_Listado_Empleados>>> ObtenerEmpleadosAprueba()
        {
            var listEmpleados = await _repository.GetEmpleados();
            return Ok(listEmpleados.Where(x => x.Aprueba == true));
        }

        [HttpGet("ObtenerEmpleadoId/{id}")]
        public async Task<ActionResult<sp_Listado_Empleados>> ObtenerEmpleadoId(int id)
        {
            var listEmpleados = await _repository.GetEmpleados();
            var list = listEmpleados.Where(x => x.Id_Empleado == id).FirstOrDefault();
            if (list == null)
            {
                return (new BadRequestObjectResult(new { message = "No se encontro el Empleado", currentDate = DateTime.Now }));
            }
            return Ok(list);
        }

        // POST: api/Empleado
        [HttpPost("CrearEmpleado/")]
        public async Task<ActionResult<Empleado>> CrearEmpleado(Empleado EmpleadoCreate)
        {
            EmpleadoCreate.FechaRegistro = DateTime.Now;
            EmpleadoCreate.Activo = true;
            _context.Empleados.Add(EmpleadoCreate);
            await _context.SaveChangesAsync();
            return Ok(EmpleadoCreate);
        }

        // PUT: api/Empleado/5
        [HttpPut("ActualizarEmpleado/{id}")]
        public async Task<ActionResult> UpdatedEmpleado(int id, Empleado EmpleadoUpdate)
        {
            var Empleado = _context.Empleados.Where(x => x.IdEmpleado == id).FirstOrDefault();
            if (Empleado == null)
            {
                return (new BadRequestObjectResult(new { message = "No se encontro el Empleado", currentDate = DateTime.Now }));
            }
            Empleado.Nombre = EmpleadoUpdate.Nombre;
            Empleado.Apellido = EmpleadoUpdate.Apellido;
            Empleado.IdPuesto = EmpleadoUpdate.IdPuesto;
            Empleado.FechaActualizo = DateTime.Now;
            Empleado.UsuarioActualizo = EmpleadoUpdate.UsuarioActualizo;
            await _context.SaveChangesAsync();
            return Ok(EmpleadoUpdate);

        }

        // DELETE: api/Empleado/5
        [HttpDelete("EliminarEmpleado/{id}")]
        public async Task<ActionResult<Empleado>> Delete(int id)
        {
            var IdEmpleado = _context.Empleados.Select(x => x.IdEmpleado).FirstOrDefault(x => x == id);
            if (IdEmpleado == default(int))
            {
                return (new BadRequestObjectResult(new { message = "No se encontro el Empleado", currentDate = DateTime.Now }));
            }
            _context.Empleados.Remove(new Empleado { IdEmpleado = IdEmpleado });
            await _context.SaveChangesAsync();
            return NoContent();
        }
    }
}
