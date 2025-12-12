using System.Reflection.Metadata.Ecma335;
using ApiCapacitacion;
using EntregaDeProyectoAPI.Dtos;
using EntregaDeProyectoAPI.Interfaces;
using EntregaDeProyectoAPI.Models;
using Npgsql;

namespace EntregaDeProyectoAPI.Repositoris
{
    
        public class CursoRepository : ICursoRepository
        {
        private readonly Postgressqlconfiguration _sqlConfiguration;

        public CursoRepository(Postgressqlconfiguration sqlConection)
            => _sqlConfiguration = sqlConection;

        private string GetConnection()
            => _sqlConfiguration.GetConnection();

        public Curso CreateCurso(CreateCursoDtb dtb)
        {
            throw new NotImplementedException();
        }

        public Curso GetCursoById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Curso> GetCursos()
        {
            string query = "SELECT*FROM FUN_GET_CURSOS()";
            List<Curso> cursos = [];
            string connectionString = GetConnection();

            using (var cn = new NpgsqlConnection(connectionString))
            {
                cn.Open();
                var cmd = new NpgsqlCommand(query, cn);

                using (var rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        cursos.Add(
                            new Curso
                            {
                                Idcurso = rd.GetInt32(rd.GetOrdinal("IdCurso")),
                                Nombre = rd.GetString(rd.GetOrdinal("Nombre")),
                                CupoMaximo = rd.GetInt32(rd.GetOrdinal("Cupomaximo")),
                                Incritos = rd.GetInt32(rd.GetOrdinal("Inscritos"))
                            }

                        );
                    }
                }
            }
            return cursos;
        }


        public Curso UpdateCurso(UpdateCursoDto dto)
            {
                throw new NotImplementedException();
            }
        }
    

    public class Postgresqlconfiguration
    {
    }
}
