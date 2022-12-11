using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auto
{
    class Auto
    {
        private string Znacka;
        private int Spotreba;
        private DateTime Cas_Rozjezdu;
        private TimeSpan Doba_Jizdy;
        private double Ujeto_celkem;
        bool Jede;

        public Auto()
        {
            Znacka = "Mercedes Benz";
            Spotreba = 12;
            Jede = false;
            Ujeto_celkem = 0;
            Doba_Jizdy = TimeSpan.Parse("00:00:00");
        }
        public string Rozjed()
        {
            Jede = true;
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

        }

        public string CelkovaSpotreba()
        {

        }


    }
}
