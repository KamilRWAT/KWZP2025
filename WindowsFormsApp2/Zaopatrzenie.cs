//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WindowsFormsApp2
{
    using System;
    using System.Collections.Generic;
    
    public partial class Zaopatrzenie
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Zaopatrzenie()
        {
            this.Szczegoly_zaopatrzenia = new HashSet<Szczegoly_zaopatrzenia>();
        }
    
        public int id_zaopatrzenia { get; set; }
        public Nullable<int> id_dostawcy { get; set; }
        public Nullable<System.DateTime> data_zaopatrzenia { get; set; }
        public Nullable<int> id_pracownik { get; set; }
    
        public virtual Dostawca Dostawca { get; set; }
        public virtual Pracownik Pracownik { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Szczegoly_zaopatrzenia> Szczegoly_zaopatrzenia { get; set; }
    }
}
