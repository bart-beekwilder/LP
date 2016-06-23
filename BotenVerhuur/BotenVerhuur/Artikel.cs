using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BotenVerhuur
{
    public class Artikel
    {
        public int ID { get; private set; }
        public string naam { get; private set; }
        public double prijs { get; private set; }

        public Artikel(int ID, string naam, double prijs)
        {
            this.ID = ID;
            this.naam = naam;
            this.prijs = prijs;
        }

        public override string ToString()
        {
            return naam;
        }
    }
}
