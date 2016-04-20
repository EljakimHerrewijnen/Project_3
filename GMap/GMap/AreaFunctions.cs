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
        //Adds the actual color to the polygons. 
        public static GMapPolygon addFill(GMapPolygon polygon, string areaname, string selectedTable, string Year)
        {
            double green = 0;
            double red = 0;
            double blue = 0;

            string echtgebeidnaam = DictionairContainer.getAreaName(areaname.ToLower());

            string dataofarea = DatabaseRequester.getDataFromYear(selectedTable, echtgebeidnaam, Year);
            double numofarea = double.Parse(dataofarea, CultureInfo.GetCultureInfo("de-DE"));
            double percentage;
            if (selectedTable == "tevredenheid_met_het_wonen_in_de_buurt_")
            {
                percentage = 100-numofarea;
            }
            else
            {
                percentage = (numofarea / 10);
            }
            double factor = 1;

            red = Math.Log10(Math.Pow(10, factor)*(percentage)) * (255 / (factor+2));       //Uses a logaristmic scale for colors
            green = -Math.Log10(Math.Pow(10, factor) * (percentage)) * (255 / factor+2) + 255;
            if (red > 255)
            {
                red = 255;

            }
            if (green > 255)
            {
                green = 255;

            }
            if (red < 0)
            {
                red = 0;
            }
            if (green < 0)
            {
                green = 0;
            }

            

            polygon.Fill = new SolidBrush(Color.FromArgb(100, (int)red, (int)green, (int)blue));
            polygon.Stroke = new Pen(Color.Green, 0);
            return polygon;
            


        }
        //This function is used to select and draw all polygon with type 'Wijk' or 'Deelgemeente' at once. 
        public static void CheckAll(NET.WindowsForms.GMapControl gmap, Rotterdam Rdam, CheckBox wijkbox, CheckBox deelgembox, GMapOverlay Heatmaps, string selectedTable, string Year)
        {
            //Clears the map beforehand
            MapFunctions.Clear(gmap);
            Heatmaps.Clear();

            //If 'all areas' is selected.
            if (wijkbox.Checked)
            {
                //Checks every borough in the Rotterdam instance
                foreach (Borough gebied in Rdam.Deelgemeenten)
                {
                    //Checks every polygon in the Rotterdam instance
                    foreach (GMapPolygon polygon in Rdam.Polygons)
                    {
                        //If the polygon name is the name as the borough name and the type equals to "Wijk", add the polygon to the heatmap
                        if (polygon.Name == gebied.Name && gebied.Type == "Wijk")
                        {
                            Heatmaps.Polygons.Add(addFill(polygon, gebied.Name, selectedTable, Year));
                        }
                    }
                }
            }

            //else...
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
            //Adds newly created Heatmaps, which contains all the added polygons to the gmap.Overlay
            gmap.Overlays.Add(Heatmaps);
            //Updates the map
            MapFunctions.UpdateMap(gmap);
       
        }
        //This function is called when you select 'Manual area' or 'Manual borough' and this function checks which areas are checked and draws them.
        public static void DrawAreas(NET.WindowsForms.GMapControl gmap, CheckedListBox checkedListBox1, Rotterdam Rdam, CheckBox wijkbox, CheckBox deelgembox, CheckBox manualareabox, CheckBox manualdeelbox, GMapOverlay Heatmaps, string selectedTable, string Year)
        {
            MapFunctions.Clear(gmap);
            Heatmaps.Clear();

            //if the 'All areas' is checked
            if (manualareabox.Checked)
            {


                //Checks which areas from the checkboxlist are checked 
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
            //else...
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
