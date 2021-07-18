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
    public class CuentaController : ControllerBase
    {
        private readonly HYPERNOVALABSContext _context;
        public CuentaController(HYPERNOVALABSContext context)
        {
            _context = context;
        }
        [HttpGet("ObtenerCuentas/")]
        public async Task<ActionResult<IEnumerable<Concepto>>> ObtenerCuentas()
        {
            var listCuenta = await _context.Cuenta.ToListAsync();
            return Ok(listCuenta);
        }

        [HttpGet("ObtenerCuentaId/{id}")]
        public async Task<ActionResult<Concepto>> ObtenerCuentaId(int id)
        {
            var Concepto = await _context.Cuenta.Where(x => x.IdCuenta == id).FirstOrDefaultAsync();
            if (Concepto == null)
            {
                var result = new BadRequestObjectResult(new { message = "No se ha encontrada la Cuenta", currentDate = DateTime.Now });
                return result;
            }
            return Ok(Concepto);
        }

        // POST: api/Cuenta
        [HttpPost("CrearCuenta/")]
        public async Task<ActionResult<Cuentum>> CrearCuenta(Cuentum CuentaCreate)
        {
            CuentaCreate.FechaRegistro = DateTime.Now;
            CuentaCreate.Activo = true;
            _context.Cuenta.Add(CuentaCreate);
            await _context.SaveChangesAsync();
            return Ok(CuentaCreate);
        }

        // PUT: api/Departamento/5
        [HttpPut("ActualizarCuenta/{id}")]
        public async Task<ActionResult> UpdatedConcepto(int id, Cuentum CuentaUpdate)
        {
            var cuenta = _context.Cuenta.Where(x => x.IdCuenta == id).FirstOrDefault();
            if (cuenta==null)
            {
                return (new BadRequestObjectResult(new { message = "No se encontro la Cuenta", currentDate = DateTime.Now }));
            }
            cuenta.Descripcion = CuentaUpdate.Descripcion;
            cuenta.FechaActualizo = DateTime.Now;
            cuenta.UsuarioActualizo = CuentaUpdate.UsuarioActualizo;
            await _context.SaveChangesAsync();
            return Ok(CuentaUpdate);

        }

        // DELETE: api/Cuenta/5
        [HttpDelete("EliminarCuenta/{id}")]
        public async Task<ActionResult<Cuentum>> Delete(int id)
        {
            var IdCuenta = _context.Cuenta.Select(x => x.IdCuenta).FirstOrDefault(x => x == id);
            if (IdCuenta == default(int))
            {
                return (new BadRequestObjectResult(new { message = "No se encontro la Cuenta", currentDate = DateTime.Now }));
            }
            _context.Cuenta.Remove(new Cuentum { IdCuenta = IdCuenta });
            await _context.SaveChangesAsync();
            return NoContent();
        }
    }
}
