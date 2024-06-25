using System;
using System.ComponentModel.DataAnnotations;

namespace Proyecto_Fullstack.Shared
{
    public class TareaUsuario
    {
        public int ID { get; set; }

        [Required(ErrorMessage = "El título es obligatorio")]
        public string Titulo { get; set; } = string.Empty;

        [Required(ErrorMessage = "La descripción es obligatoria")]
        public string Descripcion { get; set; } = string.Empty;

        public DateTime FechaCreacion { get; set; } = DateTime.Now;

        [Required(ErrorMessage = "La fecha de vencimiento es obligatoria")]
        public DateTime FechaVencimiento { get; set; } = DateTime.Now;

        public bool Completada { get; set; }
    }
}
