using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GMap.NET;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using GMap.NET.WindowsForms.ToolTips;


/* Marco's file*/

namespace GMap
{
    class MapFunctions 
    {
        public int AreaIndex = 0;
        public static void TogglePolygons(NET.WindowsForms.GMapControl gmap)
        {
            if (gmap.PolygonsEnabled == true)
            {
                gmap.PolygonsEnabled = false;
            }
            else if (gmap.PolygonsEnabled == false)
            {
                gmap.PolygonsEnabled = true;
            }
            UpdateMap(gmap);
        }

        public static void Clear(NET.WindowsForms.GMapControl gmap)
        {
            gmap.Overlays.Clear();
            UpdateMap(gmap);
        }


        public static void UpdateMap(NET.WindowsForms.GMapControl gmap)
        {
            gmap.Zoom += 1;
            gmap.Zoom -= 1;
        }

        public static void PanMap(NET.WindowsForms.GMapControl gmap, object LocationIndex)
        {
            gmap.SetPositionByKeywords(LocationIndex.ToString() + ", Rotterdam");
        }

    }
}
