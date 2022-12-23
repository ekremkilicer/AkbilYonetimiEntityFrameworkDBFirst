
using AkbilYonetimiBussinessLayer;
using AkbilYonetimiEntityLayer.Entities;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AkbilYonetimiFormUI
{
    public partial class FrmTalimatIslemleri : Form
    {
       
        public FrmTalimatIslemleri()
        {
            InitializeComponent();
        }

        private void FrmTalimatIslemleri_Load(object sender, EventArgs e)
        {
            //
            ComboBoxaAkbilleriGetir();
            cmbBoxAkbiller.SelectedIndex = -1;
            cmbBoxAkbiller.Text = "Akbil Seçiniz";
            groupBoxBakiye.Enabled = false;

            dataGridViewTalimatlar.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            timerBekleyenTalimat.Interval = 1000;
            timerBekleyenTalimat.Enabled = true;

            GrideTalimatlariGetir();
            BekleyenTalimatSayisiniGetir();
            dataGridViewTalimatlar.ContextMenuStrip = contextMenuStripTalimatGrid;


        }

        private void BekleyenTalimatSayisiniGetir()
        {
            try
            {
               // yeni kodlar gelecek
            }
            catch (Exception hata)
            {
                MessageBox.Show("Beklenmedik bir sorun oluştu!" + hata.Message);
                // hata log
            }
        }

        private void ComboBoxaAkbilleriGetir()
        {
            try
            {
                cmbBoxAkbiller.DataSource = null; //fake //yeni kodlar gelecek
                cmbBoxAkbiller.DisplayMember = "AkbilNo";
                cmbBoxAkbiller.ValueMember = "AkbilNo";
            }
            catch (Exception hata)
            {
                MessageBox.Show("Beklenmedik bir hata oluştu! " + hata.Message);
                //TODO: loglama txt dosyasına yazdır
            }
        }

        private void cmbBoxAkbiller_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbBoxAkbiller.SelectedIndex >= 0)
            {
                groupBoxBakiye.Enabled = true;
                txtBakiye.Clear();
            }
        }

        private void btnYukle_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbBoxAkbiller.SelectedIndex < 0)
                {// throw exception'lı yazılabilir.
                    MessageBox.Show("Talimat yüklemesi için akbil seçimi zorunludur!");
                    return;
                }
                if (txtBakiye.Text == null || txtBakiye.Text == string.Empty)
                    throw new Exception("Yükleme miktarı belirtilmemiş!"); // mbox'lı yazılabilir

                int eklenenTalimatSayisi = 0; //fake // yeni kodlar gelecek

                if (eklenenTalimatSayisi > 0)
                {
                    MessageBox.Show("Yeni talimat eklendi");
                    txtBakiye.Clear();
                    cmbBoxAkbiller.SelectedIndex = -1;
                    cmbBoxAkbiller.Text = "Akbil Seçiniz...";
                    groupBoxBakiye.Enabled = false;
                    TalimatlariGetir();
                }
                else
                {
                    MessageBox.Show("Yeni talimat BAŞARISIZ!");

                }
            }

            catch (Exception hata)
            {
                MessageBox.Show("Beklenmedik bir hata oluştu" + hata.Message);
                //Todo:  hata loglanır
            }
        }

        private void TalimatlariGetir()
        {
            if (checkBoxTumunuGoster.Checked)
            {
                GrideTalimatlariGetir(true);
            }
            else
            {
                GrideTalimatlariGetir();
            }
            BekleyenTalimatSayisiniGetir();
        }

        private void GrideTalimatlariGetir(bool tumunuGoster = false)
        {
            try
            {
                if (tumunuGoster) // tumunuGoster true mu?? True ise girecek
                {
                    dataGridViewTalimatlar.DataSource = null; //fake
                }
                else
                {
                    dataGridViewTalimatlar.DataSource = null; //fake
                }

                dataGridViewTalimatlar.Columns["Id"].Visible = false;
                dataGridViewTalimatlar.Columns["KullaniciId"].Visible = false;
                dataGridViewTalimatlar.Columns["AkbilID"].Width = 200;
                dataGridViewTalimatlar.Columns["OlusturulmaTarihi"].Width = 200;
                dataGridViewTalimatlar.Columns["YuklendigiTarih"].Width = 150;

                dataGridViewTalimatlar.Columns["YuklendigiTarih"].HeaderText = "Yüklendiği Tarih";
                dataGridViewTalimatlar.Columns["OlusturulmaTarihi"].HeaderText = "Oluşturulma Tarihi";
            }
            catch (Exception hata)
            {
                MessageBox.Show("Beklenmedik hata oluştu. HATA:" + hata.Message);
            }
        }
        private void checkBoxBekleyenTalimatlar_CheckedChanged(object sender, EventArgs e)
        {
            TalimatlariGetir();
        }

        private void timerBekleyenTalimat_Tick(object sender, EventArgs e)
        {
            //eğer labelda değer varsa fontunu büyültüp küçültecek
            //if (lblBekleyenTalimat.Text != "0") 
            //{
            if (DateTime.Now.Second % 2 == 0)
            {
                lblBekleyenTalimat.Font = new Font("Microsoft Sans Serif", 40);
            }
            else
            {
                lblBekleyenTalimat.Font = new Font("Microsoft Sans Serif", 20);
            }
            //}
        }

        private void cikisyapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //sistemden çıkılacak
            GenelIslemler.GirisYapmisKullaniciAdSoyad = string.Empty;
            GenelIslemler.GirisYapmisKullaniciID = 0;
            MessageBox.Show("Güle Güle");
            FrmGiris frmGiris = new FrmGiris();
            frmGiris.Show();
            this.Close(); // deneme için yazdık 

        }

        private void anamenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmIslemleri frmIslemler = new FrmIslemleri();
            frmIslemler.Show();
            this.Close();
        }

        private void talimatigerceklestirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                // hangi talimatlar --> datagrid view multiselect yapabiliyor.
                //döngü lazım
                int sayac = 0;
                foreach (DataGridViewRow item in dataGridViewTalimatlar.SelectedRows)
                {
                   
                    //yeni kodlar gelecek
                   
                }//foreach bitti
                MessageBox.Show($"{sayac/2} adet talimat gerçekleşti.");
                TalimatlariGetir();

            }
            catch (Exception hata)
            {
                MessageBox.Show("Beklenmedik bir hata oluştu! " + hata.Message);
            }
        }

        private void talimatiSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                int sayac = 0;
                foreach (DataGridViewRow item in dataGridViewTalimatlar.SelectedRows)
                {

                    bool yuklendiMi = (bool)item.Cells["YuklendiMi"].Value;
                    var akbilNo = item.Cells["AkbilID"].Value.ToString();
                    int talimatNo = (int)item.Cells["Id"].Value;
                    if (yuklendiMi)
                    {
                        MessageBox.Show($"DİKKAT!{akbilNo}seri numaralı akbilin{talimatNo}'lu yüklemesi yapılmıştır. YÜKLENEN TALİMATI SİLEMEZSİNİZé \n İşlemlerinize devam etmek için tamama basınız");
                        continue;

                    }
                  //yeni kodlar gelecek

                }//foreach bitti
                MessageBox.Show($"{sayac}adet talimat silindi!");
                TalimatlariGetir();
                {

                }
            }
            catch (Exception hata)
            {
                MessageBox.Show("Beklenmedik bir hata oluştu! " + hata.Message);
            }
        }

      
    }
}
