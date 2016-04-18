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
        private List<GMapPolygon> listofboroughs = new List<GMapPolygon>();

        public Rotterdam()
        {
        }

        public void AddtoRotterdam(GMapPolygon deelgemeente)
        {
            listofboroughs.Add(deelgemeente);
        }

        public List<GMapPolygon> Deelgemeenten { get { return listofboroughs; }
        set { listofboroughs = value; } }
    }
}

