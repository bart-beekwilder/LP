using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BotenVerhuur
{
    public class Huurder
    {
        public int ID { get; private set; }
        public string naam { get; private set; }
        public string email { get; }
        public List<Huurcontract> huurcontracten { get; private set; } 

        public Huurder(int ID, string naam, string email)
        {
            this.ID = ID;
            this.naam = naam;
            this.email = email;
            huurcontracten = new List<Huurcontract>();
        }
    }
}
