using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HizliSatis
{
    public partial class Sifre : DevExpress.XtraEditors.XtraForm
    {
        public Sifre()
        {
            DevExpress.UserSkins.BonusSkins.Register();
            DevExpress.LookAndFeel.UserLookAndFeel.Default.SkinName = "Visual Studio 2013 Blue";
            InitializeComponent();
        }
        public static string sifre;
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            sifre = txtSifre.Text;
            this.Close();
        }

        private void Sifre_Load(object sender, EventArgs e)
        {
            MessageBox.Show("İşlemi Gerçekleştirebilmek için Yönetici Şifrenizi Girmeniz Gereklidir.");
            Sifre.sifre = "";
        }

        private void txtSifre_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                simpleButton1_Click(sender, e);
            }
        }
    }
}
