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
    
    public partial class V_Statuspojazdow
    {
        public int id_pojazdu { get; set; }
        public string VIN { get; set; }
        public string Status { get; set; }
        public string Powod_niedostepnosci { get; set; }
        public Nullable<System.DateTime> data_koniec_ubezpieczenia { get; set; }
        public Nullable<int> Dni_do_konca_ubezpieczenia { get; set; }
        public Nullable<System.DateTime> data_kolejnego_przegladu { get; set; }
        public Nullable<int> Dni_do_przeglądu { get; set; }
    }
}
