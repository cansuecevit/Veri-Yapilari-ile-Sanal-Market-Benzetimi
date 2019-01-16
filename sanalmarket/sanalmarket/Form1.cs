using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace sanalmarket
{
    public partial class Form1 : Form
    {
        public static Market Marketimiz = new Market();
        public static HashMap hashTable = new HashMap();
        public static HashMapChain hashTableChain = new HashMapChain();
        public static Etiket[] e = new Etiket[7];
        public static IkiliAramaAgaci ikiliaramaAgaciblg = new IkiliAramaAgaci();
        public static IkiliAramaAgaci ikiliaramaAgacibe = new IkiliAramaAgaci();
        public static IkiliAramaAgaci ikiliaramaAgacikrt = new IkiliAramaAgaci();

        public Form1()
        {
            InitializeComponent();
            ikiliaramaAgaciblg.Ekle("Bilgisayar");
            ikiliaramaAgaciblg.Ekle("laptop");
            ikiliaramaAgaciblg.Ekle("masaüstü");
            ikiliaramaAgacibe.Ekle("Beyaz Eşya");
            ikiliaramaAgacibe.Ekle("fırın");
            ikiliaramaAgacibe.Ekle("çamaşır makinesi");
            ikiliaramaAgacikrt.Ekle("kırtasiye");
            ikiliaramaAgacikrt.Ekle("defter");
            ikiliaramaAgacikrt.Ekle("kalem");

            for (int i = 0; i < e.Length; i++)
            {
                e[i] = new Etiket();
            }
            e[0].UrunAdi = "Laptop";
            e[1].UrunAdi = "Masaüstü";
            e[2].UrunAdi = "Buzdolabı";
            e[3].UrunAdi = "Fırın";
            e[4].UrunAdi = "Çamaşır Makinesi";
            e[5].UrunAdi = "Defter";
            e[6].UrunAdi = "Kalem";

            for (int i = 0; i < e.Length; i++)
            {
                e[i].UrunEtiketi = (i *25)+821 ;
                hashTable.EtiketEkle(e[i].UrunEtiketi, e[i]);

            }
            for (int i = 0; i < e.Length; i++)
            {

                hashTableChain.EtiketEkle(e[i].UrunEtiketi, e[i]);

            }
        }

        private void btnMusteriGirisi_Click(object sender, EventArgs e)
        {
            MusteriGirisi mg = new MusteriGirisi();
            mg.Show();
       
        }

        private void btnPersonelGirisi_Click(object sender, EventArgs e)
        {
            PersonelGirişi pg = new PersonelGirişi();
            pg.Show();
        
        }
    }


    }

