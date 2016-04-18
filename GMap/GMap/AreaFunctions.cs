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
        public static void DrawAreas(NET.WindowsForms.GMapControl gmap, CheckedListBox checkedListBox1)
        {
            // Haalt alle huidige polygons van de kaart.
            MapFunctions.Clear(gmap);

            // Maak een nieuwe GMapOverlay instance aan. 
            GMapOverlay Heatmaps = new GMapOverlay("Heatmaps");

            // Maak een Rotterdam instance aan die bestaat uit een list van boroughs en de daarbij behorende polygons.
            Rotterdam Rdam = new Rotterdam();

            // Maak een Borough instance aan.
            Borough delfshaven = new Borough("delfshaven", true);

            // Voeg de polygon toe
            delfshaven.AssignCoords(@"Coordinates\Deelgemeenten_coords.txt", "delfshaven");

            // Maar een GMapPolygon instance aan.
            GMapPolygon Delfshaven = new GMapPolygon(delfshaven.Deelgemeente, "delfshaven");

            // Voeg de eerder gecreerde polygon en borough instance toe aan de Rdam instance.
            Rdam.Polygons.Add(Delfshaven);
            Rdam.Deelgemeenten.Add(delfshaven);



            Delfshaven.Fill = new SolidBrush(Color.FromArgb(100, Color.Green));
            Delfshaven.Stroke = new Pen(Color.Green, 1);

            foreach (string Items in checkedListBox1.CheckedItems)
            {
                Debug.WriteLine("1");
                foreach (Borough deelgemeente in Rdam.Deelgemeenten)
                {
                    Debug.WriteLine("2");
                    foreach (GMapPolygon polygon in Rdam.Polygons)
                    {
                        Debug.WriteLine("3");
                        if (deelgemeente.Name == Items && polygon.Name == deelgemeente.Name)
                        {
                            Debug.WriteLine("4");
                            Heatmaps.Polygons.Add(polygon);
                        }
}
Debug.Write("Hallo");



                }

            }

            gmap.Overlays.Add(Heatmaps);
            MapFunctions.UpdateMap(gmap);
        }
    }
}
