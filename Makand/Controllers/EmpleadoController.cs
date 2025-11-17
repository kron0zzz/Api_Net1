using Makand.Data;
using Makand.Models;
//using Makand.Models;

using Microsoft.AspNetCore.Mvc;

namespace Makand.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EmpleadosController : ControllerBase
    {
        private readonly MakandContext _context;
        public EmpleadosController(MakandContext context)
        {
            _context = context;
        }




        // GET: api/empleados
        [HttpGet]
        public IActionResult GetEmpleados()
        {
            var empleados = _context.Empleados.ToList();
            return Ok(empleados);
        }




        // GET: api/empleados/5
        [HttpGet("{id}")]
        public IActionResult GetEmpleado(int id)
        {
            var empleado = _context.Empleados.Find(id);
            if (empleado == null) return NotFound();
            return Ok(empleado);
        }




        // POST: api/empleados
        [HttpPost]
        public IActionResult CrearEmpleado(Empleado nuevo)
        {
            _context.Empleados.Add(nuevo);
            _context.SaveChanges();
            return CreatedAtAction(nameof(GetEmpleado), new { id = nuevo.Nro_documento }, nuevo);
        }





        // PUT: api/empleados/5
        [HttpPut("{id}")]
        public IActionResult ActualizarEmpleado(int id, Empleado actualizado)
        {
            var empleado = _context.Empleados.Find(id);
            if (empleado == null) return NotFound();
            empleado.Tipo_documento = actualizado.Tipo_documento;
            empleado.Nombre_completo = actualizado.Nombre_completo;
            empleado.Telefono = actualizado.Telefono;
            empleado.Email = actualizado.Email;
            _context.SaveChanges();
            return Ok(empleado);
        }





        // DELETE: api/empleado/5
        [HttpDelete("{id}")]
        public IActionResult EliminarEmpleado(int id)
        {
            var empleado = _context.Empleados.Find(id);
            if (empleado == null) return NotFound();
            _context.Empleados.Remove(empleado);
            _context.SaveChanges();
            return NoContent();
        }
    }
}