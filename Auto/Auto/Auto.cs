using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auto
{
    class Auto
    {
        public string Znacka;
        public int Spotreba;
        public DateTime Cas_Rozjezdu;
        public TimeSpan Doba_Jizdy;
        public double Ujeto_celkem;
        public bool Jede;
        public bool Jel_jsem_uz;
        double km;

        public Auto()
        {
            Znacka = "Mercedes Benz";
            Spotreba = 12;
            Jede = false;
            Jel_jsem_uz = false;
            Ujeto_celkem = 0;
            Doba_Jizdy = TimeSpan.Parse("00:00:00");
        }
        public string Rozjed()
        {
            Jede = true;
            Jel_jsem_uz = true;
            Cas_Rozjezdu = DateTime.Now;
            return "jeeeeeeeeeeeeedu!";
        }

        public string Zastav()
        {
            if(Jede == true)
            {
                Jede = false;
                Doba_Jizdy = DateTime.Now - Cas_Rozjezdu;
                return "stojiiiiiiiiiim!";
            }
            else
            {
                return "jeste nejedu!";
            }
        }

        public string VratUjeteKm()
        {
            if(Jel_jsem_uz == true)
            {
                km = (Doba_Jizdy.TotalSeconds * 25) / 1000;
                return "ujel jsem:" + km + "km";
            }
            else
            {
                return "jeste jsem nejel";
            }
        }

        public string CelkovaSpotreba()
        {
            if(Jel_jsem_uz == true)
            {
                double spotreba_na_metr = Spotreba / 1000000;
                double spotrebovano = (Doba_Jizdy.TotalSeconds*25) * spotreba_na_metr;
                return "spotreboval jsem:" + spotrebovano + "litru";
            }
            else
            {
                return "jeste jsem nejel";
            }
        }
        public string info()
        {
            return "znacka je Mercedes Benz, spotřeba 12 litrů na 100km";
        }
    }
}
