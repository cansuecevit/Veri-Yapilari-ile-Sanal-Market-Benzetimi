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
    public partial class MusteriGirisi : Form
    {
        public MusteriGirisi()
        {
            InitializeComponent();
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            Form1.ikiliaramaAgaciblg.InOrder();
            string inorderBLG = Form1.ikiliaramaAgaciblg.DugumleriYazdir();
            Form1.ikiliaramaAgaciblg.PostOrder();
            string postorderBLG = Form1.ikiliaramaAgaciblg.DugumleriYazdir();
            Form1.ikiliaramaAgaciblg.PreOrder();
            string preorderBLG = Form1.ikiliaramaAgaciblg.DugumleriYazdir();
            Form1.ikiliaramaAgacibe.InOrder();
            string inorderBE = Form1.ikiliaramaAgacibe.DugumleriYazdir();
            Form1.ikiliaramaAgacibe.PostOrder();
            string postorderBE = Form1.ikiliaramaAgacibe.DugumleriYazdir();
            Form1.ikiliaramaAgacibe.PreOrder();
            string preorderBE = Form1.ikiliaramaAgacibe.DugumleriYazdir();
            Form1.ikiliaramaAgacikrt.InOrder();
            string inorderKRT = Form1.ikiliaramaAgacikrt.DugumleriYazdir();
            Form1.ikiliaramaAgacikrt.PostOrder();
            string postorderKRT = Form1.ikiliaramaAgacikrt.DugumleriYazdir();
            Form1.ikiliaramaAgacikrt.PreOrder();
            string preorderKRT = Form1.ikiliaramaAgacikrt.DugumleriYazdir();
            MessageBox.Show("Bilgisayar Inorder: "+inorderBLG+"\n" + "Bilgisayar PostOrder: " +postorderBLG + "\n" 
                + "Bilgisayar PreOrder: " + preorderBLG+ "\n"+"\n"+"Beyaz Eşya Inorder: " + inorderBE + "\n" + "Beyaz Eşya PostOrder: " + postorderBE + "\n"
                + "Beyaz Eşya PreOrder: " + preorderBE + "\n" + "\n" + "Kırtasiye Inorder: " + inorderKRT + "\n" + "Kırtasiye PostOrder: " + postorderKRT + "\n"
                + "Kırtasiye PreOrder: " + preorderKRT);

          
        }

        private void btnyorum_Click(object sender, EventArgs e)
        {
            Yorum_Yap yp = new Yorum_Yap();
            yp.Show();
           

        }

        private void btnetiketArama_Click(object sender, EventArgs e)
        {
            EtiketArama ea = new EtiketArama();
            ea.Show();
        }
    }
}
