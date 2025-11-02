using System.ComponentModel.DataAnnotations;

namespace RegistroComunitario.Models
{
    public class Vecino
    {
        [Required]
        public int Id { get; set; }

        [Required(ErrorMessage = "El nombre es obligatorio")]
        [MinLength(3, ErrorMessage = "El nombre debe tener al menos 3 caracteres")]
        public string Nombre { get; set; }

        [Required]
        public string Apellidos { get; set; }

        [Phone]
        public string Telefono { get; set; }

        [Required]
        [EmailAddress(ErrorMessage = "El correo electrónico no es válido")]
        public string Correo { get; set; }

        [Required]
        public string Genero { get; set; }

        [Range(1, 120, ErrorMessage = "La edad debe estar entre 1 y 120")]
        public int Edad { get; set; }
    }
}
