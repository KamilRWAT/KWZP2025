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
    
    public partial class Pensja
    {
        public int id_pensji { get; set; }
        public Nullable<int> id_pracownik { get; set; }
        public System.DateTime data_poczatek { get; set; }
        public Nullable<System.DateTime> data_koniec { get; set; }
        public Nullable<decimal> podstawa_wynagrodzenia { get; set; }
    
        public virtual Pracownik Pracownik { get; set; }
    }
}
