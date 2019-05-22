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
    
    public partial class Paquete
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Paquete()
        {
            this.PaqueteXClientes = new HashSet<PaqueteXCliente>();
            this.RecursoXPaquetes = new HashSet<RecursoXPaquete>();
            this.PaqueteXProductoes = new HashSet<PaqueteXProducto>();
        }
    
        public int idPaquete { get; set; }
        public string nombre { get; set; }
        public Nullable<decimal> precio { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PaqueteXCliente> PaqueteXClientes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RecursoXPaquete> RecursoXPaquetes { get; set; }
        public virtual ReservacionXClienteXPaquete ReservacionXClienteXPaquete { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PaqueteXProducto> PaqueteXProductoes { get; set; }
    }
}
