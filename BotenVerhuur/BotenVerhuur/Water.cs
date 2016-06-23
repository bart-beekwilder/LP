using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BotenVerhuur
{
    public class Water
    {
        private int ID { get; }
        private string naam { get; }
        private double prijs { get; }
        private bool motorNodig { get; }

        public Water(int ID, string naam, double prijs, bool motorNodig)
        {
            this.ID = ID;
            this.naam = naam;
            this.prijs = prijs;
            this.motorNodig = motorNodig;
        }
    }
}
