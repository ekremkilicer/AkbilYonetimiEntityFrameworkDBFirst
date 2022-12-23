using System;
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
    public partial class FrmIslemleri : Form
    {
        public FrmIslemleri()
        {
            InitializeComponent();
        }

        private void btnAkbiller_Click(object sender, EventArgs e)
        {
            FrmAkbilIslemleri frmAkbilİslemleri = new FrmAkbilIslemleri();
            frmAkbilİslemleri.ShowDialog();
        }

        private void FrmIslemleri_Load(object sender, EventArgs e)
        {

        }

        private void btnTalimatIslemleri_Click(object sender, EventArgs e)
        {
            //Farklı yöntem devam ister show dialog ister show
            this.Hide();
            FrmTalimatIslemleri frmTalimatIslemleri = new FrmTalimatIslemleri();
            frmTalimatIslemleri.Show();
        }

        private void btnAyarlar_Click(object sender, EventArgs e)
        {

            this.Hide();
            FrmAyarlar frmAyarlar = new FrmAyarlar();
            frmAyarlar.Show();

        }
    }
}
