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
    
    public partial class usuario
    {
        public int usuarioID { get; set; }
        public string usuario1 { get; set; }
        public string password { get; set; }
        public string nombre { get; set; }
        public string apellidoPaterno { get; set; }
        public string apellidoMaterno { get; set; }
        public Nullable<System.DateTime> fechaNacimiento { get; set; }
        public string rfc { get; set; }
        public string curp { get; set; }
        public string email { get; set; }
        public Nullable<bool> activo { get; set; }
        public Nullable<System.DateTime> fechaContratacion { get; set; }
        public Nullable<int> idSupervisor { get; set; }
        public Nullable<int> idSucursalBase { get; set; }
        public string telefono { get; set; }
        public Nullable<System.DateTime> fechaBaja { get; set; }
        public Nullable<int> departamento { get; set; }
        public Nullable<int> puesto { get; set; }
    }
}
