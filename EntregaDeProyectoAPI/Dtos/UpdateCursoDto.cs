using System.ComponentModel.DataAnnotations;

namespace EntregaDeProyectoAPI.Dtos
{
    public class UpdateCursoDto
    {
        [Required]
        public int IdCurso { get; set; }

        [Required(ErrorMessage = "pon tu mld nombre")]
        [MaxLength(100, ErrorMessage = "El maximo son 100 caracteres")]
        public string Nombre { get; set; }
        [Required]
        public int CupoMaximo { get; set; }
        [Required]
        public int Incritos { get; set; }
    }
}
