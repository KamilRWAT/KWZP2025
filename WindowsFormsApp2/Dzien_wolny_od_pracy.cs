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
    
    public partial class Dzien_wolny_od_pracy
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Dzien_wolny_od_pracy()
        {
            this.Kalendarz_pracy = new HashSet<Kalendarz_pracy>();
        }
    
        public int id_dzien_wolny_od_pracy { get; set; }
        public string nazwa { get; set; }
        public System.DateTime data_dnia_wolnego { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Kalendarz_pracy> Kalendarz_pracy { get; set; }
    }
}
