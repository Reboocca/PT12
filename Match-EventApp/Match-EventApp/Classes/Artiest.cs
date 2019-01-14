using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Match_EventApp.Classes
{
    class Artiest
    {
        private string Naam;

        public Artiest(string n)
        {
            Naam = n;
        }

        public string getName
        {
            get { return Naam; }
        }
    }
}
