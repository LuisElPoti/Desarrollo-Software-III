//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DemoSeis
{
    using System;
    using System.Collections.Generic;
    
    public partial class Table
    {
        public int Id { get; set; }
        public int TipoDocumento { get; set; }
        public string Documento { get; set; }
        public decimal Monto { get; set; }
        public string DbCr { get; set; }
        public int TipoTransaccion { get; set; }
        public Nullable<System.DateTime> FechaTransaccion { get; set; }
        public string Descripcion { get; set; }
    }
}