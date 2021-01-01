namespace HizliSatis
{
    partial class LisansForm
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
            this.txtLinans = new DevExpress.XtraEditors.TextEdit();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.txtKullanim.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMakina.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLinans.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // txtKullanim
            // 
            this.txtKullanim.Location = new System.Drawing.Point(115, 29);
            this.txtKullanim.Name = "txtKullanim";
            this.txtKullanim.Size = new System.Drawing.Size(306, 20);
            this.txtKullanim.TabIndex = 0;
            this.txtKullanim.EditValueChanged += new System.EventHandler(this.txtKullanim_EditValueChanged);
            // 
            // txtMakina
            // 
            this.txtMakina.Location = new System.Drawing.Point(115, 55);
            this.txtMakina.Name = "txtMakina";
            this.txtMakina.Size = new System.Drawing.Size(306, 20);
            this.txtMakina.TabIndex = 1;
            // 
            // txtLinans
            // 
            this.txtLinans.Location = new System.Drawing.Point(115, 81);
            this.txtLinans.Name = "txtLinans";
            this.txtLinans.Size = new System.Drawing.Size(306, 20);
            this.txtLinans.TabIndex = 2;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.BackColor = System.Drawing.Color.LightBlue;
            this.simpleButton1.Appearance.BackColor2 = System.Drawing.Color.RoyalBlue;
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.simpleButton1.Appearance.ForeColor = System.Drawing.Color.White;
            this.simpleButton1.Appearance.Options.UseBackColor = true;
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.Appearance.Options.UseForeColor = true;
            this.simpleButton1.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.simpleButton1.Image = global::HizliSatis.Properties.Resources.ok;
            this.simpleButton1.Location = new System.Drawing.Point(345, 115);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(99, 31);
            this.simpleButton1.TabIndex = 3;
            this.simpleButton1.Text = "Kaydet";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(8, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Kullanım Kodu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(8, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Makina Kodu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(8, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Lisans Kodu";
            // 
            // LisansForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 158);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.txtLinans);
            this.Controls.Add(this.txtMakina);
            this.Controls.Add(this.txtKullanim);
            this.Name = "LisansForm";
            this.Text = "LisansForm";
            this.Load += new System.EventHandler(this.LisansForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtKullanim.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMakina.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLinans.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit txtKullanim;
        private DevExpress.XtraEditors.TextEdit txtMakina;
        private DevExpress.XtraEditors.TextEdit txtLinans;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}