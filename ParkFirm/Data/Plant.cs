//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ParkFirm.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class Plant
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Plant()
        {
            this.Plant_Area = new HashSet<Plant_Area>();
            this.Watering_Mode = new HashSet<Watering_Mode>();
        }
    
        public int ID_Plant { get; set; }
        public Nullable<int> Age { get; set; }
        public Nullable<int> ID_Type { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Plant_Area> Plant_Area { get; set; }
        public virtual Type_Plant Type_Plant { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Watering_Mode> Watering_Mode { get; set; }
    }
}
