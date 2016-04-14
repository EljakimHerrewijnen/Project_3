using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GMap
{
    class Rotterdam
    {
        private List<Borough> listofboroughs = new List<Borough>();

        public Rotterdam()
        {
        }

        public void AddtoRotterdam(Borough deelgemeente)
        {
            listofboroughs.Add(deelgemeente);
        }

        public List<Borough> Deelgemeenten { get { return listofboroughs; }
        set { listofboroughs = value; } }
    }
}

