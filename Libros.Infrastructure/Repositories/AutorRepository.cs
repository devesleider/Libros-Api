using Libros.Core.Entities;
using Libros.Core.Interfaces;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System;
using System.Threading.Tasks;

namespace Libros.Infrastructure.Repositories
{
    public class AutorRepository: IAutorRepository
    {
        public async Task<IEnumerable<Autor>> GetAutor()
        {
            var autores = Enumerable.Range(1,10).Select(x=> new Autor
            { 
                Id = x,
                Nombre_Completo = $"Nombre "+ x,
                Fecha_Nacimiento = DateTime.Now,
                Ciudad_Procedencia = $"Ciudad " + x,
                Correo_Electronico = $"Correo " + x,
            });
            return autores;
        }

    }
}
