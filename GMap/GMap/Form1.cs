using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GMap.NET;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using GMap.NET.WindowsForms.ToolTips;

/*  Deze file is van: "Marco den Hollander"
*
*/

namespace GMap
{
    public partial class FormOld : Form
    {

        public FormOld()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Initialize map:
            gmap.MapProvider = GMap.NET.MapProviders.GoogleMapProvider.Instance; //Select Google Maps as map provider
            GMap.NET.GMaps.Instance.Mode = GMap.NET.AccessMode.ServerOnly; 
            gmap.SetPositionByKeywords("Rotterdam, The Netherlands"); //default pan to Rotterdam
            gmap.BoundsOfMap = new RectLatLng(51.968807666562874, 4.371700286865234, 0.3, 0.3); //define outer edges of the map (we don't want to see other countries)


        
        }


        private void DrawRect_Click(object sender, EventArgs e)  //depreciated, used as reference
        {
            GMapOverlay markersOverlay = new GMapOverlay("markers");
            GMarkerGoogle marker = new GMarkerGoogle(new PointLatLng(51.91769699, 4.48100567),
            GMarkerGoogleType.green);
            markersOverlay.Markers.Add(marker);
            gmap.Overlays.Add(markersOverlay);
            gmap.Zoom += 1;
            gmap.Zoom -= 1;
        }

        private void DrawMarker2_Click(object sender, EventArgs e) //depreciated, used as reference
        {
            GMapOverlay markersOverlay = new GMapOverlay("markers");
            GMarkerGoogle marker = new GMarkerGoogle(new PointLatLng(53.93789705, 4.48100567),
            GMarkerGoogleType.green);
            markersOverlay.Markers.Add(marker);
            gmap.Overlays.Add(markersOverlay);
            gmap.Zoom += 1;
            gmap.Zoom -= 1;

        }

        private void gmap_Load(object sender, EventArgs e) //on map load...
        {

        }

        private void trackBar1_Scroll(object sender, EventArgs e) //on trackbar scroll...
        {

        }

        public void Test_Click(object sender, EventArgs e)
        {
            MapFunctions.Clear(gmap);
            GMapOverlay Heatmaps = new GMapOverlay("Heatmaps");
            List<PointLatLng> schiebroek_points = new List<PointLatLng>();


            //Borough Hoek_van_Holland = new Borough("Hoek van Holland", hoekvanholland_points, true);





         

            //Hier maak je instances van GMapPolygon met de lijst van coordinaten die je in een list<PointLatLng> hebt gezet. Hier kan je ook de kleur
            //GMapPolygon feijenoord = new GMapPolygon(feijenoord_points, "Feijenoord");
            //feijenoord.Fill = new SolidBrush(Color.FromArgb(100, Color.Green));
            //feijenoord.Stroke = new Pen(Color.Green, 1);


            //Hier zet je de variabele die je hiervoor hebt aangemaakt in. // De variabelen kunnen ergens anders, zodat ze niet steeds opnieuw worden aangemaakt(de coordinaten blijven altijd hetzelfde).
            //foreach (Borough deelgemeente in Rdam.Deelgemeenten)
            //{
            //    if (deelgemeente.Draw == true)
            //    {
            //        Heatmaps.Polygons.Add(new GMapPolygon(deelgemeente.Deelgemeente, "x"));
            //    }
            //}

            //Heatmaps.Polygons.Add(hoekvanholland);

            //gmap.Overlays.Add(Heatmaps);
            MapFunctions.UpdateMap(gmap);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }


        private void button1_Click(object sender, EventArgs e)
        {

        }

