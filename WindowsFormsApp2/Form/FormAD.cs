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
    public partial class FormAD : Form
    {
        KWZPEntities _db;
        int wartosc;

        public FormAD(KWZPEntities db)
        {
            InitializeComponent();
            _db = db;

        }

        private void btn_AD_Click(object sender, EventArgs e)
        {
            try
            {
                Osoba osoba = new Osoba();
                osoba.imie = "Emilia";
                List<Osoba> ostatniOsoba = _db.Osoba.ToList();
                dgv_osoba.DataSource = null;
                dgv_osoba.DataSource = _db.Osoba.ToList();
                dgv_osoba.Update();
                dgv_osoba.Refresh();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void dgv_ZatrudnieniPracownicy_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
