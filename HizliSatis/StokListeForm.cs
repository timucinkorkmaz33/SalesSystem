using DevExpress.XtraGrid.Localization;
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
    public partial class StokListeForm : DevExpress.XtraEditors.XtraForm
    {
        public StokListeForm()
        {
            InitializeComponent();
        }
        model2.Model1 dbmikro = new model2.Model1();
        public static object birimFiyat;
        public static object barkodKodu;
        public static object urunadi;
        public static object vergi;
        public static object stokkod;


        private void StokListeForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'stoklarDataset.STOKLAR' table. You can move, or remove it, as needed.
            this.sTOKLARTableAdapter.Fill(this.stoklarDataset.STOKLAR);
            // TODO: This line of code loads data into the 'stoklarDataSet.STOKLAR' table. You can move, or remove it, as needed.
            gridView1.OptionsBehavior.Editable = false;
           
         
            GridLocalizer.Active = new MyGridLocalizer();
        }

        public class MyGridLocalizer : GridLocalizer
        {
            public override string GetLocalizedString(GridStringId id)
            {
                switch (id)
                {
                    case GridStringId.FindControlFindButton:
                        return "Ara";
                    case GridStringId.FindControlClearButton:
                        return "Temizle";
                  
                    default:
                        return base.GetLocalizedString(id);
                }
            }
        }

        private void StokSec(object sender, EventArgs e)
        {
            var satir = gridView1.FocusedRowHandle;
            var row = gridView1.GetRowCellValue(satir, "sto_kod").ToString();
            var stokkodu = row;
            var sorgu = (from stk in dbmikro.STOKLAR
                         join br in dbmikro.BARKOD_TANIMLARI on stk.sto_kod equals br.bar_stokkodu into j1
                         from br in j1.DefaultIfEmpty()
                         where stk.sto_kod == stokkodu
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
          //                   Bakiye = dbmikro.STOK_HAREKETLERI_OZET.Where(x => x.sho_StokKodu == stk.sto_kod &&
          //                  x.sho_HareketCins != 6 &&
          //x.sho_HareketCins != 9 &&
          //x.sho_HareketCins != 15)
          //       .Sum(a => (a.sho_GirisNormal + a.sho_GirisIade) - (a.sho_CikisNormal + a.sho_CikisIade)).Value,

                             //Bakiye
                             P_Satis_Fiyat = dbmikro.STOK_SATIS_FIYAT_LISTELERI.Where(x => x.sfiyat_stokkod == stk.sto_kod && x.sfiyat_listesirano == 1).FirstOrDefault().sfiyat_fiyati,//parekende
                           //  T_Satis_Fiyat = dbmikro.STOK_SATIS_FIYAT_LISTELERI.Where(x => x.sfiyat_stokkod == stk.sto_kod && x.sfiyat_listesirano == 2).FirstOrDefault().sfiyat_fiyati,//toptan
                           //  K_Satis_Fiyat = dbmikro.STOK_SATIS_FIYAT_LISTELERI.Where(x => x.sfiyat_stokkod == stk.sto_kod && x.sfiyat_listesirano == 3).FirstOrDefault().sfiyat_fiyati//kurumlar
                         }).FirstOrDefault();

            birimFiyat = sorgu.P_Satis_Fiyat;
            barkodKodu = sorgu.BarkodNo;
            urunadi = sorgu.sto_isim;
            vergi = sorgu.sto_perakende_vergi;
            stokkod = sorgu.sto_kod;
            //Form1 frm = new Form1();
            //frm.Show();
            this.Close();
        }
    }
}
