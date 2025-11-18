namespace Makand.Models
{
    public class Equipo
    {
        public int Id { get; set; }
        public string Nombre_Maquinaria { get; set; } = string.Empty;
        public string? Descripcion { get; set; }
        public string? Categoria { get; set; }
        public int Cant_Disponible { get; set; }
        public string? Estado { get; set; }
        public decimal Precio_Alquiler { get; set; }
    }
}
