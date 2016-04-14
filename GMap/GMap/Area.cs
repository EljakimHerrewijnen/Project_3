using GMap.NET;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GMap
{
    class Area
    {
        private string name;
        public List<PointLatLng> deelgemeente;
        private bool draw; //True or False hier

        public Area(string name, List<PointLatLng> coordlist)
        {
            this.name = name;
            deelgemeente = coordlist;
            draw = false;
        }

        public bool Draw
        {
            get { return draw; }
            set { draw = value; }
        }
    }
}
