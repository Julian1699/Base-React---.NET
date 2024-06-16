using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using backend_.Net.Application.Interfaces;
using backend_.Net.Domain.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace backend_.Net.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ObjetoController : ControllerBase
    {
        private readonly IObjetoService _objetoService;

        public ObjetoController(IObjetoService objetoService)
        {
            _objetoService = objetoService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Objeto>>> GetObjetos()
        {
            var objetos = await _objetoService.GetAll();
            return Ok(objetos);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Objeto>> GetObjeto(long id)
        {
            var objeto = await _objetoService.GetById(id);
            if (objeto == null)
            {
                return NotFound(new { message = "Objeto no encontrado" });
            }
            return Ok(objeto);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutObjeto(long id, Objeto objeto)
        {
            if (id != objeto.id)
            {
                return BadRequest(new { message = "ID del objeto no coincide" });
            }

            try
            {
                await _objetoService.Update(objeto);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (await _objetoService.GetById(id) == null)
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

        [HttpPost]
        public async Task<ActionResult<Objeto>> PostObjeto(Objeto objeto)
        {
            await _objetoService.Add(objeto);
            return CreatedAtAction("GetObjeto", new { id = objeto.id }, new { message = "Objeto creado con éxito", objeto });
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteObjeto(long id)
        {
            var objeto = await _objetoService.GetById(id);
            if (objeto == null)
            {
                return NotFound(new { message = "Objeto no encontrado" });
            }

            await _objetoService.Delete(id);
            return Ok(new { message = "Objeto eliminado con éxito" });
        }

        [HttpGet("buscar")]
        public async Task<ActionResult<IEnumerable<Objeto>>> BuscarObjetos(
            [FromQuery] string? nombre,
            [FromQuery] string? descripcion,
            [FromQuery] double? precio,
            [FromQuery] DateTime? fechaCreacion)
        {
            var resultados = await _objetoService.Search(nombre, descripcion, precio, fechaCreacion);
            if (resultados == null || !resultados.Any())
            {
                return NotFound(new { message = "No se encontraron objetos que coincidan con los criterios de búsqueda" });
            }

            return Ok(resultados);
        }
    }
}
