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
            gmap.MapProvider = GMap.NET.MapProviders.GoogleMapProvider.Instance;
            GMap.NET.GMaps.Instance.Mode = GMap.NET.AccessMode.ServerOnly;
            gmap.SetPositionByKeywords("Rotterdam, The Netherlands");
            //            gmap.BoundsOfMap = new RectLatLng(53.91769699, 4.48100567, 10.12345678, 10.12345678);
            //            gmap.MapProvider.Area = new RectLatLng(30.981178, 105.351914, 2.765142, 4.120995);
            // not yet functional          
        }


        private void DrawRect_Click(object sender, EventArgs e)
        {
            GMapOverlay markersOverlay = new GMapOverlay("markers");
            GMarkerGoogle marker = new GMarkerGoogle(new PointLatLng(51.91769699, 4.48100567),
            GMarkerGoogleType.green);
            markersOverlay.Markers.Add(marker);
            gmap.Overlays.Add(markersOverlay);
            gmap.Zoom += 1;
            gmap.Zoom -= 1;
        }

        private void DrawMarker2_Click(object sender, EventArgs e)
        {
            GMapOverlay markersOverlay = new GMapOverlay("markers");
            GMarkerGoogle marker = new GMarkerGoogle(new PointLatLng(53.93789705, 4.48100567),
            GMarkerGoogleType.green);
            markersOverlay.Markers.Add(marker);
            gmap.Overlays.Add(markersOverlay);
            gmap.Zoom += 1;
            gmap.Zoom -= 1;

        }


        private void gmap_Load(object sender, EventArgs e)
        {

        }


        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void XCoordBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {

        }

        public void Test_Click(object sender, EventArgs e)
        {
            MapFunctions.Clear(gmap);
            GMapOverlay Heatmaps = new GMapOverlay("Heatmaps");
            List<PointLatLng> schiebroek_points = new List<PointLatLng>();
            List<PointLatLng> noord_points = new List<PointLatLng>();
            List<PointLatLng> feijenoord_points = new List<PointLatLng>();
            List<PointLatLng> pernis_points = new List<PointLatLng>();
            List<PointLatLng> rozenburg_points = new List<PointLatLng>();
            List<PointLatLng> hoekvanholland_points = new List<PointLatLng>();

            //Borough Hoek_van_Holland = new Borough("Hoek van Holland", hoekvanholland_points, true);
            //Borough Pernis = new Borough("Pernis", pernis_points, true);
            //Borough Noord = new Borough("Noord", noord_points, true);
            //Borough Schiebroek = new Borough("Schiebroek", schiebroek_points, true);
            //Borough Feijenoord = new Borough("Feijenoord", feijenoord_points, true);
            //Borough Rozenburg = new Borough("Rozenburg", rozenburg_points, true);

            //Rotterdam Rdam = new Rotterdam();
            //Rdam.AddtoRotterdam(Hoek_van_Holland);
            //Rdam.AddtoRotterdam(Rozenburg);
            //Rdam.AddtoRotterdam(Pernis);
            //Rdam.AddtoRotterdam(Noord);
            //Rdam.AddtoRotterdam(Schiebroek);
            //Rdam.AddtoRotterdam(Feijenoord);

         

            //Hier maak je instances van GMapPolygon met de lijst van coordinaten die je in een list<PointLatLng> hebt gezet. Hier kan je ook de kleur
            //GMapPolygon feijenoord = new GMapPolygon(feijenoord_points, "Feijenoord");
            //feijenoord.Fill = new SolidBrush(Color.FromArgb(100, Color.Green));
            //feijenoord.Stroke = new Pen(Color.Green, 1);

            //GMapPolygon noord = new GMapPolygon(noord_points, "Noord");
            //noord.Fill = new SolidBrush(Color.FromArgb(100, Color.Red));
            //noord.Stroke = new Pen(Color.Red, 1);

            //GMapPolygon schiebroek = new GMapPolygon(schiebroek_points, "Schiebroek");
            //schiebroek.Fill = new SolidBrush(Color.FromArgb(100, Color.Blue));
            //schiebroek.Stroke = new Pen(Color.Blue, 1);

            //GMapPolygon pernis = new GMapPolygon(pernis_points, "Charlois");
            //pernis.Fill = new SolidBrush(Color.FromArgb(100, Color.Blue));
            //pernis.Stroke = new Pen(Color.Blue, 1);

            //GMapPolygon rozenburg = new GMapPolygon(rozenburg_points, "Rozenburg");
            //rozenburg.Fill = new SolidBrush(Color.FromArgb(100, Color.Yellow));
            //rozenburg.Stroke = new Pen(Color.Yellow, 1);

            //GMapPolygon hoekvanholland = new GMapPolygon(hoekvanholland_points, "Hoek van Holland");
            //hoekvanholland.Fill = new SolidBrush(Color.FromArgb(100, Color.Purple));
            //hoekvanholland.Stroke = new Pen(Color.Purple, 1);

            //Hier zet je de variabele die je hiervoor hebt aangemaakt in. // De variabelen kunnen ergens anders, zodat ze niet steeds opnieuw worden aangemaakt(de coordinaten blijven altijd hetzelfde).
            //foreach (Borough deelgemeente in Rdam.Deelgemeenten)
            //{
            //    if (deelgemeente.Draw == true)
            //    {
            //        Heatmaps.Polygons.Add(new GMapPolygon(deelgemeente.Deelgemeente, "x"));
            //    }
            //}

            //Heatmaps.Polygons.Add(hoekvanholland);
            //Heatmaps.Polygons.Add(rozenburg);
            //Heatmaps.Polygons.Add(schiebroek);
            //Heatmaps.Polygons.Add(noord);
            //Heatmaps.Polygons.Add(feijenoord);
            //Heatmaps.Polygons.Add(pernis);
            //gmap.Overlays.Add(Heatmaps);
            MapFunctions.UpdateMap(gmap);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        //private void PolygonToggle_Click(object sender, EventArgs e)
        //{
        //    if (gmap.PolygonsEnabled == true)
        //    {
        //        gmap.PolygonsEnabled = false;
        //        MapFunctions.UpdateMap();
        //    }
        //    else if (gmap.PolygonsEnabled == false)
        //    {
        //        gmap.PolygonsEnabled = true;
        //        MapFunctions.UpdateMap();
        //    }
        //}

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private  void PolygonErase_Click(object sender, EventArgs e)
        {
            MapFunctions.Clear(gmap);
        }

//        public void UpdateMap()
//        {
//            gmap.Zoom += 1;
//            gmap.Zoom -= 1;
//        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            MapFunctions.TogglePolygons(gmap);
        }

        private void Fijnoort_Click(object sender, EventArgs e)
        {
//            MapFunctions.PanMap(gmap);
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            object LocationIndex = comboBox2.SelectedItem;
            MapFunctions.PanMap(gmap, LocationIndex);      
        }
    }
}