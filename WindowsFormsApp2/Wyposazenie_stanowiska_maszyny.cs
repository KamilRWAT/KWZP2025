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
    
    public partial class Wyposazenie_stanowiska_maszyny
    {
        public int id_wyposazenie_stanowiska_maszyny { get; set; }
        public int id_maszyny { get; set; }
        public int id_stanowisko_produkcyjne { get; set; }
        public System.DateTime data_poczatek { get; set; }
        public Nullable<System.DateTime> data_koniec { get; set; }
    
        public virtual Maszyny Maszyny { get; set; }
        public virtual Stanowisko_produkcyjne Stanowisko_produkcyjne { get; set; }
    }
}
