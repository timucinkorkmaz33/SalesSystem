using DevExpress.XtraEditors;
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
    public partial class OdemeForm : DevExpress.XtraEditors.XtraForm
    {
        public OdemeForm()
        {
            InitializeComponent();
        }

        SatisEnt db = new SatisEnt();


        private void Btn_Click(object sender, EventArgs e)
        {
            var deger = "1";

            var name = ((SimpleButton)sender).Name;
            if (name == "Btn_1") { deger = "1"; }
            else if (name == "Btn_2") { deger = "2"; }
            else if (name == "Btn_3") { deger = "3"; }
            else if (name == "Btn_4") { deger = "4"; }
            else if (name == "Btn_5") { deger = "5"; }
            else if (name == "Btn_6") { deger = "6"; }
            else if (name == "Btn_7") { deger = "7"; }
            else if (name == "Btn_8") { deger = "8"; }
            else if (name == "Btn_9") { deger = "9"; }
            else if (name == "Btn_0") { deger = "0"; }
            else if (name == "Btn_Nokta") { deger = ","; }


            if (textboxbelirle == 1)
            {
                txtNakit.Text += deger;
            }
            else if (textboxbelirle == 2)
            {
                txtKrediKart.Text += deger;
            }
            else if (textboxbelirle == 3)
            {
                txtSodex.Text += deger;
            }
            else if (textboxbelirle == 4)
            {
                txtAcikHesap.Text += deger;
            }
            else if (textboxbelirle == 5)
            {
                txtOdeme.Text += deger;
            }
        }

        private void Del_Click(object sender, EventArgs e)
        {
            if (textboxbelirle == 1)
            {
                var uzunluk = txtNakit.Text.Length - 1;
                if (uzunluk != -1)
                {
                    var degisken = txtNakit.Text.Substring(0, txtNakit.Text.Length - 1);
                    txtNakit.Text = degisken;
                }
            }
            else if (textboxbelirle == 2)
            {
                var uzunluk = txtKrediKart.Text.Length - 1;
                if (uzunluk != -1)
                {
                    var degisken = txtKrediKart.Text.Substring(0, txtKrediKart.Text.Length - 1);
                    txtKrediKart.Text = degisken;
                }
            }
            else if (textboxbelirle == 3)
            {
                var uzunluk = txtSodex.Text.Length - 1;
                if (uzunluk != -1)
                {
                    var degisken = txtSodex.Text.Substring(0, txtSodex.Text.Length - 1);
                    txtSodex.Text = degisken;
                }
            }
            else if (textboxbelirle == 4)
            {
                var uzunluk = txtAcikHesap.Text.Length - 1;
                if (uzunluk != -1)
                {
                    var degisken = txtAcikHesap.Text.Substring(0, txtAcikHesap.Text.Length - 1);
                    txtAcikHesap.Text = degisken;
                }
            }
            else if (textboxbelirle == 5)
            {
                var uzunluk = txtOdeme.Text.Length - 1;
                if (uzunluk != -1)
                {
                    var degisken = txtOdeme.Text.Substring(0, txtOdeme.Text.Length - 1);
                    txtOdeme.Text = degisken;
                }
            }

        }
        int textboxbelirle = 0;
        private void txtNakit_Click(object sender, EventArgs e)
        {
            textboxbelirle = 1;
        }

        private void txtKrediKart_Click(object sender, EventArgs e)
        {
            textboxbelirle = 2;
        }

        private void txtSodex_Click(object sender, EventArgs e)
        {
            textboxbelirle = 3;
        }

        private void txtAcikHesap_Click(object sender, EventArgs e)
        {
            textboxbelirle = 4;
        }
        private void txtOdeme_Click(object sender, EventArgs e)
        {
            textboxbelirle = 5;
        }

        private void OdemeForm_Load(object sender, EventArgs e)
        {
            txtDigitFiyat.Text = Form1.toplamfiyat;
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            txtNakit.Text = txtDigitFiyat.Text;
            txtDigitFiyat.Text = "0";
            txtOdeme.Focus();
            ButonlariKilitle();
        }

        private void BtnKK_Click(object sender, EventArgs e)
        {
            txtKrediKart.Text = txtDigitFiyat.Text;
            txtDigitFiyat.Text = "0";
            txtKrediKart.Focus();
            ButonlariKilitle();
        }

        private void BtnSodex_Click(object sender, EventArgs e)
        {
            txtSodex.Text = txtDigitFiyat.Text;
            txtDigitFiyat.Text = "0";
            txtSodex.Focus();
            ButonlariKilitle();
        }

        private void BtnAA_Click(object sender, EventArgs e)
        {
            txtAcikHesap.Text = txtDigitFiyat.Text;
            txtDigitFiyat.Text = "0";
            txtAcikHesap.Focus();
            ButonlariKilitle();
        }

        private void txtNakit_EditValueChanged(object sender, EventArgs e)
        {

            Tumalanlaritopla();
            if (Convert.ToDouble(txtDigitFiyat.Text) < 0)
            {
                var sonuc = (Convert.ToDouble(txtNakit.Text) + Convert.ToDouble(txtDigitFiyat.Text)).ToString();
                txtNakit.Text = sonuc;
                txtDigitFiyat.Text = "0";
                txtOdeme.Focus();
                ButonlariKilitle();
            }
        }
        private void txtKrediKart_EditValueChanged(object sender, EventArgs e)
        {

            Tumalanlaritopla();
            if (Convert.ToDouble(txtDigitFiyat.Text) < 0)
            {
                var sonuc = (Convert.ToDouble(txtKrediKart.Text) + Convert.ToDouble(txtDigitFiyat.Text)).ToString();
                txtKrediKart.Text = sonuc;
                txtDigitFiyat.Text = "0";
                txtOdeme.Focus();
                ButonlariKilitle();
            }
        }

        private void txtSodex_EditValueChanged(object sender, EventArgs e)
        {

            Tumalanlaritopla();
            if (Convert.ToDouble(txtDigitFiyat.Text) < 0)
            {
                var sonuc = (Convert.ToDouble(txtSodex.Text) + Convert.ToDouble(txtDigitFiyat.Text)).ToString();
                txtSodex.Text = sonuc;
                txtDigitFiyat.Text = "0";
                txtOdeme.Focus();
                ButonlariKilitle();
            }
        }

        private void txtAcikHesap_EditValueChanged(object sender, EventArgs e)
        {

            Tumalanlaritopla();
            if (Convert.ToDouble(txtDigitFiyat.Text) < 0)
            {
                var sonuc = (Convert.ToDouble(txtAcikHesap.Text) + Convert.ToDouble(txtDigitFiyat.Text)).ToString();
                txtAcikHesap.Text = sonuc;
                txtDigitFiyat.Text = "0";
                txtOdeme.Focus();
                ButonlariKilitle();
            }
        }
        private void Tumalanlaritopla()
        {
            double nakit = 0;
            double kkarti = 0;
            double sodex = 0;
            double ahesap = 0;

            if (txtNakit.Text == "") { nakit = 0; } else { nakit = Convert.ToDouble(txtNakit.Text); }
            if (txtKrediKart.Text == "") { kkarti = 0; } else { kkarti = Convert.ToDouble(txtKrediKart.Text); }
            if (txtSodex.Text == "") { sodex = 0; } else { sodex = Convert.ToDouble(txtSodex.Text); }
            if (txtAcikHesap.Text == "") { ahesap = 0; } else { ahesap = Convert.ToDouble(txtAcikHesap.Text); }

            double toplam = sodex + ahesap + kkarti + nakit;
            double anatoplam = Convert.ToDouble(Form1.toplamfiyat);
            txtDigitFiyat.Text = (anatoplam - toplam).ToString();
        }

        private void simpleButton6_Click(object sender, EventArgs e)
        {
            var acik = txtAcikHesap.Text; var nakit = txtNakit.Text; var sodex = txtSodex.Text; var kredikart = txtKrediKart.Text;
            if (txtAcikHesap.Text == "") { acik = "0"; }
            if (txtSodex.Text == "") { sodex = "0"; }

            if (txtNakit.Text == "") { nakit = "0"; }
            if (txtKrediKart.Text == "") { kredikart = "0"; }

            var total = Convert.ToDouble(nakit) + Convert.ToDouble(kredikart) + Convert.ToDouble(sodex) + Convert.ToDouble(acik);
            if (total == Convert.ToDouble(Form1.toplamfiyat))
            {

                if (txtNakit.Text != "" || txtKrediKart.Text != "" || txtSodex.Text != "" || txtAcikHesap.Text != "")
                {

                    var satis = db.Sepet.Where(u => u.sep_sepetno == Form1.sepetadi).ToList();
                    var ayarlar = db.Ayarlar.FirstOrDefault();
                    var evraksirasi = 0;
                    var sayac = 0;
                    var evraksira = db.Evrak_Bilgisi.OrderByDescending(u => u.Id).FirstOrDefault();
                    if (evraksira == null)
                    {
                        Evrak_Bilgisi evr = new Evrak_Bilgisi();
                        evr.Sira_No = 1;
                        evraksirasi = 1;
                        evr.Tarih = DateTime.Now;
                        db.Evrak_Bilgisi.Add(evr);
                        db.SaveChanges();
                    }
                    else
                    {
                        evraksirasi = Convert.ToInt32(evraksira.Sira_No) + 1;
                    }
                    var satirno = 0;
                    var tahsilatsatirno = 0;
                    //sat_durum=1 satıs
                    //sat_durum=2 iade


                    foreach (var sepeturunler in satis)
                    {
                        try
                        {
                            var vergideg = 1;
                            if (sepeturunler.sep_vergi == "1") { vergideg = 0; }
                            else if (sepeturunler.sep_vergi == "2") { vergideg = 1; }
                            else if (sepeturunler.sep_vergi == "3") { vergideg = 8; }
                            else if (sepeturunler.sep_vergi == "4") { vergideg = 18; }
                            else if (sepeturunler.sep_vergi == "5") { vergideg = 26; }


                            Satis st = new Satis();
                            st.sat_barkod_no = sepeturunler.sep_urun_barkod_no;
                            st.sat_b_fiyat = sepeturunler.sep_b_fiyat;
                            st.sat_cinsi = 0;
                           
                            st.sat_depo = ayarlar.Depo_Kodu;
                            st.sat_durum = Convert.ToInt32(sepeturunler.sep_durumu);
                            st.sat_evrak_seri = ayarlar.Nakit_Seri_No;/// bu kısım onemli
                            st.sat_evrak_sira = evraksirasi;
                            st.sat_miktar = Convert.ToDouble(sepeturunler.sep_miktar);
                            st.sat_musteri_kod = sepeturunler.sep_musteri_kod;
                            st.sat_plasiyer_kod = ayarlar.Plasiyer_Kodu;
                            st.sat_srm_merkezi = "";
                            st.sat_stok_kod = sepeturunler.sep_stok_kod;
                            st.sat_tarih = DateTime.Now;
                            st.sat_vergi3 = Math.Round(Form1.vergi3, 2);
                            st.sat_vergi4 = Math.Round(Form1.vergi4, 2);
                            //  st.sat_urun_adi = sepeturunler.sep_urun_adi;
                            st.sat_vergi = Convert.ToDecimal(sepeturunler.sep_vergi);
                            st.sat_vergi_tutar = Math.Round(vergideg * Convert.ToDouble(sepeturunler.sep_tutar) / 100, 2);
                            st.sat_tutar = Convert.ToDouble(sepeturunler.sep_tutar);
                            st.sat_toplam = Convert.ToDouble(sepeturunler.sep_miktar) * Convert.ToDouble(sepeturunler.sep_b_fiyat);    //Convert.ToDouble(Form1.toplamfiyat);
                            st.sat_satirno = satirno; satirno++;
                            st.sat_IndirimMiktari = Convert.ToDouble(Form1.Indirim) + Convert.ToDouble(Form1.totalindirim);
                            if (Form1.Indirim != 0)
                            {
                                var a = (st.sat_IndirimMiktari) * 100 / +(Convert.ToDouble(Form1.toplamfiyat)+ (st.sat_IndirimMiktari));
                                var x = (st.sat_toplam * a)/100;
                                st.sat_satirindirim = x;
                            }
                            else
                            {
                                st.sat_satirindirim = sepeturunler.sep_iskonto1;
                            }
                            db.Satis.Add(st);
                            db.SaveChanges();


                            if (sayac < 1)
                            {
                                if (txtNakit.Text != "" && txtNakit.Text != "0")
                                {
                                    Tahsilat th = new Tahsilat();
                                    th.sat_barkod_no = sepeturunler.sep_urun_barkod_no;
                                    th.sat_b_fiyat = sepeturunler.sep_b_fiyat;
                                    th.sat_cinsi = 0;
                                    th.sat_depo = ayarlar.Depo_Kodu;
                                    th.sat_durum = Convert.ToInt32(sepeturunler.sep_durumu);
                                    th.sat_indirimMiktar = Convert.ToDouble(Form1.Indirim) + Convert.ToDouble(Form1.totalindirim);
                                    th.sat_evrak_seri = ayarlar.Nakit_Seri_No;/// bu kısım onemli
                                    th.sat_evrak_sira = evraksirasi;
                                    th.sat_miktar = Convert.ToDouble(sepeturunler.sep_miktar);
                                    th.sat_musteri_kod = sepeturunler.sep_musteri_kod;
                                    th.sat_plasiyer_kod = ayarlar.Plasiyer_Kodu;
                                    th.sat_srm_merkezi = "";
                                    th.sat_stok_kod = sepeturunler.sep_stok_kod;
                                    th.sat_tarih = DateTime.Now;
                                    th.sat_vergi3 = Form1.vergi3;
                                    th.sat_vergi4 = Form1.vergi4;
                                    //th.sat_urun_adi = sepeturunler.sep_urun_adi;
                                    th.sat_vergi = Convert.ToDecimal(sepeturunler.sep_vergi);
                                    th.sat_vergi_tutar = vergideg * Convert.ToDouble(sepeturunler.sep_tutar) / 100;
                                    th.sat_tutar = Convert.ToDouble(sepeturunler.sep_tutar);
                                    th.sat_toplam = Convert.ToDouble(Form1.toplamfiyat);
                                    th.sat_satirno = tahsilatsatirno; tahsilatsatirno++;
                                    th.Kasa_Kodu = ayarlar.Nakit_Kasa_Kodu;
                                    th.Odenen_Meblag = Convert.ToDouble(txtNakit.Text);

                                    db.Tahsilat.Add(th);
                                    db.SaveChanges();

                                }
                                if (txtKrediKart.Text != "" && txtKrediKart.Text != "0")
                                {
                                    Tahsilat th = new Tahsilat();
                                    th.sat_barkod_no = sepeturunler.sep_urun_barkod_no;
                                    th.sat_b_fiyat = sepeturunler.sep_b_fiyat;
                                    th.sat_cinsi = 0;
                                    th.sat_depo = ayarlar.Depo_Kodu;
                                    th.sat_durum = Convert.ToInt32(sepeturunler.sep_durumu);
                                    th.sat_indirimMiktar = Convert.ToDouble(Form1.Indirim) + Convert.ToDouble(Form1.totalindirim);
                                    th.sat_evrak_seri = ayarlar.Nakit_Seri_No;/// bu kısım onemli
                                    th.sat_evrak_sira = evraksirasi;
                                    th.sat_miktar = Convert.ToDouble(sepeturunler.sep_miktar);
                                    th.sat_musteri_kod = sepeturunler.sep_musteri_kod;
                                    th.sat_plasiyer_kod = ayarlar.Plasiyer_Kodu;
                                    th.sat_srm_merkezi = "";
                                    th.sat_stok_kod = sepeturunler.sep_stok_kod;
                                    th.sat_tarih = DateTime.Now;
                                    th.sat_vergi3 = Form1.vergi3;
                                    th.sat_vergi4 = Form1.vergi4;
                                    //th.sat_urun_adi = sepeturunler.sep_urun_adi;
                                    th.sat_vergi = Convert.ToDecimal(sepeturunler.sep_vergi);
                                    th.sat_vergi_tutar = vergideg * Convert.ToDouble(sepeturunler.sep_tutar) / 100;
                                    th.sat_tutar = Convert.ToDouble(sepeturunler.sep_tutar);
                                    th.sat_toplam = Convert.ToDouble(Form1.toplamfiyat);
                                    th.sat_satirno = tahsilatsatirno; tahsilatsatirno++;
                                    th.Kasa_Kodu = ayarlar.KKart_Kasa_Kodu;
                                    th.Odenen_Meblag = Convert.ToDouble(txtKrediKart.Text);

                                    db.Tahsilat.Add(th);
                                    db.SaveChanges();

                                }

                                if (txtSodex.Text != "" && txtSodex.Text != "0")
                                {
                                    Tahsilat th = new Tahsilat();
                                    th.sat_barkod_no = sepeturunler.sep_urun_barkod_no;
                                    th.sat_b_fiyat = sepeturunler.sep_b_fiyat;
                                    th.sat_cinsi = 0;
                                    th.sat_depo = ayarlar.Depo_Kodu;
                                    th.sat_durum = Convert.ToInt32(sepeturunler.sep_durumu);
                                    th.sat_indirimMiktar = Convert.ToDouble(Form1.Indirim) + Convert.ToDouble(Form1.totalindirim);
                                    th.sat_evrak_seri = ayarlar.Nakit_Seri_No;/// bu kısım onemli
                                    th.sat_evrak_sira = evraksirasi;
                                    th.sat_miktar = Convert.ToDouble(sepeturunler.sep_miktar);
                                    th.sat_musteri_kod = sepeturunler.sep_musteri_kod;
                                    th.sat_plasiyer_kod = ayarlar.Plasiyer_Kodu;
                                    th.sat_srm_merkezi = "";
                                    th.sat_stok_kod = sepeturunler.sep_stok_kod;
                                    th.sat_tarih = DateTime.Now;
                                    th.sat_vergi3 = Form1.vergi3;
                                    th.sat_vergi4 = Form1.vergi4;
                                    //th.sat_urun_adi = sepeturunler.sep_urun_adi;
                                    th.sat_vergi = Convert.ToDecimal(sepeturunler.sep_vergi);
                                    th.sat_vergi_tutar = vergideg * Convert.ToDouble(sepeturunler.sep_tutar) / 100;
                                    th.sat_tutar = Convert.ToDouble(sepeturunler.sep_tutar);
                                    th.sat_toplam = Convert.ToDouble(Form1.toplamfiyat);
                                    th.sat_satirno = tahsilatsatirno; tahsilatsatirno++;
                                    th.Kasa_Kodu = ayarlar.Odeme_Sekil1_Kodu;
                                    th.Odenen_Meblag = Convert.ToDouble(txtSodex.Text);

                                    db.Tahsilat.Add(th);
                                    db.SaveChanges();
                                }
                                if (txtAcikHesap.Text != "" && txtAcikHesap.Text != "0")
                                {
                                    //Tahsilat th = new Tahsilat();
                                    //th.sat_barkod_no = sepeturunler.sep_urun_barkod_no;
                                    //th.sat_b_fiyat = sepeturunler.sep_b_fiyat;
                                    //th.sat_cinsi = 0;
                                    //th.sat_depo = ayarlar.Depo_Kodu;
                                    //th.sat_durum = Convert.ToInt32(sepeturunler.sep_durumu);
                                    //th.sat_indirimMiktar =Convert.ToDouble(Form1.Indirim)+ Convert.ToDouble(Form1.totalindirim);
                                    //th.sat_evrak_seri = ayarlar.Nakit_Seri_No;/// bu kısım onemli
                                    //th.sat_evrak_sira = evraksirasi;
                                    //th.sat_miktar = Convert.ToDouble(sepeturunler.sep_miktar);
                                    //th.sat_musteri_kod = sepeturunler.sep_musteri_kod;
                                    //th.sat_plasiyer_kod = ayarlar.Plasiyer_Kodu;
                                    //th.sat_srm_merkezi = "";
                                    //th.sat_stok_kod = sepeturunler.sep_stok_kod;
                                    //th.sat_tarih = DateTime.Now;
                                    //th.sat_vergi3 = Form1.vergi3;
                                    //th.sat_vergi4 = Form1.vergi4;
                                    //th.sat_urun_adi = sepeturunler.sep_urun_adi;
                                    //th.sat_vergi = Convert.ToDecimal(sepeturunler.sep_vergi);
                                    //th.sat_vergi_tutar = vergideg * Convert.ToDouble(sepeturunler.sep_tutar) / 100;
                                    //th.sat_tutar = Convert.ToDouble(sepeturunler.sep_tutar);
                                    //th.sat_toplam = Convert.ToDouble(Form1.toplamfiyat);
                                    //th.sat_satirno = tahsilatsatirno; tahsilatsatirno++;
                                    //th.Odenen_Meblag = Convert.ToDouble(txtAcikHesap.Text);

                                    //db.Tahsilat.Add(th);
                                    //db.SaveChanges();

                                }
                                sayac++;
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Hata oluştu, Sistem yöneticisine başvurunuz!!!" + '\n' + ex);
                            return;
                        }
                    }
                    Evrak_Bilgisi sorgu = db.Evrak_Bilgisi.Where(u => u.Sira_No == evraksira.Sira_No).FirstOrDefault();
                    sorgu.Sira_No = sorgu.Sira_No + 1;
                    sorgu.Tarih = DateTime.Now;
                    db.SaveChanges();
                    ///sepet listelerinin silinmesi
                    var carisepid = db.CariSepet.Where(u => u.SepetAdi == Form1.sepetadi.ToString()).FirstOrDefault().Id;
                    var cari = db.CariSepet.Find(carisepid);
                    db.CariSepet.Remove(cari);
                    db.SaveChanges();

                    var sepettekiurunler = db.Sepet.Where(u => u.sep_sepetno == Form1.sepetadi).ToList();
                    foreach (var urun in sepettekiurunler)
                    {
                        var id = db.Sepet.Find(urun.sep_RECno);
                        db.Sepet.Remove(id);
                        db.SaveChanges();
                    }
                    deger = 0;
                    MessageBox.Show("İşlem Tamamlandı");
                    this.Close();

                }
                else
                {
                    MessageBox.Show("Lütfen Ödeme Türü ve Miktarını Giriniz!!");
                }
            }
            else { MessageBox.Show("Toplam Fiyat ile toplam Ödenen miktar eşleşmemektedir."); }
        }
        public static int deger;
        private void simpleButton5_Click(object sender, EventArgs e)
        {
            deger = 1;
            this.Hide();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            if (txtNakit.Text != "" && txtNakit.Text != "0")
            {
                if (txtOdeme.Text != "" && txtOdeme.Text != "0")
                {
                    txtDigitFiyat.Text = (Convert.ToDouble(txtOdeme.Text) - Convert.ToDouble(txtNakit.Text)).ToString();
                }
                else
                {
                    txtDigitFiyat.Text = "";
                }
            }
        }

        private void txtOdeme_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                simpleButton2_Click(sender, e);
            }
        }

        private void txtOdeme_EditValueChanged(object sender, EventArgs e)
        {
            simpleButton2_Click(sender, e);
        }
        public void ButonlariKilitle()
        {
            simpleButton1.Enabled = false;
            BtnKK.Enabled = false;
            BtnAA.Enabled = false;
            BtnSodex.Enabled = false;
            txtNakit.ReadOnly = true;
            txtKrediKart.ReadOnly = true;
            txtSodex.ReadOnly = true;
            txtAcikHesap.ReadOnly = true;

        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            simpleButton1.Enabled = true;
            BtnKK.Enabled = true;
            BtnAA.Enabled = true;
            BtnSodex.Enabled = true;
            txtNakit.ReadOnly = false;
            txtKrediKart.ReadOnly = false;
            txtSodex.ReadOnly = false;
            txtAcikHesap.ReadOnly = false;
            txtNakit.Text = "";
            txtKrediKart.Text = "";
            txtAcikHesap.Text = "";
            txtSodex.Text = "";
        }
    }
}
