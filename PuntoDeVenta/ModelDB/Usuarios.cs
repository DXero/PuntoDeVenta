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
    
    public partial class Usuarios
    {
        public string Us_Usuario { get; set; }
        public string Us_Nombre { get; set; }
        public string Us_Apellido { get; set; }
        public string Us_Correo { get; set; }
        public Nullable<int> Us_Telefono { get; set; }
        public Nullable<int> Us_DUI { get; set; }
        public bool Us_Estado { get; set; }
        public object Usuarios { get; internal set; }
    }
}
