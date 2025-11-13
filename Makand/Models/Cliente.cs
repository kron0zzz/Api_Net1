using System.ComponentModel.DataAnnotations;

namespace Makand.Models
{
    public class Cliente
    {
        [Key]
        public int Nro_documento { get; set; }
        public int Tipo_documento { get; set; }
        public string Nombre_completo { get; set; }
        public int Numero_telefono { get; set; }
        public string Email {  get; set; }
        public string Direccion {  get; set; }
        public int Tipo_organizacion { get; set; }

    }
}
