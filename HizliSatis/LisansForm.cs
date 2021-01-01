using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HizliSatis
{
    public partial class LisansForm : DevExpress.XtraEditors.XtraForm
    {
        public LisansForm()
        {
            InitializeComponent();
        }
        //EF38E-B4E97-396B1-67A12-BBC0F
        //28C92-23F6A-43342-48054-1B167
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            var kullanim = txtKullanim.Text;
            var makina = txtMakina.Text;
            var sonuc=Licence.Licence.GetLicenseCode(makina,kullanim);
            if (sonuc == txtLinans.Text)
            {
                string productkey = ConfigurationManager.AppSettings["ProductKey"];
                if (productkey == null)
                {
                    var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                    config.AppSettings.Settings.Add("ProductKey", sonuc);
                    config.AppSettings.Settings.Add("ControlKey", kullanim);

                    config.Save(ConfigurationSaveMode.Modified);
                }
                else if (productkey != sonuc)
                {
                    var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                    config.AppSettings.Settings["ProductKey"].Value = sonuc;
                    config.AppSettings.Settings["ControlKey"].Value = kullanim;
                    config.Save(ConfigurationSaveMode.Modified);
                }
                MessageBox.Show("Lisans Kodunuz Başarıyla Kaydedilmiştir");
                this.Close();
              //  ConfigurationManager.RefreshSection("appSettings");
            }
            else
            {
                MessageBox.Show("Lisans Kodunuzda hata vardır.Lütfen Dora Bilişim ile irtibata geçiniz!!");
            }
        }

        private void LisansForm_Load(object sender, EventArgs e)
        {
            txtMakina.Text = Licence.Licence.MakinaCode();
        }

        private void txtKullanim_EditValueChanged(object sender, EventArgs e)
        {

        }
    }
}
