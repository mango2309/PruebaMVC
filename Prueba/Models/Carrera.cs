using System.ComponentModel.DataAnnotations;

namespace Prueba.Models
{
    public class Carrera
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(100)]
        public string Nombre { get; set; }


    }
}
