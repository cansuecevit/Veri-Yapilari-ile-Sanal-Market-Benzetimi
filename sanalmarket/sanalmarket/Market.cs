using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;


namespace sanalmarket
{
    public class Market
    {
        public IkiliAramaAgaci AramaAgaciBilgisayar = new IkiliAramaAgaci();
        public IkiliAramaAgaci AramaAgaciBeyazEsya = new IkiliAramaAgaci();
        public IkiliAramaAgaci AramaAgaciKirtasiye = new IkiliAramaAgaci();

        public ArrayList LaptopListe = new ArrayList();
        public ArrayList MasaustuListe = new ArrayList();

        public ArrayList CamasirMakinesiListe = new ArrayList();
        public ArrayList FirinListe = new ArrayList();
        public ArrayList BuzdolabiListe = new ArrayList();

        public ArrayList KalemListe = new ArrayList();
        public ArrayList DefterListe = new ArrayList();

        public Market()
        {
           
            AramaAgaciBilgisayar.Ekle("Bilgisayar");
            AramaAgaciBilgisayar.Ekle("Laptop");
            AramaAgaciBilgisayar.Ekle("Masaüstü");

            LaptopListe.Add("ASUS");
            LaptopListe.Add(5000);

            MasaustuListe.Add("APPLE");
            MasaustuListe.Add(12000);

            AramaAgaciBeyazEsya.Ekle("Beyaz Eşya");
            AramaAgaciBeyazEsya.Ekle("Çamaşır Makinesi");
            AramaAgaciBeyazEsya.Ekle("Fırın");
            AramaAgaciBeyazEsya.Ekle("Buzdolabı");

            CamasirMakinesiListe.Add("VESTEL");
            CamasirMakinesiListe.Add(3000);
            CamasirMakinesiListe.Add("KIRMIZI");

            FirinListe.Add("ARÇELİK");
            FirinListe.Add(500);
            FirinListe.Add("BEYAZ");

            BuzdolabiListe.Add("BEKO");
            BuzdolabiListe.Add(4500);
            BuzdolabiListe.Add("GRİ");
                
            AramaAgaciKirtasiye.Ekle("Kırtasiye");
            AramaAgaciKirtasiye.Ekle("Defter");
            AramaAgaciKirtasiye.Ekle("Kalem");

            DefterListe.Add(10);
            DefterListe.Add("MAVİ");

            KalemListe.Add(25);
            KalemListe.Add("SİYAH");
        }

    }
}
