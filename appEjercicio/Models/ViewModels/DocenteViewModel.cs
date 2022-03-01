using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace appEjercicio.Models.ViewModels
{
    public class DocenteViewModel
    {
        [Required]
        
        [Display(Name = "Nombre")]
        [StringLength(100, ErrorMessage = "La {0} debe tener al menos {1} caracteres", MinimumLength = 1)]
        public string nombre { get; set; }
    }
}