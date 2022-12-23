
namespace AkbilYonetimiFormUI
{
    partial class FrmKayitOl
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
            this.txtIsim = new System.Windows.Forms.TextBox();
            this.txtSoyisim = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.dtpDogumTarihi = new System.Windows.Forms.DateTimePicker();
            this.btnKayitOl = new System.Windows.Forms.Button();
            this.lblİsim = new System.Windows.Forms.Label();
            this.lblSoyisim = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblSifre = new System.Windows.Forms.Label();
            this.lblDTarihi = new System.Windows.Forms.Label();
            this.btnGiris = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtIsim
            // 
            this.txtIsim.Location = new System.Drawing.Point(60, 2);
            this.txtIsim.Name = "txtIsim";
            this.txtIsim.Size = new System.Drawing.Size(94, 20);
            this.txtIsim.TabIndex = 5;
          
            // 
            // txtSoyisim
            // 
            this.txtSoyisim.Location = new System.Drawing.Point(60, 32);
            this.txtSoyisim.Name = "txtSoyisim";
            this.txtSoyisim.Size = new System.Drawing.Size(94, 20);
            this.txtSoyisim.TabIndex = 6;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(60, 60);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(94, 20);
            this.txtEmail.TabIndex = 7;
            // 
            // txtSifre
            // 
            this.txtSifre.Location = new System.Drawing.Point(60, 91);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.Size = new System.Drawing.Size(94, 20);
            this.txtSifre.TabIndex = 8;
         
            // 
            // dtpDogumTarihi
            // 
            this.dtpDogumTarihi.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDogumTarihi.Location = new System.Drawing.Point(62, 117);
            this.dtpDogumTarihi.Name = "dtpDogumTarihi";
            this.dtpDogumTarihi.Size = new System.Drawing.Size(92, 20);
            this.dtpDogumTarihi.TabIndex = 9;
            // 
            // btnKayitOl
            // 
            this.btnKayitOl.Location = new System.Drawing.Point(101, 153);
            this.btnKayitOl.Name = "btnKayitOl";
            this.btnKayitOl.Size = new System.Drawing.Size(81, 29);
            this.btnKayitOl.TabIndex = 10;
            this.btnKayitOl.Text = "Kayıt Ol";
            this.btnKayitOl.UseVisualStyleBackColor = true;
            this.btnKayitOl.Click += new System.EventHandler(this.btnKayitOl_Click);
            // 
            // lblİsim
            // 
            this.lblİsim.AutoSize = true;
            this.lblİsim.Location = new System.Drawing.Point(12, 5);
            this.lblİsim.Name = "lblİsim";
            this.lblİsim.Size = new System.Drawing.Size(24, 13);
            this.lblİsim.TabIndex = 11;
            this.lblİsim.Text = "isim";
            // 
            // lblSoyisim
            // 
            this.lblSoyisim.AutoSize = true;
            this.lblSoyisim.Location = new System.Drawing.Point(12, 35);
            this.lblSoyisim.Name = "lblSoyisim";
            this.lblSoyisim.Size = new System.Drawing.Size(42, 13);
            this.lblSoyisim.TabIndex = 12;
            this.lblSoyisim.Text = "Soyisim";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(12, 63);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(32, 13);
            this.lblEmail.TabIndex = 13;
            this.lblEmail.Text = "Email";
            // 
            // lblSifre
            // 
            this.lblSifre.AutoSize = true;
            this.lblSifre.Location = new System.Drawing.Point(16, 91);
            this.lblSifre.Name = "lblSifre";
            this.lblSifre.Size = new System.Drawing.Size(28, 13);
            this.lblSifre.TabIndex = 14;
            this.lblSifre.Text = "Sifre";
            // 
            // lblDTarihi
            // 
            this.lblDTarihi.AutoSize = true;
            this.lblDTarihi.Location = new System.Drawing.Point(12, 121);
            this.lblDTarihi.Name = "lblDTarihi";
            this.lblDTarihi.Size = new System.Drawing.Size(44, 13);
            this.lblDTarihi.TabIndex = 15;
            this.lblDTarihi.Text = "D.Tarihi";
            // 
            // btnGiris
            // 
            this.btnGiris.Location = new System.Drawing.Point(12, 153);
            this.btnGiris.Name = "btnGiris";
            this.btnGiris.Size = new System.Drawing.Size(83, 29);
            this.btnGiris.TabIndex = 16;
            this.btnGiris.Text = "GİRİŞ YAP";
            this.btnGiris.UseVisualStyleBackColor = true;
           
            // 
            // FrmKayitOl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AkbilYonetimiFormUI.Properties.Resources.screen_6;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(447, 314);
            this.Controls.Add(this.btnGiris);
            this.Controls.Add(this.lblDTarihi);
            this.Controls.Add(this.lblSifre);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblSoyisim);
            this.Controls.Add(this.lblİsim);
            this.Controls.Add(this.btnKayitOl);
            this.Controls.Add(this.dtpDogumTarihi);
            this.Controls.Add(this.txtSifre);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtSoyisim);
            this.Controls.Add(this.txtIsim);
            this.Name = "FrmKayitOl";
            this.Text = "KAYIT OL";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmKayitOl_FormClosed);
            this.Load += new System.EventHandler(this.FrmKayitOl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtIsim;
        private System.Windows.Forms.TextBox txtSoyisim;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.DateTimePicker dtpDogumTarihi;
        private System.Windows.Forms.Button btnKayitOl;
        private System.Windows.Forms.Label lblİsim;
        private System.Windows.Forms.Label lblSoyisim;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblSifre;
        private System.Windows.Forms.Label lblDTarihi;
        private System.Windows.Forms.Button btnGiris;
    }
}