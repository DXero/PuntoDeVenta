//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PuntoDeVenta.ModelDB
{
    using System;
    using System.Collections.Generic;
    
    public partial class VENCIMIENTOS
    {
        public int idVencimiento { get; set; }
        public Nullable<int> idProductos { get; set; }
        public Nullable<System.DateTime> fecha { get; set; }
    
        public virtual PRODUCTOS PRODUCTO { get; set; }
    }
}
