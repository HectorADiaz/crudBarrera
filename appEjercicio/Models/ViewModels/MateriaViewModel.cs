using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace appEjercicio.Models.ViewModels
{
    public class MateriaViewModel
    {

        [Required] 
       
        public string nombre { get; set; }
    }

    public class EditMateriaViewModel
    {
        public int idMateria { get; set; }
        
        [Required]
        public string nombre { get; set; }
    }
}