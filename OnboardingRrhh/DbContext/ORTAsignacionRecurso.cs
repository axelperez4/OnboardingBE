//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OnboardingRrhh.DbContext
{
    using System;
    using System.Collections.Generic;
    
    public partial class ORTAsignacionRecurso
    {
        public int Id { get; set; }
        public int IdRecurso { get; set; }
        public int IdOnboarding { get; set; }
        public Nullable<System.DateTime> FechaCumplimiento { get; set; }
        public System.DateTime FechaCreacion { get; set; }
        public int UsuarioCreacion { get; set; }
        public Nullable<System.DateTime> FechaModificacion { get; set; }
        public Nullable<int> UsuarioModificacion { get; set; }
        public bool Activo { get; set; }
    
        public virtual ORTOnboarding ORTOnboarding { get; set; }
        public virtual ORTRecurso ORTRecurso { get; set; }
    }
}
