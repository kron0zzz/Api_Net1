using Microsoft.AspNetCore.Mvc;
using Makand.Data;
using Makand.Models;

namespace Makand.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ClientesController : ControllerBase
    {
        private readonly MakandContext _context;
        public ClientesController(MakandContext context)
        {
            _context = context;
        }




        // GET: api/clientes
        [HttpGet]
        public IActionResult GetClientes()
        {
            var clientes = _context.Clientes.ToList();
            return Ok(clientes);
        }




        // GET: api/clientes/5
        [HttpGet("{id}")]
        public IActionResult GetCliente(int id)
        {
            var cliente = _context.Clientes.Find(id);
            if (cliente == null) return NotFound();
            return Ok(cliente);
        }




        // POST: api/clientes
        [HttpPost]
        public IActionResult CrearCliente(Cliente nuevo)
        {
            _context.Clientes.Add(nuevo);
            _context.SaveChanges();
            return CreatedAtAction(nameof(GetCliente), new { id = nuevo.Nro_documento }, nuevo);
        }




        // PUT: api/clientes/5
        [HttpPut("{id}")]
        public IActionResult ActualizarCliente(int id, Cliente actualizado)
        {
            var cliente = _context.Clientes.Find(id);
            if (cliente == null) return NotFound();
            cliente.Tipo_documento = actualizado.Tipo_documento;
            cliente.Nombre_completo = actualizado.Nombre_completo;
            cliente.Numero_telefono = actualizado.Numero_telefono;
            cliente.Email = actualizado.Email;
            cliente.Direccion = actualizado.Direccion;
            cliente.Tipo_organizacion = actualizado.Tipo_organizacion;
            _context.SaveChanges();
            return Ok(cliente);
        }





        // DELETE: api/clientes/5
        [HttpDelete("{id}")]
        public IActionResult EliminarProducto(int id)
        {
            var producto = _context.Clientes.Find(id);
            if (producto == null) return NotFound();
            _context.Clientes.Remove(producto);
            _context.SaveChanges();
            return NoContent();
        }
    }
}
