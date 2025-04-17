using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class MP : Form
    {
        KWZPEntities _db;
        public MP(KWZPEntities db)
        {
            InitializeComponent();
            _db = db;
            
        }

        private void btn_zatw_Click(object sender, EventArgs e)
        {
            string wartosc = textBox1.Text;
            try
            {
                Produkt produkt = new Produkt();
                produkt.nazwa = wartosc;
                List<Produkt> ostatniProdukt = _db.Produkt.ToList();
                int index = ostatniProdukt.Last().id_produktu;
                produkt.id_produktu = index + 1;
                _db.Produkt.Add(produkt);
                _db.SaveChanges();
                MessageBox.Show("dodano produkt");
                Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
