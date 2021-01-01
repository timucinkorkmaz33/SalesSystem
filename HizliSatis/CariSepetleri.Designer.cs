namespace HizliSatis
{
    partial class CariSepetleri
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCarikodu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSepetAdi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFiyat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTarih = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.cariSepetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cariSepetler = new HizliSatis.CariSepetler();
            this.cariSepetTableAdapter = new HizliSatis.CariSepetlerTableAdapters.CariSepetTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cariSepetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cariSepetler)).BeginInit();
            this.SuspendLayout();
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCarikodu,
            this.colSepetAdi,
            this.colFiyat,
            this.colTarih});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // colCarikodu
            // 
            this.colCarikodu.Caption = "Cari Kodu";
            this.colCarikodu.FieldName = "Carikodu";
            this.colCarikodu.Name = "colCarikodu";
            this.colCarikodu.Visible = true;
            this.colCarikodu.VisibleIndex = 0;
            // 
            // colSepetAdi
            // 
            this.colSepetAdi.FieldName = "SepetAdi";
            this.colSepetAdi.Name = "colSepetAdi";
            this.colSepetAdi.Visible = true;
            this.colSepetAdi.VisibleIndex = 1;
            // 
            // colFiyat
            // 
            this.colFiyat.FieldName = "Fiyat";
            this.colFiyat.Name = "colFiyat";
            this.colFiyat.Visible = true;
            this.colFiyat.VisibleIndex = 2;
            // 
            // colTarih
            // 
            this.colTarih.FieldName = "Tarih";
            this.colTarih.Name = "colTarih";
            this.colTarih.Visible = true;
            this.colTarih.VisibleIndex = 3;
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.cariSepetBindingSource;
            this.gridControl1.Location = new System.Drawing.Point(12, 12);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(562, 322);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.Click += new System.EventHandler(this.gridControl1_Click);
            // 
            // cariSepetBindingSource
            // 
            this.cariSepetBindingSource.DataMember = "CariSepet";
            this.cariSepetBindingSource.DataSource = this.cariSepetler;
            // 
            // cariSepetler
            // 
            this.cariSepetler.DataSetName = "CariSepetler";
            this.cariSepetler.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cariSepetTableAdapter
            // 
            this.cariSepetTableAdapter.ClearBeforeFill = true;
            // 
            // CariSepetleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 346);
            this.Controls.Add(this.gridControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "CariSepetleri";
            this.Text = "Bekleyen Sepetler";
            this.Load += new System.EventHandler(this.CariSepetleri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cariSepetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cariSepetler)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colCarikodu;
        private DevExpress.XtraGrid.Columns.GridColumn colSepetAdi;
        private DevExpress.XtraGrid.Columns.GridColumn colFiyat;
        private DevExpress.XtraGrid.Columns.GridColumn colTarih;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private CariSepetler cariSepetler;
        private System.Windows.Forms.BindingSource cariSepetBindingSource;
        private CariSepetlerTableAdapters.CariSepetTableAdapter cariSepetTableAdapter;
    }
}