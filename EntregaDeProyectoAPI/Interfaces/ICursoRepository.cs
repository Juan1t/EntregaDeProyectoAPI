using EntregaDeProyectoAPI.Dtos;
using EntregaDeProyectoAPI.Models;

namespace EntregaDeProyectoAPI.Interfaces
{
    public interface ICursoRepository
    {
        List<Curso> GetCursos();
        Curso GetCursoById(int id);
        Curso CreateCurso(CreateCursoDtb dtb);
        Curso UpdateCurso(UpdateCursoDto dto);
    }
}
