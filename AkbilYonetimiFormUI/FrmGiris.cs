
using AkbilYonetimiBussinessLayer;
using System;
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
    public partial class FrmGiris : Form
    {
        public string Email { get; set; }
        public FrmGiris()
        {
            InitializeComponent();
        }

       

        private void btnKayitOl_Click(object sender, EventArgs e)
        {
            //Bu formu gizleyeceğiz.
            //Kayıt ol formunu ekrana getireceğiz
            this.Hide();
            FrmKayitOl frmKayitOl = new FrmKayitOl();
            frmKayitOl.Show();
        }

        private void FrmGiris_Load(object sender, EventArgs e)
        {
            if (Email != null)
            {
                txtemail.Text = Email;
            }
            txtemail.TabIndex = 1;
            txtsifre.TabIndex = 2;
            btnGirisYap.TabIndex = 3;
            btnKayitOl.TabIndex = 4;

            if (AkbilYonetimiFormUI.Properties.Settings.Default.BeniHatirla)
            {
                txtemail.Text = AkbilYonetimiFormUI.Properties.Settings.Default.KullaniciEmail;
                txtsifre.Text = AkbilYonetimiFormUI.Properties.Settings.Default.KullaniciSifre;
                checkBoxBeniHatirla.Checked = true;
            }
        }

        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            GirisYap();
        }

        private void GirisYap()
        {
            try
            {
                foreach (var item in Controls)
                {
                    if (item is TextBox &&
             (((TextBox)item).Text == null || ((TextBox)item).Text == string.Empty)
                        )
                    {
                        MessageBox.Show("Zorunlu alanlar boş geçilemez! ");
                        return;
                    }
                } // foreach bitti.


                    MessageBox.Show($"Hoşgeldiniz ... {GenelIslemler.GirisYapmisKullaniciAdSoyad}");

                    //AkbilYonetimiFormUI.Properties.Settings.Default.KullaniciEmail
                    if (checkBoxBeniHatirla.Checked)
                    {
                        Properties.Settings.Default.KullaniciEmail = txtemail.Text;
                        Properties.Settings.Default.KullaniciSifre = txtsifre.Text;
                        Properties.Settings.Default.Save();
                    }

                    this.Hide();
                    FrmIslemleri frmIslemler = new FrmIslemleri();
                    frmIslemler.Show();
                

            }
            catch (Exception hata)
            {
                MessageBox.Show("Beklenmedik hata oluştu! HATA:" + hata.Message);
            }
        }

        private void txtSifre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                GirisYap();
            }
        }

        private void checkBoxBeniHatirla_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxBeniHatirla.Checked)
            {
                AkbilYonetimiFormUI.Properties.Settings.Default.BeniHatirla = true;
            }
            else
            {
                AkbilYonetimiFormUI.Properties.Settings.Default.BeniHatirla = false;
            }
        }

        private void FrmGiris_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
