using System;

namespace otoparkclass
{
    class otopark
    {
        int toplamparkalanisayisi;
        int bosparkalansayisi;
        double baslangıc;
        double bitis;
        double sonuc;
        double dkucreti;
        double toplamucret;

        const double taksi = 30.0;
        const double ticariarac = 40.0;
        const double minibus = 60.0;
        const double saatbasıucret = 50.0;

        public otopark(string plaka, int parkalani, double girissaati, double cıkıssaati) // Kurucu Metot
        {
            if (parkalani <= 0)
            {
                throw new ArgumentException("Park alanı sayısı sıfırdan büyük olmalı!");
            }

            toplamparkalanisayisi = parkalani;
            bitis = cıkıssaati;
            baslangıc = girissaati;
            bosparkalansayisi = toplamparkalanisayisi;
            toplamucret = 0;

            
        }

        public void hesabislemi()
        {
            sonuc = bitis - baslangıc;
            dkucreti = sonuc * saatbasıucret;
        }

        public void otoparkgiris(bool TAKSİ, bool TİCARİARAC)
        {
            if (bosparkalansayisi <= 0)
            {
                throw new InvalidOperationException("Boş park alanı yok!");
            }
            bosparkalansayisi = 10;
            bosparkalansayisi--;

            if (TAKSİ)
                toplamucret += taksi;
            else if (TİCARİARAC)
                toplamucret += ticariarac;
            else
                toplamucret += minibus;
        }

        public void Otoparktancıkıs(bool TAKSİ, bool TİCARİARAC, bool MİNİBÜS, int durulandk)
        {
       

            bosparkalansayisi++;

            if (TAKSİ)
            {
                toplamucret += taksi + dkucreti;
            }
            else if (TİCARİARAC)
            {
                toplamucret += ticariarac + dkucreti;
            }
            else if(MİNİBÜS)
            {
                toplamucret += minibus + dkucreti;
            }
        }

        public int bosparkalanıögrenme() // Boş park alanı sayısı
        {
            return bosparkalansayisi;
        }

        public double BakiyeOgren() // Bakiye Öğren
        {
            return toplamucret;
        }
    }
}
