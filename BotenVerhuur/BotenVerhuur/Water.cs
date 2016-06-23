using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BotenVerhuur
{
    public class Water
    {
        public int ID { get; private set; }
        public string naam { get; private set; }
        public double prijs { get; private set; }
        public bool motorNodig { get; private set; }

        public Water(int ID, string naam, double prijs, bool motorNodig)
        {
            this.ID = ID;
            this.naam = naam;
            this.prijs = prijs;
            this.motorNodig = motorNodig;
        }

        public override string ToString()
        {
            return naam;
        }
    }
}
