using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Prueba.Models
{
    public class Estudiante
    {
        [Key]
        public int Id { get; set; }

        public string Nombre { get; set; }
        [Range(0, 100)]
        public int Edad { get; set; }

        public string Ciudad { get; set; }

        public Carrera Carrera { get; set; }
        [ForeignKey("Carrera")]

        public int IdCarrera { get; set; }
    }
}
