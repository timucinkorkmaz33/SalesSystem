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
    public partial class ButonSilmeFormu : Form
    {
        public ButonSilmeFormu()
        {
            InitializeComponent();
        }
        SatisEnt db = new SatisEnt();
        private void ButonSilmeFormu_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'butonBilgileri.ButonKisayolBilgileri' table. You can move, or remove it, as needed.
            this.butonKisayolBilgileriTableAdapter.Fill(this.butonBilgileri.ButonKisayolBilgileri);

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            var butonid = searchLookUpEdit1.EditValue;
             var sorgu = db.ButonKisayolBilgileri.Find(butonid);
            db.ButonKisayolBilgileri.Remove(sorgu);
            db.SaveChanges();
            MessageBox.Show("Buton Silme İşlemi Başarıyla Tamamlanmıştır.Lütfen Ekranı Yenilemeyi Unutmayınız!");
            this.Close();
        }
    }
}
