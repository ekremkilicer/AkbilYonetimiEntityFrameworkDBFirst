
namespace AkbilYonetimiFormUI
{
    partial class FrmAkbilIslemleri
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
            this.menuStripAkbilIslemleri = new System.Windows.Forms.MenuStrip();
            this.anaMenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cikisyapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBoxAkbilProps = new System.Windows.Forms.GroupBox();
            this.cmbBoxAkbilTipleri = new System.Windows.Forms.ComboBox();
            this.txtAkbilSeriNo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAkbilKaydet = new System.Windows.Forms.Button();
            this.dataGridViewAkbiller = new System.Windows.Forms.DataGridView();
            this.menuStripAkbilIslemleri.SuspendLayout();
            this.groupBoxAkbilProps.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAkbiller)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStripAkbilIslemleri
            // 
            this.menuStripAkbilIslemleri.BackColor = System.Drawing.Color.Teal;
            this.menuStripAkbilIslemleri.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.anaMenuToolStripMenuItem,
            this.cikisyapToolStripMenuItem});
            this.menuStripAkbilIslemleri.Location = new System.Drawing.Point(0, 0);
            this.menuStripAkbilIslemleri.Name = "menuStripAkbilIslemleri";
            this.menuStripAkbilIslemleri.Size = new System.Drawing.Size(544, 24);
            this.menuStripAkbilIslemleri.TabIndex = 1;
            this.menuStripAkbilIslemleri.Text = "menuStrip1";
            // 
            // anaMenuToolStripMenuItem
            // 
            this.anaMenuToolStripMenuItem.Name = "anaMenuToolStripMenuItem";
            this.anaMenuToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.anaMenuToolStripMenuItem.Text = "ANA MENÜ";
            // 
            // cikisyapToolStripMenuItem
            // 
            this.cikisyapToolStripMenuItem.Name = "cikisyapToolStripMenuItem";
            this.cikisyapToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.cikisyapToolStripMenuItem.Text = "ÇIKIŞ YAP";
            this.cikisyapToolStripMenuItem.Click += new System.EventHandler(this.cikisyapToolStripMenuItem_Click);
            // 
            // groupBoxAkbilProps
            // 
            this.groupBoxAkbilProps.Controls.Add(this.cmbBoxAkbilTipleri);
            this.groupBoxAkbilProps.Controls.Add(this.txtAkbilSeriNo);
            this.groupBoxAkbilProps.Controls.Add(this.label2);
            this.groupBoxAkbilProps.Controls.Add(this.label1);
            this.groupBoxAkbilProps.Location = new System.Drawing.Point(12, 27);
            this.groupBoxAkbilProps.Name = "groupBoxAkbilProps";
            this.groupBoxAkbilProps.Size = new System.Drawing.Size(361, 127);
            this.groupBoxAkbilProps.TabIndex = 2;
            this.groupBoxAkbilProps.TabStop = false;
            this.groupBoxAkbilProps.Text = "Bilgiler";
            // 
            // cmbBoxAkbilTipleri
            // 
            this.cmbBoxAkbilTipleri.FormattingEnabled = true;
            this.cmbBoxAkbilTipleri.Location = new System.Drawing.Point(89, 67);
            this.cmbBoxAkbilTipleri.Name = "cmbBoxAkbilTipleri";
            this.cmbBoxAkbilTipleri.Size = new System.Drawing.Size(121, 21);
            this.cmbBoxAkbilTipleri.TabIndex = 3;
            // 
            // txtAkbilSeriNo
            // 
            this.txtAkbilSeriNo.Location = new System.Drawing.Point(89, 35);
            this.txtAkbilSeriNo.Name = "txtAkbilSeriNo";
            this.txtAkbilSeriNo.Size = new System.Drawing.Size(121, 20);
            this.txtAkbilSeriNo.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Akbil Tipi";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Akbil Seri No";
            // 
            // btnAkbilKaydet
            // 
            this.btnAkbilKaydet.Location = new System.Drawing.Point(399, 27);
            this.btnAkbilKaydet.Name = "btnAkbilKaydet";
            this.btnAkbilKaydet.Size = new System.Drawing.Size(86, 127);
            this.btnAkbilKaydet.TabIndex = 3;
            this.btnAkbilKaydet.Text = "Yeni Akbil Kaydet";
            this.btnAkbilKaydet.UseVisualStyleBackColor = true;
            this.btnAkbilKaydet.Click += new System.EventHandler(this.btnAkbilKaydet_Click);
            // 
            // dataGridViewAkbiller
            // 
            this.dataGridViewAkbiller.AllowUserToAddRows = false;
            this.dataGridViewAkbiller.AllowUserToDeleteRows = false;
            this.dataGridViewAkbiller.AllowUserToOrderColumns = true;
            this.dataGridViewAkbiller.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAkbiller.Location = new System.Drawing.Point(30, 171);
            this.dataGridViewAkbiller.Name = "dataGridViewAkbiller";
            this.dataGridViewAkbiller.ReadOnly = true;
            this.dataGridViewAkbiller.Size = new System.Drawing.Size(487, 87);
            this.dataGridViewAkbiller.TabIndex = 4;
            // 
            // FrmAkbilIslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 308);
            this.Controls.Add(this.dataGridViewAkbiller);
            this.Controls.Add(this.btnAkbilKaydet);
            this.Controls.Add(this.groupBoxAkbilProps);
            this.Controls.Add(this.menuStripAkbilIslemleri);
            this.MainMenuStrip = this.menuStripAkbilIslemleri;
            this.Name = "FrmAkbilIslemleri";
            this.Text = "FrmAkbilİslemleri";
            this.Load += new System.EventHandler(this.FrmAkbilIslemleri_Load);
            this.menuStripAkbilIslemleri.ResumeLayout(false);
            this.menuStripAkbilIslemleri.PerformLayout();
            this.groupBoxAkbilProps.ResumeLayout(false);
            this.groupBoxAkbilProps.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAkbiller)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripAkbilIslemleri;
        private System.Windows.Forms.ToolStripMenuItem anaMenuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cikisyapToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBoxAkbilProps;
        private System.Windows.Forms.ComboBox cmbBoxAkbilTipleri;
        private System.Windows.Forms.TextBox txtAkbilSeriNo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAkbilKaydet;
        private System.Windows.Forms.DataGridView dataGridViewAkbiller;
    }
}