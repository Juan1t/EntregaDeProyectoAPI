using EntregaDeProyectoAPI.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EntregaDeProyectoAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CursoController : ControllerBase
    {
        private readonly ICursoRepository _repository;
        public CursoController(ICursoRepository repository)
        {
            _repository = repository;
        }

        [HttpGet("ObtenerCursos")]
        public IActionResult GetCurso()
        {
            var curso = _repository.GetCursos();
            return Ok(curso);
        }
    }
}
