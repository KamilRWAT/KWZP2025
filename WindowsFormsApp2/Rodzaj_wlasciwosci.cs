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
    
    public partial class Rodzaj_wlasciwosci
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Rodzaj_wlasciwosci()
        {
            this.Szczegoly_parametry_maszyny = new HashSet<Szczegoly_parametry_maszyny>();
            this.Wlasciwosci_narzedzia = new HashSet<Wlasciwosci_narzedzia>();
            this.Wlasciwosci_model_pojazdu = new HashSet<Wlasciwosci_model_pojazdu>();
            this.Wlasciwosci_miar = new HashSet<Wlasciwosci_miar>();
            this.Wlasciwosci_materialu = new HashSet<Wlasciwosci_materialu>();
            this.Wlasciwosci_element = new HashSet<Wlasciwosci_element>();
            this.Wlasciwosci_produkt = new HashSet<Wlasciwosci_produkt>();
            this.Wlasciwosci_model_maszyny = new HashSet<Wlasciwosci_model_maszyny>();
        }
    
        public int id_rodzaj_wlasciwosci { get; set; }
        public string nazwa { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Szczegoly_parametry_maszyny> Szczegoly_parametry_maszyny { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Wlasciwosci_narzedzia> Wlasciwosci_narzedzia { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Wlasciwosci_model_pojazdu> Wlasciwosci_model_pojazdu { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Wlasciwosci_miar> Wlasciwosci_miar { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Wlasciwosci_materialu> Wlasciwosci_materialu { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Wlasciwosci_element> Wlasciwosci_element { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Wlasciwosci_produkt> Wlasciwosci_produkt { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Wlasciwosci_model_maszyny> Wlasciwosci_model_maszyny { get; set; }
    }
}
