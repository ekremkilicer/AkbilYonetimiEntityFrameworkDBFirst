using AkbilYonetimiBussinessLayer;
using AkbilYonetimiDataLayer;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AkbilYonetimiFormUI
{
    public partial class FrmAyarlar : Form
    {
        AKBİLYONETİMİDBEntities akbilYonetimi = new AKBİLYONETİMİDBEntities();
        private Kullanicilar kullanici;

        public FrmAyarlar()
        {
            InitializeComponent();
        }

        private void FrmAyarlar_Load(object sender, EventArgs e)
        {
            dtpDogumTarihi.Format = DateTimePickerFormat.Short;
            KullaniciBilgileriniDoldur();

        }
        private void KullaniciBilgileriniDoldur()
        {
            try
            {
                kullanici = akbilYonetimi.Kullanicilar.FirstOrDefault(x=>x.id==GenelIslemler.GirisYapmisKullaniciID);
                txtIsim.Text = kullanici.İsim;
                txtSoyisim.Text = kullanici.Soyisim;
                dtpDogumTarihi.Text = kullanici.DogumTarihi.ToString();


            }
            catch (Exception hata)
            {
                MessageBox.Show("Beklenmedik bir hata oluştu"+ hata.Message);
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtIsim.Text==null || txtIsim.Text==string.Empty|| txtSoyisim.Text == null || txtSoyisim.Text == string.Empty)
                {
                    MessageBox.Show("Lütfen zorunlu alanları doldurunuz!");
                    return;
                }
                kullanici.İsim = txtIsim.Text;
                kullanici.Soyisim = txtSoyisim.Text;
                kullanici.DogumTarihi = dtpDogumTarihi.Value;
                akbilYonetimi.SaveChanges();
                MessageBox.Show("Bilgileriniz Güncellendi.");


            }
            catch (Exception)
            {

                throw;
            }
        }

        private void aNAMENÜToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmIslemleri frmIslemleri = new FrmIslemleri();
            //açık olan tüm formları gizleyecek
            for (int i = 0; i < Application.OpenForms.Count; i++)
            {
                Application.OpenForms[i].Hide();
            }
            frmIslemleri.Show();
        }
    }
}
