using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class BW : Form
    {
       
        KWZPEntities _db;
        int liczba;
        
        public BW(KWZPEntities db)
        {
            InitializeComponent();
            _db = db;
        }
       
        private void BW_Load(object sender, EventArgs e)
        {
            List<Produkt> ostatniProdukt = _db.Produkt.ToList();
            liczba = ostatniProdukt.Last().id_produktu+1;
            lbl_4.Text = liczba.ToString();
        }

        private void btn_2_Click(object sender, EventArgs e)
        {
            Produkt produkt = new Produkt();
            produkt.id_produktu = liczba; 
            produkt.nazwa = txt_1.Text;
            _db.Produkt.Add(produkt);
            _db.SaveChanges();
            this.Close();
        }
    }
}
