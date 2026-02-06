using Microsoft.AspNetCore.Mvc;
using Recetario.Domain;
using Recetario.Application.Services;
using Recetario.Domain.Enums;

namespace Recetario.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class RecetasController : ControllerBase
    {
        private readonly IRecetaService _recetaService;

        public RecetasController(IRecetaService recetaService)
        {
            _recetaService = recetaService;
        }

        // GET: api/recetas
        [HttpGet]
        public IActionResult ObtenerTodas()
        {
            var recetas = _recetaService.ObtenerTodas();
            return Ok(recetas);
        }

        // GET: api/recetas/5
        [HttpGet("{id}")]
        public IActionResult ObtenerPorId(int id)
        {
            var receta = _recetaService.ObtenerPorId(id);

            if (receta == null)
                return NotFound($"No se encontró la receta con id {id}");

            return Ok(receta);
        }

        // GET /api/recetas/categoria/1
        [HttpGet("categoria/{categoriaId}")]
        public IActionResult ObtenerPorCategoria(int categoriaId)
        {
            var recetas = _recetaService.ObtenerPorCategoriaId(categoriaId);
            return Ok(recetas);
        }

        // GET: api/recetas/dificultad/Facil
        [HttpGet("dificultad/{dificultad}")]
        public IActionResult ObtenerPorDificultad(Dificultad dificultad)
        {
            var recetas = _recetaService.ObtenerPorDificultad(dificultad);
            return Ok(recetas);
        }

        // GET: api/recetas/ingrediente/Harina
        [HttpGet("ingrediente/{ingrediente}")]
        public IActionResult ObtenerPorIngrediente(string ingrediente)
        {
            var recetas = _recetaService.ObtenerPorIngrediente(ingrediente);
            return Ok(recetas);
        }

        // POST: api/recetas
        [HttpPost]
        public IActionResult Crear([FromBody] Receta receta)
        {
            if (receta == null)
                return BadRequest("La receta es inválida");

            _recetaService.Agregar(receta);

            return CreatedAtAction(nameof(ObtenerPorId), new { id = receta.Id }, receta);
        }

        // PUT: api/recetas/5
        [HttpPut("{id}")]
        public IActionResult Actualizar(int id, [FromBody] Receta receta)
        {
            if (id != receta.Id)
                return BadRequest("El id no coincide");

            var existe = _recetaService.ObtenerPorId(id);
            if (existe == null)
                return NotFound($"No se encontró la receta con id {id}");

            _recetaService.Modificar(receta);
            return NoContent();
        }

        // DELETE: api/recetas/5
        [HttpDelete("{id}")]
        public IActionResult Eliminar(int id)
        {
            var receta = _recetaService.ObtenerPorId(id);

            if (receta == null)
                return NotFound($"No se encontró la receta con id {id}");

            _recetaService.Eliminar(id);
            return NoContent();
        }

    }

}
