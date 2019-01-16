using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sanalmarket
{
    public partial class EtiketArama : Form
    {
        public EtiketArama()
        {
            InitializeComponent();
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
                   if (Form1.hashTableChain.EtiketGetir(Convert.ToInt32(txtEtiket.Text)) == null)
                       MessageBox.Show("kayıt bulunamadı");
                   else
                       rtbBulunanUrun.Text = Form1.hashTableChain.EtiketGetir(Convert.ToInt32(txtEtiket.Text)).UrunAdi.ToString();
            if (rtbBulunanUrun.Text == "Laptop")
            {
                object bilgiler="";
                foreach (object eleman in Form1.Marketimiz.LaptopListe)
                {
                    bilgiler += eleman+"\n";
                }
                rtbBulunanUrun.Text = "Laptop" + "\n" + bilgiler;
            }
            else if (rtbBulunanUrun.Text == "Masaüstü")
            {
                object bilgiler = "";
                foreach (object eleman in Form1.Marketimiz.MasaustuListe)
                {
                    bilgiler += eleman + "\n";
                }
                rtbBulunanUrun.Text = "Masaüstü" + "\n" + bilgiler;
            }
            else if (rtbBulunanUrun.Text == "Fırın")
            {
                object bilgiler = "";
                foreach (object eleman in Form1.Marketimiz.FirinListe)
                {
                    bilgiler += eleman + "\n";
                }
                rtbBulunanUrun.Text = "Fırın" + "\n" + bilgiler;
            }
            else if (rtbBulunanUrun.Text == "Çamaşır Makinesi")
            {
                object bilgiler = "";
                foreach (object eleman in Form1.Marketimiz.CamasirMakinesiListe)
                {
                    bilgiler += eleman + "\n";
                }
                rtbBulunanUrun.Text = "Çamaşır Makinesi" + "\n" + bilgiler;
            }
            else if (rtbBulunanUrun.Text == "Buzdolabı")
            {
                object bilgiler = "";
                foreach (object eleman in Form1.Marketimiz.BuzdolabiListe)
                {
                    bilgiler += eleman + "\n";
                }
                rtbBulunanUrun.Text = "Buzdolabı" + "\n" + bilgiler;
            }
            else if (rtbBulunanUrun.Text == "Defter")
            {
                object bilgiler = "";
                foreach (object eleman in Form1.Marketimiz.DefterListe)
                {
                    bilgiler += eleman + "\n";
                }
                rtbBulunanUrun.Text = "Defter" + "\n" + bilgiler;
            }
            else if (rtbBulunanUrun.Text == "Kalem")
            {
                object bilgiler = "";
                foreach (object eleman in Form1.Marketimiz.KalemListe)
                {
                    bilgiler += eleman + "\n";
                }
                rtbBulunanUrun.Text = "Kalem" + "\n" + bilgiler;
            }

        }
    }
}
