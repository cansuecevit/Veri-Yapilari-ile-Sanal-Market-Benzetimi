using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace sanalmarket
{
    public class IkiliAramaAgaci
    {
        private IkiliAramaAgaciDugum kok;
        private string dugumler;
        public IkiliAramaAgaci()
        {

        }
        public IkiliAramaAgaci(IkiliAramaAgaciDugum kok)
        {
            this.kok = kok;
        }
        public int DugumSayisi()
        {
            return DugumSayisi(kok);
        }
        public int DugumSayisi(IkiliAramaAgaciDugum dugum)
        {
            int count = 0;
            if(dugum!=null)
            {
                count = 1;
                count += DugumSayisi(dugum.sol);
                count += DugumSayisi(dugum.sag);
            }
            return count;
        }
        
        public string DugumleriYazdir()
        {
            return dugumler;
        }
        public void PreOrder()
        {
            dugumler = "";
            PreOrderInt(kok);
        }
        private void PreOrderInt(IkiliAramaAgaciDugum dugum)
        {
            if (dugum == null)
                return;
            Ziyaret(dugum);
            PreOrderInt(dugum.sol);
            PreOrderInt(dugum.sag);
        }
        public void InOrder()
        {
            dugumler = "";
            InOrderInt(kok);
        }
        private void InOrderInt(IkiliAramaAgaciDugum dugum)
        {
            if (dugum == null)
                return;
            InOrderInt(dugum.sol);
            Ziyaret(dugum);
            InOrderInt(dugum.sag);
        }
        private void Ziyaret(IkiliAramaAgaciDugum dugum)
        {
            dugumler += dugum.veri + " ";
        }
        public void PostOrder()
        {
            dugumler = "";
            PostOrderInt(kok);
        }
        private void PostOrderInt(IkiliAramaAgaciDugum dugum)
        {
            if (dugum == null)
                return;
            PostOrderInt(dugum.sol);
            PostOrderInt(dugum.sag);
            Ziyaret(dugum);
        }
        public void Ekle(string deger)
        {
            IkiliAramaAgaciDugum tempParent = new IkiliAramaAgaciDugum();
            IkiliAramaAgaciDugum tempSearch = kok;
            while(tempSearch!=null)
            {
                tempParent = tempSearch;
                if (deger == tempSearch.veri)
                    return;
                else if (deger.Length<tempSearch.veri.Length)
                    tempSearch = tempSearch.sol;
                else
                    tempSearch = tempSearch.sag;
            }
            IkiliAramaAgaciDugum eklenecek = new IkiliAramaAgaciDugum(deger);
            if (kok == null)
                kok = eklenecek;
            else if (deger.Length<tempParent.veri.Length)
                tempParent.sol = eklenecek;
            else
                tempParent.sag = eklenecek;
        }
        public IkiliAramaAgaciDugum Ara(string anahtar)
        {
            return AraInt(kok, anahtar);
        }
        private IkiliAramaAgaciDugum AraInt(IkiliAramaAgaciDugum dugum,string anahtar)
        {
            if (dugum == null)
                return null;
            else if (dugum.veri == anahtar)
                return dugum;
            else if (dugum.veri.Length>anahtar.Length)
                return (AraInt(dugum.sol, anahtar));
            else 
                return (AraInt(dugum.sag, anahtar));
        }
        private IkiliAramaAgaciDugum Successor(IkiliAramaAgaciDugum silDugum)
        {
            IkiliAramaAgaciDugum successorParent = silDugum;
            IkiliAramaAgaciDugum successor = silDugum;
            IkiliAramaAgaciDugum current = silDugum.sag;
            while(current!=null)
            {
                successorParent = successor;
                successor = current;
                current = current.sol;
            }
            if(successor!=silDugum.sag)
            {
                successorParent.sol = successor.sag;
                successor.sag = silDugum.sag;
            }
            return successor;
        }
        public bool Sil(string deger)
        {
            IkiliAramaAgaciDugum current = kok;
            IkiliAramaAgaciDugum parent = kok;
            bool issol = true;
            while (current.veri != deger)
            {
                parent = current;
                if (deger.Length<current.veri.Length)
                {
                    issol = true;
                    current = current.sol;
                }
                else
                {
                    issol = false;
                    current = current.sag;
                }
                if (current == null)
                    return false;
            }
                if (current.sol == null && current.sag == null)
                {
                    if (current == kok)
                        kok = null;
                    else if (issol)
                        parent.sol = null;
                    else
                        parent.sag = null;
                }
                else if (current.sol == null)
                {
                    if (current == kok)
                        kok = current.sag;
                    else if (issol)
                        parent.sol = current.sag;
                    else
                        parent.sag = current.sag;
                }
                else
                {
                    IkiliAramaAgaciDugum successor = Successor(current);
                    if (current == kok)
                        kok = successor;
                    else if (issol)
                        parent.sol = successor;
                    else
                        parent.sag = successor;
                    successor.sol = current.sol;
                }
                return true;       
            }
        }
    
            
            
    }

