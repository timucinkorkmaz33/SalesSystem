using HizliSatis.Entity;
using HizliSatis.Model;
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
    public partial class KisayolEkle : Form
    {
        public KisayolEkle()
        {
            InitializeComponent();
        }
        SatisEnt db = new SatisEnt();
        MikroEnt dbmikro = new MikroEnt();
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            StokListeForm stk = new StokListeForm();
            stk.ShowDialog();
            KisayolEkle_Load(sender, e);
        }

        private void KisayolEkle_Load(object sender, EventArgs e)
        {
            if (StokListeForm.barkodKodu != null)
            {
                txtBarkod.Text = StokListeForm.barkodKodu.ToString();
            }

        }
        string CorrectFilename = "";
        string yol = "";
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            OpenFileDialog dosya = new OpenFileDialog();

            var urunbilgi = dbmikro.BARKOD_TANIMLARI.Where(u => u.bar_kodu == txtBarkod.Text).FirstOrDefault().bar_stokkodu;
            var stoktakiurun = dbmikro.STOKLAR.Where(u => u.sto_kod == urunbilgi).FirstOrDefault();
            var P_Satis_Fiyat = dbmikro.STOK_SATIS_FIYAT_LISTELERI.Where(x => x.sfiyat_stokkod == stoktakiurun.sto_kod && x.sfiyat_listesirano == 1).FirstOrDefault().sfiyat_fiyati;//parekende

            var vergi = stoktakiurun.sto_perakende_vergi;
            var vergideg = 1;
            if (vergi == 1) { vergideg = 0; }
            else if (vergi == 2) { vergideg = 1; }
            else if (vergi == 3) { vergideg = 8; }
            else if (vergi == 4) { vergideg = 18; }
            else if (vergi == 5) { vergideg = 26; }

            ButonKisayolBilgileri btnkisayol = new ButonKisayolBilgileri();
            btnkisayol.ButonAdi = txtIsim.Text;
            btnkisayol.ButonResim = txtResim.Text;
            btnkisayol.Barkod = txtBarkod.Text;
            btnkisayol.B_Fiyat = P_Satis_Fiyat;
            btnkisayol.Stokkodu = urunbilgi;
            btnkisayol.Urunadi = stoktakiurun.sto_isim;

            btnkisayol.Vergiyuzdesi = vergideg.ToString();
            db.ButonKisayolBilgileri.Add(btnkisayol);

            db.SaveChanges();
            MessageBox.Show("Kısayol oluşturma işlemi tamamlandı.Lütfen ekranı yenileyiniz!");
            this.Close();

        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            OpenFileDialog dosya = new OpenFileDialog();
            dosya.Filter = "Resim Dosyası |*.jpg;*.nef;*.png";
            dosya.Title = "Resim Seç";
            if (dosya.ShowDialog() == DialogResult.OK)
            {
                string dosyaadi = dosya.FileName;
                pbox.Image = Image.FromFile(dosyaadi);
                pbox.Top = 110;
                pbox.Size = new System.Drawing.Size(100, 100);
                pbox.SizeMode = PictureBoxSizeMode.StretchImage;
                this.Controls.Add(pbox);
                string paths = Application.StartupPath.Substring(0, (Application.StartupPath.Length - 10));
                string CorrectFilename = System.IO.Path.GetFileName(dosya.FileName);
                yol = paths + "\\resimler\\" + CorrectFilename;
                txtResim.Text = yol;
                var sorgu = db.ButonKisayolBilgileri.Where(u => u.ButonResim.Contains(dosya.FileName)).FirstOrDefault();
                if (sorgu != null)
                {
                    System.IO.File.Copy(dosya.FileName, paths + "\\resimler\\" + CorrectFilename);
                }
                MessageBox.Show("Yukleme Başarılı");
            }
        }
    }
}
