using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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

        public static void PanMapKeyword(NET.WindowsForms.GMapControl gmap, object LocationIndex) //Pan to specific area, takes string input
        {
            gmap.SetPositionByKeywords(LocationIndex.ToString() + ", Rotterdam");
        }

        public static void PanMapCoord(NET.WindowsForms.GMapControl gmap, double Lat, double Long, double Zoom) //Pan to specific area, takes string input
        {
            gmap.Position = new PointLatLng(Lat, Long);
            gmap.Zoom = Zoom;
        }

        //public static void CreateOverlay(NET.WindowsForms.GMapControl gmap)
        //{
        //    GMapOverlay markersOverlay = new GMapOverlay("markers");
        //}


        public static void DrawMarker(NET.WindowsForms.GMapControl gmap, double Lat, double Long) //Draws pointer based on 2 inputs (latitude & longitude)
        {
            GMapOverlay markersOverlay = new GMapOverlay("markers");
            GMarkerGoogle marker = new GMarkerGoogle(new PointLatLng(Lat, Long),
              GMarkerGoogleType.green);
            markersOverlay.Markers.Add(marker);
            gmap.Overlays.Add(markersOverlay);
            UpdateMap(gmap);
        }


    }
}
