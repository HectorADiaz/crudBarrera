using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace appEjercicio.Models.ViewModels
{
    public class AlumnoViewModel
    {

        [Required]
        public string nombre { get; set; }

        [Required]
        public int idGrado { get; set; }
    }

    public class EditAlumnoViewModel
    {
        
        public int idAlumno { get; set; }

        [Required]
        public string nombre { get; set; }

        [Required]
        public int idGrado { get; set; }
    }


    public class DeleteAlumnoViewModel
    {

        public int idAlumno { get; set; }

    }
}