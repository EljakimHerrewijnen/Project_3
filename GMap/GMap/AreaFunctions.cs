﻿using System;
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


        public static void DrawAreas(NET.WindowsForms.GMapControl gmap, CheckedListBox checkedListBox1, Rotterdam Rdam, CheckBox checkbox)
        {

            //Delfshaven.Fill = new SolidBrush(Color.FromArgb(100, Color.Green));
            //Delfshaven.Stroke = new Pen(Color.Green, 1);

            // Haalt alle huidige polygons van de kaart.
            MapFunctions.Clear(gmap);

            // Maak een nieuwe GMapOverlay instance aan. 
            GMapOverlay Heatmaps = new GMapOverlay("Heatmaps");



            // Test -> Gebruikt een aparte check button die ervoor zorgt dat alle deelgemeenten worden laten zien.
            if (checkbox.Checked)
            {
                foreach (Borough gebied in Rdam.Deelgemeenten)
                {
                    foreach (GMapPolygon polygon in Rdam.Polygons)
                    {
                        if (polygon.Name == gebied.Name && gebied.Type == "Deelgemeente")
                        {
                            Heatmaps.Polygons.Add(polygon);
                        }
                    }
                }

            }

            //Gaat elke checkbox uit de lijst checkListBox1 af en kijkt of ze gechecked zijn.
            foreach (string Check in checkedListBox1.CheckedItems)
            {
                string new_check = Check.ToLower();

                foreach (Borough gebied in Rdam.Deelgemeenten) {
                    //Gaat elke polygon af in de lijst van Rdam.Polygons(bevat elke polygon die voor onze database van belang is).
                    foreach (GMapPolygon polygon in Rdam.Polygons)

                    {
                        //
                        if (polygon.Name.Contains("3"))
                        {
                            string new_check3 = new_check + "3";
                            if (polygon.Name == new_check3 && polygon.Name == gebied.Name)
                            {
                                Heatmaps.Polygons.Add(polygon);
                            }
                        }

                        if (polygon.Name.Contains("2"))
                        {
                            string new_check2 = new_check + "2";
                            if (polygon.Name == new_check2 && polygon.Name == gebied.Name)
                            {
                                Heatmaps.Polygons.Add(polygon);
                            }
                        }
                        if (polygon.Name.Contains("1"))
                        {
                            string new_check1 = new_check + "1";
                            if (polygon.Name == new_check1 && polygon.Name == gebied.Name)
                            {
                                Heatmaps.Polygons.Add(polygon);
                            }
                        }

                        if (polygon.Name == new_check && polygon.Name == gebied.Name) //Je kan hieraan toevoegen: && gebied.Type == "Wijk" of "Deelgemeente"
                        {
                            Heatmaps.Polygons.Add(polygon);
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