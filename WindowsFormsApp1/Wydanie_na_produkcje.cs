//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WindowsFormsApp1
{
    using System;
    using System.Collections.Generic;
    
    public partial class Wydanie_na_produkcje
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Wydanie_na_produkcje()
        {
            this.Szczegoly_wydania = new HashSet<Szczegoly_wydania>();
        }
    
        public int id_wydania { get; set; }
        public Nullable<int> id_zamowienie { get; set; }
        public Nullable<int> id_pracownik { get; set; }
    
        public virtual Pracownik Pracownik { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Szczegoly_wydania> Szczegoly_wydania { get; set; }
        public virtual Zamowienie Zamowienie { get; set; }
    }
}
