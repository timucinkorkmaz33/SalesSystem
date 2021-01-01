namespace HizliSatis
{
    partial class StokListeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StokListeForm));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colsto_kod = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colsto_isim = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemButtonEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.sTOKLARBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stoklarDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stoklarDataset = new HizliSatis.StoklarDataset();
            this.stoklarDatasetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.stoklarDatasetBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.sTOKLARBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.sTOKLARTableAdapter = new HizliSatis.StoklarDatasetTableAdapters.STOKLARTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTOKLARBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stoklarDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stoklarDataset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stoklarDatasetBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stoklarDatasetBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTOKLARBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.sTOKLARBindingSource1;
            this.gridControl1.Location = new System.Drawing.Point(7, 12);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemButtonEdit1});
            this.gridControl1.Size = new System.Drawing.Size(433, 344);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.Click += new System.EventHandler(this.StokSec);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colsto_kod,
            this.colsto_isim});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsFind.AlwaysVisible = true;
            this.gridView1.OptionsFind.ClearFindOnClose = false;
            this.gridView1.OptionsFind.FindNullPrompt = "Stok ismini giriniz...";
            this.gridView1.OptionsFind.ShowCloseButton = false;
            // 
            // colsto_kod
            // 
            this.colsto_kod.Caption = "Stok Kodu";
            this.colsto_kod.FieldName = "sto_kod";
            this.colsto_kod.Name = "colsto_kod";
            this.colsto_kod.Visible = true;
            this.colsto_kod.VisibleIndex = 0;
            // 
            // colsto_isim
            // 
            this.colsto_isim.Caption = "Stok Ismi";
            this.colsto_isim.FieldName = "sto_isim";
            this.colsto_isim.Name = "colsto_isim";
            this.colsto_isim.Visible = true;
            this.colsto_isim.VisibleIndex = 1;
            // 
            // repositoryItemButtonEdit1
            // 
            this.repositoryItemButtonEdit1.AutoHeight = false;
            this.repositoryItemButtonEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, ((System.Drawing.Image)(resources.GetObject("repositoryItemButtonEdit1.Buttons"))), new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, "", null, null, true)});
            this.repositoryItemButtonEdit1.Name = "repositoryItemButtonEdit1";
            this.repositoryItemButtonEdit1.Tag = "Seç";
            this.repositoryItemButtonEdit1.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // sTOKLARBindingSource
            // 
            this.sTOKLARBindingSource.DataMember = "STOKLAR";
            // 
            // stoklarDataset
            // 
            this.stoklarDataset.DataSetName = "StoklarDataset";
            this.stoklarDataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // stoklarDatasetBindingSource1
            // 
            this.stoklarDatasetBindingSource1.DataSource = this.stoklarDataset;
            this.stoklarDatasetBindingSource1.Position = 0;
            // 
            // stoklarDatasetBindingSource2
            // 
            this.stoklarDatasetBindingSource2.DataSource = this.stoklarDataset;
            this.stoklarDatasetBindingSource2.Position = 0;
            // 
            // sTOKLARBindingSource1
            // 
            this.sTOKLARBindingSource1.DataMember = "STOKLAR";
            this.sTOKLARBindingSource1.DataSource = this.stoklarDatasetBindingSource2;
            // 
            // sTOKLARTableAdapter
            // 
            this.sTOKLARTableAdapter.ClearBeforeFill = true;
            // 
            // StokListeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 368);
            this.Controls.Add(this.gridControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "StokListeForm";
            this.Text = "Stok Listesi";
            this.Load += new System.EventHandler(this.StokListeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTOKLARBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stoklarDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stoklarDataset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stoklarDatasetBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stoklarDatasetBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTOKLARBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
       
        private System.Windows.Forms.BindingSource sTOKLARBindingSource;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonEdit1;
        private System.Windows.Forms.BindingSource stoklarDataSetBindingSource;
       
        private DevExpress.XtraGrid.Columns.GridColumn colsto_kod;
        private DevExpress.XtraGrid.Columns.GridColumn colsto_isim;
        private System.Windows.Forms.BindingSource stoklarDatasetBindingSource1;
        private StoklarDataset stoklarDataset;
        private System.Windows.Forms.BindingSource stoklarDatasetBindingSource2;
        private System.Windows.Forms.BindingSource sTOKLARBindingSource1;
        private StoklarDatasetTableAdapters.STOKLARTableAdapter sTOKLARTableAdapter;
    }
}