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
    public partial class PM : Form
    {
        KWZPEntities _db;
        public PM(KWZPEntities db)
        {
            InitializeComponent();
            _db = db;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Osoba osoba = new Osoba();
                osoba.imie = "piotr";
                List<Osoba> ostatniaOsoba = _db.Osoba.ToList();
                dgv_osoba.DataSource = null; //odświeżenie
                dgv_osoba.DataSource = _db.Osoba.ToList();
                dgv_osoba.Update();
                dgv_osoba.Refresh();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
