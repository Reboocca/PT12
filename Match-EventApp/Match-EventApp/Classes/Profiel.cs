using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

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
        private string url;
        private Bitmap Foto;

        public Profiel()
        {

        }

        public Profiel(int id, string voornaam,string achternaam, int geslacht, int leeftijd,
            string festival, string films, string hobby, string url)
        {
            this.profielID      = id;
            this.voornaam       = voornaam;
            this.achternaam     = achternaam;
            this.geslacht       = geslacht;
            this.leeftijd       = leeftijd;
            this.favofestival   = festival;
            this.favofilms      = films;
            this.hobbys         = hobby;

            setFoto(url);
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

        public string _hobbys
        {
            get { return hobbys; }
            set { hobbys = value;}
        }

        public string _url
        {
            get { return url; }
            set { _url = value; }
        }

        public Bitmap _foto
        {
            get { return Foto; }
        }

        private void setFoto(string url)
        {
            System.Net.WebRequest request = System.Net.WebRequest.Create(url);
            System.Net.WebResponse resp = request.GetResponse();
            System.IO.Stream respStream = resp.GetResponseStream();
            Bitmap bmp = new Bitmap(respStream);
            respStream.Dispose();

            Foto = bmp;
        }
    }

}
