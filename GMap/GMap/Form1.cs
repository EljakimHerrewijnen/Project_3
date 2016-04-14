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

        private void Test_Click(object sender, EventArgs e)
        {
            GMapOverlay Heatmaps = new GMapOverlay("Heatmaps");
            List<PointLatLng> schiebroek_points = new List<PointLatLng>();
            List<PointLatLng> noord_points = new List<PointLatLng>();
            List<PointLatLng> feijenoord_points = new List<PointLatLng>();

            Borough Noord = new Borough("Noord", noord_points, true);
            Borough Schiebroek = new Borough("Schiebroek", schiebroek_points, false);
            Borough Feijenoord = new Borough("Feijenoord", feijenoord_points, true);

            Rotterdam Rdam = new Rotterdam();
            Rdam.AddtoRotterdam(Noord);
            Rdam.AddtoRotterdam(Schiebroek);
            Rdam.AddtoRotterdam(Feijenoord);


            // Noord
            noord_points.Add(new PointLatLng(51.94281648774292, 4.485737085342407));
            noord_points.Add(new PointLatLng(51.939390426323214, 4.460556507110596));
            noord_points.Add(new PointLatLng(51.93884143849165, 4.457112550735474));
            noord_points.Add(new PointLatLng(51.93828582950888, 4.455138444900513));
            noord_points.Add(new PointLatLng(51.93717459090055, 4.452981948852539));
            noord_points.Add(new PointLatLng(51.935210012449296, 4.451136589050293));
            noord_points.Add(new PointLatLng(51.93460805368726, 4.447542428970337));
            noord_points.Add(new PointLatLng(51.93406562239103, 4.445675611495972));
            noord_points.Add(new PointLatLng(51.93368856262664, 4.44597601890564));
            noord_points.Add(new PointLatLng(51.926060690953335, 4.432210922241211));
            noord_points.Add(new PointLatLng(51.92207754024217, 4.437103271484375)); // Noordelijke grens Delfshaven
            noord_points.Add(new PointLatLng(51.92310975276089, 4.450128078460693)); // Vervolg op grens Delfshaven(oostelijke richting)
            noord_points.Add(new PointLatLng(51.92322885267803, 4.454913139343262)); // Meest noordoostelijke punt Delfshaven (DIT PUNT KOMT BIJ CENTRUM NET ZUIDELIJKER DAN DE VOLGENDE)
            noord_points.Add(new PointLatLng(51.92396991172871, 4.454827308654785));
            noord_points.Add(new PointLatLng(51.92442645094639, 4.458222985267639));
            noord_points.Add(new PointLatLng(51.92452238975679, 4.460223913192749));
            noord_points.Add(new PointLatLng(51.924704342109806, 4.462412595748901));
            noord_points.Add(new PointLatLng(51.92521711295459, 4.465067982673645));
            noord_points.Add(new PointLatLng(51.92538913799029, 4.465384483337402));
            noord_points.Add(new PointLatLng(51.92584897090665, 4.468206167221069));
            noord_points.Add(new PointLatLng(51.92605738283531, 4.46969211101532));
            noord_points.Add(new PointLatLng(51.92602760976189, 4.470620155334473));
            noord_points.Add(new PointLatLng(51.92616655060219, 4.473280906677246));
            noord_points.Add(new PointLatLng(51.92624594517497, 4.475727081298828));
            noord_points.Add(new PointLatLng(51.92548507474302, 4.482454061508179));
            noord_points.Add(new PointLatLng(51.92498223155278, 4.485189914703369));
            noord_points.Add(new PointLatLng(51.925994528546035, 4.485372304916382));
            noord_points.Add(new PointLatLng(51.92711927620635, 4.484546184539795));
            noord_points.Add(new PointLatLng(51.92836969787115, 4.484760761260986));
            noord_points.Add(new PointLatLng(51.929428228664634, 4.485812187194824));
            noord_points.Add(new PointLatLng(51.93145921471352, 4.486391544342041));
            noord_points.Add(new PointLatLng(51.93317919615934, 4.4879150390625));
            noord_points.Add(new PointLatLng(51.93397962658333, 4.48941707611084));
            noord_points.Add(new PointLatLng(51.93466758843016, 4.489932060241699));
            noord_points.Add(new PointLatLng(51.935375384321524, 4.489953517913818));
            noord_points.Add(new PointLatLng(51.935792118736195, 4.48766827583313));
            noord_points.Add(new PointLatLng(51.93752516319531, 4.48691725730896));
            noord_points.Add(new PointLatLng(51.93860332119872, 4.48567271232605));
            noord_points.Add(new PointLatLng(51.93964176790779, 4.4857800006866455));
            noord_points.Add(new PointLatLng(51.94046853950135, 4.48667049407959));
            noord_points.Add(new PointLatLng(51.94117624388162, 4.486466646194458));
            noord_points.Add(new PointLatLng(51.94144741736775, 4.487013816833496));

            //Schiebroek
            schiebroek_points.Add(new PointLatLng(51.96708905110036, 4.457037448883057));
            schiebroek_points.Add(new PointLatLng(51.96708905110036, 4.457037448883057));
            schiebroek_points.Add(new PointLatLng(51.96340041540989, 4.4614577293396));
            schiebroek_points.Add(new PointLatLng(51.956141245872814, 4.461522102355957));
            schiebroek_points.Add(new PointLatLng(51.95209464118261, 4.45995569229126));
            schiebroek_points.Add(new PointLatLng(51.94066696241652, 4.4599127769470215));
            schiebroek_points.Add(new PointLatLng(51.939390426323214, 4.460556507110596));
            schiebroek_points.Add(new PointLatLng(51.93884143849165, 4.457112550735474));
            schiebroek_points.Add(new PointLatLng(51.94281648774292, 4.485737085342407));
            schiebroek_points.Add(new PointLatLng(51.94873541741756, 4.530315399169922));
            schiebroek_points.Add(new PointLatLng(51.95075891698686, 4.529628753662109));
            schiebroek_points.Add(new PointLatLng(51.95328485694294, 4.530315399169922));
            schiebroek_points.Add(new PointLatLng(51.95328485694294, 4.530315399169922));
            schiebroek_points.Add(new PointLatLng(51.956273481693835, 4.528083801269531));
            schiebroek_points.Add(new PointLatLng(51.95944702439491, 4.526302814483643));
            schiebroek_points.Add(new PointLatLng(51.96432590808907, 4.524843692779541));
            schiebroek_points.Add(new PointLatLng(51.96354585123928, 4.523191452026367));
            schiebroek_points.Add(new PointLatLng(51.96341363686843, 4.521174430847168));
            schiebroek_points.Add(new PointLatLng(51.95965858592097, 4.518256187438965));
            schiebroek_points.Add(new PointLatLng(51.965714111277784, 4.505832195281982));
            schiebroek_points.Add(new PointLatLng(51.96630904233955, 4.5064544677734375));
            schiebroek_points.Add(new PointLatLng(51.971689504568346, 4.49589729309082));
            schiebroek_points.Add(new PointLatLng(51.967452609867486, 4.495221376419067));
            schiebroek_points.Add(new PointLatLng(51.969415776248084, 4.490629434585571));
            schiebroek_points.Add(new PointLatLng(51.972780060062085, 4.4836342334747314));
            schiebroek_points.Add(new PointLatLng(51.9733352417543, 4.482904672622681));
            schiebroek_points.Add(new PointLatLng(51.97995062752042, 4.469332695007324));
            schiebroek_points.Add(new PointLatLng(51.97850338883613, 4.466832876205444));
            schiebroek_points.Add(new PointLatLng(51.97885363810285, 4.465835094451904));
            schiebroek_points.Add(new PointLatLng(51.9782654821121, 4.46420431137085));
            schiebroek_points.Add(new PointLatLng(51.977498885184865, 4.463227987289429));
            schiebroek_points.Add(new PointLatLng(51.97728740786198, 4.463539123535156));
            schiebroek_points.Add(new PointLatLng(51.975919389814905, 4.461961984634399));
            schiebroek_points.Add(new PointLatLng(51.975195711201444, 4.460878372192383));
            schiebroek_points.Add(new PointLatLng(51.97238349749894, 4.46169376373291));
            schiebroek_points.Add(new PointLatLng(51.97236366927866, 4.4615113735198975));
            schiebroek_points.Add(new PointLatLng(51.972039807105304, 4.4615864753723145));
            schiebroek_points.Add(new PointLatLng(51.971861351438115, 4.46044921875));
            schiebroek_points.Add(new PointLatLng(51.97034775442492, 4.461854696273804));
            schiebroek_points.Add(new PointLatLng(51.96937611717232, 4.4620585441589355));
            schiebroek_points.Add(new PointLatLng(51.96708905110036, 4.457037448883057));


            //Feijenoord
            feijenoord_points.Add(new PointLatLng(51.918279323170914, 4.500231742858887));
            feijenoord_points.Add(new PointLatLng(51.917723459571604, 4.505767822265625));
            feijenoord_points.Add(new PointLatLng(51.91616171072476, 4.509994983673096));
            feijenoord_points.Add(new PointLatLng(51.913871929886554, 4.513943195343018));
            feijenoord_points.Add(new PointLatLng(51.9103377614944, 4.5163679122924805));
            feijenoord_points.Add(new PointLatLng(51.904407146183786, 4.5174407958984375));
            feijenoord_points.Add(new PointLatLng(51.90173281794483, 4.513213634490967));
            feijenoord_points.Add(new PointLatLng(51.886663577703885, 4.524983167648315));
            feijenoord_points.Add(new PointLatLng(51.88655100285276, 4.5240068435668945));
            feijenoord_points.Add(new PointLatLng(51.886584113132336, 4.523524045944214));
            feijenoord_points.Add(new PointLatLng(51.88641856149043, 4.522762298583984));
            feijenoord_points.Add(new PointLatLng(51.88503452590689, 4.522022008895874));
            feijenoord_points.Add(new PointLatLng(51.884041172664126, 4.521753787994385));
            feijenoord_points.Add(new PointLatLng(51.882842497191916, 4.521356821060181));
            feijenoord_points.Add(new PointLatLng(51.88221996803803, 4.516668319702148));
            feijenoord_points.Add(new PointLatLng(51.88202790943132, 4.516110420227051));
            feijenoord_points.Add(new PointLatLng(51.882465007138066, 4.515520334243774));
            feijenoord_points.Add(new PointLatLng(51.88239878048598, 4.513835906982422));
            feijenoord_points.Add(new PointLatLng(51.882114004770294, 4.513149261474609));
            feijenoord_points.Add(new PointLatLng(51.881100718408575, 4.511518478393555));
            feijenoord_points.Add(new PointLatLng(51.879637042231295, 4.5098876953125));
            feijenoord_points.Add(new PointLatLng(51.87752423104397, 4.505993127822876)); // Grens oost Charlois
            feijenoord_points.Add(new PointLatLng(51.878848889167095, 4.503611326217651));
            feijenoord_points.Add(new PointLatLng(51.882551101639905, 4.498579502105713));
            feijenoord_points.Add(new PointLatLng(51.883114023165284, 4.497431516647339));
            feijenoord_points.Add(new PointLatLng(51.88438553760754, 4.493333101272583));
            feijenoord_points.Add(new PointLatLng(51.88496168074829, 4.491895437240601));
            feijenoord_points.Add(new PointLatLng(51.88848460230135, 4.492743015289307));
            feijenoord_points.Add(new PointLatLng(51.88919974814752, 4.4939446449279785));
            feijenoord_points.Add(new PointLatLng(51.894251796941376, 4.493805170059204));
            feijenoord_points.Add(new PointLatLng(51.89796598165136, 4.4956183433532715));
            feijenoord_points.Add(new PointLatLng(51.89989908999172, 4.496079683303833));
            feijenoord_points.Add(new PointLatLng(51.8958275491638, 4.477636814117432));
            feijenoord_points.Add(new PointLatLng(51.89838306343293, 4.469354152679443));
            feijenoord_points.Add(new PointLatLng(51.90027643362919, 4.468109607696533));
            feijenoord_points.Add(new PointLatLng(51.904274757442565, 4.478945732116699));
            feijenoord_points.Add(new PointLatLng(51.905360333602275, 4.478559494018555));
            feijenoord_points.Add(new PointLatLng(51.9062870242002, 4.4788384437561035));
            feijenoord_points.Add(new PointLatLng(51.91036423569981, 4.483494758605957));
            feijenoord_points.Add(new PointLatLng(51.9096759012868, 4.485254287719727));
            feijenoord_points.Add(new PointLatLng(51.910331142940606, 4.485608339309692));
            feijenoord_points.Add(new PointLatLng(51.91701538525815, 4.495725631713867));

            //Hier maak je instances van GMapPolygon met de lijst van coordinaten die je in een list<PointLatLng> hebt gezet. Hier kan je ook de kleur
            GMapPolygon feijenoord = new GMapPolygon(feijenoord_points, "Feijenoord");
            feijenoord.Fill = new SolidBrush(Color.FromArgb(100, Color.Green));
            feijenoord.Stroke = new Pen(Color.Green, 1);

            GMapPolygon noord = new GMapPolygon(noord_points, "Noord");
            noord.Fill = new SolidBrush(Color.FromArgb(100, Color.Red));
            noord.Stroke = new Pen(Color.Red, 1);

            GMapPolygon schiebroek = new GMapPolygon(schiebroek_points, "Schiebroek");
            schiebroek.Fill = new SolidBrush(Color.FromArgb(100, Color.Blue));
            schiebroek.Stroke = new Pen(Color.Blue, 1);

            //Hier zet je de variabele die je hiervoor hebt aangemaakt in. // De variabelen kunnen ergens anders, zodat ze niet steeds opnieuw worden aangemaakt(de coordinaten blijven altijd hetzelfde).
            foreach (Borough deelgemeente in Rdam.Deelgemeenten)
            {
                if (deelgemeente.Draw == true)
                {
                    Heatmaps.Polygons.Add(new GMapPolygon(deelgemeente.Deelgemeente, "x"));
                }
            }

            //Heatmaps.Polygons.Add(schiebroek); 
            //Heatmaps.Polygons.Add(noord);
            //Heatmaps.Polygons.Add(feijenoord);
            gmap.Overlays.Add(Heatmaps);
        }
                    
    }

}