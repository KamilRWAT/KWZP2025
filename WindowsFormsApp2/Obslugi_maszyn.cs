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
    
    public partial class Obslugi_maszyn
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Obslugi_maszyn()
        {
            this.Narzedzia_w_obsludze = new HashSet<Narzedzia_w_obsludze>();
            this.Szczegoly_obslugi = new HashSet<Szczegoly_obslugi>();
        }
    
        public int id_obslugi { get; set; }
        public Nullable<int> id_maszyny { get; set; }
        public System.DateTime data_poczatek { get; set; }
        public System.DateTime data_koniec { get; set; }
        public int id_typ_obslugi { get; set; }
        public Nullable<int> id_pracownik { get; set; }
    
        public virtual Maszyny Maszyny { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Narzedzia_w_obsludze> Narzedzia_w_obsludze { get; set; }
        public virtual Pracownik Pracownik { get; set; }
        public virtual Typ_obslugi Typ_obslugi { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Szczegoly_obslugi> Szczegoly_obslugi { get; set; }
    }
}
