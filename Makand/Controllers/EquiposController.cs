using Microsoft.AspNetCore.Mvc;
using Makand.Data;
using Makand.Models;

namespace Makand.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EquiposController : ControllerBase
    {
        private readonly MakandContext _context;

        public EquiposController(MakandContext context)
        {
            _context = context;
        }

        // GET: api/equipos
        [HttpGet]
        public IActionResult GetEquipos()
        {
            return Ok(_context.Equipos.ToList());
        }

        // GET: api/equipos/5
        [HttpGet("{id}")]
        public IActionResult GetEquipo(int id)
        {
            var equipo = _context.Equipos.Find(id);
            if (equipo == null) return NotFound();
            return Ok(equipo);
        }

        // POST: api/equipos
        [HttpPost]
        public IActionResult CrearEquipo([FromBody] Equipo nuevo)
        {
            _context.Equipos.Add(nuevo);
            _context.SaveChanges();
            return CreatedAtAction(nameof(GetEquipo), new { id = nuevo.Id }, nuevo);
        }

        // PUT: api/equipos/5
        [HttpPut("{id}")]
        public IActionResult ActualizarEquipo(int id, [FromBody] Equipo actualizado)
        {
            var equipo = _context.Equipos.Find(id);
            if (equipo == null) return NotFound();

            equipo.Nombre_Maquinaria = actualizado.Nombre_Maquinaria;
            equipo.Descripcion = actualizado.Descripcion;
            equipo.Categoria = actualizado.Categoria;
            equipo.Cant_Disponible = actualizado.Cant_Disponible;
            equipo.Estado = actualizado.Estado;
            equipo.Precio_Alquiler = actualizado.Precio_Alquiler;

            _context.SaveChanges();
            return Ok(equipo);
        }

        // DELETE: api/equipos/5
        [HttpDelete("{id}")]
        public IActionResult EliminarEquipo(int id)
        {
            var equipo = _context.Equipos.Find(id);
            if (equipo == null) return NotFound();

            _context.Equipos.Remove(equipo);
            _context.SaveChanges();
            return NoContent();
        }
    }
}