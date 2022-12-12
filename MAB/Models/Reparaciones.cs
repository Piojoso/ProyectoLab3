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
    
    public partial class Reparaciones
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Reparaciones()
        {
            this.Entregas = new HashSet<Entregas>();
            this.Repuestos = new HashSet<ReparacionesRepuestos>();
        }
    
        public int Id { get; set; }
        public System.DateTime fechaIngreso { get; set; }
        public Nullable<System.DateTime> fechaEgreso { get; set; }
        public string errorAReparar { get; set; }
        public estadosReparacion estadoReparacion { get; set; }
        public Nullable<int> mesesGarantia { get; set; }
        public string reparacionRealizada { get; set; }
        public double manoDeObra { get; set; }
        public double totalRepuestos { get; set; }
        public int LavarropasId { get; set; }
    
        public virtual Lavarropas Lavarropas { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Entregas> Entregas { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ReparacionesRepuestos> Repuestos { get; set; }
    }
}
