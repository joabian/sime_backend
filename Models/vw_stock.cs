//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace sime.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class vw_stock
    {
        public int id { get; set; }
        public int equipoID { get; set; }
        public string descripcion { get; set; }
        public Nullable<System.DateTime> fechaIngreso { get; set; }
        public Nullable<int> id_categoria { get; set; }
        public Nullable<int> id_subcategoria { get; set; }
        public Nullable<bool> activo { get; set; }
        public string marcaEquipo { get; set; }
        public string nombreEquipo { get; set; }
        public string modeloEquipo { get; set; }
        public Nullable<bool> serializado { get; set; }
        public string numeroSerie { get; set; }
        public string fechaModifico { get; set; }
        public string userModifico { get; set; }
        public string userCaptura { get; set; }
        public string categoriaNombre { get; set; }
        public string SubcategoriaNombre { get; set; }
        public string sucursal { get; set; }
    }
}