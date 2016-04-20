using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GMap.NET;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using GMap.NET.WindowsForms.ToolTips;

namespace GMap
{
    class AreaFunctions
    {

        public static void CheckAll(NET.WindowsForms.GMapControl gmap, Rotterdam Rdam, CheckBox wijkbox, CheckBox deelgembox, GMapOverlay Heatmaps)
        {
            MapFunctions.Clear(gmap);
            Heatmaps.Clear();
            if (wijkbox.Checked)
            {
                foreach (Borough gebied in Rdam.Deelgemeenten)
                {
                    foreach (GMapPolygon polygon in Rdam.Polygons)
                    {
                        if (polygon.Name == gebied.Name && gebied.Type == "Wijk")
                        {
                            string dataofarea = "0,0";//get that bitch ass selected data type somehow 
                            Heatmaps.Polygons.Add(polygon);
                        }
                    }
                }
            }

            if (deelgembox.Checked)
            {
                foreach (Borough gebied in Rdam.Deelgemeenten)
                {
                    string new_name = gebied.Name;
                    foreach (GMapPolygon polygon in Rdam.Polygons)
                    {
                        if (polygon.Name == gebied.Name && gebied.Type == "Deelgemeente")
                        {
                            Heatmaps.Polygons.Add(polygon);
                        }
                    }
                }
            }
            gmap.Overlays.Add(Heatmaps);
            MapFunctions.UpdateMap(gmap);
       
        }

        public static void DrawAreas(NET.WindowsForms.GMapControl gmap, CheckedListBox checkedListBox1, Rotterdam Rdam, CheckBox wijkbox, CheckBox deelgembox, CheckBox manualareabox, CheckBox manualdeelbox, GMapOverlay Heatmaps)
        {
            MapFunctions.Clear(gmap);

            Heatmaps.Clear();


            if (manualareabox.Checked)
            {
                

                //Gaat elke checkbox uit de lijst checkListBox1 af en kijkt of ze gechecked zijn.
                foreach (string Check in checkedListBox1.CheckedItems)
                {
                    string new_check = Check.ToLower();

                    foreach(Borough wijk in Rdam.Deelgemeenten)
                    {
                        if (wijk.Name.Contains("3"))
                        {
                            string new_check3 = new_check + "3";
                            if (wijk.Name == new_check3 && wijk.Type == "Wijk")
                            {
                                Heatmaps.Polygons.Add(wijk.Polygon);
                            }
                        }

                        if (wijk.Name.Contains("2"))
                        {
                            string new_check2 = new_check + "2";
                            if (wijk.Name == new_check2 && wijk.Type == "Wijk")
                            {
                                Heatmaps.Polygons.Add(wijk.Polygon);
                            }
                        }
                        if (wijk.Name.Contains("1"))
                        {
                            string new_check1 = new_check + "1";
                            if (wijk.Name == new_check1 && wijk.Type == "Wijk")
                            {
                                Heatmaps.Polygons.Add(wijk.Polygon);
                            }
                        }
                        if (wijk.InDeelgemeente.ToLower() == new_check)
                        {
                            Debug.Write("1");
                            Heatmaps.Polygons.Add(wijk.Polygon);
                        }
                    }
                }

            }

            else if (manualdeelbox.Checked)
            {
                foreach (string Check in checkedListBox1.CheckedItems)
                {
                    string new_check = Check.ToLower();

                    foreach (Borough deelgemeente in Rdam.Deelgemeenten)
                    {
                        if (deelgemeente.Name.Contains("2"))
                        {
                            string new_check2 = new_check + "2";
                            if (deelgemeente.Name == new_check2 && deelgemeente.Type == "Deelgemeente")
                            {
                                Heatmaps.Polygons.Add(deelgemeente.Polygon);
                            }
                        }
                        if (deelgemeente.Name.Contains("1"))
                        {
                            string new_check1= new_check + "1";
                            if (deelgemeente.Name == new_check1 && deelgemeente.Type == "Deelgemeente")
                            {
                                Heatmaps.Polygons.Add(deelgemeente.Polygon);
                            }
                        }
                        if (new_check == deelgemeente.Name && deelgemeente.Type == "Deelgemeente") //Je kan hieraan toevoegen: && gebied.Type == "Wijk" of "Deelgemeente"
                        {
                            Heatmaps.Polygons.Add(deelgemeente.Polygon);
                        }
                    }
                }
            }



            
            gmap.Overlays.Add(Heatmaps);
            MapFunctions.UpdateMap(gmap);
            
            
        }
    }
}

// Wat te doen?
// Een button/checkbox/dropdownbar waar je kan selecteren of je deelgemeenten OF wijken wilt zien. Deze moet vervolgens geimplementeerd worden in de functie hierboven.
// 
//
//
//
//