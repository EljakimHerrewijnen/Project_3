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


        public static void UpdateMap(NET.WindowsForms.GMapControl gmap) //Update map info
        {
            gmap.ReloadMap();
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

        public static void DrawMarker(NET.WindowsForms.GMapControl gmap, double Lat, double Long) //Draws pointer based on 2 inputs (latitude & longitude)
        {
            GMapOverlay markersOverlay = new GMapOverlay("markers");
            GMarkerGoogle marker = new GMarkerGoogle(new PointLatLng(Lat, Long),
              GMarkerGoogleType.green);
            markersOverlay.Markers.Add(marker);
            gmap.Overlays.Add(markersOverlay);
            UpdateMap(gmap);
        }

        public static void Warp(NET.WindowsForms.GMapControl gmap, object item, Rotterdam Rdam, GMapOverlay Heatmaps, string selectedTable, string Year) //checks dropdown for selected area, and pans to its coords
        {
            object LocationIndex = item;
            Clear(gmap);
            Heatmaps.Clear();
            switch (Convert.ToString(LocationIndex))
            {
                case "Charlois":
                    PanMapCoord(gmap, 51.88507425958, 4.47864532470703, 14);
                    break;
                case "Delfshaven":
                    PanMapCoord(gmap, 51.9106025028462, 4.43856239318848, 13);
                    break;

                case "Feijenoord":
                    PanMapCoord(gmap, 51.8986875968913, 4.50267791748047, 13);
                    break;

                case "Schiebroek":
                    PanMapCoord(gmap, 51.9588652250502, 4.48688507080078, 13);
                    break;

                case "Hoek_van_Holland":
                    PanMapCoord(gmap, 51.9681731085283, 4.16072845458984, 12);
                    break;

                case "Hoogvliet":
                    PanMapCoord(gmap, 51.8669520608064, 4.36723709106445, 13);
                    break;

                case "IJsselmonde":
                    PanMapCoord(gmap, 51.8883587884291, 4.54473495483398, 13);
                    break;

                case "Kralingen":
                    PanMapCoord(gmap, 51.9287071072723, 4.51297760009766, 13);
                    break;

                case "Noord":
                    PanMapCoord(gmap, 51.9337348683824, 4.46843147277832, 14);
                    break;

                case "Overschie":
                    PanMapCoord(gmap, 51.9461695415817, 4.43881988525391, 13);
                    break;

                case "Pernis":
                    PanMapCoord(gmap, 51.8876436292015, 4.38830852508545, 15);
                    break;

                case "Prins_Alexander":
                    PanMapCoord(gmap, 51.9612452655421, 4.5428466796875, 14);
                    break;

                case "Rozenburg":
                    PanMapCoord(gmap, 51.9186498950804, 4.22698974609375, 13);
                    break;

                case "Stadscentrum":
                    PanMapCoord(gmap, 51.9162146522532, 4.47752952575684, 14);
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
                            Heatmaps.Polygons.Add(AreaFunctions.addFill(deelgemeente.Polygon, deelgemeente.Name, selectedTable, Year));
                        }
                    }
                    if (deelgemeente.Name.Contains("1"))
                    {
                        string new_check1 = new_check + "1";
                        if (deelgemeente.InDeelgemeente == new_check1 && deelgemeente.Type == "Wijk" && item.ToString().ToLower() == deelgemeente.InDeelgemeente)
                        {
                            Heatmaps.Polygons.Add(AreaFunctions.addFill(deelgemeente.Polygon, deelgemeente.Name, selectedTable, Year));
                        }
                    }

                    if (item.ToString().ToLower() == deelgemeente.InDeelgemeente && deelgemeente.Type == "Wijk" && polygon.Name == deelgemeente.Name) //Je kan hieraan toevoegen: && gebied.Type == "Wijk" of "Deelgemeente"
                    {
                        Heatmaps.Polygons.Add(AreaFunctions.addFill(deelgemeente.Polygon, deelgemeente.Name, selectedTable, Year));
                    }
                }


            }
            gmap.Overlays.Add(Heatmaps);
            UpdateMap(gmap);
        }

        }



    }

