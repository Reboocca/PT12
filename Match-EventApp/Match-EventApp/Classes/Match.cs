using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Match_EventApp.Classes
{
    class Match
    {
        public int account1 { get; private set; }
        public int account2 { get; private set; }
        public bool status_match { get; private set; }

        public Match()
        {

        }

        public bool getStatus
        {
            get { return status_match; }
        }

        public void updateStatus(bool waarde)
        {

        }
    }
}
