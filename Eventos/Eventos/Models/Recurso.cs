//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Eventos.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Recurso
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Recurso()
        {
            this.RecursoXPaquetes = new HashSet<RecursoXPaquete>();
            this.ReservacionXRecursoes = new HashSet<ReservacionXRecurso>();
        }
    
        public int idRecurso { get; set; }
        public string nombre { get; set; }
        public string correo { get; set; }
        public string telefono { get; set; }
        public string provincia { get; set; }
        public string tipoRecurso { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RecursoXPaquete> RecursoXPaquetes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ReservacionXRecurso> ReservacionXRecursoes { get; set; }
    }
}
