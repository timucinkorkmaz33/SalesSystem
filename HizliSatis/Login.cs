using HizliSatis.Entity;
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
    public partial class Login : DevExpress.XtraEditors.XtraForm
    {
        SatisEnt db = new SatisEnt();
        public Login()
        {
            InitializeComponent();
            DevExpress.UserSkins.BonusSkins.Register();
            DevExpress.LookAndFeel.UserLookAndFeel.Default.SkinName = "Visual Studio 2013 Blue";
        }

        private void Login_Load(object sender, EventArgs e)
        {
          
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            var sorgu = db.KullaniciBilgileri.Count();
            if (sorgu == 0)
            {
                KullaniciBilgileri user = new KullaniciBilgileri();
                user.AdiSoyadi = "Dora Bilişim";
                user.KullaniciAdi = "Admin";
                user.Sifre = "dora";
                user.Tarih = DateTime.Now;
                user.Telefon = "03242370767";
                user.Adres = "Mersin";
                user.EMail = "info@dbt.com.tr";
                user.Rol = "Admin";
                db.KullaniciBilgileri.Add(user);
                db.SaveChanges();
            }
            var ayarlar = db.Ayarlar.Count();
            if (ayarlar == 0)
            {
                Ayarlar ayar = new Ayarlar();
                ayar.Cari_Kodu = "000001";
                ayar.Nakit_Seri_No = "PS";
                ayar.Depo_Kodu = "1";
                ayar.Kurulum_Tarihi = DateTime.Now;
                ayar.Plasiyer_Kodu = "001";
                ayar.Sifre = Licence.Licence.ToMD5("Dbt.2018");
                ayar.Kasa_Seri = "KS";
                ayar.Nakit_Kasa_Kodu = "100";
                ayar.KKart_Kasa_Kodu = "101";
                ayar.KKart_Kasa_Aciklama = "Kredi Kart Kasası";
                ayar.Odeme_Sekil1_Kodu = "102";
                ayar.Odeme_Sekil1_Aciklama = "Çek Kasa";
                db.Ayarlar.Add(ayar);
                db.SaveChanges();
            }
            var login = db.KullaniciBilgileri.Where(u => u.KullaniciAdi == txtUser.Text && u.Sifre == txtPass.Text).Count();
            if (login != 0)
            {
                string productkey = ConfigurationManager.AppSettings["ProductKey"].ToString();
                string controlkey = ConfigurationManager.AppSettings["ControlKey"].ToString();
                var makina = Licence.Licence.MakinaCode();
                var sonuc = Licence.Licence.GetLicenseCode(makina,controlkey);
                if (sonuc == productkey)
                {
                    Form1 frm = new Form1();
                    frm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Lisans Kodu Eksiktir. Lütfen lisans kodunu giriniz.");
                }
            }
            else
            {
                MessageBox.Show("Kullanici Adi veya Şifre hatalıdır.Lütfen tekrar deneyiniz.");
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtPass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                simpleButton1_Click(sender, e);
            }
        }

        private void simpleButton2_Click_1(object sender, EventArgs e)
        {
            DatabaseAyari db = new DatabaseAyari();
            db.ShowDialog();

        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
           
            DatabaseAyariHizli dbh = new DatabaseAyariHizli();
            dbh.ShowDialog();
        }
        int control = 0;
        int f = 0;

        private void txtUser_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control) { control = 1; }
            if (e.KeyCode == Keys.F) { f = 1; }
            if(control==1 && f == 1)
            {
                control = 0;
                f = 0;
                LisansForm lf = new LisansForm();
                lf.ShowDialog();
                Application.Restart();
            }
        }
    }
}
