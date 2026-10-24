
using System;
using System.ComponentModel.DataAnnotations;

namespace MiZoologico.Models
{
    public class Visita
    {
        [Required(ErrorMessage = "Escribe tu nombre")]
        public string Nombre { get; set; } = "";

        [Required(ErrorMessage = "Selecciona un animal")]
        public string AnimalFavorito { get; set; } = "";

        [DataType(DataType.Date)]
        public DateTime Fecha { get; set; } = DateTime.Today;
    }
}
