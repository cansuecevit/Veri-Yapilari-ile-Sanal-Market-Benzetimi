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
    public partial class PersonelGirişi : Form
    {
        public PersonelGirişi()
        {
            InitializeComponent();
        }

        private void btnUrunArama_Click(object sender, EventArgs e)
        {
            IkiliAramaAgaciDugum kontrolblg = Form1.ikiliaramaAgaciblg.Ara(txtUrunAra.Text);
            IkiliAramaAgaciDugum kontrolbe = Form1.ikiliaramaAgacibe.Ara(txtUrunAra.Text);
            IkiliAramaAgaciDugum kontrolkrt = Form1.ikiliaramaAgacikrt.Ara(txtUrunAra.Text);

            if (cmbUrunAra.Text == "Bilgisayar")
            {
                if ( txtUrunAra.Text == kontrolblg.veri)
                    MessageBox.Show("Ürün bulundu.");
                else
                    MessageBox.Show("Ürün bulunamadı.");
            }
            else if (cmbUrunAra.Text=="Beyaz Eşya")
            {
                if (txtUrunAra.Text ==  kontrolbe.veri)
                    MessageBox.Show("Ürün bulundu.");
                else
                    MessageBox.Show("Ürün bulunamadı.");
            }
            else if (cmbUrunAra.Text == "Kırtasiye")
            {
                if (txtUrunAra.Text == kontrolkrt.veri)
                    MessageBox.Show("Ürün bulundu.");
                else
                    MessageBox.Show("Ürün bulunamadı.");
            }
        }

        private void btnUrunEkle_Click(object sender, EventArgs e)
        {
            int dugumsayisiBLG = Form1.ikiliaramaAgaciblg.DugumSayisi();
            int dugumsayisiBE = Form1.ikiliaramaAgacibe.DugumSayisi();
            int dugumsayisiKRT = Form1.ikiliaramaAgacikrt.DugumSayisi();

            if(cmbUrunEkle.Text=="Bilgisayar")
            {
                Form1.ikiliaramaAgaciblg.Ekle(txtUrunEkle.Text);
                int ydugumsayisiBLG = Form1.ikiliaramaAgaciblg.DugumSayisi();
                if(ydugumsayisiBLG>dugumsayisiBLG)
                    MessageBox.Show("Ürün eklendi.");
                else
                    MessageBox.Show("Aynı üründen var.");
            }
            else if(cmbUrunEkle.Text=="Beyaz Eşya")

            {
                Form1.ikiliaramaAgacibe.Ekle(txtUrunEkle.Text);
                int ydugumsayisiBE = Form1.ikiliaramaAgacibe.DugumSayisi();
                if(ydugumsayisiBE>dugumsayisiKRT)
                    MessageBox.Show("Ürün eklendi.");
                else
                    MessageBox.Show("Aynı üründen var.");
            }
            else if (cmbUrunEkle.Text=="Kırtasiye")
            {
                Form1.ikiliaramaAgacikrt.Ekle(txtUrunEkle.Text);
                int ydugumsayisiKRT = Form1.ikiliaramaAgacikrt.DugumSayisi();
                if(ydugumsayisiKRT>dugumsayisiKRT)
                    MessageBox.Show("Ürün eklendi.");
                else
                    MessageBox.Show("Aynı üründen var.");
            }

                
        }

        private void btnUrunSil_Click(object sender, EventArgs e)
        {
            if(cmbUrunSil.Text=="Bilgisayar")
            {
                Form1.ikiliaramaAgaciblg.Sil(txtUrunSil.Text);
                MessageBox.Show("Ürün silindi.");
            }
            else if(cmbUrunSil.Text=="Beyaz Eşya")
            {
                Form1.ikiliaramaAgacibe.Sil(txtUrunSil.Text);
                MessageBox.Show("Ürün silindi.");
            }
            else if(cmbUrunSil.Text=="Kırtasiye")
            {
                Form1.ikiliaramaAgacikrt.Sil(txtUrunSil.Text);
                MessageBox.Show("Ürün sil");
            }

        }
    }
}
