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
    
    public partial class Niedostepnosc
    {
        public int id_niedostepnosci { get; set; }
        public Nullable<int> id_stan_pracownika { get; set; }
        public Nullable<int> id_pracownik { get; set; }
        public System.DateTime data_poczatek { get; set; }
        public System.DateTime data_koniec { get; set; }
        public int liczba_dni { get; set; }
    
        public virtual Pracownik Pracownik { get; set; }
        public virtual Stan_pracownika Stan_pracownika { get; set; }
    }
}
