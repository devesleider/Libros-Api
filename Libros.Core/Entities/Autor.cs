using System;

namespace Libros.Core.Entities
{
    public class Autor
    {
        public int? Id { get; set; }
        public string Nombre_Completo { get; set; }
        public DateTime Fecha_Nacimiento { get; set; }
        public string Ciudad_Procedencia { get; set; }
        public string Correo_Electronico { get; set; }
    }
}
