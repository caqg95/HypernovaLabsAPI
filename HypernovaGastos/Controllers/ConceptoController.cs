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
    public class ConceptoController : ControllerBase
    {
        private readonly HYPERNOVALABSContext _context;
        public ConceptoController(HYPERNOVALABSContext context)
        {
            _context = context;
        }
        [HttpGet("ObtenerConceptos/")]
        public async Task<ActionResult<IEnumerable<Concepto>>> ObtenerConceptos()
        {
            var listConceptos = await _context.Conceptos.ToListAsync();
            return Ok(listConceptos);
        }

        [HttpGet("ObtenerConceptoId/{id}")]
        public async Task<ActionResult<Concepto>> ObtenerConceptoId(int id)
        {
            var Concepto = await _context.Conceptos.Where(x => x.IdConcepto == id).FirstOrDefaultAsync();
            if (Concepto == null)
            {
                var result = new BadRequestObjectResult(new { message = "No se ha encontrada el Concepto", currentDate = DateTime.Now });
                return result;
            }
            return Ok(Concepto);
        }

        // POST: api/Concepto
        [HttpPost("CrearConcepto/")]
        public async Task<ActionResult<Departamento>> CrearConcepto(Concepto ConceptoCreate)
        {
            ConceptoCreate.FechaRegistro = DateTime.Now;
            ConceptoCreate.Activo = true;
            _context.Conceptos.Add(ConceptoCreate);
            await _context.SaveChangesAsync();
            return Ok(ConceptoCreate);
        }

        // PUT: api/Concepto/5
        [HttpPut("ActualizarConcepto/{id}")]
        public async Task<ActionResult> UpdatedConcepto(int id, Concepto ConceptoUpdate)
        {
            var concepto = _context.Conceptos.Where(x => x.IdConcepto == id).FirstOrDefault();
            if (concepto == null)
            {
                return (new BadRequestObjectResult(new { message = "No se encontro el Concepto", currentDate = DateTime.Now }));
            }
            concepto.Descripcion = ConceptoUpdate.Descripcion;
            concepto.FechaActualizo = DateTime.Now;
            concepto.UsuarioActualizo = ConceptoUpdate.UsuarioActualizo;
            
            await _context.SaveChangesAsync();
            return Ok(ConceptoUpdate);

        }

        // DELETE: api/Concepto/5
        [HttpDelete("EliminarConcepto/{id}")]
        public async Task<ActionResult<Concepto>> Delete(int id)
        {
            var IdConcepto = _context.Conceptos.Select(x => x.IdConcepto).FirstOrDefault(x => x == id);
            if (IdConcepto == default(int))
            {
                return (new BadRequestObjectResult(new { message = "No se encontro el Concepto", currentDate = DateTime.Now }));
            }
            _context.Conceptos.Remove(new Concepto { IdConcepto = IdConcepto });
            await _context.SaveChangesAsync();
            return NoContent();
        }
    }

}
