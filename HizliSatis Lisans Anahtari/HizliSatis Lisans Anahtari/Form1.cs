using HizliSatis.Licence;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HizliSatis_Lisans_Anahtari
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            var kullanim = txtKullanim.Text;
            var makina = txtMakina.Text;
            var sonuc = Licence.GetLicenseCode(makina,kullanim);
            txtLisans.Text = sonuc;
        }
    }
}
