using HypernovaGastos.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.JsonPatch;
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
    public class DepartamentoController : ControllerBase
    {
        private readonly HYPERNOVALABSContext _context;
        public DepartamentoController(HYPERNOVALABSContext context)
        {
            _context = context;
        }
        // GET: api/<DepartamentoController>
        [HttpGet("ObtenerDepartamentos/")]
        public async Task<ActionResult<IEnumerable<Departamento>>> ObtenerDepartamentos()
        {
            var listDepartamentos = await _context.Departamentos.ToListAsync();
            return Ok(listDepartamentos);
        }

        [HttpGet("ObtenerDepartamentoId/{id}")]
        public async Task<ActionResult<Departamento>> ObtenerDepartamentoId(int id)
        {
            var Departamento = await _context.Departamentos.Where(x => x.IdDepartamento == id).FirstOrDefaultAsync();
            if (Departamento == null)
            {
                var result = new BadRequestObjectResult(new { message = "No se ha encontrada el Departamento", currentDate = DateTime.Now });
                return result;
            }
            return Ok(Departamento);
        }                                                                        

        // POST: api/Departamento
        [HttpPost("CrearDepartamento/")]
        public async Task<ActionResult<Departamento>> CrearDepartamento(Departamento DepartamentoCreate)
        {
            DepartamentoCreate.FechaRegistro = DateTime.Now;
            DepartamentoCreate.Activo = true;
            _context.Departamentos.Add(DepartamentoCreate);
            await _context.SaveChangesAsync();
            return Ok(DepartamentoCreate);
        }

        // PUT: api/Departamento/5
        [HttpPut("ActualizarDepartamento/{id}")]
        public async Task<ActionResult> UpdatedDepartamento(int id, Departamento DepartamentoUpdate)
        {
            var departamento = _context.Departamentos.Where(x => x.IdDepartamento == id).FirstOrDefault();
            if (departamento==null)
            {
                return (new BadRequestObjectResult(new { message = "No se encontro el Departamento", currentDate = DateTime.Now }));
            }
            departamento.Descripcion = DepartamentoUpdate.Descripcion;
            departamento.FechaActualizo = DateTime.Now;
            departamento.UsuarioActualizo = DepartamentoUpdate.UsuarioActualizo;
            await _context.SaveChangesAsync();
            return Ok(DepartamentoUpdate);

        }

        // DELETE: api/Departamento/5
        [HttpDelete("EliminarDepartamento/{id}")]
        public async Task<ActionResult<Departamento>> Delete(int id)
        {
            var IdDepartamento = _context.Departamentos.Select(x => x.IdDepartamento).FirstOrDefault(x => x== id);
            if (IdDepartamento == default(int))
            {
                return (new BadRequestObjectResult(new { message = "No se encontro el Departamento", currentDate = DateTime.Now }));
            }
            _context.Departamentos.Remove(new Departamento { IdDepartamento = IdDepartamento });
            await _context.SaveChangesAsync();
            return NoContent();
        }
    }
}
