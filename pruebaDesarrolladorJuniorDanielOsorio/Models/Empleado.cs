using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace pruebaDesarrolladorJuniorDanielOsorio.Models
{
    public class Empleado
    {
        [Key]
        public int Id { get; set; }

        public string tipoDocumento { get; set; }

        [Required(ErrorMessage = "El campo documento es obligatorio")]
        public string documento { get; set; }

        [Required(ErrorMessage = "El campo nombre es obligatorio")]
        public string nombres { get; set; }

        [Required(ErrorMessage = "El campo apellidos es obligatorio")]
        public string apellidos { get; set; }

        [Required(ErrorMessage = "El campo area es obligatorio")]
        public string area { get; set; }

        [Required(ErrorMessage = "El campo Sub Area es obligatorio")]
        public string subArea { get; set; }
    }
}
