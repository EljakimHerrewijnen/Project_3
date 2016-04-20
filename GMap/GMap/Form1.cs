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
using System.Windows.Forms.DataVisualization.Charting;

namespace GMap
{
    public partial class FormOld : Form
    {
        //Maakt de benodigde instances
        Rotterdam RotterdamInstance = new Rotterdam(); 
        GMapOverlay Heatmaps = new GMapOverlay("Heatmaps");

        public FormOld()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Initialize map
            gmap.MapProvider = GMap.NET.MapProviders.GoogleMapProvider.Instance; //Select Google Maps as map provider
            GMap.NET.GMaps.Instance.Mode = GMap.NET.AccessMode.ServerOnly;
            gmap.SetPositionByKeywords("Rotterdam, The Netherlands"); //default pan to Rotterdam
            gmap.BoundsOfMap = new RectLatLng(52.0, 4.0, 0.6, 0.15); //define outer edges of the map (we don't want to see other countries)

            //
            DropdownYear.SelectedIndex = 1;
            comboBox2.SelectedIndex = 1;
            DropdownCrime.SelectedIndex = 3;
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
            Heatmaps.Clear();
            foreach (int i in checkedListBox1.CheckedIndices)
            {
                checkedListBox1.SetItemCheckState(i, CheckState.Unchecked);
            }
            Deel.Checked = false;
            manual2.Checked = false;
            testbox.Checked = false;
            manualdeel.Checked = false;
        }


        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            MapFunctions.TogglePolygons(gmap);
        }

        private void Fijnoort_Click(object sender, EventArgs e)
        {
            Debug.Write(DatabaseRequester.getDataFromYear("_meldingen_overlast", "Zuidplein", "2011"));
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            Deel.Checked = false;
            manual2.Checked = true;
            testbox.Checked = false;
            manualdeel.Checked = false;

            
            if (DropdownCrime.SelectedIndex != -1 && DropdownYear.SelectedIndex != -1)
            {
                MapFunctions.Warp(gmap, comboBox2.SelectedItem, RotterdamInstance, Heatmaps, DictionairContainer.ChangeName(DropdownCrime.SelectedItem.ToString()), DropdownYear.SelectedItem.ToString());
 
            }
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

        //The checklistbox where you can choose manual areas or manual borough
        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (manual2.Checked == false && (testbox.Checked == false || testbox.Checked == true) && (Deel.Checked == false || Deel.Checked == true) && manualdeel.Checked == false)
            {
                if (checkedListBox1.CheckedIndices.Count > 0)
                {
                    manual2.Checked = true;
                    testbox.Checked = false;
                    Deel.Checked = false;
                }
            }
            MapFunctions.Clear(gmap);
            AreaFunctions.DrawAreas(gmap, checkedListBox1, RotterdamInstance, testbox, Deel, manual2, manualdeel, Heatmaps, DictionairContainer.ChangeName(DropdownCrime.SelectedItem.ToString()), DropdownYear.SelectedItem.ToString());
        }
        
        //Dropdown menu where you can select which data you want to see
        private void DropdownCrime_SelectedIndexChanged(object sender, EventArgs e)
        {
            object LocationIndex = DropdownCrime.SelectedItem;
            MapFunctions.Clear(gmap);
            if (DropdownCrime.SelectedIndex != -1 && DropdownYear.SelectedIndex != -1 && (manual2.Checked || manualdeel.Checked))
            {
                AreaFunctions.DrawAreas(gmap, checkedListBox1, RotterdamInstance, testbox, Deel, manual2, manualdeel, Heatmaps, DictionairContainer.ChangeName(DropdownCrime.SelectedItem.ToString()), DropdownYear.SelectedItem.ToString());
            }
            else if ((DropdownCrime.SelectedIndex != -1 && DropdownYear.SelectedIndex != -1))
            {
                AreaFunctions.CheckAll(gmap, RotterdamInstance, testbox, Deel, Heatmaps, DictionairContainer.ChangeName(DropdownCrime.SelectedItem.ToString()), DropdownYear.SelectedItem.ToString());
            }
        }
        //The all area checkbox
        private void testbox_CheckedChanged(object sender, EventArgs e)
        {
            MapFunctions.Clear(gmap);
            Heatmaps.Clear();
            if (testbox.Checked)
            {
                foreach (int i in checkedListBox1.CheckedIndices)
                {
                    checkedListBox1.SetItemCheckState(i, CheckState.Unchecked);
                }
                manualdeel.Checked = false;
                Deel.Checked = false;
                manual2.Checked = false;
                AreaFunctions.CheckAll(gmap, RotterdamInstance, testbox, Deel, Heatmaps, DictionairContainer.ChangeName(DropdownCrime.SelectedItem.ToString()), DropdownYear.SelectedItem.ToString());
            } 
        }
        //not used
        private void checkBox3_CheckedChanged_1(object sender, EventArgs e)
        {
        }

        private void Btn_AddServer_Click(object sender, EventArgs e)
        {
        //    OpenConnectionDatabase AddConnection = new OpenConnectionDatabase();
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
        }

        //The manual borough checkbox
        private void manualdeel_CheckedChanged(object sender, EventArgs e)
        {
            MapFunctions.Clear(gmap);
            Heatmaps.Clear();
            if (manualdeel.Checked)
            {
                manual2.Checked = false;
                testbox.Checked = false;
                Deel.Checked = false;
            }
            else
            {
                foreach (int i in checkedListBox1.CheckedIndices)
                {
                    checkedListBox1.SetItemCheckState(i, CheckState.Unchecked);
                }
            }
        }

        //The all borough checkbox
        private void Deel_CheckedChanged(object sender, EventArgs e)
        {
            MapFunctions.Clear(gmap);
            Heatmaps.Clear();
            if (Deel.Checked)
            {
                foreach (int i in checkedListBox1.CheckedIndices)
                {
                    checkedListBox1.SetItemCheckState(i, CheckState.Unchecked);
                }
                manualdeel.Checked = false;
                manual2.Checked = false;
                testbox.Checked = false;
                AreaFunctions.CheckAll(gmap, RotterdamInstance, testbox, Deel, Heatmaps, DictionairContainer.ChangeName(DropdownCrime.SelectedItem.ToString()), DropdownYear.SelectedItem.ToString());
            }
        }

        //The manual area checkbox
        private void checkBox3_CheckedChanged_2(object sender, EventArgs e)
        {
            MapFunctions.Clear(gmap);
            Heatmaps.Clear();
            if (manual2.Checked)
            {
                testbox.Checked = false;
                Deel.Checked = false;
                manualdeel.Checked = false;
            }
            else
            {
                foreach (int i in checkedListBox1.CheckedIndices)
                {
                    checkedListBox1.SetItemCheckState(i, CheckState.Unchecked);
                }
            }
        }

        //The chart which displays info for the currently selected area on a line chart.
        private void chart1_Click_1(object sender, EventArgs e)
        {
            chart1.Series.Clear();
            if (comboBox2.SelectedItem == null || DropdownCrime.SelectedItem == null/* anderding == null */)
            {
                chart1.Series.Add(new Series());
            }
            else
            {
                Series series = LineChartClass.CreateNewChart(comboBox2.SelectedItem.ToString(), DropdownCrime.SelectedItem.ToString()/*anderding*/);
                chart1.Series.Add(series);
            }
        }

        //The dropdown menu for year
        private void DropdownYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            object LocationIndex = DropdownYear.SelectedItem;

            MapFunctions.Clear(gmap);
            if (DropdownCrime.SelectedIndex != -1 && DropdownYear.SelectedIndex != -1 && (manual2.Checked || manualdeel.Checked))
            {
                AreaFunctions.DrawAreas(gmap, checkedListBox1, RotterdamInstance, testbox, Deel, manual2, manualdeel, Heatmaps, DictionairContainer.ChangeName(DropdownCrime.SelectedItem.ToString()), DropdownYear.SelectedItem.ToString());
            }
            else if ((DropdownCrime.SelectedIndex != -1 && DropdownYear.SelectedIndex != -1))
            {
                AreaFunctions.CheckAll(gmap, RotterdamInstance, testbox, Deel, Heatmaps, DictionairContainer.ChangeName(DropdownCrime.SelectedItem.ToString()), DropdownYear.SelectedItem.ToString());
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            pictureBox1.Visible = !pictureBox1.Visible;
        }


        //private void Btn_AddServer_Click(object sender, EventArgs e)
        //{
        //    OpenConnectionDatabase AddConnection = new OpenConnectionDatabase();
        //}
    }
}

