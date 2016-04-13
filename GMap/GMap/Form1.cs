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
    }

}