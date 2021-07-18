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
    public class GastoController : ControllerBase
    {
        private readonly HYPERNOVALABSContext _context;
        private readonly SpGastosRepository _repository;
        public GastoController(HYPERNOVALABSContext context, SpGastosRepository repository)
        {
            _context = context;
            _repository = repository;
        }
        [HttpGet("ObtenerGastos/")]
        public async Task<ActionResult<List<sp_Listado_Gastos>>> ObtenerGastos()
        {
            var listGastos = await _repository.GetGastos();
            return Ok(listGastos);
        }

        [HttpGet("ObtenerGastoId/{id}")]
        public async Task<ActionResult<sp_Listado_Gastos>> ObtenerGastoId(int id)
        {
            var listGastos = await _repository.GetGastos();
            var list = listGastos.Where(x => x.Id_Gasto == id).FirstOrDefault();
            if (list== null)
            {
                var result = new BadRequestObjectResult(new { message = "No se ha encontrada el Gasto", currentDate = DateTime.Now });
                return result;
            }
            return Ok(list);
        }
        [HttpGet("ObtenerGastoDetalleId/{id}")]
        public async Task<ActionResult<GastoDetalle>> ObtenerGastoDetalleId(int id)
        {
            var listGastosDetalle = await _context.GastoDetalles.Where(x => x.IdGasto == id).Join(
                   _context.Cuenta,
                   detalle => detalle.IdCuenta,
                   cuenta => cuenta.IdCuenta,
                   (detalle, cuenta) => new {

                       detalle,
                       cuenta
                   }
                   ).ToListAsync();
            if (listGastosDetalle == null)
            {
                var result = new BadRequestObjectResult(new { message = "No se ha encontrada detalle del Gasto", currentDate = DateTime.Now });
                return result;
            }
            return Ok(listGastosDetalle);
        }

        // POST: api/Gasto
        [HttpPost("CrearGasto/")]
        public async Task<ActionResult<Gasto>> CrearGasto(Gasto GastoCreate )
        {
            GastoCreate.FechaRegistro = DateTime.Now;
            decimal montoTotal = 0;

            foreach (var item in GastoCreate.GastoDetalles)
            {

                item.Total = (item.Cantidad * item.Precio);
                item.FechaRegistro = DateTime.Now;
                item.UsuarioRegistro = GastoCreate.UsuarioRegistro;
                item.Activo = true;
                montoTotal += item.Total;
            }
            GastoCreate.Activo = true;
            GastoCreate.CantidadItem = GastoCreate.GastoDetalles.Count();
            GastoCreate.MontoTotal = montoTotal;
            _context.Gastos.Add(GastoCreate);
            await _context.SaveChangesAsync();
            return Ok(GastoCreate);
        }

        // PUT: api/Gasto/5
        [HttpPut("ActualizarEmpleado/{id}")]
        public async Task<ActionResult> UpdatedEmpleado(int id, Empleado EmpleadoUpdate)
        {
            if (id != EmpleadoUpdate.IdEmpleado)
            {
                return (new BadRequestObjectResult(new { message = "No se encontro el Empleado", currentDate = DateTime.Now }));
            }
            _context.Entry(EmpleadoUpdate).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return Ok(EmpleadoUpdate);

        }

        // DELETE: api/Gasto/5
        [HttpDelete("EliminarGasto/{id}")]
        public async Task<ActionResult<Gasto>> Delete(int id)
        {
            var IdGasto = _context.Gastos.Select(x => x.IdGasto).FirstOrDefault(x => x == id);
            if (IdGasto == default(int))
            {
                return (new BadRequestObjectResult(new { message = "No se encontro el Gasto", currentDate = DateTime.Now }));
            }
            var detalle = _context.GastoDetalles.Where(x => x.IdGasto == id);
            _context.GastoDetalles.RemoveRange(detalle);
            _context.SaveChanges();
            _context.Gastos.Remove(new Gasto { IdGasto = IdGasto });
            await _context.SaveChangesAsync();
            return NoContent();
        }

    }
}
