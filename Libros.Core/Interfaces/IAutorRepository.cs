using Libros.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Libros.Core.Interfaces
{
    public interface IAutorRepository
    {
        Task<IEnumerable<Autor>> GetAutor();
    }
}
