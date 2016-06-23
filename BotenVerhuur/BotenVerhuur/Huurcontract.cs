using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BotenVerhuur
{
    public class Huurcontract
    {
        private int ID { get; }
        private DateTime StartDate { get; }
        private DateTime EndDate { get; }
        private Huurder huurder;
        private List<Artikel> artikelen;
        private List<Water> wateren;
        private List<Boot> boten;  

        public Huurcontract(Huurder huurder)
        {
            this.huurder = huurder;
            artikelen = new List<Artikel>();
            wateren = new List<Water>();
            boten = new List<Boot>();
        }

        public void AddArtikel(Artikel artikel)
        {
            artikelen.Add(artikel);
        }

        public void AddWater(Water water)
        {
            wateren.Add(water);
        }

        public void AddBoot(Boot boot)
        {
            boten.Add(boot);
        }

        public void ExportToTxt()
        {

        }

        public int CalcBudget(double budget)
        {
            int aantalMeren;
            return 0;
        }
    }
}
