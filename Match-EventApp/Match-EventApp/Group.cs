using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Match_EventApp
{
    class Group
    {
        //list voor een groep
        public List<int> group1 = new List<int>();

        //test int
        int test = 1;

        public void GroupJoin()
        {
            //profiel toevoegen aan de list
            group1.Add(test);
        }
    }
}
