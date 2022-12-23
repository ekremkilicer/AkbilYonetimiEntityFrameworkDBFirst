
namespace AkbilYonetimiFormUI
{
    partial class FrmTalimatIslemleri
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
            this.menuStripTalimat = new System.Windows.Forms.MenuStrip();
            this.anamenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cikisyapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cmbBoxAkbiller = new System.Windows.Forms.ComboBox();
            this.dataGridViewTalimatlar = new System.Windows.Forms.DataGridView();
            this.checkBoxTumunuGoster = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblBekleyenTalimat = new System.Windows.Forms.Label();
            this.timerBekleyenTalimat = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.btnYukle = new System.Windows.Forms.Button();
            this.groupBoxBakiye = new System.Windows.Forms.GroupBox();
            this.txtBakiye = new System.Windows.Forms.TextBox();
            this.contextMenuStripTalimatGrid = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.talimatigerceklestirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.talimatiSilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripTalimat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTalimatlar)).BeginInit();
            this.groupBoxBakiye.SuspendLayout();
            this.contextMenuStripTalimatGrid.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStripTalimat
            // 
            this.menuStripTalimat.BackColor = System.Drawing.Color.DarkCyan;
            this.menuStripTalimat.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.anamenuToolStripMenuItem,
            this.cikisyapToolStripMenuItem});
            this.menuStripTalimat.Location = new System.Drawing.Point(0, 0);
            this.menuStripTalimat.Name = "menuStripTalimat";
            this.menuStripTalimat.Size = new System.Drawing.Size(486, 24);
            this.menuStripTalimat.TabIndex = 0;
            this.menuStripTalimat.Text = "menuStrip1";
            // 
            // anamenuToolStripMenuItem
            // 
            this.anamenuToolStripMenuItem.Name = "anamenuToolStripMenuItem";
            this.anamenuToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.anamenuToolStripMenuItem.Text = "ANA MENÜ";
            this.anamenuToolStripMenuItem.Click += new System.EventHandler(this.anamenuToolStripMenuItem_Click);
            // 
            // cikisyapToolStripMenuItem
            // 
            this.cikisyapToolStripMenuItem.Name = "cikisyapToolStripMenuItem";
            this.cikisyapToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.cikisyapToolStripMenuItem.Text = "ÇIKIŞ YAP";
            this.cikisyapToolStripMenuItem.Click += new System.EventHandler(this.cikisyapToolStripMenuItem_Click);
            // 
            // cmbBoxAkbiller
            // 
            this.cmbBoxAkbiller.FormattingEnabled = true;
            this.cmbBoxAkbiller.Location = new System.Drawing.Point(31, 41);
            this.cmbBoxAkbiller.Name = "cmbBoxAkbiller";
            this.cmbBoxAkbiller.Size = new System.Drawing.Size(199, 21);
            this.cmbBoxAkbiller.TabIndex = 1;
            this.cmbBoxAkbiller.Text = "Akbil Seçiniz...";
            this.cmbBoxAkbiller.SelectedIndexChanged += new System.EventHandler(this.cmbBoxAkbiller_SelectedIndexChanged);
            // 
            // dataGridViewTalimatlar
            // 
            this.dataGridViewTalimatlar.AllowUserToAddRows = false;
            this.dataGridViewTalimatlar.AllowUserToDeleteRows = false;
            this.dataGridViewTalimatlar.AllowUserToOrderColumns = true;
            this.dataGridViewTalimatlar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTalimatlar.Location = new System.Drawing.Point(31, 150);
            this.dataGridViewTalimatlar.Name = "dataGridViewTalimatlar";
            this.dataGridViewTalimatlar.ReadOnly = true;
            this.dataGridViewTalimatlar.Size = new System.Drawing.Size(444, 114);
            this.dataGridViewTalimatlar.TabIndex = 3;
            // 
            // checkBoxTumunuGoster
            // 
            this.checkBoxTumunuGoster.AutoSize = true;
            this.checkBoxTumunuGoster.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.checkBoxTumunuGoster.Location = new System.Drawing.Point(52, 120);
            this.checkBoxTumunuGoster.Name = "checkBoxTumunuGoster";
            this.checkBoxTumunuGoster.Size = new System.Drawing.Size(99, 17);
            this.checkBoxTumunuGoster.TabIndex = 4;
            this.checkBoxTumunuGoster.Text = "Tümünü Göster";
            this.checkBoxTumunuGoster.UseVisualStyleBackColor = true;
            this.checkBoxTumunuGoster.CheckedChanged += new System.EventHandler(this.checkBoxBekleyenTalimatlar_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(354, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Bekleyen Talimat";
            // 
            // lblBekleyenTalimat
            // 
            this.lblBekleyenTalimat.AutoSize = true;
            this.lblBekleyenTalimat.ForeColor = System.Drawing.Color.DarkRed;
            this.lblBekleyenTalimat.Location = new System.Drawing.Point(389, 67);
            this.lblBekleyenTalimat.Name = "lblBekleyenTalimat";
            this.lblBekleyenTalimat.Size = new System.Drawing.Size(13, 13);
            this.lblBekleyenTalimat.TabIndex = 6;
            this.lblBekleyenTalimat.Text = "0";
            // 
            // timerBekleyenTalimat
            // 
            this.timerBekleyenTalimat.Tick += new System.EventHandler(this.timerBekleyenTalimat_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Yüklenecek Bakiye";
            // 
            // btnYukle
            // 
            this.btnYukle.BackColor = System.Drawing.Color.Chartreuse;
            this.btnYukle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnYukle.Location = new System.Drawing.Point(207, 15);
            this.btnYukle.Name = "btnYukle";
            this.btnYukle.Size = new System.Drawing.Size(70, 25);
            this.btnYukle.TabIndex = 8;
            this.btnYukle.Text = "YÜKLE";
            this.btnYukle.UseVisualStyleBackColor = false;
            this.btnYukle.Click += new System.EventHandler(this.btnYukle_Click);
            // 
            // groupBoxBakiye
            // 
            this.groupBoxBakiye.Controls.Add(this.txtBakiye);
            this.groupBoxBakiye.Controls.Add(this.btnYukle);
            this.groupBoxBakiye.Controls.Add(this.label2);
            this.groupBoxBakiye.Location = new System.Drawing.Point(12, 68);
            this.groupBoxBakiye.Name = "groupBoxBakiye";
            this.groupBoxBakiye.Size = new System.Drawing.Size(277, 46);
            this.groupBoxBakiye.TabIndex = 9;
            this.groupBoxBakiye.TabStop = false;
            this.groupBoxBakiye.Text = "groupBox1";
            // 
            // txtBakiye
            // 
            this.txtBakiye.Location = new System.Drawing.Point(122, 15);
            this.txtBakiye.Name = "txtBakiye";
            this.txtBakiye.Size = new System.Drawing.Size(65, 20);
            this.txtBakiye.TabIndex = 8;
         
            // 
            // contextMenuStripTalimatGrid
            // 
            this.contextMenuStripTalimatGrid.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.talimatigerceklestirToolStripMenuItem,
            this.talimatiSilToolStripMenuItem});
            this.contextMenuStripTalimatGrid.Name = "contextMenuStripTalimatGrid";
            this.contextMenuStripTalimatGrid.Size = new System.Drawing.Size(176, 48);
            // 
            // talimatigerceklestirToolStripMenuItem
            // 
            this.talimatigerceklestirToolStripMenuItem.Name = "talimatigerceklestirToolStripMenuItem";
            this.talimatigerceklestirToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.talimatigerceklestirToolStripMenuItem.Text = "talimatiGerceklestir";
            this.talimatigerceklestirToolStripMenuItem.Click += new System.EventHandler(this.talimatigerceklestirToolStripMenuItem_Click);
            // 
            // talimatiSilToolStripMenuItem
            // 
            this.talimatiSilToolStripMenuItem.Name = "talimatiSilToolStripMenuItem";
            this.talimatiSilToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.talimatiSilToolStripMenuItem.Text = "talimatiSil";
            this.talimatiSilToolStripMenuItem.Click += new System.EventHandler(this.talimatiSilToolStripMenuItem_Click);
            // 
            // FrmTalimatIslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 287);
            this.Controls.Add(this.groupBoxBakiye);
            this.Controls.Add(this.lblBekleyenTalimat);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkBoxTumunuGoster);
            this.Controls.Add(this.dataGridViewTalimatlar);
            this.Controls.Add(this.cmbBoxAkbiller);
            this.Controls.Add(this.menuStripTalimat);
            this.MainMenuStrip = this.menuStripTalimat;
            this.Name = "FrmTalimatIslemleri";
            this.Text = "TALİMAT İŞLEMLERİ";
            this.Load += new System.EventHandler(this.FrmTalimatIslemleri_Load);
            this.menuStripTalimat.ResumeLayout(false);
            this.menuStripTalimat.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTalimatlar)).EndInit();
            this.groupBoxBakiye.ResumeLayout(false);
            this.groupBoxBakiye.PerformLayout();
            this.contextMenuStripTalimatGrid.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripTalimat;
        private System.Windows.Forms.ComboBox cmbBoxAkbiller;
        private System.Windows.Forms.ToolStripMenuItem anamenuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cikisyapToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridViewTalimatlar;
        private System.Windows.Forms.CheckBox checkBoxTumunuGoster;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblBekleyenTalimat;
        private System.Windows.Forms.Timer timerBekleyenTalimat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnYukle;
        private System.Windows.Forms.GroupBox groupBoxBakiye;
        private System.Windows.Forms.TextBox txtBakiye;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripTalimatGrid;
        private System.Windows.Forms.ToolStripMenuItem talimatigerceklestirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem talimatiSilToolStripMenuItem;
    }
}