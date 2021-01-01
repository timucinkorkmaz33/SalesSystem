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
    public partial class CariSepetleri : DevExpress.XtraEditors.XtraForm
    {
        SatisEnt db = new SatisEnt();
        BindingSource source = new BindingSource();
        public object Carikod;
        public object Fiyat;
        public DateTime Tarih;
        public object BekleyenSepet;
        public CariSepetleri()
        {
            InitializeComponent();
        }
        class CariSepetListesi
        {
            public string CariKodu { get; set; }
            public string SepetNo { get; set; }
            public string Fiyat { get; set; }
            public DateTime? Tarih { get; set; }

            public CariSepetListesi(string ckodu, string sno, string fyt, DateTime? trh)
            {
                CariKodu = ckodu;
                SepetNo = sno;
                Fiyat = fyt;
                Tarih = trh;
            }

        }
        private void CariSepetleri_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cariSepetler.CariSepet' table. You can move, or remove it, as needed.
            this.cariSepetTableAdapter.Fill(this.cariSepetler.CariSepet);
            // TODO: This line of code loads data into the 'cariSepetler.CariSepet' table. You can move, or remove it, as needed.
            gridView1.OptionsBehavior.Editable = false;

            //var sorgu = db.CariSepet.ToList();
            //List<CariSepetListesi> spt = new List<CariSepetListesi>();
            //foreach (var item in sorgu)
            //{
            //    var carikodu = item.Carikodu;
            //    var bekleyenSepet = item.SepetAdi.ToString();
            //    var fiyt = item.Fiyat;
            //    var tarih = item.Tarih;

            //    spt.Add(new CariSepetListesi(carikodu, bekleyenSepet, fiyt, tarih));
            //}
            //List<CariSepetListesi> list = spt;
            //source.DataSource = list;
            //gridControl1.DataSource = source;
        }
        public static object sepetno;
        private void repositoryItemButtonEdit1_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var satir = gridView1.FocusedRowHandle;
            var row = gridView1.GetRowCellValue(satir, "SepetAdi").ToString();
            sepetno = row;
            this.Close();
        }


        private void gridControl1_Click(object sender, EventArgs e)
        {
            var satir = gridView1.FocusedRowHandle;
            var row = gridView1.GetRowCellValue(satir, "SepetAdi").ToString();
            sepetno = row;
            this.Close();
        }
    }
}
