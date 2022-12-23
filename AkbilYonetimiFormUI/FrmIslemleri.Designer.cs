
namespace AkbilYonetimiFormUI
{
    partial class FrmIslemleri
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
            this.btnAkbiller = new System.Windows.Forms.Button();
            this.btnTalimatIslemleri = new System.Windows.Forms.Button();
            this.btnAyarlar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAkbiller
            // 
            this.btnAkbiller.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAkbiller.Location = new System.Drawing.Point(80, 35);
            this.btnAkbiller.Name = "btnAkbiller";
            this.btnAkbiller.Size = new System.Drawing.Size(103, 25);
            this.btnAkbiller.TabIndex = 0;
            this.btnAkbiller.Text = "Akbil İslemleri";
            this.btnAkbiller.UseVisualStyleBackColor = true;
            this.btnAkbiller.Click += new System.EventHandler(this.btnAkbiller_Click);
            // 
            // btnTalimatIslemleri
            // 
            this.btnTalimatIslemleri.Location = new System.Drawing.Point(80, 64);
            this.btnTalimatIslemleri.Name = "btnTalimatIslemleri";
            this.btnTalimatIslemleri.Size = new System.Drawing.Size(103, 25);
            this.btnTalimatIslemleri.TabIndex = 1;
            this.btnTalimatIslemleri.Text = "Talimat İşlemleri";
            this.btnTalimatIslemleri.UseVisualStyleBackColor = true;
            this.btnTalimatIslemleri.Click += new System.EventHandler(this.btnTalimatIslemleri_Click);
            // 
            // btnAyarlar
            // 
            this.btnAyarlar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAyarlar.Location = new System.Drawing.Point(80, 93);
            this.btnAyarlar.Name = "btnAyarlar";
            this.btnAyarlar.Size = new System.Drawing.Size(103, 25);
            this.btnAyarlar.TabIndex = 2;
            this.btnAyarlar.Text = "Ayarlar";
            this.btnAyarlar.UseVisualStyleBackColor = true;
            this.btnAyarlar.Click += new System.EventHandler(this.btnAyarlar_Click);
            // 
            // FrmIslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AkbilYonetimiFormUI.Properties.Resources._61974a8cd4f85c8c1b9a49646c4d7120;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelButton = this.btnAyarlar;
            this.ClientSize = new System.Drawing.Size(283, 191);
            this.Controls.Add(this.btnAyarlar);
            this.Controls.Add(this.btnTalimatIslemleri);
            this.Controls.Add(this.btnAkbiller);
            this.Name = "FrmIslemleri";
            this.Text = "FrmIslemleri";
            this.Load += new System.EventHandler(this.FrmIslemleri_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAkbiller;
        private System.Windows.Forms.Button btnTalimatIslemleri;
        private System.Windows.Forms.Button btnAyarlar;
    }
}