        private  void PolygonErase_Click(object sender, EventArgs e)
        {
            MapFunctions.Clear(gmap);
        }


        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            MapFunctions.TogglePolygons(gmap);
        }

        private void Fijnoort_Click(object sender, EventArgs e)
        {


        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            object LocationIndex = comboBox2.SelectedItem;
            MapFunctions.PanMap(gmap, LocationIndex);
        }

        private void trackBar1_ValueChanged(object sender, System.EventArgs e)
        {
            this.gmap.Zoom = this.trackBar1.Value;
        }

        private void LatBox_TextChanged(object sender, EventArgs e)
        {

        }


        private void gmap_Click(object sender, MouseEventArgs e) //on map click...
        {
            switch (e.Button)
            {
                case MouseButtons.Left:
                    LatBox.Text = Convert.ToString(gmap.FromLocalToLatLng(e.X, e.Y).Lat);
                    LongBox.Text = Convert.ToString(gmap.FromLocalToLatLng(e.X, e.Y).Lng);
                    break;

                case MouseButtons.Middle:
                    MapFunctions.DrawMarker(gmap, gmap.FromLocalToLatLng(e.X, e.Y).Lat, gmap.FromLocalToLatLng(e.X, e.Y).Lng);
                    break;
                    
            }
        }

        private void gmap_ZoomChanged() // on zoom (with scroll)
        {
            trackBar1.Value = Convert.ToInt32(gmap.Zoom);
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            // Haalt alle huidige polygons van de kaart.
            MapFunctions.Clear(gmap);

            // Maak een nieuwe GMapOverlay instance aan. 
            GMapOverlay Heatmaps = new GMapOverlay("Heatmaps");

            // Maak een Rotterdam instance aan die bestaat uit een list van boroughs en de daarbij behorende polygons.
            Rotterdam Rdam = new Rotterdam();

            // Maak een Borough instance aan.
            Borough delfshaven = new Borough("Delfshaven", true);

            // Maar een GMapPolygon instance aan.
            GMapPolygon Delfshaven = new GMapPolygon(delfshaven.Deelgemeente, "Delfshaven");

            // Voeg de eerder gecreerde polygon en borough instance toe aan de Rdam instance.
            Rdam.Polygons.Add(Delfshaven);
            Rdam.Deelgemeenten.Add(delfshaven);

            // Voeg de polygon toe
            delfshaven.AssignCoords(@"c:\users\sintae\documents\testdelfs.txt", "delfshaven");

            Delfshaven.Fill = new SolidBrush(Color.FromArgb(100, Color.Green));
            Delfshaven.Stroke = new Pen(Color.Green, 1);

            if (paultest.Checked)
            {
                Heatmaps.Polygons.Add(Delfshaven);

            }

            gmap.Overlays.Add(Heatmaps);
            MapFunctions.UpdateMap(gmap);

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Haalt alle huidige polygons van de kaart.
            MapFunctions.Clear(gmap);

            // Maak een nieuwe GMapOverlay instance aan. 
            GMapOverlay Heatmaps = new GMapOverlay("Heatmaps");

            // Maak een Rotterdam instance aan die bestaat uit een list van boroughs en de daarbij behorende polygons.
            Rotterdam Rdam = new Rotterdam();

            // Maak een Borough instance aan.
            Borough delfshaven = new Borough("Delfshaven", true);

            // Maar een GMapPolygon instance aan.
            GMapPolygon Delfshaven = new GMapPolygon(delfshaven.Deelgemeente, "Delfshaven");

            // Voeg de eerder gecreerde polygon en borough instance toe aan de Rdam instance.
            Rdam.Polygons.Add(Delfshaven);
            Rdam.Deelgemeenten.Add(delfshaven);

            // Voeg de polygon toe
            delfshaven.AssignCoords(@"c:\users\sintae\documents\testdelfs.txt", "delfshaven");

            Delfshaven.Fill = new SolidBrush(Color.FromArgb(100, Color.Green));
            Delfshaven.Stroke = new Pen(Color.Green, 1);

            foreach (string checks in checkedListBox1.CheckedItems)
            {
                foreach (Borough deelgemeente in Rdam.Deelgemeenten)
                {
                    foreach (GMapPolygon polygon in Rdam.Polygons)
                    {
                        if (deelgemeente.Name == checks && polygon.Name == deelgemeente.Name)
                        {
                            Heatmaps.Polygons.Add(polygon);
                        }
                    }
                 Console.WriteLine("Hallo");



                }

            }

            gmap.Overlays.Add(Heatmaps);
            MapFunctions.UpdateMap(gmap);



            //    }
            //}



        }
    }
}

