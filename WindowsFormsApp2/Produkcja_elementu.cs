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
    
    public partial class Produkcja_elementu
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Produkcja_elementu()
        {
            this.Kontrola_jakosci_elementu = new HashSet<Kontrola_jakosci_elementu>();
        }
    
        public int id_produkcja_elementu { get; set; }
        public Nullable<int> id_zamowienie { get; set; }
        public Nullable<int> id_element { get; set; }
        public Nullable<System.DateTime> data_poczatek { get; set; }
        public Nullable<System.DateTime> data_koniec { get; set; }
        public Nullable<int> ilosc { get; set; }
        public Nullable<int> id_pracownik { get; set; }
        public Nullable<int> id_maszyny { get; set; }
        public Nullable<int> id_stanowisko_produkcyjne { get; set; }
        public Nullable<int> id_czynnosc { get; set; }
    
        public virtual Czynnosci_produkcyjne Czynnosci_produkcyjne { get; set; }
        public virtual Element Element { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Kontrola_jakosci_elementu> Kontrola_jakosci_elementu { get; set; }
        public virtual Maszyny Maszyny { get; set; }
        public virtual Pracownik Pracownik { get; set; }
        public virtual Stanowisko_produkcyjne Stanowisko_produkcyjne { get; set; }
        public virtual Zamowienie Zamowienie { get; set; }
    }
}
