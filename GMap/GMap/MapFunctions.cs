using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GMap.NET;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using GMap.NET.WindowsForms.ToolTips;


/* Marco den Hollander's file */

namespace GMap
{
    class MapFunctions 
    {
        public static void TogglePolygons(NET.WindowsForms.GMapControl gmap) //Toggle heatmaps on or off
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

        public static void Clear(NET.WindowsForms.GMapControl gmap) //Erase all pointers and heatmaps
        {
            gmap.Overlays.Clear();
            UpdateMap(gmap);
        }


        public static void UpdateMap(NET.WindowsForms.GMapControl gmap) //Update map info (it won't re-draw until a function is called)
        {
            gmap.Zoom += 1;
            gmap.Zoom -= 1;
        }

        public static void PanMap(NET.WindowsForms.GMapControl gmap, object LocationIndex) //Pan to specific area, takes string input
        {
            gmap.SetPositionByKeywords(LocationIndex.ToString() + ", Rotterdam");
        }

    }
}
