namespace HizliSatis
{
    partial class GunlukTahsilatlar
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
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GunlukTahsilatlar));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.repositoryItemButtonEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.tahsilatlarDataset = new HizliSatis.TahsilatlarDataset();
            this.tahsilatBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tahsilatTableAdapter = new HizliSatis.TahsilatlarDatasetTableAdapters.TahsilatTableAdapter();
            this.tahsilatBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.colsat_evrak_seri = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colsat_evrak_sira = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOdenen_Meblag = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colsat_indirimMiktar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colsat_musteri_kod = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colsat_tarih = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colsat_toplam = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tahsilatlarDataset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tahsilatBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tahsilatBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.tahsilatBindingSource1;
            gridLevelNode1.RelationName = "Level1";
            this.gridControl1.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.gridControl1.Location = new System.Drawing.Point(12, 12);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemButtonEdit1});
            this.gridControl1.Size = new System.Drawing.Size(552, 311);
            this.gridControl1.TabIndex = 1;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colsat_evrak_seri,
            this.colsat_evrak_sira,
            this.colOdenen_Meblag,
            this.colsat_indirimMiktar,
            this.colsat_musteri_kod,
            this.colsat_tarih,
            this.colsat_toplam});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsFind.AlwaysVisible = true;
            this.gridView1.OptionsFind.ClearFindOnClose = false;
            this.gridView1.OptionsFind.FindNullPrompt = "Stok ismini giriniz...";
            this.gridView1.OptionsFind.ShowCloseButton = false;
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
            // tahsilatlarDataset
            // 
            this.tahsilatlarDataset.DataSetName = "TahsilatlarDataset";
            this.tahsilatlarDataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tahsilatBindingSource
            // 
            this.tahsilatBindingSource.DataMember = "Tahsilat";
            this.tahsilatBindingSource.DataSource = this.tahsilatlarDataset;
            // 
            // tahsilatTableAdapter
            // 
            this.tahsilatTableAdapter.ClearBeforeFill = true;
            // 
            // tahsilatBindingSource1
            // 
            this.tahsilatBindingSource1.DataMember = "Tahsilat";
            this.tahsilatBindingSource1.DataSource = this.tahsilatlarDataset;
            // 
            // colsat_evrak_seri
            // 
            this.colsat_evrak_seri.FieldName = "sat_evrak_seri";
            this.colsat_evrak_seri.Name = "colsat_evrak_seri";
            this.colsat_evrak_seri.Visible = true;
            this.colsat_evrak_seri.VisibleIndex = 1;
            // 
            // colsat_evrak_sira
            // 
            this.colsat_evrak_sira.FieldName = "sat_evrak_sira";
            this.colsat_evrak_sira.Name = "colsat_evrak_sira";
            this.colsat_evrak_sira.Visible = true;
            this.colsat_evrak_sira.VisibleIndex = 2;
            // 
            // colOdenen_Meblag
            // 
            this.colOdenen_Meblag.FieldName = "Odenen_Meblag";
            this.colOdenen_Meblag.Name = "colOdenen_Meblag";
            this.colOdenen_Meblag.Visible = true;
            this.colOdenen_Meblag.VisibleIndex = 4;
            // 
            // colsat_indirimMiktar
            // 
            this.colsat_indirimMiktar.FieldName = "sat_indirimMiktar";
            this.colsat_indirimMiktar.Name = "colsat_indirimMiktar";
            this.colsat_indirimMiktar.Visible = true;
            this.colsat_indirimMiktar.VisibleIndex = 3;
            // 
            // colsat_musteri_kod
            // 
            this.colsat_musteri_kod.FieldName = "sat_musteri_kod";
            this.colsat_musteri_kod.Name = "colsat_musteri_kod";
            this.colsat_musteri_kod.Visible = true;
            this.colsat_musteri_kod.VisibleIndex = 0;
            // 
            // colsat_tarih
            // 
            this.colsat_tarih.FieldName = "sat_tarih";
            this.colsat_tarih.Name = "colsat_tarih";
            this.colsat_tarih.Visible = true;
            this.colsat_tarih.VisibleIndex = 5;
            // 
            // colsat_toplam
            // 
            this.colsat_toplam.FieldName = "sat_toplam";
            this.colsat_toplam.Name = "colsat_toplam";
            this.colsat_toplam.Visible = true;
            this.colsat_toplam.VisibleIndex = 6;
            // 
            // GunlukTahsilatlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 335);
            this.Controls.Add(this.gridControl1);
            this.Name = "GunlukTahsilatlar";
            this.Text = "GunlukTahsilatlat";
            this.Load += new System.EventHandler(this.GunlukTahsilatlar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tahsilatlarDataset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tahsilatBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tahsilatBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonEdit1;
        private TahsilatlarDataset tahsilatlarDataset;
        private System.Windows.Forms.BindingSource tahsilatBindingSource;
        private TahsilatlarDatasetTableAdapters.TahsilatTableAdapter tahsilatTableAdapter;
        private System.Windows.Forms.BindingSource tahsilatBindingSource1;
        private DevExpress.XtraGrid.Columns.GridColumn colsat_evrak_seri;
        private DevExpress.XtraGrid.Columns.GridColumn colsat_evrak_sira;
        private DevExpress.XtraGrid.Columns.GridColumn colOdenen_Meblag;
        private DevExpress.XtraGrid.Columns.GridColumn colsat_indirimMiktar;
        private DevExpress.XtraGrid.Columns.GridColumn colsat_musteri_kod;
        private DevExpress.XtraGrid.Columns.GridColumn colsat_tarih;
        private DevExpress.XtraGrid.Columns.GridColumn colsat_toplam;
    }
}