using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace appEjercicio.Models.TableViewModels
{
    public class AlumnoTableViewModel
    {
        public int idAlumno { get; set; }
        public string nombre { get; set; }
        public int idRol { get; set; }
        public int idGrado { get; set; }
    }
}