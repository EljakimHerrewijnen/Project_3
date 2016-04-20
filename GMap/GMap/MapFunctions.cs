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

        public static void Warp(NET.WindowsForms.GMapControl gmap, object item, Rotterdam Rdam, GMapOverlay Heatmaps)
        {
            object LocationIndex = item;
            MapFunctions.Clear(gmap);
            Heatmaps.Clear();
            switch (Convert.ToString(LocationIndex))
            {
                case "Charlois":
                    MapFunctions.PanMapCoord(gmap, 51.88507425958, 4.47864532470703, 14);
                    break;
                case "Delfshaven":
                    MapFunctions.PanMapCoord(gmap, 51.9106025028462, 4.43856239318848, 13);
                    break;


                case "Feijenoord":
                    MapFunctions.PanMapCoord(gmap, 51.8986875968913, 4.50267791748047, 13);
                    break;

                case "Schiebroek":
                    MapFunctions.PanMapCoord(gmap, 51.9588652250502, 4.48688507080078, 13);
                    break;

                case "Hoek_van_Holland":
                    MapFunctions.PanMapCoord(gmap, 51.9681731085283, 4.16072845458984, 12);
                    break;

                case "Hoogvliet":
                    MapFunctions.PanMapCoord(gmap, 51.8669520608064, 4.36723709106445, 13);
                    break;

                case "IJsselmonde":
                    MapFunctions.PanMapCoord(gmap, 51.8883587884291, 4.54473495483398, 13);
                    break;

                case "Kralingen":
                    MapFunctions.PanMapCoord(gmap, 51.9287071072723, 4.51297760009766, 13);
                    break;

                case "Noord":
                    MapFunctions.PanMapCoord(gmap, 51.9337348683824, 4.46843147277832, 14);
                    break;

                case "Overschie":
                    MapFunctions.PanMapCoord(gmap, 51.9461695415817, 4.43881988525391, 13);
                    break;

                case "Pernis":
                    MapFunctions.PanMapCoord(gmap, 51.8876436292015, 4.38830852508545, 15);
                    break;

                case "Prins_Alexander":
                    MapFunctions.PanMapCoord(gmap, 51.9612452655421, 4.5428466796875, 14);
                    break;

                case "Rozenburg":
                    MapFunctions.PanMapCoord(gmap, 51.9186498950804, 4.22698974609375, 13);
                    break;

                case "Stadscentrum":
                    MapFunctions.PanMapCoord(gmap, 51.9162146522532, 4.47752952575684, 14);
                    break;
            }


            foreach (Borough deelgemeente in Rdam.Deelgemeenten)
            {
                string new_check = item.ToString().ToLower();
                foreach (GMapPolygon polygon in Rdam.Polygons)
                {
                    if (deelgemeente.Name.Contains("2"))
                    {
                        string new_check2 = new_check + "2";
                        if (deelgemeente.InDeelgemeente == new_check2 && deelgemeente.Type == "Wijk" && item.ToString().ToLower() == deelgemeente.InDeelgemeente)
                        {
                            Heatmaps.Polygons.Add(deelgemeente.Polygon);
                        }
                    }
                    if (deelgemeente.Name.Contains("1"))
                    {
                        string new_check1 = new_check + "1";
                        if (deelgemeente.InDeelgemeente == new_check1 && deelgemeente.Type == "Wijk" && item.ToString().ToLower() == deelgemeente.InDeelgemeente)
                        {
                            Heatmaps.Polygons.Add(deelgemeente.Polygon);
                        }
                    }

                    if (item.ToString().ToLower() == deelgemeente.InDeelgemeente && deelgemeente.Type == "Wijk" && polygon.Name == deelgemeente.Name) //Je kan hieraan toevoegen: && gebied.Type == "Wijk" of "Deelgemeente"
                    {
                        Heatmaps.Polygons.Add(deelgemeente.Polygon);
                    }
                }


            }
            gmap.Overlays.Add(Heatmaps);
            MapFunctions.UpdateMap(gmap);
        }

        }



    }

