namespace HizliSatis_Lisans_Anahtari
{
    partial class Form1
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
            this.txtKullanim = new DevExpress.XtraEditors.TextEdit();
            this.txtMakina = new DevExpress.XtraEditors.TextEdit();
            this.txtLisans = new DevExpress.XtraEditors.TextEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.txtKullanim.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMakina.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLisans.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // txtKullanim
            // 
            this.txtKullanim.Location = new System.Drawing.Point(163, 44);
            this.txtKullanim.Name = "txtKullanim";
            this.txtKullanim.Size = new System.Drawing.Size(324, 20);
            this.txtKullanim.TabIndex = 0;
            // 
            // txtMakina
            // 
            this.txtMakina.Location = new System.Drawing.Point(163, 83);
            this.txtMakina.Name = "txtMakina";
            this.txtMakina.Size = new System.Drawing.Size(324, 20);
            this.txtMakina.TabIndex = 1;
            // 
            // txtLisans
            // 
            this.txtLisans.Location = new System.Drawing.Point(163, 124);
            this.txtLisans.Name = "txtLisans";
            this.txtLisans.Size = new System.Drawing.Size(324, 20);
            this.txtLisans.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(30, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Kullanım Kodu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(30, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Makina Kodu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(30, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Lisans Kodu";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.BackColor = System.Drawing.Color.LightSkyBlue;
            this.simpleButton1.Appearance.BackColor2 = System.Drawing.Color.RoyalBlue;
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.simpleButton1.Appearance.ForeColor = System.Drawing.Color.White;
            this.simpleButton1.Appearance.Options.UseBackColor = true;
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.Appearance.Options.UseForeColor = true;
            this.simpleButton1.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.simpleButton1.Image = global::HizliSatis_Lisans_Anahtari.Properties.Resources.ok;
            this.simpleButton1.Location = new System.Drawing.Point(423, 158);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(113, 30);
            this.simpleButton1.TabIndex = 6;
            this.simpleButton1.Text = "Gönder";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::HizliSatis_Lisans_Anahtari.Properties.Resources.main_bg;
            this.ClientSize = new System.Drawing.Size(566, 200);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtLisans);
            this.Controls.Add(this.txtMakina);
            this.Controls.Add(this.txtKullanim);
            this.Name = "Form1";
            this.Text = "Hızlı Satış Lisans Kodu";
            ((System.ComponentModel.ISupportInitialize)(this.txtKullanim.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMakina.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLisans.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit txtKullanim;
        private DevExpress.XtraEditors.TextEdit txtMakina;
        private DevExpress.XtraEditors.TextEdit txtLisans;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
    }
}

