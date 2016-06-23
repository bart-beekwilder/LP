using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BotenVerhuur
{
    public class Huurder
    {
        private int ID { get; }
        private string naam { get; }
        private string email { get; }
        private List<Huurcontract> huurcontracten { get; } 

        public Huurder(int ID, string naam, string email)
        {
            this.ID = ID;
            this.naam = naam;
            this.email = email;
            huurcontracten = new List<Huurcontract>();
        }
    }
}
