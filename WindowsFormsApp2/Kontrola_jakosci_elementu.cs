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
    
    public partial class Kontrola_jakosci_elementu
    {
        public int id_kontrola_jakosci_elementu { get; set; }
        public Nullable<int> id_produkcja_elementu { get; set; }
        public decimal ilosc_brakow { get; set; }
    
        public virtual Produkcja_elementu Produkcja_elementu { get; set; }
    }
}
