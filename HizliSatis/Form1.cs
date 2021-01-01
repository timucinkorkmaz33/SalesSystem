using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraSplashScreen;
using HizliSatis.Entity;
using HizliSatis.Model;
using HizliSatis.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HizliSatis
{
    public partial class Form1 : DevExpress.XtraEditors.XtraForm
    {
        public Form1()
        {
            InitializeComponent();
            DevExpress.UserSkins.BonusSkins.Register();
            DevExpress.LookAndFeel.UserLookAndFeel.Default.SkinName = "Visual Studio 2013 Blue";
        }
        SatisEnt db = new SatisEnt();
        MikroEnt dbmikro = new MikroEnt();
        public string vergi;
        public string stkkodu;
        public static string toplamfiyat;
        public static int sepetadi;
        public static double vergi3 = 0;
        public static double vergi4 = 0;
        public string sepet_RecNo = "";
        public double total;
        public static double? totalindirim;
        public int otoenter = 0;


        class SepetListe
        {
            public string BarkodNo { get; set; }
            public string UrunAdi { get; set; }
            public string Kodu { get; set; }
            public string Vergi { get; set; }

            public double? Miktar { get; set; }
            public double? BirimFiyat { get; set; }
            public double? Tutar { get; set; }
            public double? IskontoTutar { get; set; }
            public double? IskontoYuzde { get; set; }



            public SepetListe(string barkod, string uadi, string ukodu, string vergi, double? mik, double? cbirimfiyat, double? fiyat, double? iskonto, double? iskontoyuzde)
            {
                BarkodNo = barkod;
                UrunAdi = uadi;
                Kodu = ukodu;
                BirimFiyat = cbirimfiyat;
                Miktar = mik;
                Vergi = vergi;
                IskontoTutar = iskonto;
                IskontoYuzde = iskontoyuzde;
                Tutar = fiyat;
            }
        }
        BindingSource source = new BindingSource();
        public object stokkodu;
        public double? AnaFiyat = 0;
        public double? KDV = 0;
        public double? Toplam = 0;
        public static double? Indirim = 0;
        public static int butonid;
        private void Form1_Load(object sender, EventArgs e)
        {

            SplashScreenManager.ShowForm(typeof(WaitForm1));
            txtAnaFiyat.ReadOnly = true;
            txtKDV.ReadOnly = true;
            txtToplam.ReadOnly = true;
            txtIskonto.ReadOnly = true;
            gridView1.OptionsBehavior.Editable = false;
            if (CariSepetleri.sepetno != null)
            {
                sepetno = Convert.ToInt32(CariSepetleri.sepetno.ToString());
                var sorgu = db.CariSepet.Where(u => u.SepetAdi == sepetno.ToString()).FirstOrDefault();
                CariListeForm.CariKodu = sorgu.Carikodu;

            }
            if (CariListeForm.CariKodu != null)
            {
                txtCari.Text = CariListeForm.CariKodu.ToString();
            }
            else
            {
                txtCari.Text = db.Ayarlar.Select(u => u.Cari_Kodu).FirstOrDefault();
            }
            var barkod = StokListeForm.barkodKodu;
            var vergideg = StokListeForm.vergi;

            if (barkod != null && vergideg != null)
            {
                txtBarkod.Text = barkod.ToString();
                txtUrunAdi.Text = StokListeForm.urunadi.ToString();
                stokkodu = StokListeForm.stokkod;
                txtBirimfiyatı.Text = StokListeForm.birimFiyat.ToString();
            }
           // var sorgu1 = dbmikro.BARKOD_TANIMLARI.ToList();
            listele();
            txtBarkod.Focus();
            SplashScreenManager.CloseForm();

            pictureBox2.Visible = false;
            KisayolEkle_Click(sender, e);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StokListeForm stk = new StokListeForm();
            stk.ShowDialog();
            // this.Visible = false;
            Form1_Load(sender, e);
            if (chckoto.Checked)
            {
                BarkodGetir(txtBarkod.Text);
                Ekle();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CariListeForm cr = new CariListeForm();
            // cr.Show();
            cr.ShowDialog();
            //this.Visible = false; 
            Form1_Load(sender, e);
        }

        public void Temizle()
        {
            txtMiktar.Text = "";
            txtBarkod.Text = "";
            txtBirimfiyatı.Text = "";
            txtUrunAdi.Text = "";
            StokListeForm.barkodKodu = "";
            StokListeForm.birimFiyat = "";
            StokListeForm.stokkod = "";
            StokListeForm.urunadi = "";
            StokListeForm.vergi = "";
            sepet_RecNo = "";
            txtisktl.Text = "";
            txtiskyuz.Text = "";
            //txtIskonto.Text = "";
            txtsatisktl.Text = "";
            txtsatiskyuzde.Text = "";
            txtBarkod.ReadOnly = false;
            txtUrunAdi.ReadOnly = false;
            txtBarkod.Focus();

        }

        public void listele()
        {
            var mkodu = txtCari.Text;
            var sepetsorgu = db.Sepet.Where(u => u.sep_sepetno == sepetno).ToList();
            List<SepetListe> spt = new List<SepetListe>();
            txtAnaFiyat.Text = "";
            txtKDV.Text = "";
            txtToplam.Text = "";
            txtDigit.Text = "";
            txtIskonto.Text = "";
            AnaFiyat = 0;
            KDV = 0;
            Toplam = 0;
            vergi3 = 0;
            vergi4 = 0;
            totalindirim = 0;
            foreach (var s in sepetsorgu)
            {
                var urunadi = s.sep_urun_adi;
                var urunkodu = s.sep_stok_kod;
                var birimfiyat = s.sep_b_fiyat;
                var miktar = s.sep_miktar;
                var vergidegeri = s.sep_vergi;
                var vergi = 0;
                if (vergidegeri == "1") { vergi = 0; }
                else if (vergidegeri == "2") { vergi = 1; }
                else if (vergidegeri == "3") { vergi = 8; }
                else if (vergidegeri == "4") { vergi = 18; }
                else if (vergidegeri == "5") { vergi = 26; }
                var barkodno = s.sep_urun_barkod_no;
                var fiyat = s.sep_tutar;
                AnaFiyat = AnaFiyat + Convert.ToDouble(fiyat);
                if (vergidegeri == "3") { vergi3 = vergi3 + (Convert.ToDouble(fiyat) * vergi / 100); }
                else if (vergidegeri == "4") { vergi4 = vergi4 + (Convert.ToDouble(fiyat) * vergi / 100); }

                KDV = KDV + (Convert.ToDouble(fiyat) * vergi / 100);
                Toplam = KDV + AnaFiyat;
                totalindirim = totalindirim + s.sep_iskonto1;///toplam satırda yapılan iskonto
                double? yuzde = (s.sep_iskonto1 * 100) / (Convert.ToDouble(miktar) * Convert.ToDouble(birimfiyat));

                spt.Add(new SepetListe(barkodno, urunadi, urunkodu, vergi.ToString(), Convert.ToDouble(miktar), Convert.ToDouble(birimfiyat), Convert.ToDouble(fiyat), s.sep_iskonto1, yuzde));
            }
            List<SepetListe> list = spt;
            source.DataSource = list;
            gridControl1.DataSource = source;

            if (AnaFiyat != 0)
            {
                var ana = Math.Round(Convert.ToDouble(AnaFiyat), 2);
                txtAnaFiyat.Text = ana.ToString() + '₺';
                var kdv = Math.Round(Convert.ToDouble(KDV), 2);
                txtKDV.Text = kdv.ToString() + '₺';
                var indirim = Math.Round(Convert.ToDouble(totalindirim), 2);
                txtIskonto.Text = indirim.ToString() + '₺';

                var digit = Math.Round(Convert.ToDouble(Toplam), 2);
                total = digit;
                txtToplam.Text = digit.ToString() + '₺';
                txtDigit.Text = digit.ToString();
            }
        }
        public int sepetno = 0;
        private void simpleButton5_Click(object sender, EventArgs e)
        {
            if (txtBarkod.Text != "")
            {
                if (txtMiktar.Text == "")
                {
                    txtMiktar.Text = "1";
                }


                if (sepetno == 0)
                {
                    var sorgu = db.CariSepet.Where(u => u.Carikodu == txtCari.Text).OrderByDescending(u => u.Id).FirstOrDefault();
                    if (sorgu == null)
                    {
                        sepetno = 1;
                    }
                    else
                    {
                        sepetno = Convert.ToInt32(sorgu.SepetAdi) + 1;
                    }
                    CariSepet csep = new CariSepet();
                    csep.Tarih = DateTime.Now;
                    csep.SepetAdi = sepetno.ToString();
                    if (checkBox1.Checked == true) { csep.Durum = "0"; }
                    else { csep.Durum = "1"; }
                    csep.Fiyat = "0";
                    csep.Carikodu = txtCari.Text;
                    db.CariSepet.Add(csep);
                    db.SaveChanges();

                }
                if (sepet_RecNo == "")
                {

                    Sepet sp = new Sepet();
                    sp.sep_musteri_kod = txtCari.Text;
                    sp.sep_urun_adi = txtUrunAdi.Text;
                    if (checkBox1.Checked == true) { sp.sep_durumu = 0; }
                    else { sp.sep_durumu = 1; }
                    sp.sep_vergi = StokListeForm.vergi.ToString();
                    sp.sep_b_fiyat = txtBirimfiyatı.Text;
                    if (txtsatiskyuzde.Text != "" || txtsatisktl.Text != "")
                    {
                        var total = (Convert.ToDouble(sp.sep_b_fiyat) * Convert.ToInt32(txtMiktar.Text));
                        if (txtsatiskyuzde.Text != "")
                        {
                            var indirim = (total * Convert.ToDouble(txtsatiskyuzde.Text)) / 100;
                            var indirimlifiyat = total - indirim;
                            sp.sep_tutar = indirimlifiyat.ToString();
                            sp.sep_iskonto1 = indirim;
                        }
                        else if (txtsatisktl.Text != "")
                        {
                            var indirimtoplam = Convert.ToDouble(txtsatisktl.Text) * Convert.ToInt32(txtMiktar.Text);
                            var indirimlifiyat = total - indirimtoplam;
                            sp.sep_tutar = indirimlifiyat.ToString();
                            sp.sep_iskonto1 = indirimtoplam;
                        }
                    }
                    else
                    {
                        sp.sep_tutar = (Convert.ToDouble(sp.sep_b_fiyat) * Convert.ToInt32(txtMiktar.Text)).ToString();
                        sp.sep_iskonto1 = 0;
                    }
                    sp.sep_stok_kod = stokkodu.ToString();
                    sp.sep_urun_barkod_no = txtBarkod.Text;
                    sp.sep_miktar = txtMiktar.Text;
                    sp.sep_sepetno = sepetno;
                    db.Sepet.Add(sp);
                    db.SaveChanges();
                    var vergi = StokListeForm.vergi.ToString();
                    var vergideg = 1;
                    if (vergi == "1") { vergideg = 0; }
                    else if (vergi == "2") { vergideg = 1; }
                    else if (vergi == "3") { vergideg = 8; }
                    else if (vergi == "4") { vergideg = 18; }
                    else if (vergi == "5") { vergideg = 26; }
                    var sepetfiyat = db.CariSepet.Where(u => u.SepetAdi == sepetno.ToString()).FirstOrDefault();
                    var tutar = Convert.ToDouble(txtBirimfiyatı.Text) * Convert.ToInt32(txtMiktar.Text);

                    listele();
                    Temizle();
                    var fiyat = Convert.ToDouble(txtDigit.Text);
                    sepetfiyat.Fiyat = Math.Round(fiyat, 2).ToString();
                    db.SaveChanges();
                }
                else
                {
                    int sepkodu = Convert.ToInt32(sepet_RecNo);
                    Sepet sp = db.Sepet.Where(u => u.sep_RECno == sepkodu).FirstOrDefault();
                    // sp.sep_musteri_kod = txtCari.Text;
                    //sp.sep_urun_adi = txtUrunAdi.Text;
                    //  sp.sep_vergi = StokListeForm.vergi.ToString();
                    sp.sep_b_fiyat = txtBirimfiyatı.Text;
                    if (txtsatiskyuzde.Text != "" || txtsatisktl.Text != "")
                    {
                        var total = (Convert.ToDouble(sp.sep_b_fiyat) * Convert.ToInt32(txtMiktar.Text));
                        if (txtsatiskyuzde.Text != "")
                        {
                            var indirim = (total * Convert.ToDouble(txtsatiskyuzde.Text)) / 100;
                            var indirimlifiyat = total - indirim;
                            sp.sep_tutar = indirimlifiyat.ToString();
                            sp.sep_iskonto1 = indirim;
                        }
                        else if (txtsatisktl.Text != "")
                        {
                            var indirimtoplam = Convert.ToDouble(txtsatisktl.Text) * Convert.ToInt32(txtMiktar.Text);
                            var indirimlifiyat = total - indirimtoplam;
                            sp.sep_tutar = indirimlifiyat.ToString();
                            sp.sep_iskonto1 = indirimtoplam;
                        }
                    }
                    else
                    {
                        sp.sep_tutar = (Convert.ToDouble(sp.sep_b_fiyat) * Convert.ToInt32(txtMiktar.Text)).ToString();
                        sp.sep_iskonto1 = 0;
                    }
                    // sp.sep_stok_kod = stokkodu.ToString();
                    // sp.sep_urun_barkod_no = txtBarkod.Text;
                    sp.sep_miktar = txtMiktar.Text;
                    //  sp.sep_sepetno = sepetno;
                    //db.Sepet.Add(sp);
                    db.SaveChanges();
                    var vergi = sp.sep_vergi;
                    var vergideg = 1;
                    if (vergi == "1") { vergideg = 0; }
                    else if (vergi == "2") { vergideg = 1; }
                    else if (vergi == "3") { vergideg = 8; }
                    else if (vergi == "4") { vergideg = 18; }
                    else if (vergi == "5") { vergideg = 26; }
                    var sepetfiyat = db.CariSepet.Where(u => u.SepetAdi == sepetno.ToString()).FirstOrDefault();
                    var tutar = Convert.ToDouble(txtBirimfiyatı.Text) * Convert.ToInt32(txtMiktar.Text);

                    listele();
                    Temizle();
                    var fiyat = Convert.ToDouble(txtDigit.Text);
                    sepetfiyat.Fiyat = Math.Round(fiyat, 2).ToString();
                    db.SaveChanges();
                }
            }
            else
            {
                MessageBox.Show("Lütfen geçerli bir barkod giriniz!!");
            }


        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        private void gridControl1_DoubleClick(object sender, EventArgs e)
        {
            var sepetsorgula = db.Sepet.Where(u => u.sep_sepetno == sepetno).Count();
            if (sepetsorgula != 0)
            {

                var sil = MessageBox.Show("Silmek istediğinize emin misiniz?", "Ürün Sil", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                if (sil == DialogResult.Yes)
                {
                    var a = gridView1.FocusedRowHandle;
                    var sorgu = db.Sepet.Where(u => u.sep_musteri_kod == txtCari.Text && u.sep_sepetno == sepetno).ToList();
                    var id = sorgu[a].sep_RECno;
                    var data = db.Sepet.Find(id);
                    db.Sepet.Remove(data);
                    db.SaveChanges();
                    Form1_Load(sender, e);
                    listele();
                }

            }
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            FiyatGor fyt = new FiyatGor();
            fyt.Show();
        }

        private void txtBarkod_KeyDown(object sender, KeyEventArgs e)
        {
            if (chckoto.Checked)
            {
                if (e.KeyCode == Keys.Enter)
                {
                    BarkodGetir(txtBarkod.Text);
                    if (otoenter == 0)
                    {
                        Ekle();
                    }
                    Temizle();
                }

            }
            else
            {
                if (e.KeyCode == Keys.Enter)
                {
                    BarkodGetir(txtBarkod.Text);
                }
            }
        }

        model2.Model1 dbbb = new model2.Model1();
        public void BarkodGetir(string code)
        {
            var sorgu1=dbbb.BARKOD_TANIMLARI.Where(u => u.bar_kodu == code).FirstOrDefault();
            //var sorgu1 = dbmikro.BARKOD_TANIMLARI.Where(u => u.bar_kodu == code).FirstOrDefault();
            if (sorgu1 != null)
            {
                var result = (from stk in dbbb.STOKLAR
                                  //join br in dbmikro.BARKOD_TANIMLARI on stk.sto_kod equals br.bar_stokkodu into j1
                                  //from br in j1.DefaultIfEmpty()
                              where stk.sto_kod == sorgu1.bar_stokkodu
                              select new StokModelView
                              {
                                  sto_kod = stk.sto_kod,
                                  sto_kisa_ismi = stk.sto_kisa_ismi,
                                  sto_isim = stk.sto_isim,
                                  sto_perakende_vergi = stk.sto_perakende_vergi,
                                  // BarkodNo = br.bar_kodu,
                                  //                   sto_RECno = stk.sto_RECno,
                                  //                   sto_birim1_ad = stk.sto_birim1_ad,
                                  //                   sto_birim1_katsayi = stk.sto_birim1_katsayi,
                                  //                   sto_birim2_ad = stk.sto_birim2_ad,
                                  //                   sto_birim2_katsayi = stk.sto_birim2_katsayi,
                                  //                   sto_birim3_ad = stk.sto_birim3_ad,
                                  //                   sto_birim3_katsayi = stk.sto_birim3_katsayi,
                                  //                   sto_birim4_ad = stk.sto_birim4_ad,
                                  //                   sto_birim4_katsayi = stk.sto_birim4_katsayi,
                                  //                   Alış_Fiyatı = stk.sto_standartmaliyet,
                                  //                   Bakiye = dbmikro.STOK_HAREKETLERI_OZET.Where(x => x.sho_StokKodu == stk.sto_kod &&
                                  //                  x.sho_HareketCins != 6 &&
                                  //x.sho_HareketCins != 9 &&
                                  //x.sho_HareketCins != 15)
                                  //     .Sum(a => (a.sho_GirisNormal + a.sho_GirisIade) - (a.sho_CikisNormal + a.sho_CikisIade)).Value,
                                  //Bakiye
                                  P_Satis_Fiyat = dbbb.STOK_SATIS_FIYAT_LISTELERI.Where(x => x.sfiyat_stokkod == stk.sto_kod && x.sfiyat_listesirano == 1).FirstOrDefault().sfiyat_fiyati,//parekende
                                                                                                                                                                                             //  T_Satis_Fiyat = dbmikro.STOK_SATIS_FIYAT_LISTELERI.Where(x => x.sfiyat_stokkod == stk.sto_kod && x.sfiyat_listesirano == 2).FirstOrDefault().sfiyat_fiyati,//toptan
                                                                                                                                                                                             //   K_Satis_Fiyat = dbmikro.STOK_SATIS_FIYAT_LISTELERI.Where(x => x.sfiyat_stokkod == stk.sto_kod && x.sfiyat_listesirano == 3).FirstOrDefault().sfiyat_fiyati//kurumlar
                              }).ToList().FirstOrDefault();

                txtUrunAdi.Text = result.sto_isim;
                txtBirimfiyatı.Text = result.P_Satis_Fiyat.ToString();
                vergi = result.sto_perakende_vergi.ToString();
                stkkodu = result.sto_kod;
                StokListeForm.vergi = vergi;
                otoenter = 0;
            }
            else
            {
                otoenter = 1;
                MessageBox.Show("Kayıtlı Barkod Bulunamadı!Lütfen Barkodu kontrol ediniz!");
            }
        }
        public void Ekle()
        {
            if (txtMiktar.Text == "")
            {
                txtMiktar.Text = "1";
            }
            if (vergi == null)
            {
                vergi = StokListeForm.vergi.ToString();
            }
            if (sepetno == 0)
            {
                var sorgu = db.CariSepet.Where(u => u.Carikodu == txtCari.Text).OrderByDescending(u => u.Id).FirstOrDefault();
                if (sorgu == null)
                {
                    sepetno = 1;
                }
                else
                {
                    sepetno = Convert.ToInt32(sorgu.SepetAdi) + 1;
                }
                CariSepet csep = new CariSepet();
                csep.Tarih = DateTime.Now;
                csep.SepetAdi = sepetno.ToString();
                if (checkBox1.Checked == true) { csep.Durum = "0"; }
                else { csep.Durum = "1"; }

                csep.Fiyat = "0";
                csep.Carikodu = txtCari.Text;
                db.CariSepet.Add(csep);
                db.SaveChanges();

            }
            Sepet sp = new Sepet();
            sp.sep_musteri_kod = txtCari.Text;
            sp.sep_urun_adi = txtUrunAdi.Text;
            sp.sep_vergi = vergi;
            sp.sep_b_fiyat = txtBirimfiyatı.Text;
            sp.sep_tutar = (Convert.ToDouble(sp.sep_b_fiyat) * Convert.ToInt32(txtMiktar.Text)).ToString();
            sp.sep_stok_kod = stkkodu;
            sp.sep_urun_barkod_no = txtBarkod.Text;
            sp.sep_miktar = txtMiktar.Text;
            sp.sep_sepetno = sepetno;
            db.Sepet.Add(sp);
            db.SaveChanges();
            var vergideg = 1;
            if (vergi == "1") { vergideg = 0; }
            else if (vergi == "2") { vergideg = 1; }
            else if (vergi == "3") { vergideg = 8; }
            else if (vergi == "4") { vergideg = 18; }
            else if (vergi == "5") { vergideg = 26; }
            var sepetfiyat = db.CariSepet.Where(u => u.SepetAdi == sepetno.ToString()).FirstOrDefault();
            var tutar = Convert.ToDouble(txtBirimfiyatı.Text) * Convert.ToInt32(txtMiktar.Text);
            var fiyat = ((tutar * Convert.ToInt32(vergideg) / 100) + tutar) + Convert.ToDouble(sepetfiyat.Fiyat);
            sepetfiyat.Fiyat = Math.Round(fiyat, 2).ToString();
            db.SaveChanges();
            listele();
            Temizle();
        }
        private void simpleButton6_Click(object sender, EventArgs e)
        {
            var sepetsil = MessageBox.Show("Programdan çıkmak istediğinize emin misiniz?", "Çıkış", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (sepetsil == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void simpleButton7_Click(object sender, EventArgs e)
        {
            CariSepetleri cspt = new CariSepetleri();
            cspt.ShowDialog();
            //this.Visible = false;
            Form1_Load(sender, e);

        }

        private void simpleButton6_Click_1(object sender, EventArgs e)
        {

            CariSepetleri.sepetno = null;
            sepetno = Convert.ToInt32(CariSepetleri.sepetno);
            Form1_Load(sender, e);
            Temizle();
        }

        private void KisayolEkle_Click(object sender, EventArgs e)
        {
        
            var butonlar = db.ButonKisayolBilgileri.Select(u => u).ToList();
            List<ButonKisayolBilgileri> btn = new List<ButonKisayolBilgileri>();
            btn = butonlar;
            var sorgu = db.ButonKisayolBilgileri.Select(u => u).Count();
            var a = Math.Ceiling(Convert.ToDouble(sorgu) / 8);
            var b = Math.Ceiling(Convert.ToDouble(sorgu) / 5);
            for (int k = 1; a + 1 > k; k++)
            {
                if (8 * k < sorgu)
                {
                    for (int i = 0; i < 8; i++)
                    {
                        var sira = (k - 1) * 8 + i;

                        SimpleButton simpleButton = new SimpleButton();
                        Controls.Add(simpleButton);
                        simpleButton.Text = btn[Convert.ToInt32(sira)].ButonAdi;
                        simpleButton.Size = new Size(85, 85);
                        simpleButton.Visible = true;
                        simpleButton.TabStop = true;
                        simpleButton.Click += Hizlierisim_Click;
                        // simpleButton.Image = System.Drawing.Image.(btn[i - 1].ButonResim);
                        //  simpleButton.StyleController = layoutControl2;
                        simpleButton.Name = btn[Convert.ToInt32(sira)].Id.ToString();
                        simpleButton.Location = new Point(630 + (i * 92), 61 + (k * 90));
                    }
                }
                else
                {
                    var sira = (k - 1) * 8;
                    var kalan = sorgu - sira;
                    for (int i = 0; i < kalan; i++)
                    {
                        var sira1 = (k - 1) * 8 + i;

                        SimpleButton simpleButton = new SimpleButton();
                        Controls.Add(simpleButton);
                        simpleButton.Text = btn[Convert.ToInt32(sira1)].ButonAdi;
                        simpleButton.Size = new Size(85, 85);
                        simpleButton.Visible = true;
                        simpleButton.TabStop = true;
                        simpleButton.Click += Hizlierisim_Click;

                        simpleButton.Name = btn[Convert.ToInt32(sira1)].Id.ToString();
                        // simpleButton.Image = System.Drawing.Image.(btn[i - 1].ButonResim);
                        //  simpleButton.StyleController = layoutControl2;

                        simpleButton.Location = new Point(630 + (i * 92), 61 + (k * 90));
                    }
                }
            }
        }

        private void Hizlierisim_Click(object sender, EventArgs e)
        {
            SimpleButton b = (SimpleButton)sender;
            butonid = Convert.ToInt32(b.Name);
            Temizle();
            var sorgu = db.ButonKisayolBilgileri.Select(u => u).Where(u => u.Id == butonid).FirstOrDefault();
            txtBarkod.Text = sorgu.Barkod;
            txtBirimfiyatı.Text = sorgu.B_Fiyat.ToString();
            txtUrunAdi.Text = sorgu.Urunadi;
            stokkodu = sorgu.Stokkodu;

            if (sorgu.Vergiyuzdesi == "0") { StokListeForm.vergi = 1; }
            else if (sorgu.Vergiyuzdesi == "1") { StokListeForm.vergi = 2; }
            else if (sorgu.Vergiyuzdesi == "8") { StokListeForm.vergi = 3; }
            else if (sorgu.Vergiyuzdesi == "18") { StokListeForm.vergi = 4; }
            else if (sorgu.Vergiyuzdesi == "26") { StokListeForm.vergi = 5; }

        }
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            toplamfiyat = txtDigit.Text;
            sepetadi = sepetno;
            if (txtisktl.Text == "")
            {
                Indirim = 0;
            }
            else
            {
                Indirim = Convert.ToDouble(txtisktl.Text);
            }
            if (txtDigit.Text != "" && txtDigit.Text != null)
            {
                OdemeForm odm = new OdemeForm();
                odm.ShowDialog();

                if (OdemeForm.deger != 1)
                {
                    CariSepetleri.sepetno = null;
                    sepetno = Convert.ToInt32(CariSepetleri.sepetno);
                    Form1_Load(sender, e);
                    Temizle();

                }
            }
            else
            {
                MessageBox.Show("Ödeme işlemi yapılacak hesap bulunamamıştır.");
            }
        }
        int control = 0;
        int d = 0;
        int o = 0;
        int r = 0;
        int a = 0;


        private void txtCari_KeyDown_1(object sender, KeyEventArgs e)
        {

            if (e.Control) { control = 1; }
            // if (e.KeyCode == Keys.D) { d = 1; }
            if (e.KeyCode == Keys.O) { o = 1; }
            //if (e.KeyCode == Keys.R) { r = 1; }
            //if (e.KeyCode == Keys.A) { a = 1; }
            if (control == 1 /*&& d == 1*/ && o == 1 /*&& r == 1 && a == 1*/)
            {
                Sifre sf = new Sifre();
                sf.ShowDialog();
                var sifre = Sifre.sifre;
                sifre = Licence.Licence.ToMD5(sifre);
                var sifresorgu = db.Ayarlar.Where(u => u.Sifre == sifre).FirstOrDefault();
                o = 0;

                if (sifresorgu != null)
                {
                    Sifre.sifre = "";
                    AyarlarForm ayr = new AyarlarForm();
                    ayr.Show();
                    control = 0;
                    // d = 0;
                    ////r = 0;
                    ////a = 0;
                }
                else
                {
                    MessageBox.Show("Girdiniz şifre hatalıdır.Lütfen Tekrar Deneyiniz!");
                }
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            if (sepetno != 0)
            {
                Sifre sf = new Sifre();
                sf.ShowDialog();
                var sifre = Sifre.sifre;
                sifre = Licence.Licence.ToMD5(sifre);
                var sifresorgu = db.Ayarlar.Where(u => u.Sifre == sifre).FirstOrDefault();
                if (sifresorgu != null)
                {
                    var sepetsil = MessageBox.Show("Sepeti Silmek istediğinize emin misiniz?", "Sepet Sil", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                    if (sepetsil == DialogResult.Yes)
                    {
                        var sorgu = db.Sepet.Where(u => u.sep_sepetno == sepetno).ToList();
                        foreach (var item in sorgu)
                        {
                            db.Sepet.Remove(item);
                            db.SaveChanges();
                        }
                        var id = db.CariSepet.Where(u => u.SepetAdi == sepetno.ToString()).FirstOrDefault();
                        db.CariSepet.Remove(id);
                        db.SaveChanges();
                        CariSepetleri.sepetno = null;
                        sepetno = Convert.ToInt32(CariSepetleri.sepetno);
                        Form1_Load(sender, e);
                        Form1_Load(sender, e);
                    }
                }
                else
                {
                    MessageBox.Show("Girdiğiniz Şifre Hatalıdır.Lütfen tekrar deneyiniz!!");
                }
            }
            else
            {
                MessageBox.Show("Sepet seçmediğiniz için bu işlem gerçekleştirilemez!!");
            }
        }


        ///Güncelleme İşlemi 
        private void gridControl1_Click(object sender, EventArgs e)
        {
            var sepetsorgula = db.Sepet.Where(u => u.sep_sepetno == sepetno).Count();
            if (sepetsorgula != 0)
            {


                var a = gridView1.FocusedRowHandle;
                var sorgu = db.Sepet.Where(u => u.sep_musteri_kod == txtCari.Text && u.sep_sepetno == sepetno).ToList();
                var id = sorgu[a].sep_RECno;
                var data = db.Sepet.Find(id);
                txtBarkod.Text = data.sep_urun_barkod_no;
                txtBirimfiyatı.Text = data.sep_b_fiyat;
                txtUrunAdi.Text = data.sep_urun_adi;
                txtMiktar.Text = data.sep_miktar;
                txtBarkod.ReadOnly = true;
                txtUrunAdi.ReadOnly = true;
                sepet_RecNo = data.sep_RECno.ToString();
                txtsatisktl.Text = data.sep_iskonto1.ToString();



            }

        }

        private void gridControl1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                gridControl1_Click(sender, e);
            }
        }

        private void txtMiktar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                simpleButton5_Click(sender, e);

            }
        }


        private void txtiskyuz_EditValueChanged(object sender, EventArgs e)
        {

            if (txtiskyuz.Text != "")
            {
                listele();
                var iskontoyuzde = txtiskyuz.Text;
                var indirim = Math.Round(Convert.ToDouble(total) * Convert.ToDouble(iskontoyuzde) / 100, 2);
                var sonfiyat = Math.Round(Convert.ToDouble(total) - indirim, 2);
                txtDigit.Text = sonfiyat.ToString();
                txtToplam.Text = sonfiyat.ToString();
                txtisktl.Text = indirim.ToString();
            }
            else
            {
                listele();
                txtisktl.Text = "";
            }

        }

        private void textEdit1_EditValueChanged(object sender, EventArgs e)
        {
            if (txtisktl.Text != "")
            {
                listele();
                var iskontotl = txtisktl.Text;
                var sonfiyat = Math.Round(Convert.ToDouble(total) - Convert.ToDouble(iskontotl), 2);
                var iskontoyuzde = Math.Round(Convert.ToDouble(iskontotl) / Convert.ToDouble(total) * 100, 2);
                txtDigit.Text = sonfiyat.ToString();
                txtToplam.Text = sonfiyat.ToString();
                txtiskyuz.Text = iskontoyuzde.ToString();
            }
            else
            {
                listele();
                txtiskyuz.Text = "";
            }

        }

        private void txtiskyuz_Click(object sender, EventArgs e)
        {
            Sifre sf = new Sifre();
            sf.ShowDialog();
            var sifre = Sifre.sifre;
            sifre = Licence.Licence.ToMD5(sifre);
            var sifresorgu = db.Ayarlar.Where(u => u.Sifre == sifre).FirstOrDefault();
            if (sifresorgu != null)
            {
                txtiskyuz.Focus();
            }

            else
            {
                MessageBox.Show("Girdiğiniz Şifre Hatalıdır.Lütfen tekrar deneyiniz!!");
                txtBarkod.Focus();
            }
        }

        private void txtisktl_Click(object sender, EventArgs e)
        {
            Sifre sf = new Sifre();
            sf.ShowDialog();
            var sifre = Sifre.sifre;
            sifre = Licence.Licence.ToMD5(sifre);
            var sifresorgu = db.Ayarlar.Where(u => u.Sifre == sifre).FirstOrDefault();
            if (sifresorgu != null)
            {
                txtisktl.Focus();
            }

            else
            {
                MessageBox.Show("Girdiğiniz Şifre Hatalıdır.Lütfen tekrar deneyiniz!!");
                txtBarkod.Focus();
            }

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            Sifre sf = new Sifre();
            sf.ShowDialog();
            var sifre = Sifre.sifre;
            sifre = Licence.Licence.ToMD5(sifre);
            var sifresorgu = db.Ayarlar.Where(u => u.Sifre == sifre).FirstOrDefault();
            if (sifresorgu != null)
            {
                checkBox1.Checked = true;
            }

            else
            {

                MessageBox.Show("Girdiğiniz Şifre Hatalıdır.Lütfen tekrar deneyiniz!!");
                checkBox1.Checked = false;
            }
        }

        private void BtnKisayolEkle_Click(object sender, EventArgs e)
        {
            KisayolEkle ksy = new KisayolEkle();
            ksy.ShowDialog();
        }

        private void txtsatiskyuzde_EditValueChanged(object sender, EventArgs e)
        {
            if (txtsatiskyuzde.Text != "")
            {
                txtsatisktl.Enabled = false;
            }
            else
            {
                txtsatisktl.Enabled = true;
            }
        }

        private void txtsatisktl_EditValueChanged(object sender, EventArgs e)
        {
            if (txtsatisktl.Text != "")
            {
                txtsatiskyuzde.Enabled = false;
            }
            else
            {
                txtsatiskyuzde.Enabled = true;
            }
        }

        private void simpleButton9_Click(object sender, EventArgs e)
        {
            ButonSilmeFormu frm = new ButonSilmeFormu();
           frm.ShowDialog();
        }

        private void simpleButton8_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 frm = new Form1();
            frm.Show();

        }


        private void simpleButton10_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("C:\\Program Files\\Common Files\\Microsoft shared\\ink\\TabTip.exe");
        }

        private void btnTahsilatlar_Click(object sender, EventArgs e)
        {
            GunlukTahsilatlar frm = new GunlukTahsilatlar();
            frm.ShowDialog();
        }

        ///Güncelleme İşlemi  sonu
        ///

    }
}
