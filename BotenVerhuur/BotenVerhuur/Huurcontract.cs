using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BotenVerhuur
{
    public class Huurcontract
    {
        public int ID { get; private set; }
        public DateTime StartDate { get; private set; }
        public  DateTime EndDate { get; private set; }
        public  Huurder huurder { get; private set; }
        public  List<Artikel> artikelen { get; private set; }
        public  List<Water> wateren { get; private set; }
        public  List<Boot> boten { get; private set; }

        public Huurcontract(Huurder huurder)
        {
            this.huurder = huurder;
            artikelen = new List<Artikel>();
            wateren = new List<Water>();
            boten = new List<Boot>();
        }
        public Huurcontract(int ID, Huurder huurder)
        {
            this.ID = ID;
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
