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
    
    public partial class COMPRAS
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public COMPRAS()
        {
            this.DETALLE_COMPRA = new HashSet<DETALLE_COMPRA>();
        }
    
        public long IdCompra { get; set; }
        public Nullable<int> IdProveedor { get; set; }
        public string IdUsuario { get; set; }
        public Nullable<System.DateTime> Fecha { get; set; }
        public string Comentario { get; set; }
        public Nullable<bool> Anulado { get; set; }
        public string Motivo { get; set; }
    
        public virtual PROVEEDORES PROVEEDORES { get; set; }
        public virtual Usuarios Usuarios { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DETALLE_COMPRA> DETALLE_COMPRA { get; set; }
    }
}
