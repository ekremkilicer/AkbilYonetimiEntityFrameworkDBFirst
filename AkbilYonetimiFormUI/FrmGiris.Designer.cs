
namespace AkbilYonetimiFormUI
{
    partial class FrmGiris
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
            this.lblemail = new System.Windows.Forms.Label();
            this.lblsifre = new System.Windows.Forms.Label();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.txtsifre = new System.Windows.Forms.TextBox();
            this.btnGirisYap = new System.Windows.Forms.Button();
            this.btnKayitOl = new System.Windows.Forms.Button();
            this.checkBoxBeniHatirla = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // lblemail
            // 
            this.lblemail.AutoSize = true;
            this.lblemail.BackColor = System.Drawing.Color.Transparent;
            this.lblemail.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblemail.Location = new System.Drawing.Point(12, 12);
            this.lblemail.Name = "lblemail";
            this.lblemail.Size = new System.Drawing.Size(32, 13);
            this.lblemail.TabIndex = 0;
            this.lblemail.Text = "Email";
            // 
            // lblsifre
            // 
            this.lblsifre.AutoSize = true;
            this.lblsifre.BackColor = System.Drawing.Color.Transparent;
            this.lblsifre.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblsifre.Location = new System.Drawing.Point(12, 39);
            this.lblsifre.Name = "lblsifre";
            this.lblsifre.Size = new System.Drawing.Size(28, 13);
            this.lblsifre.TabIndex = 1;
            this.lblsifre.Text = "Şifre";
            // 
            // txtemail
            // 
            this.txtemail.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtemail.Location = new System.Drawing.Point(50, 12);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(126, 20);
            this.txtemail.TabIndex = 2;
            // 
            // txtsifre
            // 
            this.txtsifre.Location = new System.Drawing.Point(50, 39);
            this.txtsifre.Name = "txtsifre";
            this.txtsifre.Size = new System.Drawing.Size(126, 20);
            this.txtsifre.TabIndex = 3;
            // 
            // btnGirisYap
            // 
            this.btnGirisYap.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnGirisYap.Location = new System.Drawing.Point(15, 65);
            this.btnGirisYap.Name = "btnGirisYap";
            this.btnGirisYap.Size = new System.Drawing.Size(80, 27);
            this.btnGirisYap.TabIndex = 4;
            this.btnGirisYap.Text = "Giriş Yap";
            this.btnGirisYap.UseVisualStyleBackColor = false;
            this.btnGirisYap.Click += new System.EventHandler(this.btnGirisYap_Click);
            // 
            // btnKayitOl
            // 
            this.btnKayitOl.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnKayitOl.Location = new System.Drawing.Point(101, 65);
            this.btnKayitOl.Name = "btnKayitOl";
            this.btnKayitOl.Size = new System.Drawing.Size(75, 27);
            this.btnKayitOl.TabIndex = 5;
            this.btnKayitOl.Text = "Kayıt Ol";
            this.btnKayitOl.UseVisualStyleBackColor = false;
            this.btnKayitOl.Click += new System.EventHandler(this.btnKayitOl_Click);
            // 
            // checkBoxBeniHatirla
            // 
            this.checkBoxBeniHatirla.AutoSize = true;
            this.checkBoxBeniHatirla.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxBeniHatirla.Location = new System.Drawing.Point(59, 98);
            this.checkBoxBeniHatirla.Name = "checkBoxBeniHatirla";
            this.checkBoxBeniHatirla.Size = new System.Drawing.Size(86, 17);
            this.checkBoxBeniHatirla.TabIndex = 6;
            this.checkBoxBeniHatirla.Text = "Beni Hatırla !";
            this.checkBoxBeniHatirla.UseVisualStyleBackColor = false;
            this.checkBoxBeniHatirla.CheckedChanged += new System.EventHandler(this.checkBoxBeniHatirla_CheckedChanged_1);
            // 
            // FrmGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AkbilYonetimiFormUI.Properties.Resources.thumb_1920_812126;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(436, 288);
            this.Controls.Add(this.checkBoxBeniHatirla);
            this.Controls.Add(this.btnKayitOl);
            this.Controls.Add(this.btnGirisYap);
            this.Controls.Add(this.txtsifre);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.lblsifre);
            this.Controls.Add(this.lblemail);
            this.Name = "FrmGiris";
            this.Text = "KULLANICI GİRİŞİ";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmGiris_FormClosed);
            this.Load += new System.EventHandler(this.FrmGiris_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblemail;
        private System.Windows.Forms.Label lblsifre;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.TextBox txtsifre;
        private System.Windows.Forms.Button btnGirisYap;
        private System.Windows.Forms.Button btnKayitOl;
        private System.Windows.Forms.CheckBox checkBoxBeniHatirla;
    }
}

