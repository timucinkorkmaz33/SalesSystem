namespace HizliSatis
{
    partial class ButonSilmeFormu
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
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.searchLookUpEdit1 = new DevExpress.XtraEditors.GridLookUpEdit();
            this.butonKisayolBilgileriBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.butonBilgileri = new HizliSatis.ButonBilgileri();
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.butonKisayolBilgileriTableAdapter = new HizliSatis.ButonBilgileriTableAdapters.ButonKisayolBilgileriTableAdapter();
            this.colBarkod = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUrunadi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStokkodu = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.butonKisayolBilgileriBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.butonBilgileri)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            this.SuspendLayout();
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.Image = global::HizliSatis.Properties.Resources.close;
            this.simpleButton1.Location = new System.Drawing.Point(311, 21);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(84, 42);
            this.simpleButton1.TabIndex = 1;
            this.simpleButton1.Text = "Sil";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // searchLookUpEdit1
            // 
            this.searchLookUpEdit1.EditValue = "Lütfen Buton Seçiniz";
            this.searchLookUpEdit1.Location = new System.Drawing.Point(29, 33);
            this.searchLookUpEdit1.Name = "searchLookUpEdit1";
            this.searchLookUpEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.searchLookUpEdit1.Properties.DataSource = this.butonKisayolBilgileriBindingSource;
            this.searchLookUpEdit1.Properties.DisplayMember = "ButonAdi";
            this.searchLookUpEdit1.Properties.ValueMember = "Id";
            this.searchLookUpEdit1.Properties.View = this.gridLookUpEdit1View;
            this.searchLookUpEdit1.Size = new System.Drawing.Size(256, 20);
            this.searchLookUpEdit1.TabIndex = 2;
            // 
            // butonKisayolBilgileriBindingSource
            // 
            this.butonKisayolBilgileriBindingSource.DataMember = "ButonKisayolBilgileri";
            this.butonKisayolBilgileriBindingSource.DataSource = this.butonBilgileri;
            // 
            // butonBilgileri
            // 
            this.butonBilgileri.DataSetName = "ButonBilgileri";
            this.butonBilgileri.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridLookUpEdit1View
            // 
            this.gridLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colBarkod,
            this.colUrunadi,
            this.colStokkodu});
            this.gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit1View.Name = "gridLookUpEdit1View";
            this.gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // butonKisayolBilgileriTableAdapter
            // 
            this.butonKisayolBilgileriTableAdapter.ClearBeforeFill = true;
            // 
            // colBarkod
            // 
            this.colBarkod.FieldName = "Barkod";
            this.colBarkod.Name = "colBarkod";
            this.colBarkod.Visible = true;
            this.colBarkod.VisibleIndex = 0;
            // 
            // colUrunadi
            // 
            this.colUrunadi.FieldName = "Urunadi";
            this.colUrunadi.Name = "colUrunadi";
            this.colUrunadi.Visible = true;
            this.colUrunadi.VisibleIndex = 1;
            // 
            // colStokkodu
            // 
            this.colStokkodu.FieldName = "Stokkodu";
            this.colStokkodu.Name = "colStokkodu";
            this.colStokkodu.Visible = true;
            this.colStokkodu.VisibleIndex = 2;
            // 
            // ButonSilmeFormu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 98);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.searchLookUpEdit1);
            this.Name = "ButonSilmeFormu";
            this.Text = "ButonSilmeFormu";
            this.Load += new System.EventHandler(this.ButonSilmeFormu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.butonKisayolBilgileriBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.butonBilgileri)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.GridLookUpEdit searchLookUpEdit1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private ButonBilgileri butonBilgileri;
        private System.Windows.Forms.BindingSource butonKisayolBilgileriBindingSource;
        private ButonBilgileriTableAdapters.ButonKisayolBilgileriTableAdapter butonKisayolBilgileriTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colBarkod;
        private DevExpress.XtraGrid.Columns.GridColumn colUrunadi;
        private DevExpress.XtraGrid.Columns.GridColumn colStokkodu;
    }
}