using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Curso_2.Dominio.Models
{
    public class Estudiante
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Column(TypeName="varchar(80)")]
        public string Nombres { get; set; }

        [Required]

        public DateTime FechaInscripcion { get; set; }



    }
}
