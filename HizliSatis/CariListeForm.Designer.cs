namespace HizliSatis
{
    partial class CariListeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CariListeForm));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.cARIHESAPLARBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.carilerDataSet = new HizliSatis.CarilerDataSet();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colcari_unvan1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcari_kod = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemButtonEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.cARI_HESAPLARTableAdapter = new HizliSatis.CarilerDataSetTableAdapters.CARI_HESAPLARTableAdapter();
            this.carilisteler = new HizliSatis.Carilisteler();
            this.cARIHESAPLARBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.cARI_HESAPLARTableAdapter1 = new HizliSatis.CarilistelerTableAdapters.CARI_HESAPLARTableAdapter();
            this.carilistelerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cARIHESAPLARBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cARIHESAPLARBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carilerDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carilisteler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cARIHESAPLARBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carilistelerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cARIHESAPLARBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.cARIHESAPLARBindingSource2;
            this.gridControl1.Location = new System.Drawing.Point(12, 12);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemButtonEdit1});
            this.gridControl1.Size = new System.Drawing.Size(520, 366);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.Click += new System.EventHandler(this.CariSec);
            // 
            // cARIHESAPLARBindingSource
            // 
            this.cARIHESAPLARBindingSource.DataMember = "CARI_HESAPLAR";
            this.cARIHESAPLARBindingSource.DataSource = this.carilerDataSet;
            // 
            // carilerDataSet
            // 
            this.carilerDataSet.DataSetName = "CarilerDataSet";
            this.carilerDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colcari_unvan1,
            this.colcari_kod});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsFind.AlwaysVisible = true;
            this.gridView1.OptionsFind.FindNullPrompt = "Cari Arayınız...";
            this.gridView1.OptionsFind.ShowCloseButton = false;
            // 
            // colcari_unvan1
            // 
            this.colcari_unvan1.Caption = "Cari Adı";
            this.colcari_unvan1.FieldName = "cari_unvan1";
            this.colcari_unvan1.Name = "colcari_unvan1";
            this.colcari_unvan1.Visible = true;
            this.colcari_unvan1.VisibleIndex = 0;
            // 
            // colcari_kod
            // 
            this.colcari_kod.Caption = "Cari Kodu";
            this.colcari_kod.FieldName = "cari_kod";
            this.colcari_kod.Name = "colcari_kod";
            this.colcari_kod.Visible = true;
            this.colcari_kod.VisibleIndex = 1;
            // 
            // repositoryItemButtonEdit1
            // 
            this.repositoryItemButtonEdit1.AutoHeight = false;
            this.repositoryItemButtonEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "Seç", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, ((System.Drawing.Image)(resources.GetObject("repositoryItemButtonEdit1.Buttons"))), new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, "", null, null, true)});
            this.repositoryItemButtonEdit1.Name = "repositoryItemButtonEdit1";
            this.repositoryItemButtonEdit1.Tag = "Seç";
            this.repositoryItemButtonEdit1.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // cARI_HESAPLARTableAdapter
            // 
            this.cARI_HESAPLARTableAdapter.ClearBeforeFill = true;
            // 
            // carilisteler
            // 
            this.carilisteler.DataSetName = "Carilisteler";
            this.carilisteler.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cARIHESAPLARBindingSource1
            // 
            this.cARIHESAPLARBindingSource1.DataMember = "CARI_HESAPLAR";
            this.cARIHESAPLARBindingSource1.DataSource = this.carilisteler;
            // 
            // cARI_HESAPLARTableAdapter1
            // 
            this.cARI_HESAPLARTableAdapter1.ClearBeforeFill = true;
            // 
            // carilistelerBindingSource
            // 
            this.carilistelerBindingSource.DataSource = this.carilisteler;
            this.carilistelerBindingSource.Position = 0;
            // 
            // cARIHESAPLARBindingSource2
            // 
            this.cARIHESAPLARBindingSource2.DataMember = "CARI_HESAPLAR";
            this.cARIHESAPLARBindingSource2.DataSource = this.carilistelerBindingSource;
            // 
            // CariListeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 390);
            this.Controls.Add(this.gridControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "CariListeForm";
            this.Text = "Cari Listesi";
            this.Load += new System.EventHandler(this.CariListeForm_Load);
            this.Click += new System.EventHandler(this.CariSec);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cARIHESAPLARBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carilerDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carilisteler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cARIHESAPLARBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carilistelerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cARIHESAPLARBindingSource2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private CarilerDataSet carilerDataSet;
        private System.Windows.Forms.BindingSource cARIHESAPLARBindingSource;
        private CarilerDataSetTableAdapters.CARI_HESAPLARTableAdapter cARI_HESAPLARTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colcari_unvan1;
        private DevExpress.XtraGrid.Columns.GridColumn colcari_kod;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonEdit1;
        private Carilisteler carilisteler;
        private System.Windows.Forms.BindingSource cARIHESAPLARBindingSource1;
        private CarilistelerTableAdapters.CARI_HESAPLARTableAdapter cARI_HESAPLARTableAdapter1;
        private System.Windows.Forms.BindingSource cARIHESAPLARBindingSource2;
        private System.Windows.Forms.BindingSource carilistelerBindingSource;
    }
}