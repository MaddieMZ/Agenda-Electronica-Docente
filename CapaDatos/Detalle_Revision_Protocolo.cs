//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CapaDatos
{
    using System;
    using System.Collections.Generic;
    
    public partial class Detalle_Revision_Protocolo
    {
        public int IdRev { get; set; }
        public Nullable<int> IdDoc_Prof { get; set; }
        public string Observacion { get; set; }
        public Nullable<int> Aprobado { get; set; }
    
        public virtual Doc_Prof Doc_Prof { get; set; }
    }
}
