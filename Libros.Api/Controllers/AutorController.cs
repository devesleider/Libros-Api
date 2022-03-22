using Libros.Core.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Libros.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AutorController : ControllerBase
    {
        private readonly IAutorRepository _autorRepository;
        public AutorController(IAutorRepository autorRepository)
        {
            _autorRepository = autorRepository;
        }

        [HttpGet]
        public IActionResult GetAutores()
        {
            _autorRepository.GetAutor();
            return Ok(null);
        }
    }
}
