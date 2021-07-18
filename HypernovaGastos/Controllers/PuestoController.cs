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
    public class PuestoController : ControllerBase
    {
        private readonly HYPERNOVALABSContext _context;
        public PuestoController(HYPERNOVALABSContext context)
        {
            _context = context;
        }

        [HttpGet("ObtenerPuestos/")]
        public async Task<ActionResult<IEnumerable<Concepto>>> ObtenerPuestos()
        {
            var listPuestos = await _context.Puestos.ToListAsync();
            return Ok(listPuestos);
        }

        [HttpGet("ObtenerPuestoId/{id}")]
        public async Task<ActionResult<Concepto>> ObtenerPuestoId(int id)
        {
            var Puesto = await _context.Puestos.Where(x => x.IdPuesto == id).FirstOrDefaultAsync();
            if (Puesto == null)
            {
                var result = new BadRequestObjectResult(new { message = "No se ha encontrada el Puesto", currentDate = DateTime.Now });
                return result;
            }
            return Ok(Puesto);
        }

        // POST: api/Puesto
        [HttpPost("CrearPuesto/")]
        public async Task<ActionResult<Puesto>> CrearPuesto(Puesto PuestoCreate)
        {
            PuestoCreate.FechaRegistro = DateTime.Now;
            PuestoCreate.Activo = true;
            _context.Puestos.Add(PuestoCreate);
            await _context.SaveChangesAsync();
            return Ok(PuestoCreate);
        }

        // PUT: api/Puesto/5
        [HttpPut("ActualizarPuesto/{id}")]
        public async Task<ActionResult> UpdatedPuesto(int id, Puesto PuestoUpdate)
        {

            var puesto = _context.Puestos.Where(x => x.IdPuesto == id).FirstOrDefault();
            if (puesto==null)
            {
                return (new BadRequestObjectResult(new { message = "No se encontro el Puesto", currentDate = DateTime.Now }));
            }
            puesto.Descripcion = PuestoUpdate.Descripcion;
            puesto.IdDepartamento = PuestoUpdate.IdDepartamento;
            puesto.Aprueba = PuestoUpdate.Aprueba;
            puesto.Supervisor = PuestoUpdate.Supervisor;
            puesto.CantidadPuesto = PuestoUpdate.CantidadPuesto;
            puesto.FechaActualizo = DateTime.Now;
            puesto.UsuarioActualizo = PuestoUpdate.UsuarioActualizo;
            await _context.SaveChangesAsync();
            return Ok(PuestoUpdate);

        }

        // DELETE: api/Puesto/5
        [HttpDelete("EliminarPuesto/{id}")]
        public async Task<ActionResult<Puesto>> Delete(int id)
        {
            var IdPuesto = _context.Puestos.Select(x => x.IdPuesto).FirstOrDefault(x => x == id);
            if (IdPuesto == default(int))
            {
                return (new BadRequestObjectResult(new { message = "No se encontro el Puesto", currentDate = DateTime.Now }));
            }
            _context.Puestos.Remove(new Puesto { IdPuesto = IdPuesto });
            await _context.SaveChangesAsync();
            return NoContent();
        }
    }
}
