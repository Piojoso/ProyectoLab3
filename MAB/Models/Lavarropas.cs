//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MAB.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Lavarropas
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Lavarropas()
        {
            this.Reparacion = new HashSet<Reparaciones>();
        }
    
        public int Id { get; set; }
        public string marca { get; set; }
        public string modelo { get; set; }
        public string estadoGeneral { get; set; }
        public int ClienteId { get; set; }
        public bool estado { get; set; }
    
        public virtual Clientes Cliente { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Reparaciones> Reparacion { get; set; }
    }
}
