using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BotenVerhuur
{
    public class Boot
    {
        private int ID { get; }
        private string naam { get; }
        private double prijs { get; }
        private int tankInhoud { get; }

        public Boot(int ID, string naam, double prijs, int tankInhoud)
        {
            this.ID = ID;
            this.naam = naam;
            this.prijs = prijs;
            this.tankInhoud = tankInhoud;
        }

        public int GetActieradius()
        {
            int actieradius;
            actieradius = tankInhoud*15;
            return actieradius;
        }
    }
}
