using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using backend_.Net.Context;
using backend_.Net.Models;

namespace backend_.Net.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ObjetoController : ControllerBase
    {
        private readonly AppDbContext _context;

        public ObjetoController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/Objeto
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Objeto>>> GetObjetos()
        {
            return await _context.objeto.ToListAsync();
        }

        // GET: api/Objeto/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Objeto>> GetObjeto(long id)
        {
            var objeto = await _context.objeto.FindAsync(id);

            if (objeto == null)
            {
                return NotFound(new { message = "Objeto no encontrado" });
            }

            return objeto;
        }

        // PUT: api/Objeto/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutObjeto(long id, Objeto objeto)
        {
            if (id != objeto.id)
            {
                return BadRequest(new { message = "ID del objeto no coincide" });
            }

            _context.Entry(objeto).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ObjetoExists(id))
                {
                    return NotFound(new { message = "Objeto no encontrado" });
                }
                else
                {
                    throw;
                }
            }

            return Ok(new { message = "Objeto actualizado con éxito" });
        }

        // POST: api/Objeto
        [HttpPost]
        public async Task<ActionResult<Objeto>> PostObjeto(Objeto objeto)
        {
            _context.objeto.Add(objeto);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetObjeto", new { id = objeto.id }, new { message = "Objeto creado con éxito", objeto });
        }

        // DELETE: api/Objeto/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteObjeto(long id)
        {
            var objeto = await _context.objeto.FindAsync(id);
            if (objeto == null)
            {
                return NotFound(new { message = "Objeto no encontrado" });
            }

            _context.objeto.Remove(objeto);
            await _context.SaveChangesAsync();

            return Ok(new { message = "Objeto eliminado con éxito" });
        }

        // GET: api/Objeto/buscar
        [HttpGet("buscar")]
        public async Task<ActionResult<IEnumerable<Objeto>>> BuscarObjetos(
            [FromQuery] string? nombre,
            [FromQuery] string? descripcion,
            [FromQuery] double? precio,
            [FromQuery] DateTime? fechaCreacion)
        {
            var query = _context.objeto.AsQueryable();

            if (!string.IsNullOrEmpty(nombre))
            {
                query = query.Where(o => o.nombre.Contains(nombre));
            }

            if (!string.IsNullOrEmpty(descripcion))
            {
                query = query.Where(o => o.descripcion.Contains(descripcion));
            }

            if (precio.HasValue)
            {
                query = query.Where(o => o.precio == precio.Value);
            }

            if (fechaCreacion.HasValue)
            {
                query = query.Where(o => o.fecha_creacion.Date == fechaCreacion.Value.Date);
            }

            var resultados = await query.ToListAsync();
            if (resultados.Count == 0)
            {
                return NotFound(new { message = "No se encontraron objetos que coincidan con los criterios de búsqueda" });
            }

            return Ok(resultados);
        }

        private bool ObjetoExists(long id)
        {
            return _context.objeto.Any(e => e.id == id);
        }
    }
}
