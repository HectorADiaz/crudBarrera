//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace appEjercicio.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class asignacion_materia
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public asignacion_materia()
        {
            this.nota_f = new HashSet<nota_f>();
        }
    
        public int idAsignacion { get; set; }
        public int idDocente { get; set; }
        public int idMateria { get; set; }
        public int idGrado { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<nota_f> nota_f { get; set; }
        public virtual docente docente { get; set; }
        public virtual grado grado { get; set; }
        public virtual materia materia { get; set; }
    }
}
