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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class crudEntities : DbContext
    {
        public crudEntities()
            : base("name=crudEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<admon> admon { get; set; }
        public virtual DbSet<alumno> alumno { get; set; }
        public virtual DbSet<asignacion_materia> asignacion_materia { get; set; }
        public virtual DbSet<bimestre> bimestre { get; set; }
        public virtual DbSet<docente> docente { get; set; }
        public virtual DbSet<grado> grado { get; set; }
        public virtual DbSet<materia> materia { get; set; }
        public virtual DbSet<nota_f> nota_f { get; set; }
        public virtual DbSet<rol> rol { get; set; }
    }
}
