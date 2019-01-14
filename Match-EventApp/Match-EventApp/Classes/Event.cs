using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Match_EventApp.Classes
{
    class Event
    {
        public EventType eventType { get; private set; }
        public string naam { get; private set; }
        public string locatie { get; private set; }
        public DateTime datum { get; private set; }
        public int id { get; private set; }

        public Event()
        {

        }

        public void newEvent()
        {

        }

        public List<Event> getEvents()
        {
            return new List<Event>();
        }
    }
}
