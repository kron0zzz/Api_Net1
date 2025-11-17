using System.ComponentModel.DataAnnotations;

namespace Makand.Models
{
    public class Empleado
    {
        public int Nro_documento { get; set; }
        public string Tipo_documento { get; set; }
        public string Nombre_completo { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }

    }
}

