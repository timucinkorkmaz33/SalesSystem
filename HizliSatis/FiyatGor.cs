using HizliSatis.Entity;
using HizliSatis.Model;
using HizliSatis.ViewModel;
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
    public partial class FiyatGor : DevExpress.XtraEditors.XtraForm
    {
        public FiyatGor()
        {
            InitializeComponent();
        }
        MikroEnt db = new MikroEnt();
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            var code = txtBarkod.Text;

            var result = (from stk in db.STOKLAR
                          join br in db.BARKOD_TANIMLARI on stk.sto_kod equals br.bar_stokkodu into j1
                          from br in j1.DefaultIfEmpty()
                          where br.bar_kodu == code
                          select new StokModelView
                          {
                              sto_kod = stk.sto_kod,
                              sto_kisa_ismi = stk.sto_kisa_ismi,
                              sto_isim = stk.sto_isim,
                              sto_perakende_vergi = stk.sto_perakende_vergi,
                              BarkodNo = br.bar_kodu,
                              sto_RECno = stk.sto_RECno,
                              sto_birim1_ad = stk.sto_birim1_ad,
                              sto_birim1_katsayi = stk.sto_birim1_katsayi,
                              sto_birim2_ad = stk.sto_birim2_ad,
                              sto_birim2_katsayi = stk.sto_birim2_katsayi,
                              sto_birim3_ad = stk.sto_birim3_ad,
                              sto_birim3_katsayi = stk.sto_birim3_katsayi,
                              sto_birim4_ad = stk.sto_birim4_ad,
                              sto_birim4_katsayi = stk.sto_birim4_katsayi,
                              Alış_Fiyatı = stk.sto_standartmaliyet,
                              Bakiye = db.STOK_HAREKETLERI_OZET.Where(x => x.sho_StokKodu == stk.sto_kod &&
                             x.sho_HareketCins != 6 &&
           x.sho_HareketCins != 9 &&
           x.sho_HareketCins != 15)
                .Sum(a => (a.sho_GirisNormal + a.sho_GirisIade) - (a.sho_CikisNormal + a.sho_CikisIade)).Value,

                              //Bakiye
                              P_Satis_Fiyat = db.STOK_SATIS_FIYAT_LISTELERI.Where(x => x.sfiyat_stokkod == stk.sto_kod && x.sfiyat_listesirano == 1).FirstOrDefault().sfiyat_fiyati,//parekende
                              T_Satis_Fiyat = db.STOK_SATIS_FIYAT_LISTELERI.Where(x => x.sfiyat_stokkod == stk.sto_kod && x.sfiyat_listesirano == 2).FirstOrDefault().sfiyat_fiyati,//toptan
                              K_Satis_Fiyat = db.STOK_SATIS_FIYAT_LISTELERI.Where(x => x.sfiyat_stokkod == stk.sto_kod && x.sfiyat_listesirano == 3).FirstOrDefault().sfiyat_fiyati//kurumlar
                          }).FirstOrDefault();
            if (result != null)
            {
                txtDigit.Text = result.P_Satis_Fiyat.ToString();
                txtBakiye.Text = result.Bakiye.ToString();
                txtAdi.Text = result.sto_isim.ToString();
                txtAliş.Text = result.Alış_Fiyatı.ToString();
                txtToptan.Text = result.T_Satis_Fiyat.ToString();
            }
            else
            {
               
                MessageBox.Show(txtBarkod.Text+" barkod numaralı bir kayıt bulunamamıştır!");
                Temizle();
            }
        }
        public void Temizle()
        {
            txtDigit.Text ="";
            txtBakiye.Text = "";
            txtAdi.Text = "";
            txtAliş.Text = "";
            txtToptan.Text = "";
            txtBarkod.Text = "";
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        private void txtBarkod_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                simpleButton1_Click(sender, e);
            }
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            
            StokListeForm stk = new StokListeForm();
            stk.ShowDialog();
            if (StokListeForm.barkodKodu != null)
            {
                txtBarkod.Text = StokListeForm.barkodKodu.ToString();
                simpleButton1_Click(sender, e);
            }
        }

        private void FiyatGor_Load(object sender, EventArgs e)
        {

        }
    }
}
