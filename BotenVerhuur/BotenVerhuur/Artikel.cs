using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BotenVerhuur
{
    public class Artikel
    {
        private int ID { get; }
        private string naam { get; }
        private double prijs { get; }

        public Artikel(int ID, string naam, double prijs)
        {
            this.ID = ID;
            this.naam = naam;
            this.prijs = prijs;
        }
    }
}
