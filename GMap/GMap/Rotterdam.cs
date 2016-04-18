using GMap.NET;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using GMap.NET.WindowsForms.ToolTips;
using System.IO;

namespace GMap
{
    class Rotterdam
    {
        private List<Borough> listofboroughs = new List<Borough>();
        private List<GMapPolygon> listofpolygons = new List<GMapPolygon>();

        public Rotterdam()
        {
        }

        public void AddtoRotterdam(Borough deelgemeente)
        {
            listofboroughs.Add(deelgemeente);
        }

        public List<Borough> Deelgemeenten { get { return listofboroughs; }
        set { listofboroughs = value; } }

        public List<GMapPolygon> Polygons { get { return listofpolygons; } set { listofpolygons = value; } }

    }
}

