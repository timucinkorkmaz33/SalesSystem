using DevExpress.XtraGrid.Localization;
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
    public partial class CariListeForm : DevExpress.XtraEditors.XtraForm
    {
        public CariListeForm()
        {
            InitializeComponent();
        }
        public static object CariKodu;
        private void CariListeForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'carilisteler.CARI_HESAPLAR' table. You can move, or remove it, as needed.
            this.cARI_HESAPLARTableAdapter1.Fill(this.carilisteler.CARI_HESAPLAR);
            // TODO: This line of code loads data into the 'carilerDataSet.CARI_HESAPLAR' table. You can move, or remove it, as needed.
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

        private void CariSec(object sender, EventArgs e)
        {
            var satir = gridView1.FocusedRowHandle;
            var row = gridView1.GetRowCellValue(satir, "cari_kod").ToString();
            var cari_kod = row;
            CariKodu = cari_kod;
            //Form1 frm = new Form1();
            //frm.Show();
            this.Close();
        }
    }
}
