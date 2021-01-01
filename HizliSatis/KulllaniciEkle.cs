using HizliSatis.Entity;
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
    public partial class KulllaniciEkle : DevExpress.XtraEditors.XtraForm
    {
        public KulllaniciEkle()
        {
            InitializeComponent();
            DevExpress.UserSkins.BonusSkins.Register();
            DevExpress.LookAndFeel.UserLookAndFeel.Default.SkinName = "Visual Studio 2013 Blue";
        }
        SatisEnt db = new SatisEnt();
        private void KulllaniciEkle_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'kullaniciDataset.KullaniciBilgileri' table. You can move, or remove it, as needed.
            this.kullaniciBilgileriTableAdapter.Fill(this.kullaniciDataset.KullaniciBilgileri);
            var roles = db.RolTanimlari.Where(u => u.RolAdi != "AppAdmin").Select(u => u.RolAdi).ToList();

            foreach (var item in roles)
            {
                cmbRol.Properties.Items.Add(item);
            }
        }

        private void repositoryItemButtonEdit2_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var a = gridView1.FocusedRowHandle;
            var x = gridView1.GetRowCellValue(a, "Id").ToString();
            var id = Convert.ToInt32(x);
            if (MessageBox.Show("Kaydı Silmek İstiyor Musunuz?", "Kullanıcı Bilgileri Silme Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                var kullaniciBilgileri = db.KullaniciBilgileri.Find(id);
                db.KullaniciBilgileri.Remove(kullaniciBilgileri);
                db.SaveChanges();
            }
            Temizle();
            KulllaniciEkle_Load(sender, e);
        }

        private void repositoryItemButtonEdit1_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var a = gridView1.FocusedRowHandle;
            var x = gridView1.GetRowCellValue(a, "Id").ToString();
            var id = Convert.ToInt32(x);
            var sorgu = db.KullaniciBilgileri.Where(u => u.Id == id).ToList().FirstOrDefault();
            txtAdSoyad.Text = sorgu.AdiSoyadi;
            txtAdres.Text = sorgu.Adres;
            txtEMail.Text = sorgu.EMail;
            txtKullaniciAdi.Text = sorgu.KullaniciAdi;
            txtSifre.Text = sorgu.Sifre;
            txtTelefon.Text = sorgu.Telefon;
            txtKullaniciId.Text = sorgu.Id.ToString();
            if (sorgu.Rol == "User")
            {

                cmbRol.SelectedText = "User";
            }
            else
            {

                cmbRol.SelectedText = "Admin";
            }
        
        }
        public void Temizle()
        {
            txtSifre.Text = "";
            txtTelefon.Text = "";
            txtAdres.Text = "";
            txtAdSoyad.Text = "";
            txtEMail.Text = "";
            txtKullaniciAdi.Text = "";
            cmbRol.Text = "";
            txtKullaniciId.Text = "";
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (txtKullaniciId.Text == null || txtKullaniciId.Text == "")
            {
                KullaniciBilgileri kul = new KullaniciBilgileri();
                kul.AdiSoyadi = txtAdSoyad.Text;
                kul.Adres = txtAdres.Text;
                kul.EMail = txtEMail.Text;
                kul.KullaniciAdi = txtKullaniciAdi.Text;
                kul.Sifre = txtSifre.Text;
                kul.Telefon = txtTelefon.Text;
                kul.Rol = cmbRol.Text;
                kul.Tarih = DateTime.Now;
                db.KullaniciBilgileri.Add(kul);
                db.SaveChanges();
            
            }
            else
            {
                var id = Convert.ToInt32(txtKullaniciId.Text);
                KullaniciBilgileri kul = db.KullaniciBilgileri.Where(u => u.Id == id).FirstOrDefault();
                kul.AdiSoyadi = txtAdSoyad.Text;
                kul.Adres = txtAdres.Text;
                kul.EMail = txtEMail.Text;
                kul.KullaniciAdi = txtKullaniciAdi.Text;
                kul.Sifre = txtSifre.Text;
                kul.Telefon = txtTelefon.Text;
                kul.Rol = cmbRol.Text;
                db.SaveChanges();
        
            }


            MessageBox.Show("Kullanıcı Ekleme işlemi Başarılı");
            Temizle();
            KulllaniciEkle_Load(sender, e);
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            Temizle();
        }
    }
}
