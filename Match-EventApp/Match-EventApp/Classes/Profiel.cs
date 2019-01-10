using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Match_EventApp.Classes
{
    class Profiel
    {
        private int profielID;
        private string voornaam;
        private string achternaam;
        private int geslacht;
        private int leeftijd;
        private string favofestival;
        private string favofilms;
        private string hobbys;

        public Profiel()
        {

        }

        public int _profielID
        {
            get { return profielID; }
            set { profielID = value;}
        }

        public string _voornaam
        {
            get { return voornaam; }
            set { voornaam = value;}  
        }

        public string _achternaam
        {
            get { return achternaam; }
            set { achternaam = value; }
        }

        public int _geslacht
        {
            get { return geslacht; }
            set { geslacht = value;}
        }

        public int _leeftijd
        {
            get { return leeftijd; }
            set { leeftijd = value;}
        }
        
        public string _favofestival
        {
            get { return favofestival; }
            set { favofestival = value;}
        }

        public string _favofilms
        {
            get { return favofilms; }
            set { favofilms = value;}
        }

        private string _hobbys
        {
            get { return hobbys; }
            set { hobbys = value;}
        }


    }

}
