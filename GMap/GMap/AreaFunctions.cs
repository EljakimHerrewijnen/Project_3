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
using System.Globalization;

namespace GMap
{
    class AreaFunctions
    {
        public static GMapPolygon addFill(GMapPolygon polygon, string areaname, string selectedTable, string Year)
        {
            double green = 255;
            double red = 255;
            double blue = 0;

            string echtgebeidnaam = DictionairContainer.getAreaName(areaname.ToLower());

            string dataofarea = DatabaseRequester.getDataFromYear(selectedTable, echtgebeidnaam, Year);
            double numofarea = double.Parse(dataofarea, CultureInfo.GetCultureInfo("de-DE"));

            red *= (numofarea / 100);
            green *= (1 - (numofarea / 100));
            if (red > 255)
            {
                red = 255;
                blue = 255;
            }
            if (green > 255)
            {
                green = 255;
                blue = 255;
            }
            if (red < 0)
            {
                red = 0;
            }
            if (green < 0)
            {
                green = 0;
            }

            if(selectedTable == "tevredenheid_met_het_wonen_in_de_buurt_" && false)
            {
                double temp = red;
                red = green;
                green = temp;
            }

            polygon.Fill = new SolidBrush(Color.FromArgb(100, (int)red, (int)green, (int)blue));
            polygon.Stroke = new Pen(Color.Green, 0);
            return polygon;
        }

        public static void CheckAll(NET.WindowsForms.GMapControl gmap, Rotterdam Rdam, CheckBox wijkbox, CheckBox deelgembox, GMapOverlay Heatmaps, string selectedTable, string Year)
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
                            Heatmaps.Polygons.Add(addFill(polygon, gebied.Name, selectedTable, Year));
                        }
                    }
                }
            }

            else
            {
                foreach (Borough gebied in Rdam.Deelgemeenten)
                {
                    string new_name = gebied.Name;
                    foreach (GMapPolygon polygon in Rdam.Polygons)
                    {
                        if (polygon.Name == gebied.Name && gebied.Type == "Deelgemeente")
                        {
                            Heatmaps.Polygons.Add(addFill(polygon, gebied.Name, selectedTable, Year));
                        }
                    }
                }
            }
            gmap.Overlays.Add(Heatmaps);
            MapFunctions.UpdateMap(gmap);
       
        }

        public static void DrawAreas(NET.WindowsForms.GMapControl gmap, CheckedListBox checkedListBox1, Rotterdam Rdam, CheckBox wijkbox, CheckBox deelgembox, CheckBox manualareabox, CheckBox manualdeelbox, GMapOverlay Heatmaps, string selectedTable, string Year)
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
                                Heatmaps.Polygons.Add(addFill(wijk.Polygon, wijk.Name, selectedTable, Year));
                            }
                        }

                        if (wijk.Name.Contains("2"))
                        {
                            string new_check2 = new_check + "2";
                            if (wijk.Name == new_check2 && wijk.Type == "Wijk")
                            {
                                Heatmaps.Polygons.Add(addFill(wijk.Polygon, wijk.Name, selectedTable, Year));
                            }
                        }
                        if (wijk.Name.Contains("1"))
                        {
                            string new_check1 = new_check + "1";
                            if (wijk.Name == new_check1 && wijk.Type == "Wijk")
                            {
                                Heatmaps.Polygons.Add(addFill(wijk.Polygon, wijk.Name, selectedTable, Year));
                            }
                        }
                        if (wijk.InDeelgemeente.ToLower() == new_check)
                        {
                            Debug.Write("1");
                            Heatmaps.Polygons.Add(addFill(wijk.Polygon, wijk.Name, selectedTable, Year));
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
                                Heatmaps.Polygons.Add(addFill(deelgemeente.Polygon, deelgemeente.Name, selectedTable, Year));
                            }
                        }
                        if (deelgemeente.Name.Contains("1"))
                        {
                            string new_check1= new_check + "1";
                            if (deelgemeente.Name == new_check1 && deelgemeente.Type == "Deelgemeente")
                            {
                                Heatmaps.Polygons.Add(addFill(deelgemeente.Polygon, deelgemeente.Name, selectedTable, Year));
                            }
                        }
                        if (new_check == deelgemeente.Name && deelgemeente.Type == "Deelgemeente") //Je kan hieraan toevoegen: && gebied.Type == "Wijk" of "Deelgemeente"
                        {
                            Heatmaps.Polygons.Add(addFill(deelgemeente.Polygon, deelgemeente.Name, selectedTable, Year));
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