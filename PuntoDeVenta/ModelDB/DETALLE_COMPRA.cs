//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PuntoDeVenta.ModelDB
{
    using System;
    using System.Collections.Generic;
    
    public partial class DETALLE_COMPRA
    {
        public long IdDetalle { get; set; }
        public Nullable<long> IdCompras { get; set; }
        public Nullable<int> IdProducto { get; set; }
        public Nullable<float> Costo { get; set; }
        public Nullable<float> Cantidad { get; set; }
        public Nullable<float> SubTotal { get; set; }
        public Nullable<float> Descuento { get; set; }
    
        public virtual COMPRAS COMPRAS { get; set; }
        public virtual PRODUCTOS PRODUCTOS { get; set; }
    }
}
