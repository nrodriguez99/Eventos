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
    
    public partial class ProductoXRecurso
    {
        public int idProductoXRecurso { get; set; }
        public Nullable<int> idProducto { get; set; }
        public Nullable<int> idRecurso { get; set; }
    
        public virtual Producto Producto { get; set; }
        public virtual Recurso Recurso { get; set; }
    }
}
