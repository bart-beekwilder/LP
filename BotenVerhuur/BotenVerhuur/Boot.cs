using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BotenVerhuur
{
    public class Boot
    {
        public int ID { get; private set; }
        public string naam { get; private set; }
        public double prijs { get; private set; }
        public int tankInhoud { get; private set; }

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

        public override string ToString()
        {
            return naam;
        }
    }
}
