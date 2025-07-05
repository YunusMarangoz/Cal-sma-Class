using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calısma_Class
{
    public class Arac
    {
        public string Marka;
        public string Model;
        public int ModelYil;
        public int Yakittipi;
        public string? Vitestipi;
        public decimal AlısFiyat;
        public decimal SatisFiyat;
        public decimal MaxindirimTutar;
        public decimal Fiyat;
        public Arac() 
        { }
       public Arac(string _Marka,string _Model)
        { 
            Marka = _Marka;
            Model = _Model; 
        }
        public Arac(string _Marka, string _Model,int _modelYil)
        {
            Marka = _Marka;
            Model = _Model;
            ModelYil = _modelYil;
        }
        public Arac(string marka, string model, int modelYil, int yakittipi, string vitestipi, decimal alısFiyat, decimal satisFiyat, decimal maxindirimTutar, decimal fiyat) : this(marka, model)
        {
            ModelYil = modelYil;
            Yakittipi = yakittipi;
            Vitestipi = vitestipi;
            AlısFiyat = alısFiyat;
            SatisFiyat = satisFiyat;
            MaxindirimTutar = maxindirimTutar;
            Fiyat = fiyat;
        }
        public void BilgileriGoruntule()
        {
            Console.WriteLine( $"MArka: {Marka}, Model: {Model}, Model Yıl: {ModelYil}");
        }
        public void FiyatAta(decimal _fiyat)
        {
            decimal Fiyathesap = SatisFiyat - MaxindirimTutar;
            if (_fiyat < Fiyathesap)
            {
                Console.WriteLine( "Geçersiz Fiyat Girişi Yaptınız");
            }
            else
                Fiyat=_fiyat;
        }
    }
}
