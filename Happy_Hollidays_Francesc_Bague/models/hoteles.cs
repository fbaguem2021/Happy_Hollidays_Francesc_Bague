//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Happy_Hollidays_Francesc_Bague.models
{
    using System;
    using System.Collections.Generic;
    
    public partial class hoteles
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public hoteles()
        {
            this.act_hotel = new HashSet<act_hotel>();
        }
    
        public int id_ciudad { get; set; }
        public string nombre { get; set; }
        public int categoria { get; set; }
        public string direccion { get; set; }
        public int telefono { get; set; }
        public string tipo { get; set; }
        public string cif { get; set; }
        public Nullable<int> id { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<act_hotel> act_hotel { get; set; }
        public virtual cadenas cadenas { get; set; }
        public virtual ciudades ciudades { get; set; }
    }
}
