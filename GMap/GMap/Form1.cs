﻿using System;
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
            GMapOverlay Heatmaps = new GMapOverlay("Heatmaps");
            List<PointLatLng> schiebroek_points = new List<PointLatLng>();
            List<PointLatLng> noord_points = new List<PointLatLng>();
            List<PointLatLng> feijenoord_points = new List<PointLatLng>();
            List<PointLatLng> pernis_points = new List<PointLatLng>();
            List<PointLatLng> rozenburg_points = new List<PointLatLng>();
            List<PointLatLng> hoekvanholland_points = new List<PointLatLng>();

            Borough Hoek_van_Holland = new Borough("Hoek van Holland", hoekvanholland_points, true);
            Borough Pernis = new Borough("Pernis", pernis_points, true);
            Borough Noord = new Borough("Noord", noord_points, true);
            Borough Schiebroek = new Borough("Schiebroek", schiebroek_points, true);
            Borough Feijenoord = new Borough("Feijenoord", feijenoord_points, true);
            Borough Rozenburg = new Borough("Rozenburg", rozenburg_points, true);

            Rotterdam Rdam = new Rotterdam();
            Rdam.AddtoRotterdam(Hoek_van_Holland);
            Rdam.AddtoRotterdam(Rozenburg);
            Rdam.AddtoRotterdam(Pernis);
            Rdam.AddtoRotterdam(Noord);
            Rdam.AddtoRotterdam(Schiebroek);
            Rdam.AddtoRotterdam(Feijenoord);

            hoekvanholland_points.Add(new PointLatLng(51.9787932221, 4.15535666164));
            hoekvanholland_points.Add(new PointLatLng(51.9777427033, 4.15956636145));
            hoekvanholland_points.Add(new PointLatLng(51.9777085861, 4.15989621907));
            hoekvanholland_points.Add(new PointLatLng(51.976610973, 4.16382124599));
            hoekvanholland_points.Add(new PointLatLng(51.976568747, 4.16396647484));
            hoekvanholland_points.Add(new PointLatLng(51.9759674623, 4.1659686851));
            hoekvanholland_points.Add(new PointLatLng(51.9759673104, 4.16620681957));
            hoekvanholland_points.Add(new PointLatLng(51.9749376921, 4.16986309155));
            hoekvanholland_points.Add(new PointLatLng(51.9747253499, 4.17051054356));
            hoekvanholland_points.Add(new PointLatLng(51.9746313702, 4.17059336063));
            hoekvanholland_points.Add(new PointLatLng(51.9744411346, 4.17116296624));
            hoekvanholland_points.Add(new PointLatLng(51.9740195474, 4.17242523337));
            hoekvanholland_points.Add(new PointLatLng(51.9739225799, 4.17249744136));
            hoekvanholland_points.Add(new PointLatLng(51.9737726603, 4.17291165175));
            hoekvanholland_points.Add(new PointLatLng(51.9737177162, 4.17306345178));
            hoekvanholland_points.Add(new PointLatLng(51.973650059, 4.17328830608));
            hoekvanholland_points.Add(new PointLatLng(51.9729520942, 4.17535892756));
            hoekvanholland_points.Add(new PointLatLng(51.9726579242, 4.17615679045));
            hoekvanholland_points.Add(new PointLatLng(51.9721871835, 4.17733028451));
            hoekvanholland_points.Add(new PointLatLng(51.9718563967, 4.17807960261));
            hoekvanholland_points.Add(new PointLatLng(51.9714587443, 4.17906408644));
            hoekvanholland_points.Add(new PointLatLng(51.9712829534, 4.17950086947));
            hoekvanholland_points.Add(new PointLatLng(51.9710577818, 4.18009821877));
            hoekvanholland_points.Add(new PointLatLng(51.9710515243, 4.18011482069));
            hoekvanholland_points.Add(new PointLatLng(51.9710202795, 4.18020985214));
            hoekvanholland_points.Add(new PointLatLng(51.9710132618, 4.18023121967));
            hoekvanholland_points.Add(new PointLatLng(51.9709979538, 4.18028835552));
            hoekvanholland_points.Add(new PointLatLng(51.9709721823, 4.18035345835));
            hoekvanholland_points.Add(new PointLatLng(51.9705452535, 4.1813919193));
            hoekvanholland_points.Add(new PointLatLng(51.9705125892, 4.18147136875));
            hoekvanholland_points.Add(new PointLatLng(51.9702647205, 4.18201997887));
            hoekvanholland_points.Add(new PointLatLng(51.9701324054, 4.1823226935));
            hoekvanholland_points.Add(new PointLatLng(51.9698708652, 4.18292107689));
            hoekvanholland_points.Add(new PointLatLng(51.9697435015, 4.18321238739));
            hoekvanholland_points.Add(new PointLatLng(51.9693329884, 4.18415134716));
            hoekvanholland_points.Add(new PointLatLng(51.968944173, 4.18506685652));
            hoekvanholland_points.Add(new PointLatLng(51.9688015442, 4.18540266565));
            hoekvanholland_points.Add(new PointLatLng(51.9678006148, 4.18775313299));
            hoekvanholland_points.Add(new PointLatLng(51.9677813162, 4.18773493172));
            hoekvanholland_points.Add(new PointLatLng(51.9668325666, 4.18684030455));
            hoekvanholland_points.Add(new PointLatLng(51.9666215785, 4.18742423868));
            hoekvanholland_points.Add(new PointLatLng(51.9663584073, 4.18816929536));
            hoekvanholland_points.Add(new PointLatLng(51.9663552095, 4.18817837537));
            hoekvanholland_points.Add(new PointLatLng(51.9663525739, 4.18818792064));
            hoekvanholland_points.Add(new PointLatLng(51.9663505445, 4.18819784268));
            hoekvanholland_points.Add(new PointLatLng(51.9663491201, 4.18820803962));
            hoekvanholland_points.Add(new PointLatLng(51.966348318, 4.18821842369));
            hoekvanholland_points.Add(new PointLatLng(51.9663481548, 4.18822886345));
            hoekvanholland_points.Add(new PointLatLng(51.9663486299, 4.1882393007));
            hoekvanholland_points.Add(new PointLatLng(51.9663497327, 4.18824959019));
            hoekvanholland_points.Add(new PointLatLng(51.9663514538, 4.18825967394));
            hoekvanholland_points.Add(new PointLatLng(51.9663537827, 4.18826942126));
            hoekvanholland_points.Add(new PointLatLng(51.9663567009, 4.18827875986));
            hoekvanholland_points.Add(new PointLatLng(51.966360162, 4.18828757455));
            hoekvanholland_points.Add(new PointLatLng(51.9663641477, 4.1882958076));
            hoekvanholland_points.Add(new PointLatLng(51.9663686029, 4.18830335861));
            hoekvanholland_points.Add(new PointLatLng(51.966373509, 4.18831016985));
            hoekvanholland_points.Add(new PointLatLng(51.966392887, 4.18833087202));
            hoekvanholland_points.Add(new PointLatLng(51.9663316107, 4.18846400745));
            hoekvanholland_points.Add(new PointLatLng(51.9662897981, 4.18855485175));
            hoekvanholland_points.Add(new PointLatLng(51.9662703339, 4.18859711342));
            hoekvanholland_points.Add(new PointLatLng(51.966181704, 4.18878969061));
            hoekvanholland_points.Add(new PointLatLng(51.9662678793, 4.18891102629));
            hoekvanholland_points.Add(new PointLatLng(51.9662974722, 4.18895311248));
            hoekvanholland_points.Add(new PointLatLng(51.9663241217, 4.18900013846));
            hoekvanholland_points.Add(new PointLatLng(51.9663805566, 4.18911167382));
            hoekvanholland_points.Add(new PointLatLng(51.9663941395, 4.18914596471));
            hoekvanholland_points.Add(new PointLatLng(51.9664039318, 4.18917351635));
            hoekvanholland_points.Add(new PointLatLng(51.9664685189, 4.18938371623));
            hoekvanholland_points.Add(new PointLatLng(51.9669727176, 4.19077133547));
            hoekvanholland_points.Add(new PointLatLng(51.9669258033, 4.19081865167));
            hoekvanholland_points.Add(new PointLatLng(51.9669451292, 4.19086961523));
            hoekvanholland_points.Add(new PointLatLng(51.9669451283, 4.19086961525));
            hoekvanholland_points.Add(new PointLatLng(51.966906839, 4.19091010812));
            hoekvanholland_points.Add(new PointLatLng(51.9668190691, 4.1910029192));
            hoekvanholland_points.Add(new PointLatLng(51.9666697681, 4.19116082773));
            hoekvanholland_points.Add(new PointLatLng(51.9666753076, 4.19117600574));
            hoekvanholland_points.Add(new PointLatLng(51.9665634369, 4.19129373501));
            hoekvanholland_points.Add(new PointLatLng(51.9664082927, 4.19145702241));
            hoekvanholland_points.Add(new PointLatLng(51.9661331323, 4.19072536959));
            hoekvanholland_points.Add(new PointLatLng(51.9657212191, 4.18963010439));
            hoekvanholland_points.Add(new PointLatLng(51.9652522256, 4.1890188897));
            hoekvanholland_points.Add(new PointLatLng(51.964964286, 4.188643627));
            hoekvanholland_points.Add(new PointLatLng(51.9641487046, 4.18758077314));
            hoekvanholland_points.Add(new PointLatLng(51.9641050434, 4.18752387222));
            hoekvanholland_points.Add(new PointLatLng(51.9637143053, 4.18701469318));
            hoekvanholland_points.Add(new PointLatLng(51.9637068037, 4.18700726791));
            hoekvanholland_points.Add(new PointLatLng(51.9636989791, 4.18700079725));
            hoekvanholland_points.Add(new PointLatLng(51.9636908677, 4.18699528025));
            hoekvanholland_points.Add(new PointLatLng(51.9636825329, 4.18699078796));
            hoekvanholland_points.Add(new PointLatLng(51.9636740019, 4.18698731965));
            hoekvanholland_points.Add(new PointLatLng(51.9636653379, 4.18698491731));
            hoekvanholland_points.Add(new PointLatLng(51.9636565857, 4.18698356517));
            hoekvanholland_points.Add(new PointLatLng(51.9636477997, 4.18698330543));
            hoekvanholland_points.Add(new PointLatLng(51.9636390245, 4.18698410781));
            hoekvanholland_points.Add(new PointLatLng(51.9636303053, 4.18698598563));
            hoekvanholland_points.Add(new PointLatLng(51.9636217048, 4.18698892268));
            hoekvanholland_points.Add(new PointLatLng(51.9636132678, 4.18699290319));
            hoekvanholland_points.Add(new PointLatLng(51.9636050391, 4.18699791142));
            hoekvanholland_points.Add(new PointLatLng(51.9635970631, 4.18700390251));
            hoekvanholland_points.Add(new PointLatLng(51.9635893936, 4.18701086047));
            hoekvanholland_points.Add(new PointLatLng(51.963106552, 4.1873533218));
            hoekvanholland_points.Add(new PointLatLng(51.9627171058, 4.18762953586));
            hoekvanholland_points.Add(new PointLatLng(51.9621342338, 4.18804292548));
            hoekvanholland_points.Add(new PointLatLng(51.9615573494, 4.18845205497));
            hoekvanholland_points.Add(new PointLatLng(51.9605186406, 4.18918738999));
            hoekvanholland_points.Add(new PointLatLng(51.9590893805, 4.19019915117));
            hoekvanholland_points.Add(new PointLatLng(51.9588281443, 4.19038262009));
            hoekvanholland_points.Add(new PointLatLng(51.9571342887, 4.19157223214));
            hoekvanholland_points.Add(new PointLatLng(51.9570541212, 4.19162852819));
            hoekvanholland_points.Add(new PointLatLng(51.9564940622, 4.19203139775));
            hoekvanholland_points.Add(new PointLatLng(51.9561748979, 4.19230663301));
            hoekvanholland_points.Add(new PointLatLng(51.9557681437, 4.19265718332));
            hoekvanholland_points.Add(new PointLatLng(51.9547222897, 4.19467847049));
            hoekvanholland_points.Add(new PointLatLng(51.9538162266, 4.19643371599));
            hoekvanholland_points.Add(new PointLatLng(51.9534854087, 4.19707454984));
            hoekvanholland_points.Add(new PointLatLng(51.9529811339, 4.19805137527));
            hoekvanholland_points.Add(new PointLatLng(51.9529524071, 4.19810701874));
            hoekvanholland_points.Add(new PointLatLng(51.9529482665, 4.19810295265));
            hoekvanholland_points.Add(new PointLatLng(51.9526418338, 4.19870418051));
            hoekvanholland_points.Add(new PointLatLng(51.9522224474, 4.19952699872));
            hoekvanholland_points.Add(new PointLatLng(51.9515022597, 4.20091211892));
            hoekvanholland_points.Add(new PointLatLng(51.9514420162, 4.20102782241));
            hoekvanholland_points.Add(new PointLatLng(51.9513077177, 4.20128573863));
            hoekvanholland_points.Add(new PointLatLng(51.9511628887, 4.20156389317));
            hoekvanholland_points.Add(new PointLatLng(51.9511108288, 4.2016638837));
            hoekvanholland_points.Add(new PointLatLng(51.9510754774, 4.20165296001));
            hoekvanholland_points.Add(new PointLatLng(51.9510445536, 4.20162643895));
            hoekvanholland_points.Add(new PointLatLng(51.9510286129, 4.20165661333));
            hoekvanholland_points.Add(new PointLatLng(51.9510535669, 4.2017142966));
            hoekvanholland_points.Add(new PointLatLng(51.9510410796, 4.2017927269));
            hoekvanholland_points.Add(new PointLatLng(51.9493968922, 4.20496944404));
            hoekvanholland_points.Add(new PointLatLng(51.9492339485, 4.20528424883));
            hoekvanholland_points.Add(new PointLatLng(51.9482478391, 4.20718769775));
            hoekvanholland_points.Add(new PointLatLng(51.9479588953, 4.20774542259));
            hoekvanholland_points.Add(new PointLatLng(51.9465103664, 4.21053098301));
            hoekvanholland_points.Add(new PointLatLng(51.9457154089, 4.21207009049));
            hoekvanholland_points.Add(new PointLatLng(51.9448509414, 4.21374367489));
            hoekvanholland_points.Add(new PointLatLng(51.9437711499, 4.21582425126));
            hoekvanholland_points.Add(new PointLatLng(51.9430670753, 4.21718080064));
            hoekvanholland_points.Add(new PointLatLng(51.9427270586, 4.21783806091));
            hoekvanholland_points.Add(new PointLatLng(51.942597407, 4.21808868527));
            hoekvanholland_points.Add(new PointLatLng(51.9425128657, 4.21949754407));
            hoekvanholland_points.Add(new PointLatLng(51.9424855294, 4.21995296254));
            hoekvanholland_points.Add(new PointLatLng(51.9423603905, 4.21979399533));
            hoekvanholland_points.Add(new PointLatLng(51.9423648543, 4.21971845613));
            hoekvanholland_points.Add(new PointLatLng(51.9422022459, 4.21957591295));
            hoekvanholland_points.Add(new PointLatLng(51.9401012753, 4.21773293522));
            hoekvanholland_points.Add(new PointLatLng(51.9383428131, 4.21618925708));
            hoekvanholland_points.Add(new PointLatLng(51.9380567638, 4.21593825397));
            hoekvanholland_points.Add(new PointLatLng(51.9380370107, 4.21592092263));
            hoekvanholland_points.Add(new PointLatLng(51.9379704593, 4.21586253009));
            hoekvanholland_points.Add(new PointLatLng(51.9378269718, 4.21573662048));
            hoekvanholland_points.Add(new PointLatLng(51.9377824228, 4.21569753721));
            hoekvanholland_points.Add(new PointLatLng(51.9377642748, 4.21568160413));
            hoekvanholland_points.Add(new PointLatLng(51.9376779632, 4.21560880494));
            hoekvanholland_points.Add(new PointLatLng(51.9375556543, 4.21556836244));
            hoekvanholland_points.Add(new PointLatLng(51.9374432954, 4.2154438823));
            hoekvanholland_points.Add(new PointLatLng(51.9374566871, 4.21540746159));
            hoekvanholland_points.Add(new PointLatLng(51.9370596955, 4.21505974821));
            hoekvanholland_points.Add(new PointLatLng(51.9368829521, 4.21490493922));
            hoekvanholland_points.Add(new PointLatLng(51.9346872577, 4.2129819733));
            hoekvanholland_points.Add(new PointLatLng(51.9360663584, 4.20961523659));
            hoekvanholland_points.Add(new PointLatLng(51.9396362481, 4.19989480623));
            hoekvanholland_points.Add(new PointLatLng(51.9424906302, 4.19211993593));
            hoekvanholland_points.Add(new PointLatLng(51.9427109736, 4.19152885005));
            hoekvanholland_points.Add(new PointLatLng(51.944768286, 4.18649245518));
            hoekvanholland_points.Add(new PointLatLng(51.9450032777, 4.18591209426));
            hoekvanholland_points.Add(new PointLatLng(51.9452394609, 4.18533299729));
            hoekvanholland_points.Add(new PointLatLng(51.9454768328, 4.18475517159));
            hoekvanholland_points.Add(new PointLatLng(51.9457153909, 4.18417862447));
            hoekvanholland_points.Add(new PointLatLng(51.9459551325, 4.1836033589));
            hoekvanholland_points.Add(new PointLatLng(51.9461960552, 4.18302938509));
            hoekvanholland_points.Add(new PointLatLng(51.9464381561, 4.18245670747));
            hoekvanholland_points.Add(new PointLatLng(51.9466814319, 4.18188533336));
            hoekvanholland_points.Add(new PointLatLng(51.9469258818, 4.1813152686));
            hoekvanholland_points.Add(new PointLatLng(51.9471714721, 4.18074648642));
            hoekvanholland_points.Add(new PointLatLng(51.9474182312, 4.18017902677));
            hoekvanholland_points.Add(new PointLatLng(51.9476661547, 4.17961289411));
            hoekvanholland_points.Add(new PointLatLng(51.9479152399, 4.17904809721));
            hoekvanholland_points.Add(new PointLatLng(51.9481654843, 4.1784846405));
            hoekvanholland_points.Add(new PointLatLng(51.9484168853, 4.17792252983));
            hoekvanholland_points.Add(new PointLatLng(51.948669441, 4.17736177252));
            hoekvanholland_points.Add(new PointLatLng(51.9489231463, 4.17680237305));
            hoekvanholland_points.Add(new PointLatLng(51.9491780012, 4.17624434157));
            hoekvanholland_points.Add(new PointLatLng(51.9493457926, 4.17587902476));
            hoekvanholland_points.Add(new PointLatLng(51.9495140735, 4.17551429721));
            hoekvanholland_points.Add(new PointLatLng(51.9496828449, 4.1751501618));
            hoekvanholland_points.Add(new PointLatLng(51.949852104, 4.17478662004));
            hoekvanholland_points.Add(new PointLatLng(51.950021851, 4.17442367193));
            hoekvanholland_points.Add(new PointLatLng(51.9501920849, 4.17406132041));
            hoekvanholland_points.Add(new PointLatLng(51.9503628048, 4.17369956693));
            hoekvanholland_points.Add(new PointLatLng(51.9505340108, 4.17333841442));
            hoekvanholland_points.Add(new PointLatLng(51.9507057011, 4.1729778629));
            hoekvanholland_points.Add(new PointLatLng(51.9508778802, 4.17261792099));
            hoekvanholland_points.Add(new PointLatLng(51.9510505419, 4.17225858449));
            hoekvanholland_points.Add(new PointLatLng(51.9512236862, 4.17189985483));
            hoekvanholland_points.Add(new PointLatLng(51.9513973122, 4.17154173351));
            hoekvanholland_points.Add(new PointLatLng(51.9515714181, 4.17118422201));
            hoekvanholland_points.Add(new PointLatLng(51.9517460039, 4.17082732178));
            hoekvanholland_points.Add(new PointLatLng(51.9519210679, 4.17047103579));
            hoekvanholland_points.Add(new PointLatLng(51.952096611, 4.170115364));
            hoekvanholland_points.Add(new PointLatLng(51.9522726305, 4.16976031085));
            hoekvanholland_points.Add(new PointLatLng(51.9595116371, 4.15528717659));
            hoekvanholland_points.Add(new PointLatLng(51.9601314422, 4.15406980627));
            hoekvanholland_points.Add(new PointLatLng(51.9651859641, 4.14413994513));
            hoekvanholland_points.Add(new PointLatLng(51.9653001209, 4.14391633042));
            hoekvanholland_points.Add(new PointLatLng(51.9686805495, 4.13729375829));
            hoekvanholland_points.Add(new PointLatLng(51.9688830845, 4.13689512378));
            hoekvanholland_points.Add(new PointLatLng(51.9689889227, 4.13670295533));
            hoekvanholland_points.Add(new PointLatLng(51.9692002883, 4.13628951377));
            hoekvanholland_points.Add(new PointLatLng(51.9693061254, 4.13609734254));
            hoekvanholland_points.Add(new PointLatLng(51.969728851, 4.13527044398));
            hoekvanholland_points.Add(new PointLatLng(51.9698255439, 4.13506396783));
            hoekvanholland_points.Add(new PointLatLng(51.9700369037, 4.13465051085));
            hoekvanholland_points.Add(new PointLatLng(51.9701335956, 4.13444403195));
            hoekvanholland_points.Add(new PointLatLng(51.9702392746, 4.13423730107));
            hoekvanholland_points.Add(new PointLatLng(51.9706348692, 4.13339657016));
            hoekvanholland_points.Add(new PointLatLng(51.9707314036, 4.13317553434));
            hoekvanholland_points.Add(new PointLatLng(51.9708280928, 4.13296904907));
            hoekvanholland_points.Add(new PointLatLng(51.9709246264, 4.13274801139));
            hoekvanholland_points.Add(new PointLatLng(51.9710213149, 4.13254152432));
            hoekvanholland_points.Add(new PointLatLng(51.9711178477, 4.13232048477));
            hoekvanholland_points.Add(new PointLatLng(51.9712145354, 4.13211399588));
            hoekvanholland_points.Add(new PointLatLng(51.9713020799, 4.13189320603));
            hoekvanholland_points.Add(new PointLatLng(51.9715828413, 4.13124487965));
            hoekvanholland_points.Add(new PointLatLng(51.9717672251, 4.13083214387));
            hoekvanholland_points.Add(new PointLatLng(51.9719062099, 4.13048620016));
            hoekvanholland_points.Add(new PointLatLng(51.9719774809, 4.13031678613));
            hoekvanholland_points.Add(new PointLatLng(51.9722143856, 4.12977156375));
            hoekvanholland_points.Add(new PointLatLng(51.9724421446, 4.12921203572));
            hoekvanholland_points.Add(new PointLatLng(51.9726790441, 4.12866680187));
            hoekvanholland_points.Add(new PointLatLng(51.9727929213, 4.12838703288));
            hoekvanholland_points.Add(new PointLatLng(51.9728978103, 4.1281075148));
            hoekvanholland_points.Add(new PointLatLng(51.9729160744, 4.12806013437));
            hoekvanholland_points.Add(new PointLatLng(51.9729345184, 4.12801293809));
            hoekvanholland_points.Add(new PointLatLng(51.9729531433, 4.12796592738));
            hoekvanholland_points.Add(new PointLatLng(51.9729719464, 4.12791910377));
            hoekvanholland_points.Add(new PointLatLng(51.9729909277, 4.12787246872));
            hoekvanholland_points.Add(new PointLatLng(51.9730100872, 4.12782602513));
            hoekvanholland_points.Add(new PointLatLng(51.9730294232, 4.12777977452));
            hoekvanholland_points.Add(new PointLatLng(51.9730489357, 4.12773371689));
            hoekvanholland_points.Add(new PointLatLng(51.9730686238, 4.12768785661));
            hoekvanholland_points.Add(new PointLatLng(51.9730883109, 4.12764199487));
            hoekvanholland_points.Add(new PointLatLng(51.9731078224, 4.12759593714));
            hoekvanholland_points.Add(new PointLatLng(51.9731271583, 4.12754968488));
            hoekvanholland_points.Add(new PointLatLng(51.9731463168, 4.12750324104));
            hoekvanholland_points.Add(new PointLatLng(51.9731652989, 4.12745660561));
            hoekvanholland_points.Add(new PointLatLng(51.9731841018, 4.12740978156));
            hoekvanholland_points.Add(new PointLatLng(51.9732027264, 4.12736277034));
            hoekvanholland_points.Add(new PointLatLng(51.9732211711, 4.1273155749));
            hoekvanholland_points.Add(new PointLatLng(51.9732394357, 4.12726819524));
            hoekvanholland_points.Add(new PointLatLng(51.9733443221, 4.12698867178));
            hoekvanholland_points.Add(new PointLatLng(51.9734581952, 4.12670889439));
            hoekvanholland_points.Add(new PointLatLng(51.9735629242, 4.12641481592));
            hoekvanholland_points.Add(new PointLatLng(51.9737124231, 4.12604367988));
            hoekvanholland_points.Add(new PointLatLng(51.9737784736, 4.12586405167));
            hoekvanholland_points.Add(new PointLatLng(51.9738635062, 4.12565899676));
            hoekvanholland_points.Add(new PointLatLng(51.9743270141, 4.12439448279));
            hoekvanholland_points.Add(new PointLatLng(51.9745063241, 4.12389562475));
            hoekvanholland_points.Add(new PointLatLng(51.9746379173, 4.1235459595));
            hoekvanholland_points.Add(new PointLatLng(51.9746936353, 4.12335814425));
            hoekvanholland_points.Add(new PointLatLng(51.9747248198, 4.12326692531));
            hoekvanholland_points.Add(new PointLatLng(51.9748296965, 4.12298738329));
            hoekvanholland_points.Add(new PointLatLng(51.9749344161, 4.12269328719));
            hoekvanholland_points.Add(new PointLatLng(51.9750301474, 4.12239944322));
            hoekvanholland_points.Add(new PointLatLng(51.9751348655, 4.12210534444));
            hoekvanholland_points.Add(new PointLatLng(51.9752305954, 4.1218114979));
            hoekvanholland_points.Add(new PointLatLng(51.9753354686, 4.12153194935));
            hoekvanholland_points.Add(new PointLatLng(51.975473405, 4.12112587963));
            hoekvanholland_points.Add(new PointLatLng(51.9758139466, 4.1200481385));
            hoekvanholland_points.Add(new PointLatLng(51.9759486282, 4.11963042277));
            hoekvanholland_points.Add(new PointLatLng(51.9761147825, 4.11912646051));
            hoekvanholland_points.Add(new PointLatLng(51.9762084641, 4.11883385125));
            hoekvanholland_points.Add(new PointLatLng(51.9762660714, 4.11862327169));
            hoekvanholland_points.Add(new PointLatLng(51.9763791392, 4.11827068882));
            hoekvanholland_points.Add(new PointLatLng(51.9765614343, 4.11766866313));
            hoekvanholland_points.Add(new PointLatLng(51.9767347389, 4.11706688714));
            hoekvanholland_points.Add(new PointLatLng(51.9769170279, 4.11646485182));
            hoekvanholland_points.Add(new PointLatLng(51.977177053, 4.11556944876));
            hoekvanholland_points.Add(new PointLatLng(51.9772546341, 4.11526153139));
            hoekvanholland_points.Add(new PointLatLng(51.9775144925, 4.1143515611));
            hoekvanholland_points.Add(new PointLatLng(51.9775920704, 4.11404363933));
            hoekvanholland_points.Add(new PointLatLng(51.9777046515, 4.11364737368));
            hoekvanholland_points.Add(new PointLatLng(51.9783082101, 4.11127178419));
            hoekvanholland_points.Add(new PointLatLng(51.9790614999, 4.1086152482));
            hoekvanholland_points.Add(new PointLatLng(51.9798725653, 4.10549108793));
            hoekvanholland_points.Add(new PointLatLng(51.9804926615, 4.10299832435));
            hoekvanholland_points.Add(new PointLatLng(51.9807249851, 4.10204532713));
            hoekvanholland_points.Add(new PointLatLng(51.9813949469, 4.09918705116));
            hoekvanholland_points.Add(new PointLatLng(51.9820913218, 4.09628424909));            

            hoekvanholland_points.Add(new PointLatLng(51.9995097497, 4.13276967039));
            hoekvanholland_points.Add(new PointLatLng(51.9981463061, 4.13123908749));
            hoekvanholland_points.Add(new PointLatLng(51.9980985839, 4.13127842429));
            hoekvanholland_points.Add(new PointLatLng(51.9979328353, 4.13141506891));
            hoekvanholland_points.Add(new PointLatLng(51.997660227, 4.13163903543));
            hoekvanholland_points.Add(new PointLatLng(51.9970807395, 4.13210558665));
            hoekvanholland_points.Add(new PointLatLng(51.9970447833, 4.13213464461));
            hoekvanholland_points.Add(new PointLatLng(51.9965837441, 4.13250727758));
            hoekvanholland_points.Add(new PointLatLng(51.9965014922, 4.13257375017));
            hoekvanholland_points.Add(new PointLatLng(51.9964766986, 4.13259324663));
            hoekvanholland_points.Add(new PointLatLng(51.9964730255, 4.13259614578));
            hoekvanholland_points.Add(new PointLatLng(51.996426823, 4.13261532401));
            hoekvanholland_points.Add(new PointLatLng(51.9964061056, 4.13262673971));
            hoekvanholland_points.Add(new PointLatLng(51.9963892736, 4.13264251783));
            hoekvanholland_points.Add(new PointLatLng(51.996342729, 4.13269705267));
            hoekvanholland_points.Add(new PointLatLng(51.9960191892, 4.13307699666));
            hoekvanholland_points.Add(new PointLatLng(51.9959054674, 4.13321054124));
            hoekvanholland_points.Add(new PointLatLng(51.9958796072, 4.1332404656));
            hoekvanholland_points.Add(new PointLatLng(51.9958667036, 4.13325539061));
            hoekvanholland_points.Add(new PointLatLng(51.9956037333, 4.13355479798));
            hoekvanholland_points.Add(new PointLatLng(51.9953330967, 4.13386292147));
            hoekvanholland_points.Add(new PointLatLng(51.9951050504, 4.13412256203));
            hoekvanholland_points.Add(new PointLatLng(51.9950693145, 4.13416474736));
            hoekvanholland_points.Add(new PointLatLng(51.9950004263, 4.13424606005));
            hoekvanholland_points.Add(new PointLatLng(51.9949766939, 4.13427405955));
            hoekvanholland_points.Add(new PointLatLng(51.9949406602, 4.13431613646));
            hoekvanholland_points.Add(new PointLatLng(51.9947113065, 4.13458395));
            hoekvanholland_points.Add(new PointLatLng(51.9946277752, 4.13468150121));
            hoekvanholland_points.Add(new PointLatLng(51.9946213463, 4.13468900635));
            hoekvanholland_points.Add(new PointLatLng(51.9943782141, 4.1349698858));
            hoekvanholland_points.Add(new PointLatLng(51.9943064444, 4.13505418917));
            hoekvanholland_points.Add(new PointLatLng(51.9943014366, 4.13506006709));
            hoekvanholland_points.Add(new PointLatLng(51.9940373725, 4.13537200829));
            hoekvanholland_points.Add(new PointLatLng(51.9938971413, 4.1355440441));
            hoekvanholland_points.Add(new PointLatLng(51.9938073215, 4.13564801498));
            hoekvanholland_points.Add(new PointLatLng(51.9937026699, 4.13577667653));
            hoekvanholland_points.Add(new PointLatLng(51.9936789967, 4.13580688637));
            hoekvanholland_points.Add(new PointLatLng(51.9936694051, 4.13581964944));
            hoekvanholland_points.Add(new PointLatLng(51.9936516387, 4.13584903897));
            hoekvanholland_points.Add(new PointLatLng(51.9936270496, 4.13589372103));
            hoekvanholland_points.Add(new PointLatLng(51.9936019981, 4.1359405713));
            hoekvanholland_points.Add(new PointLatLng(51.9935847802, 4.13597928044));
            hoekvanholland_points.Add(new PointLatLng(51.9935253347, 4.13611001362));
            hoekvanholland_points.Add(new PointLatLng(51.9935030526, 4.13616536408));
            hoekvanholland_points.Add(new PointLatLng(51.9934695354, 4.13625814962));
            hoekvanholland_points.Add(new PointLatLng(51.9934141687, 4.13642331207));
            hoekvanholland_points.Add(new PointLatLng(51.9933957069, 4.13648116243));
            hoekvanholland_points.Add(new PointLatLng(51.9932688093, 4.13687668435));
            hoekvanholland_points.Add(new PointLatLng(51.9931382471, 4.13728365084));
            hoekvanholland_points.Add(new PointLatLng(51.9930209433, 4.13764316302));
            hoekvanholland_points.Add(new PointLatLng(51.9928582848, 4.13814164491));
            hoekvanholland_points.Add(new PointLatLng(51.9928559601, 4.13814877274));
            hoekvanholland_points.Add(new PointLatLng(51.9926144446, 4.13886382801));
            hoekvanholland_points.Add(new PointLatLng(51.9926135869, 4.13886636546));
            hoekvanholland_points.Add(new PointLatLng(51.9926111759, 4.13887350144));
            hoekvanholland_points.Add(new PointLatLng(51.9922590126, 4.13999608077));
            hoekvanholland_points.Add(new PointLatLng(51.9917228867, 4.14164097644));
            hoekvanholland_points.Add(new PointLatLng(51.9913912047, 4.14264639899));
            hoekvanholland_points.Add(new PointLatLng(51.991389803, 4.14265071929));
            hoekvanholland_points.Add(new PointLatLng(51.9911098552, 4.14351034893));
            hoekvanholland_points.Add(new PointLatLng(51.9910978473, 4.14354717547));
            hoekvanholland_points.Add(new PointLatLng(51.991032461, 4.14374262553));
            hoekvanholland_points.Add(new PointLatLng(51.9909094077, 4.1441103305));
            hoekvanholland_points.Add(new PointLatLng(51.99074261, 4.14461017564));
            hoekvanholland_points.Add(new PointLatLng(51.9906967172, 4.14475245424));
            hoekvanholland_points.Add(new PointLatLng(51.9905482026, 4.14519524293));
            hoekvanholland_points.Add(new PointLatLng(51.9903956659, 4.14566937588));
            hoekvanholland_points.Add(new PointLatLng(51.9902310791, 4.14618340444));
            hoekvanholland_points.Add(new PointLatLng(51.9901229627, 4.14651644711));
            hoekvanholland_points.Add(new PointLatLng(51.9899342334, 4.14710375804));
            hoekvanholland_points.Add(new PointLatLng(51.9897914198, 4.14753983522));
            hoekvanholland_points.Add(new PointLatLng(51.9897710729, 4.1476104118));
            hoekvanholland_points.Add(new PointLatLng(51.9894864305, 4.14848009783));
            hoekvanholland_points.Add(new PointLatLng(51.9890918217, 4.14970839222));
            hoekvanholland_points.Add(new PointLatLng(51.9888915843, 4.1503210686));
            hoekvanholland_points.Add(new PointLatLng(51.9887211337, 4.15086159519));
            hoekvanholland_points.Add(new PointLatLng(51.9886021285, 4.15122651392));
            hoekvanholland_points.Add(new PointLatLng(51.9885843723, 4.15121276232));
            hoekvanholland_points.Add(new PointLatLng(51.9873609221, 4.15023271944));
            hoekvanholland_points.Add(new PointLatLng(51.9860669541, 4.14922369173));
            hoekvanholland_points.Add(new PointLatLng(51.9860595062, 4.14924892732));
            hoekvanholland_points.Add(new PointLatLng(51.9860562772, 4.14925987881));
            hoekvanholland_points.Add(new PointLatLng(51.9860351402, 4.14933150432));
            hoekvanholland_points.Add(new PointLatLng(51.9859967638, 4.14946155744));
            hoekvanholland_points.Add(new PointLatLng(51.9859918593, 4.14947817559));
            hoekvanholland_points.Add(new PointLatLng(51.9859899499, 4.1494846787));
            hoekvanholland_points.Add(new PointLatLng(51.985973561, 4.14954021437));
            hoekvanholland_points.Add(new PointLatLng(51.9859732919, 4.14954112457));
            hoekvanholland_points.Add(new PointLatLng(51.9857761039, 4.15020941298));
            hoekvanholland_points.Add(new PointLatLng(51.9849495736, 4.14956132119));
            hoekvanholland_points.Add(new PointLatLng(51.9845172225, 4.14922675273));
            hoekvanholland_points.Add(new PointLatLng(51.984491488, 4.14920665681));
            hoekvanholland_points.Add(new PointLatLng(51.9844911708, 4.14920641805));
            hoekvanholland_points.Add(new PointLatLng(51.9842597865, 4.14902575342));
            hoekvanholland_points.Add(new PointLatLng(51.9842053985, 4.14898328395));
            hoekvanholland_points.Add(new PointLatLng(51.9841384651, 4.14893102726));
            hoekvanholland_points.Add(new PointLatLng(51.9841341961, 4.1489277381));
            hoekvanholland_points.Add(new PointLatLng(51.9836515027, 4.14855603239));
            hoekvanholland_points.Add(new PointLatLng(51.9824635054, 4.14761797853));
            hoekvanholland_points.Add(new PointLatLng(51.9823584713, 4.14753503956));
            hoekvanholland_points.Add(new PointLatLng(51.9823491241, 4.14756767843));
            hoekvanholland_points.Add(new PointLatLng(51.9823211691, 4.14766531594));
            hoekvanholland_points.Add(new PointLatLng(51.9823205362, 4.14766753192));
            hoekvanholland_points.Add(new PointLatLng(51.9820188178, 4.14872119711));
            hoekvanholland_points.Add(new PointLatLng(51.9814283762, 4.15100603982));
            hoekvanholland_points.Add(new PointLatLng(51.9813003449, 4.15150014186));
            hoekvanholland_points.Add(new PointLatLng(51.9809761238, 4.15275137518));
            hoekvanholland_points.Add(new PointLatLng(51.9809381641, 4.1529386017));
            hoekvanholland_points.Add(new PointLatLng(51.9809371041, 4.15294382846));
            hoekvanholland_points.Add(new PointLatLng(51.9806760456, 4.15429662895));
            hoekvanholland_points.Add(new PointLatLng(51.980660702, 4.15439804648));
            hoekvanholland_points.Add(new PointLatLng(51.9806599282, 4.154460584));
            hoekvanholland_points.Add(new PointLatLng(51.9806580337, 4.15461260265));
            hoekvanholland_points.Add(new PointLatLng(51.9806603232, 4.15514416061));
            hoekvanholland_points.Add(new PointLatLng(51.9806613047, 4.15518120079));
            hoekvanholland_points.Add(new PointLatLng(51.9806714218, 4.15556424605));
            hoekvanholland_points.Add(new PointLatLng(51.9806724785, 4.15560419596));
            hoekvanholland_points.Add(new PointLatLng(51.9803452569, 4.1555562302));
            hoekvanholland_points.Add(new PointLatLng(51.9801004282, 4.15551842034));
            hoekvanholland_points.Add(new PointLatLng(51.9788028517, 4.15531807363));
            hoekvanholland_points.Add(new PointLatLng(51.9787932221, 4.15535666164));




            rozenburg_points.Add(new PointLatLng(51.9346872577, 4.2129819733));
            rozenburg_points.Add(new PointLatLng(51.9346872568, 4.21298197187));
            rozenburg_points.Add(new PointLatLng(51.9345560788, 4.21334962544));
            rozenburg_points.Add(new PointLatLng(51.9341641754, 4.21436712956));
            rozenburg_points.Add(new PointLatLng(51.9336649524, 4.21556534319));
            rozenburg_points.Add(new PointLatLng(51.9333687229, 4.21622670219));
            rozenburg_points.Add(new PointLatLng(51.9331377117, 4.21673451903));
            rozenburg_points.Add(new PointLatLng(51.9329430921, 4.2171287585));
            rozenburg_points.Add(new PointLatLng(51.9326094101, 4.21782082734));
            rozenburg_points.Add(new PointLatLng(51.9320421192, 4.21901671746));
            rozenburg_points.Add(new PointLatLng(51.9314618034, 4.22013434048));
            rozenburg_points.Add(new PointLatLng(51.9314275768, 4.22019784152));
            rozenburg_points.Add(new PointLatLng(51.9308778384, 4.22121776658));
            rozenburg_points.Add(new PointLatLng(51.9303002766, 4.22222353028));
            rozenburg_points.Add(new PointLatLng(51.9297233377, 4.22317105637));
            rozenburg_points.Add(new PointLatLng(51.9296316348, 4.22332166016));
            rozenburg_points.Add(new PointLatLng(51.9292059472, 4.22396822907));
            rozenburg_points.Add(new PointLatLng(51.9289785146, 4.22430684322));
            rozenburg_points.Add(new PointLatLng(51.9286058161, 4.22484051412));
            rozenburg_points.Add(new PointLatLng(51.9283036684, 4.22527316078));
            rozenburg_points.Add(new PointLatLng(51.9276116698, 4.22617301566));
            rozenburg_points.Add(new PointLatLng(51.926874048, 4.22702455153));
            rozenburg_points.Add(new PointLatLng(51.9261239423, 4.22783694599));
            rozenburg_points.Add(new PointLatLng(51.925361873, 4.22856444129));
            rozenburg_points.Add(new PointLatLng(51.9245980652, 4.22932942776));
            rozenburg_points.Add(new PointLatLng(51.9242641253, 4.22965655074));
            rozenburg_points.Add(new PointLatLng(51.9238404019, 4.23007161941));
            rozenburg_points.Add(new PointLatLng(51.9230802007, 4.23089345843));
            rozenburg_points.Add(new PointLatLng(51.9216677713, 4.23243388003));
            rozenburg_points.Add(new PointLatLng(51.9216034178, 4.23250406006));
            rozenburg_points.Add(new PointLatLng(51.9208569282, 4.23333692118));
            rozenburg_points.Add(new PointLatLng(51.9201359671, 4.23419750861));
            rozenburg_points.Add(new PointLatLng(51.9194196756, 4.23506002749));
            rozenburg_points.Add(new PointLatLng(51.9187385576, 4.23600800618));
            rozenburg_points.Add(new PointLatLng(51.9186291038, 4.23617687233));
            rozenburg_points.Add(new PointLatLng(51.9183637509, 4.23657865688));
            rozenburg_points.Add(new PointLatLng(51.9182612334, 4.23673268913));
            rozenburg_points.Add(new PointLatLng(51.9181128347, 4.23695565679));
            rozenburg_points.Add(new PointLatLng(51.9180676652, 4.23702601678));
            rozenburg_points.Add(new PointLatLng(51.917958395, 4.23721102541));
            rozenburg_points.Add(new PointLatLng(51.917570537, 4.2378541583));
            rozenburg_points.Add(new PointLatLng(51.9174341934, 4.23808573834));
            rozenburg_points.Add(new PointLatLng(51.9171505936, 4.23861075705));
            rozenburg_points.Add(new PointLatLng(51.9168667973, 4.23913247394));
            rozenburg_points.Add(new PointLatLng(51.9166489345, 4.23959553974));
            rozenburg_points.Add(new PointLatLng(51.9164089636, 4.24011204016));
            rozenburg_points.Add(new PointLatLng(51.9163089374, 4.24032446399));
            rozenburg_points.Add(new PointLatLng(51.9158290439, 4.24138817512));
            rozenburg_points.Add(new PointLatLng(51.9152989028, 4.24267591789));
            rozenburg_points.Add(new PointLatLng(51.9148659867, 4.24391861903));
            rozenburg_points.Add(new PointLatLng(51.9147465831, 4.24430966145));
            rozenburg_points.Add(new PointLatLng(51.9147003585, 4.24446718427));
            rozenburg_points.Add(new PointLatLng(51.9146916587, 4.24449683218));
            rozenburg_points.Add(new PointLatLng(51.9145982646, 4.24480315508));
            rozenburg_points.Add(new PointLatLng(51.9144537637, 4.24527711198));
            rozenburg_points.Add(new PointLatLng(51.9140853627, 4.24657562052));
            rozenburg_points.Add(new PointLatLng(51.9137083393, 4.24793112249));
            rozenburg_points.Add(new PointLatLng(51.9133212331, 4.2492079067));
            rozenburg_points.Add(new PointLatLng(51.9129085454, 4.25053206631));
            rozenburg_points.Add(new PointLatLng(51.9127209344, 4.25112521694));
            rozenburg_points.Add(new PointLatLng(51.9124880394, 4.2518431996));
            rozenburg_points.Add(new PointLatLng(51.9120568274, 4.25311405051));
            rozenburg_points.Add(new PointLatLng(51.9117718081, 4.25390410488));
            rozenburg_points.Add(new PointLatLng(51.9116455488, 4.25424768849));
            rozenburg_points.Add(new PointLatLng(51.9112953991, 4.25524120574));
            rozenburg_points.Add(new PointLatLng(51.9111732683, 4.25557980825));
            rozenburg_points.Add(new PointLatLng(51.9111277691, 4.25569948552));
            rozenburg_points.Add(new PointLatLng(51.9110084665, 4.25601328534));
            rozenburg_points.Add(new PointLatLng(51.9106005583, 4.25706935151));
            rozenburg_points.Add(new PointLatLng(51.9102031257, 4.25808266113));
            rozenburg_points.Add(new PointLatLng(51.9097184024, 4.25928907156));
            rozenburg_points.Add(new PointLatLng(51.9092122554, 4.26057262457));
            rozenburg_points.Add(new PointLatLng(51.9081616207, 4.26319595242));
            rozenburg_points.Add(new PointLatLng(51.9078229795, 4.26402631302));
            rozenburg_points.Add(new PointLatLng(51.9072472465, 4.26545233857));
            rozenburg_points.Add(new PointLatLng(51.9068607498, 4.26645566029));
            rozenburg_points.Add(new PointLatLng(51.9068607287, 4.26645571168));
            rozenburg_points.Add(new PointLatLng(51.9061942321, 4.26613032995));
            rozenburg_points.Add(new PointLatLng(51.9045579609, 4.26532349067));
            rozenburg_points.Add(new PointLatLng(51.9038725135, 4.26498308738));
            rozenburg_points.Add(new PointLatLng(51.903751764, 4.26492312365));
            rozenburg_points.Add(new PointLatLng(51.9031787661, 4.26464153265));
            rozenburg_points.Add(new PointLatLng(51.9031619795, 4.26463331758));
            rozenburg_points.Add(new PointLatLng(51.9023079666, 4.26421549906));
            rozenburg_points.Add(new PointLatLng(51.9022969065, 4.2642100871));
            rozenburg_points.Add(new PointLatLng(51.9014961458, 4.2638168294));
            rozenburg_points.Add(new PointLatLng(51.9014763727, 4.26380711857));
            rozenburg_points.Add(new PointLatLng(51.900444929, 4.26330059293));
            rozenburg_points.Add(new PointLatLng(51.9001617466, 4.26316153178));
            rozenburg_points.Add(new PointLatLng(51.8975203629, 4.26075878606));
            rozenburg_points.Add(new PointLatLng(51.8975806734, 4.26044229428));
            rozenburg_points.Add(new PointLatLng(51.8981035036, 4.25769845145));
            rozenburg_points.Add(new PointLatLng(51.8981247609, 4.25758688687));
            rozenburg_points.Add(new PointLatLng(51.8988062811, 4.25400960461));
            rozenburg_points.Add(new PointLatLng(51.8989752329, 4.25312267506));
            rozenburg_points.Add(new PointLatLng(51.8991185836, 4.25237010748));
            rozenburg_points.Add(new PointLatLng(51.8992160851, 4.2518582248));
            rozenburg_points.Add(new PointLatLng(51.8992355393, 4.25175608952));
            rozenburg_points.Add(new PointLatLng(51.8996381902, 4.24964201294));
            rozenburg_points.Add(new PointLatLng(51.8997427469, 4.24909300654));
            rozenburg_points.Add(new PointLatLng(51.8998098618, 4.24874059527));
            rozenburg_points.Add(new PointLatLng(51.8998695017, 4.2484274287));
            rozenburg_points.Add(new PointLatLng(51.8999669141, 4.24791590435));
            rozenburg_points.Add(new PointLatLng(51.9000147213, 4.24766486181));
            rozenburg_points.Add(new PointLatLng(51.9003348659, 4.24598362838));
            rozenburg_points.Add(new PointLatLng(51.90087428, 4.24315056195));
            rozenburg_points.Add(new PointLatLng(51.900950936, 4.242747921));
            rozenburg_points.Add(new PointLatLng(51.9011152127, 4.24188502131));
            rozenburg_points.Add(new PointLatLng(51.9019911038, 4.23728189617));
            rozenburg_points.Add(new PointLatLng(51.9021549577, 4.23642066121));
            rozenburg_points.Add(new PointLatLng(51.9022386068, 4.23598098143));
            rozenburg_points.Add(new PointLatLng(51.9023437549, 4.23542230165));
            rozenburg_points.Add(new PointLatLng(51.9031708739, 4.23423583841));
            rozenburg_points.Add(new PointLatLng(51.9033243218, 4.23401711731));
            rozenburg_points.Add(new PointLatLng(51.903554032, 4.23368969508));
            rozenburg_points.Add(new PointLatLng(51.9036555258, 4.23354709533));
            rozenburg_points.Add(new PointLatLng(51.9044762609, 4.23074375812));
            rozenburg_points.Add(new PointLatLng(51.9044217719, 4.23023535509));
            rozenburg_points.Add(new PointLatLng(51.904411655, 4.23014096517));
            rozenburg_points.Add(new PointLatLng(51.9042236492, 4.22843875136));
            rozenburg_points.Add(new PointLatLng(51.9066119995, 4.2277603845));
            rozenburg_points.Add(new PointLatLng(51.9096977503, 4.22688382445));
            rozenburg_points.Add(new PointLatLng(51.9103540017, 4.22669738987));
            rozenburg_points.Add(new PointLatLng(51.9111166283, 4.22646037279));
            rozenburg_points.Add(new PointLatLng(51.9118741985, 4.22618481107));
            rozenburg_points.Add(new PointLatLng(51.9126165613, 4.22587214276));
            rozenburg_points.Add(new PointLatLng(51.9141097605, 4.22512934182));
            rozenburg_points.Add(new PointLatLng(51.9150289871, 4.224592096));
            rozenburg_points.Add(new PointLatLng(51.9158302444, 4.22406224403));
            rozenburg_points.Add(new PointLatLng(51.9161257191, 4.22385048089));
            rozenburg_points.Add(new PointLatLng(51.9162585847, 4.22375879451));
            rozenburg_points.Add(new PointLatLng(51.9169679825, 4.22321104019));
            rozenburg_points.Add(new PointLatLng(51.9169768838, 4.22320416703));
            rozenburg_points.Add(new PointLatLng(51.9175312364, 4.22274391005));
            rozenburg_points.Add(new PointLatLng(51.9183528645, 4.22202082997));
            rozenburg_points.Add(new PointLatLng(51.9191775319, 4.22123294627));
            rozenburg_points.Add(new PointLatLng(51.9199854836, 4.22042816606));
            rozenburg_points.Add(new PointLatLng(51.9205434509, 4.21981697663));
            rozenburg_points.Add(new PointLatLng(51.923550135, 4.21930464763));
            rozenburg_points.Add(new PointLatLng(51.9236794579, 4.2190466));
            rozenburg_points.Add(new PointLatLng(51.9247710207, 4.21686844481));
            rozenburg_points.Add(new PointLatLng(51.9255847803, 4.21523362475));
            rozenburg_points.Add(new PointLatLng(51.9309774798, 4.2044304225));
            rozenburg_points.Add(new PointLatLng(51.9314878822, 4.20339824572));
            rozenburg_points.Add(new PointLatLng(51.9326976321, 4.20097760952));
            rozenburg_points.Add(new PointLatLng(51.9378755561, 4.19058644254));
            rozenburg_points.Add(new PointLatLng(51.9394930789, 4.18734094785));
            rozenburg_points.Add(new PointLatLng(51.9397888963, 4.1877259171));
            rozenburg_points.Add(new PointLatLng(51.940419831, 4.18854704807));
            rozenburg_points.Add(new PointLatLng(51.9427109736, 4.19152885005));
            rozenburg_points.Add(new PointLatLng(51.9424906302, 4.19211993593));
            rozenburg_points.Add(new PointLatLng(51.9396362481, 4.19989480623));
            rozenburg_points.Add(new PointLatLng(51.9360663584, 4.20961523659));
            rozenburg_points.Add(new PointLatLng(51.9346872577, 4.2129819733));



            pernis_points.Add(new PointLatLng(51.8792977247, 4.38612466274));
            pernis_points.Add(new PointLatLng(51.8792996874, 4.3861227801));
            pernis_points.Add(new PointLatLng(51.8792997375, 4.38612434049));
            pernis_points.Add(new PointLatLng(51.8793018822, 4.38612219524));
            pernis_points.Add(new PointLatLng(51.8793019542, 4.38612505374));
            pernis_points.Add(new PointLatLng(51.8793350507, 4.38609227037));
            pernis_points.Add(new PointLatLng(51.8793421593, 4.38608522984));
            pernis_points.Add(new PointLatLng(51.879338494, 4.38607488637));
            pernis_points.Add(new PointLatLng(51.8795408834, 4.38588311593));
            pernis_points.Add(new PointLatLng(51.8797576601, 4.38567776123));
            pernis_points.Add(new PointLatLng(51.8799446827, 4.38550952154));
            pernis_points.Add(new PointLatLng(51.8801415836, 4.3853331161));
            pernis_points.Add(new PointLatLng(51.8803124411, 4.38519449346));
            pernis_points.Add(new PointLatLng(51.8803085476, 4.38518301754));
            pernis_points.Add(new PointLatLng(51.8804976982, 4.38503488116));
            pernis_points.Add(new PointLatLng(51.8805030151, 4.38505081104));
            pernis_points.Add(new PointLatLng(51.8807098887, 4.38488934725));
            pernis_points.Add(new PointLatLng(51.8813927632, 4.384403849));
            pernis_points.Add(new PointLatLng(51.8816325064, 4.38424329019));
            pernis_points.Add(new PointLatLng(51.8819234391, 4.38404844536));
            pernis_points.Add(new PointLatLng(51.8827680479, 4.38348277788));
            pernis_points.Add(new PointLatLng(51.8827773751, 4.38352422523));
            pernis_points.Add(new PointLatLng(51.8833453143, 4.38316144682));
            pernis_points.Add(new PointLatLng(51.8833637749, 4.38316510212));
            pernis_points.Add(new PointLatLng(51.8833973918, 4.38314343254));
            pernis_points.Add(new PointLatLng(51.8834068328, 4.38312259337));
            pernis_points.Add(new PointLatLng(51.8837883114, 4.3828849813));
            pernis_points.Add(new PointLatLng(51.8844131012, 4.38250551717));
            pernis_points.Add(new PointLatLng(51.8845542495, 4.38242095014));
            pernis_points.Add(new PointLatLng(51.8846955482, 4.38233704456));
            pernis_points.Add(new PointLatLng(51.8848369963, 4.38225379611));
            pernis_points.Add(new PointLatLng(51.884978593, 4.38217120917));
            pernis_points.Add(new PointLatLng(51.8851203364, 4.38208928234));
            pernis_points.Add(new PointLatLng(51.8852622256, 4.38200801854));
            pernis_points.Add(new PointLatLng(51.8854042589, 4.38192741637));
            pernis_points.Add(new PointLatLng(51.8855464363, 4.38184747729));
            pernis_points.Add(new PointLatLng(51.8856887559, 4.38176820134));
            pernis_points.Add(new PointLatLng(51.8864545365, 4.38135039333));
            pernis_points.Add(new PointLatLng(51.8864688676, 4.38135472165));
            pernis_points.Add(new PointLatLng(51.8864910469, 4.38134331198));
            pernis_points.Add(new PointLatLng(51.8865044015, 4.38133649302));
            pernis_points.Add(new PointLatLng(51.8865163514, 4.38131472421));
            pernis_points.Add(new PointLatLng(51.8866019589, 4.38126896608));
            pernis_points.Add(new PointLatLng(51.88668762, 4.38122347389));
            pernis_points.Add(new PointLatLng(51.8867733354, 4.38117824617));
            pernis_points.Add(new PointLatLng(51.8868591043, 4.38113328295));
            pernis_points.Add(new PointLatLng(51.8869449258, 4.38108858425));
            pernis_points.Add(new PointLatLng(51.8870308, 4.38104415151));
            pernis_points.Add(new PointLatLng(51.8871167267, 4.38099998329));
            pernis_points.Add(new PointLatLng(51.8872027051, 4.38095607961));
            pernis_points.Add(new PointLatLng(51.8872887361, 4.38091244335));
            pernis_points.Add(new PointLatLng(51.8872814919, 4.38087057528));
            pernis_points.Add(new PointLatLng(51.8878849835, 4.38056796872));
            pernis_points.Add(new PointLatLng(51.8884361908, 4.38030185872));
            pernis_points.Add(new PointLatLng(51.8888707341, 4.38009873749));
            pernis_points.Add(new PointLatLng(51.8892855339, 4.3799108713));
            pernis_points.Add(new PointLatLng(51.8895251544, 4.37980849776));
            pernis_points.Add(new PointLatLng(51.8899138682, 4.37965453185));
            pernis_points.Add(new PointLatLng(51.8901735124, 4.37955956256));
            pernis_points.Add(new PointLatLng(51.8903682103, 4.37949388475));
            pernis_points.Add(new PointLatLng(51.8904130639, 4.37947892097));
            pernis_points.Add(new PointLatLng(51.8904579483, 4.37946419475));
            pernis_points.Add(new PointLatLng(51.8905028617, 4.37944970178));
            pernis_points.Add(new PointLatLng(51.8905478042, 4.3794354464));
            pernis_points.Add(new PointLatLng(51.8905927756, 4.37942142572));
            pernis_points.Add(new PointLatLng(51.8906377742, 4.37940764123));
            pernis_points.Add(new PointLatLng(51.8906827999, 4.37939409293));
            pernis_points.Add(new PointLatLng(51.8907278529, 4.37938078083));
            pernis_points.Add(new PointLatLng(51.8907729331, 4.37936770491));
            pernis_points.Add(new PointLatLng(51.891112737, 4.3792716016));
            pernis_points.Add(new PointLatLng(51.8920285049, 4.37903689772));
            pernis_points.Add(new PointLatLng(51.8920683937, 4.37902679843));
            pernis_points.Add(new PointLatLng(51.892108259, 4.37901646281));
            pernis_points.Add(new PointLatLng(51.8921481006, 4.37900588941));
            pernis_points.Add(new PointLatLng(51.8921879177, 4.37899507826));
            pernis_points.Add(new PointLatLng(51.8922277094, 4.37898403082));
            pernis_points.Add(new PointLatLng(51.8922674766, 4.37897274562));
            pernis_points.Add(new PointLatLng(51.8923072174, 4.37896122416));
            pernis_points.Add(new PointLatLng(51.892346932, 4.37894946642));
            pernis_points.Add(new PointLatLng(51.8923866194, 4.37893747244));
            pernis_points.Add(new PointLatLng(51.89243811, 4.37892237598));
            pernis_points.Add(new PointLatLng(51.8924895587, 4.37890690119));
            pernis_points.Add(new PointLatLng(51.8925409628, 4.37889105104));
            pernis_points.Add(new PointLatLng(51.8925923223, 4.37887482552));
            pernis_points.Add(new PointLatLng(51.8926436354, 4.37885822178));
            pernis_points.Add(new PointLatLng(51.8926949013, 4.37884124419));
            pernis_points.Add(new PointLatLng(51.8927461199, 4.37882389129));
            pernis_points.Add(new PointLatLng(51.8927972885, 4.37880616314));
            pernis_points.Add(new PointLatLng(51.892848408, 4.37878806117));
            pernis_points.Add(new PointLatLng(51.8928468717, 4.3787767622));
            pernis_points.Add(new PointLatLng(51.8928958796, 4.37875720951));
            pernis_points.Add(new PointLatLng(51.8929014946, 4.37878294706));
            pernis_points.Add(new PointLatLng(51.8928885344, 4.37879181056));
            pernis_points.Add(new PointLatLng(51.8928973098, 4.37883999881));
            pernis_points.Add(new PointLatLng(51.8928995506, 4.37883922204));
            pernis_points.Add(new PointLatLng(51.8929002425, 4.37884661395));
            pernis_points.Add(new PointLatLng(51.8929701668, 4.37882354366));
            pernis_points.Add(new PointLatLng(51.8931579782, 4.37875161971));
            pernis_points.Add(new PointLatLng(51.8932860757, 4.37869832594));
            pernis_points.Add(new PointLatLng(51.8935084277, 4.37859714658));
            pernis_points.Add(new PointLatLng(51.8936673206, 4.37851816871));
            pernis_points.Add(new PointLatLng(51.8939044485, 4.37838948412));
            pernis_points.Add(new PointLatLng(51.8939740276, 4.37834843894));
            pernis_points.Add(new PointLatLng(51.8940174966, 4.3783227964));
            pernis_points.Add(new PointLatLng(51.8940872946, 4.37862638813));
            pernis_points.Add(new PointLatLng(51.8940466494, 4.37874655877));
            pernis_points.Add(new PointLatLng(51.8940412338, 4.37876047403));
            pernis_points.Add(new PointLatLng(51.8940360657, 4.37877463365));
            pernis_points.Add(new PointLatLng(51.8940311513, 4.37878902587));
            pernis_points.Add(new PointLatLng(51.8940264942, 4.3788036419));
            pernis_points.Add(new PointLatLng(51.8940220969, 4.37881846569));
            pernis_points.Add(new PointLatLng(51.8940179647, 4.37883348842));
            pernis_points.Add(new PointLatLng(51.8940141001, 4.37884869403));
            pernis_points.Add(new PointLatLng(51.8940105068, 4.37886407373));
            pernis_points.Add(new PointLatLng(51.8940071881, 4.37887961437));
            pernis_points.Add(new PointLatLng(51.8939969475, 4.37894659687));
            pernis_points.Add(new PointLatLng(51.8939896216, 4.37901150877));
            pernis_points.Add(new PointLatLng(51.8939876689, 4.37905663174));
            pernis_points.Add(new PointLatLng(51.893985134, 4.379099177));
            pernis_points.Add(new PointLatLng(51.8939825773, 4.37913394752));
            pernis_points.Add(new PointLatLng(51.8939780322, 4.37918496113));
            pernis_points.Add(new PointLatLng(51.8940065113, 4.37919217903));
            pernis_points.Add(new PointLatLng(51.894025831, 4.37920007315));
            pernis_points.Add(new PointLatLng(51.8940654268, 4.37921468768));
            pernis_points.Add(new PointLatLng(51.8940697248, 4.37921614605));
            pernis_points.Add(new PointLatLng(51.8940872016, 4.37922403357));
            pernis_points.Add(new PointLatLng(51.894089243, 4.37922495551));
            pernis_points.Add(new PointLatLng(51.8940898244, 4.37922534061));
            pernis_points.Add(new PointLatLng(51.894090369, 4.37922584858));
            pernis_points.Add(new PointLatLng(51.8940908661, 4.37922646951));
            pernis_points.Add(new PointLatLng(51.8940913074, 4.3792271934));
            pernis_points.Add(new PointLatLng(51.8940916839, 4.37922800738));
            pernis_points.Add(new PointLatLng(51.8940919891, 4.37922889561));
            pernis_points.Add(new PointLatLng(51.8940922175, 4.37922984224));
            pernis_points.Add(new PointLatLng(51.8940923653, 4.3792308299));
            pernis_points.Add(new PointLatLng(51.8940924288, 4.3792318398));
            pernis_points.Add(new PointLatLng(51.8941021953, 4.37971461461));
            pernis_points.Add(new PointLatLng(51.8941019049, 4.37972970519));
            pernis_points.Add(new PointLatLng(51.8941010196, 4.37974470448));
            pernis_points.Add(new PointLatLng(51.8940846508, 4.37985955825));
            pernis_points.Add(new PointLatLng(51.8940180442, 4.38027564339));
            pernis_points.Add(new PointLatLng(51.8937444273, 4.38203743024));
            pernis_points.Add(new PointLatLng(51.8937151895, 4.38222407227));
            pernis_points.Add(new PointLatLng(51.8936853452, 4.38239241942));
            pernis_points.Add(new PointLatLng(51.8936975716, 4.38334498633));
            pernis_points.Add(new PointLatLng(51.893958614, 4.38343825783));
            pernis_points.Add(new PointLatLng(51.8939535042, 4.38348653587));
            pernis_points.Add(new PointLatLng(51.8939493503, 4.38353505264));
            pernis_points.Add(new PointLatLng(51.8939461571, 4.38358376009));
            pernis_points.Add(new PointLatLng(51.893943928, 4.38363260585));
            pernis_points.Add(new PointLatLng(51.8939426642, 4.38368154193));
            pernis_points.Add(new PointLatLng(51.893942369, 4.38373051887));
            pernis_points.Add(new PointLatLng(51.8939430409, 4.38377948583));
            pernis_points.Add(new PointLatLng(51.8939446797, 4.38382839344));
            pernis_points.Add(new PointLatLng(51.8939472839, 4.38387719232));
            pernis_points.Add(new PointLatLng(51.8939675373, 4.38402259641));
            pernis_points.Add(new PointLatLng(51.8939677924, 4.38402635845));
            pernis_points.Add(new PointLatLng(51.8939680753, 4.38403011551));
            pernis_points.Add(new PointLatLng(51.8939683861, 4.38403386759));
            pernis_points.Add(new PointLatLng(51.8939687237, 4.38403761181));
            pernis_points.Add(new PointLatLng(51.8939690883, 4.38404135106));
            pernis_points.Add(new PointLatLng(51.8939694806, 4.38404508243));
            pernis_points.Add(new PointLatLng(51.8939699008, 4.38404880592));
            pernis_points.Add(new PointLatLng(51.8939703479, 4.38405252153));
            pernis_points.Add(new PointLatLng(51.8939708219, 4.38405622783));
            pernis_points.Add(new PointLatLng(51.8939716031, 4.38406190777));
            pernis_points.Add(new PointLatLng(51.8939724488, 4.38406756447));
            pernis_points.Add(new PointLatLng(51.8939733572, 4.38407319507));
            pernis_points.Add(new PointLatLng(51.8939743293, 4.38407879955));
            pernis_points.Add(new PointLatLng(51.8939753649, 4.3840843721));
            pernis_points.Add(new PointLatLng(51.8939764623, 4.38408991566));
            pernis_points.Add(new PointLatLng(51.8939776214, 4.38409542442));
            pernis_points.Add(new PointLatLng(51.8939788431, 4.38410089837));
            pernis_points.Add(new PointLatLng(51.8939801257, 4.38410633608));
            pernis_points.Add(new PointLatLng(51.893982563, 4.38411593133));
            pernis_points.Add(new PointLatLng(51.8939851916, 4.38412539445));
            pernis_points.Add(new PointLatLng(51.8939880087, 4.38413471532));
            pernis_points.Add(new PointLatLng(51.8939910105, 4.38414388386));
            pernis_points.Add(new PointLatLng(51.8939941944, 4.38415288995));
            pernis_points.Add(new PointLatLng(51.8939975575, 4.38416172495));
            pernis_points.Add(new PointLatLng(51.8940010961, 4.38417037876));
            pernis_points.Add(new PointLatLng(51.8940048066, 4.38417884275));
            pernis_points.Add(new PointLatLng(51.8940086845, 4.3841871083));
            pernis_points.Add(new PointLatLng(51.8940131438, 4.38419672527));
            pernis_points.Add(new PointLatLng(51.8940177473, 4.38420616322));
            pernis_points.Add(new PointLatLng(51.894022493, 4.38421541636));
            pernis_points.Add(new PointLatLng(51.8940273773, 4.38422447897));
            pernis_points.Add(new PointLatLng(51.8940323975, 4.3842333453));
            pernis_points.Add(new PointLatLng(51.8940375508, 4.38424200959));
            pernis_points.Add(new PointLatLng(51.8940428328, 4.38425046904));
            pernis_points.Add(new PointLatLng(51.8940482423, 4.38425871495));
            pernis_points.Add(new PointLatLng(51.894053775, 4.38426674597));
            pernis_points.Add(new PointLatLng(51.8940633816, 4.38428011321));
            pernis_points.Add(new PointLatLng(51.8940731387, 4.38429319665));
            pernis_points.Add(new PointLatLng(51.8940830407, 4.38430599062));
            pernis_points.Add(new PointLatLng(51.8940930858, 4.3843184908));
            pernis_points.Add(new PointLatLng(51.8941032695, 4.38433069146));
            pernis_points.Add(new PointLatLng(51.89411359, 4.38434259266));
            pernis_points.Add(new PointLatLng(51.8941240418, 4.38435418579));
            pernis_points.Add(new PointLatLng(51.8941346232, 4.3843654709));
            pernis_points.Add(new PointLatLng(51.8941453304, 4.38437644226));
            pernis_points.Add(new PointLatLng(51.8941734341, 4.38440300464));
            pernis_points.Add(new PointLatLng(51.8942022755, 4.38442741752));
            pernis_points.Add(new PointLatLng(51.8942317903, 4.38444962566));
            pernis_points.Add(new PointLatLng(51.8942619152, 4.38446958252));
            pernis_points.Add(new PointLatLng(51.8942925841, 4.38448724308));
            pernis_points.Add(new PointLatLng(51.8943237294, 4.38450256961));
            pernis_points.Add(new PointLatLng(51.8943552832, 4.38451552728));
            pernis_points.Add(new PointLatLng(51.8943871771, 4.38452609002));
            pernis_points.Add(new PointLatLng(51.8944193416, 4.38453423321));
            pernis_points.Add(new PointLatLng(51.8944305408, 4.38453629083));
            pernis_points.Add(new PointLatLng(51.8944417463, 4.38453823352));
            pernis_points.Add(new PointLatLng(51.8944529606, 4.38454006267));
            pernis_points.Add(new PointLatLng(51.8944641812, 4.38454177834));
            pernis_points.Add(new PointLatLng(51.894475408, 4.38454337909));
            pernis_points.Add(new PointLatLng(51.8944866411, 4.38454486491));
            pernis_points.Add(new PointLatLng(51.8944978794, 4.38454623581));
            pernis_points.Add(new PointLatLng(51.894509123, 4.38454749327));
            pernis_points.Add(new PointLatLng(51.8945203711, 4.38454863583));
            pernis_points.Add(new PointLatLng(51.8945794314, 4.3845527484));
            pernis_points.Add(new PointLatLng(51.8946810699, 4.3845598257));
            pernis_points.Add(new PointLatLng(51.894859572, 4.38458602249));
            pernis_points.Add(new PointLatLng(51.8949052433, 4.38460800289));
            pernis_points.Add(new PointLatLng(51.8949509431, 4.38462983448));
            pernis_points.Add(new PointLatLng(51.8949966694, 4.38465151731));
            pernis_points.Add(new PointLatLng(51.8950424232, 4.38467305136));
            pernis_points.Add(new PointLatLng(51.8950882027, 4.38469443667));
            pernis_points.Add(new PointLatLng(51.8951340097, 4.38471567174));
            pernis_points.Add(new PointLatLng(51.8951798432, 4.38473675804));
            pernis_points.Add(new PointLatLng(51.8952257025, 4.38475769414));
            pernis_points.Add(new PointLatLng(51.8952715883, 4.38477848149));
            pernis_points.Add(new PointLatLng(51.8952908036, 4.3847871376));
            pernis_points.Add(new PointLatLng(51.8953100231, 4.38479576892));
            pernis_points.Add(new PointLatLng(51.8953292478, 4.38480437252));
            pernis_points.Add(new PointLatLng(51.8953484768, 4.38481295134));
            pernis_points.Add(new PointLatLng(51.89536771, 4.38482150391));
            pernis_points.Add(new PointLatLng(51.8953869484, 4.38483002876));
            pernis_points.Add(new PointLatLng(51.8954061911, 4.38483852883));
            pernis_points.Add(new PointLatLng(51.8954254372, 4.38484700266));
            pernis_points.Add(new PointLatLng(51.8954446884, 4.38485545024));
            pernis_points.Add(new PointLatLng(51.8955477148, 4.38488715491));
            pernis_points.Add(new PointLatLng(51.8956414118, 4.3849277471));
            pernis_points.Add(new PointLatLng(51.8957289025, 4.38496565013));
            pernis_points.Add(new PointLatLng(51.8958166177, 4.38503806088));
            pernis_points.Add(new PointLatLng(51.8958166385, 4.38503807931));
            pernis_points.Add(new PointLatLng(51.8959628505, 4.38515878199));
            pernis_points.Add(new PointLatLng(51.8959634462, 4.38515937029));
            pernis_points.Add(new PointLatLng(51.8959640278, 4.38515999524));
            pernis_points.Add(new PointLatLng(51.8959645935, 4.38516065832));
            pernis_points.Add(new PointLatLng(51.8959651416, 4.38516135812));
            pernis_points.Add(new PointLatLng(51.8959656728, 4.38516209027));
            pernis_points.Add(new PointLatLng(51.8959661855, 4.3851628577));
            pernis_points.Add(new PointLatLng(51.8959666787, 4.38516365754));
            pernis_points.Add(new PointLatLng(51.8959671515, 4.38516448835));
            pernis_points.Add(new PointLatLng(51.8959676038, 4.38516534867));
            pernis_points.Add(new PointLatLng(51.8959684436, 4.38516715214));
            pernis_points.Add(new PointLatLng(51.8959691925, 4.3851690579));
            pernis_points.Add(new PointLatLng(51.8959698451, 4.38517105445));
            pernis_points.Add(new PointLatLng(51.8959703968, 4.38517312735));
            pernis_points.Add(new PointLatLng(51.8959708457, 4.38517526649));
            pernis_points.Add(new PointLatLng(51.8959711871, 4.38517745452));
            pernis_points.Add(new PointLatLng(51.895971421, 4.38517967982));
            pernis_points.Add(new PointLatLng(51.8959715435, 4.3851819294));
            pernis_points.Add(new PointLatLng(51.8959715556, 4.38518418726));
            pernis_points.Add(new PointLatLng(51.8959715218, 4.38518527784));
            pernis_points.Add(new PointLatLng(51.8959714618, 4.38518636465));
            pernis_points.Add(new PointLatLng(51.8959713758, 4.38518744913));
            pernis_points.Add(new PointLatLng(51.8959712645, 4.38518852545));
            pernis_points.Add(new PointLatLng(51.8959711271, 4.3851895951));
            pernis_points.Add(new PointLatLng(51.8959709653, 4.38519065511));
            pernis_points.Add(new PointLatLng(51.8959707783, 4.38519170552));
            pernis_points.Add(new PointLatLng(51.895970566, 4.38519274195));
            pernis_points.Add(new PointLatLng(51.8959703293, 4.38519376586));
            pernis_points.Add(new PointLatLng(51.8959703206, 4.38519379947));
            pernis_points.Add(new PointLatLng(51.8959703128, 4.38519383307));
            pernis_points.Add(new PointLatLng(51.8959703041, 4.38519386814));
            pernis_points.Add(new PointLatLng(51.8959702954, 4.38519390175));
            pernis_points.Add(new PointLatLng(51.8959702867, 4.38519393537));
            pernis_points.Add(new PointLatLng(51.8959702789, 4.38519396896));
            pernis_points.Add(new PointLatLng(51.8959702702, 4.38519400403));
            pernis_points.Add(new PointLatLng(51.8959702615, 4.38519403765));
            pernis_points.Add(new PointLatLng(51.8959702537, 4.38519407269));
            pernis_points.Add(new PointLatLng(51.8959629092, 4.38525172562));
            pernis_points.Add(new PointLatLng(51.8959440308, 4.38539992135));
            pernis_points.Add(new PointLatLng(51.8959332241, 4.38548234396));
            pernis_points.Add(new PointLatLng(51.8959225644, 4.38556481557));
            pernis_points.Add(new PointLatLng(51.8959120515, 4.38564733618));
            pernis_points.Add(new PointLatLng(51.8959016865, 4.38572990577));
            pernis_points.Add(new PointLatLng(51.8958914692, 4.38581252288));
            pernis_points.Add(new PointLatLng(51.8958813997, 4.38589518753));
            pernis_points.Add(new PointLatLng(51.895871478, 4.3859778997));
            pernis_points.Add(new PointLatLng(51.8958617041, 4.38606065794));
            pernis_points.Add(new PointLatLng(51.8958520788, 4.38614346079));
            pernis_points.Add(new PointLatLng(51.8958057271, 4.38655716471));
            pernis_points.Add(new PointLatLng(51.8957349823, 4.38728160614));
            pernis_points.Add(new PointLatLng(51.8955927189, 4.38895655377));
            pernis_points.Add(new PointLatLng(51.8955484179, 4.38935016279));
            pernis_points.Add(new PointLatLng(51.8955249012, 4.38951606105));
            pernis_points.Add(new PointLatLng(51.8955159163, 4.38957939578));
            pernis_points.Add(new PointLatLng(51.8954999863, 4.38969169679));
            pernis_points.Add(new PointLatLng(51.8954260224, 4.3901494622));
            pernis_points.Add(new PointLatLng(51.8953784936, 4.39040698605));
            pernis_points.Add(new PointLatLng(51.8953715538, 4.39044473126));
            pernis_points.Add(new PointLatLng(51.8953644243, 4.39048238621));
            pernis_points.Add(new PointLatLng(51.8953571053, 4.3905199451));
            pernis_points.Add(new PointLatLng(51.8953495976, 4.39055740644));
            pernis_points.Add(new PointLatLng(51.8953419019, 4.39059476731));
            pernis_points.Add(new PointLatLng(51.8953340194, 4.39063202769));
            pernis_points.Add(new PointLatLng(51.8953259489, 4.39066918179));
            pernis_points.Add(new PointLatLng(51.8953176914, 4.39070622814));
            pernis_points.Add(new PointLatLng(51.8953092487, 4.39074316669));
            pernis_points.Add(new PointLatLng(51.8952147012, 4.39114892833));
            pernis_points.Add(new PointLatLng(51.8951990298, 4.39121472521));
            pernis_points.Add(new PointLatLng(51.895183212, 4.3912804323));
            pernis_points.Add(new PointLatLng(51.8951672486, 4.3913460452));
            pernis_points.Add(new PointLatLng(51.8951511387, 4.3914115654));
            pernis_points.Add(new PointLatLng(51.8951348833, 4.39147699288));
            pernis_points.Add(new PointLatLng(51.8951184823, 4.39154232326));
            pernis_points.Add(new PointLatLng(51.8951019357, 4.39160755947));
            pernis_points.Add(new PointLatLng(51.8950852444, 4.39167269713));
            pernis_points.Add(new PointLatLng(51.8950684085, 4.39173773912));
            pernis_points.Add(new PointLatLng(51.8949408932, 4.39223238847));
            pernis_points.Add(new PointLatLng(51.8947592313, 4.39289432991));
            pernis_points.Add(new PointLatLng(51.8946552505, 4.39324879261));
            pernis_points.Add(new PointLatLng(51.8945536572, 4.39357914115));
            pernis_points.Add(new PointLatLng(51.8945245131, 4.39355570248));
            pernis_points.Add(new PointLatLng(51.8945080921, 4.39361051733));
            pernis_points.Add(new PointLatLng(51.8945059194, 4.39361765482));
            pernis_points.Add(new PointLatLng(51.8944999236, 4.39363736149));
            pernis_points.Add(new PointLatLng(51.8945287394, 4.39366014776));
            pernis_points.Add(new PointLatLng(51.8944446747, 4.39393536908));
            pernis_points.Add(new PointLatLng(51.8941979772, 4.39469916552));
            pernis_points.Add(new PointLatLng(51.8941744064, 4.39476935516));
            pernis_points.Add(new PointLatLng(51.8941506898, 4.39483941572));
            pernis_points.Add(new PointLatLng(51.8941268273, 4.39490934575));
            pernis_points.Add(new PointLatLng(51.894102819, 4.39497914524));
            pernis_points.Add(new PointLatLng(51.8940786638, 4.39504881422));
            pernis_points.Add(new PointLatLng(51.8940543645, 4.39511834971));
            pernis_points.Add(new PointLatLng(51.8940299194, 4.39518775322));
            pernis_points.Add(new PointLatLng(51.8940053292, 4.39525702181));
            pernis_points.Add(new PointLatLng(51.893980594, 4.39532615694));
            pernis_points.Add(new PointLatLng(51.8930330929, 4.39794112069));
            pernis_points.Add(new PointLatLng(51.8926694414, 4.39895430673));
            pernis_points.Add(new PointLatLng(51.8926632669, 4.3989704109));
            pernis_points.Add(new PointLatLng(51.8926554776, 4.39897954714));
            pernis_points.Add(new PointLatLng(51.8926519331, 4.39898117251));
            pernis_points.Add(new PointLatLng(51.8926483016, 4.39898218372));
            pernis_points.Add(new PointLatLng(51.8926446253, 4.39898256967));
            pernis_points.Add(new PointLatLng(51.8926409437, 4.3989823266));
            pernis_points.Add(new PointLatLng(51.892637299, 4.39898145792));
            pernis_points.Add(new PointLatLng(51.892633731, 4.39897997004));
            pernis_points.Add(new PointLatLng(51.8926302802, 4.39897788385));
            pernis_points.Add(new PointLatLng(51.8926269854, 4.39897521885));
            pernis_points.Add(new PointLatLng(51.8926238821, 4.39897200767));
            pernis_points.Add(new PointLatLng(51.8925720036, 4.39803757649));
            pernis_points.Add(new PointLatLng(51.8909524078, 4.39721961438));
            pernis_points.Add(new PointLatLng(51.8909232916, 4.39720441277));
            pernis_points.Add(new PointLatLng(51.890740392, 4.39710892081));
            pernis_points.Add(new PointLatLng(51.8899023264, 4.39668522248));
            pernis_points.Add(new PointLatLng(51.8895987354, 4.39653024241));
            pernis_points.Add(new PointLatLng(51.8875490973, 4.39826534298));
            pernis_points.Add(new PointLatLng(51.8874541424, 4.39797468711));
            pernis_points.Add(new PointLatLng(51.8874234065, 4.39782326415));
            pernis_points.Add(new PointLatLng(51.8874001752, 4.39769402647));
            pernis_points.Add(new PointLatLng(51.8873311272, 4.39771472355));
            pernis_points.Add(new PointLatLng(51.8873220148, 4.39771565489));
            pernis_points.Add(new PointLatLng(51.8873128925, 4.39771626247));
            pernis_points.Add(new PointLatLng(51.8873037638, 4.39771654621));
            pernis_points.Add(new PointLatLng(51.8872946333, 4.397716506));
            pernis_points.Add(new PointLatLng(51.8872855054, 4.39771614031));
            pernis_points.Add(new PointLatLng(51.8872763856, 4.39771545191));
            pernis_points.Add(new PointLatLng(51.8872672766, 4.39771443785));
            pernis_points.Add(new PointLatLng(51.8872581837, 4.39771310236));
            pernis_points.Add(new PointLatLng(51.8872491115, 4.39771144388));
            pernis_points.Add(new PointLatLng(51.8872394671, 4.39770930404));
            pernis_points.Add(new PointLatLng(51.8872298573, 4.39770680024));
            pernis_points.Add(new PointLatLng(51.8872202867, 4.39770393091));
            pernis_points.Add(new PointLatLng(51.8872107599, 4.39770070033));
            pernis_points.Add(new PointLatLng(51.887201283, 4.39769710835));
            pernis_points.Add(new PointLatLng(51.8871918606, 4.39769315777));
            pernis_points.Add(new PointLatLng(51.8871824981, 4.39768884994));
            pernis_points.Add(new PointLatLng(51.887173201, 4.39768418909));
            pernis_points.Add(new PointLatLng(51.8871639747, 4.39767917656));
            pernis_points.Add(new PointLatLng(51.8869808112, 4.39758935651));
            pernis_points.Add(new PointLatLng(51.8869834699, 4.39757404346));
            pernis_points.Add(new PointLatLng(51.8854479015, 4.39681491711));
            pernis_points.Add(new PointLatLng(51.8854383138, 4.3968656554));
            pernis_points.Add(new PointLatLng(51.8850555323, 4.3966696403));
            pernis_points.Add(new PointLatLng(51.8849337475, 4.396601659));
            pernis_points.Add(new PointLatLng(51.8849156627, 4.39658911061));
            pernis_points.Add(new PointLatLng(51.8848977401, 4.39657596738));
            pernis_points.Add(new PointLatLng(51.8848799887, 4.39656223639));
            pernis_points.Add(new PointLatLng(51.884862413, 4.39654792189));
            pernis_points.Add(new PointLatLng(51.8848450231, 4.39653302948));
            pernis_points.Add(new PointLatLng(51.8848278244, 4.3965175663));
            pernis_points.Add(new PointLatLng(51.8848108249, 4.39650153943));
            pernis_points.Add(new PointLatLng(51.884794032, 4.39648495453));
            pernis_points.Add(new PointLatLng(51.884777452, 4.39646781871));
            pernis_points.Add(new PointLatLng(51.8847616079, 4.39645073352));
            pernis_points.Add(new PointLatLng(51.8847459805, 4.39643313946));
            pernis_points.Add(new PointLatLng(51.8847305737, 4.39641504082));
            pernis_points.Add(new PointLatLng(51.8847153955, 4.39639644757));
            pernis_points.Add(new PointLatLng(51.8847004514, 4.39637736396));
            pernis_points.Add(new PointLatLng(51.8846857469, 4.39635780149));
            pernis_points.Add(new PointLatLng(51.8846712883, 4.39633776438));
            pernis_points.Add(new PointLatLng(51.884657082, 4.39631726266));
            pernis_points.Add(new PointLatLng(51.8846431334, 4.39629630492));
            pernis_points.Add(new PointLatLng(51.8846111612, 4.39624352568));
            pernis_points.Add(new PointLatLng(51.8845805478, 4.39618868418));
            pernis_points.Add(new PointLatLng(51.8845513428, 4.3961318723));
            pernis_points.Add(new PointLatLng(51.8845235953, 4.39607318486));
            pernis_points.Add(new PointLatLng(51.8844973511, 4.3960127167));
            pernis_points.Add(new PointLatLng(51.8844726534, 4.39595057148));
            pernis_points.Add(new PointLatLng(51.8844495444, 4.3958868514));
            pernis_points.Add(new PointLatLng(51.8844280626, 4.3958216602));
            pernis_points.Add(new PointLatLng(51.8844082424, 4.39575511045));
            pernis_points.Add(new PointLatLng(51.8832705204, 4.39226410086));
            pernis_points.Add(new PointLatLng(51.8832474828, 4.39219017033));
            pernis_points.Add(new PointLatLng(51.8832229554, 4.39211750183));
            pernis_points.Add(new PointLatLng(51.883196966, 4.39204617464));
            pernis_points.Add(new PointLatLng(51.883169542, 4.39197626371));
            pernis_points.Add(new PointLatLng(51.883140712, 4.39190784393));
            pernis_points.Add(new PointLatLng(51.8831105072, 4.39184099162));
            pernis_points.Add(new PointLatLng(51.8830789615, 4.39177577721));
            pernis_points.Add(new PointLatLng(51.8830461078, 4.39171227116));
            pernis_points.Add(new PointLatLng(51.8830119826, 4.39165054239));
            pernis_points.Add(new PointLatLng(51.8828504617, 4.39141006864));
            pernis_points.Add(new PointLatLng(51.8828135614, 4.39136404282));
            pernis_points.Add(new PointLatLng(51.8827757809, 4.39131992214));
            pernis_points.Add(new PointLatLng(51.8827371584, 4.3912777479));
            pernis_points.Add(new PointLatLng(51.882697732, 4.39123756426));
            pernis_points.Add(new PointLatLng(51.8826575406, 4.3911994096));
            pernis_points.Add(new PointLatLng(51.8826166251, 4.39116332222));
            pernis_points.Add(new PointLatLng(51.8825750244, 4.39112933902));
            pernis_points.Add(new PointLatLng(51.882532782, 4.39109749245));
            pernis_points.Add(new PointLatLng(51.8824899386, 4.39106781502));
            pernis_points.Add(new PointLatLng(51.8820530973, 4.39076880417));
            pernis_points.Add(new PointLatLng(51.8820280912, 4.39075306683));
            pernis_points.Add(new PointLatLng(51.8820033557, 4.39073625291));
            pernis_points.Add(new PointLatLng(51.8819789077, 4.39071837365));
            pernis_points.Add(new PointLatLng(51.8819547645, 4.39069944175));
            pernis_points.Add(new PointLatLng(51.8819309452, 4.39067946986));
            pernis_points.Add(new PointLatLng(51.881907465, 4.39065847361));
            pernis_points.Add(new PointLatLng(51.8818843422, 4.39063646859));
            pernis_points.Add(new PointLatLng(51.8818615921, 4.39061346899));
            pernis_points.Add(new PointLatLng(51.8818392329, 4.39058949328));
            pernis_points.Add(new PointLatLng(51.8815202156, 4.3902336956));
            pernis_points.Add(new PointLatLng(51.8815022648, 4.39021277327));
            pernis_points.Add(new PointLatLng(51.8814853858, 4.39018964244));
            pernis_points.Add(new PointLatLng(51.8814696812, 4.39016444172));
            pernis_points.Add(new PointLatLng(51.8814552477, 4.39013733021));
            pernis_points.Add(new PointLatLng(51.8814421749, 4.39010847299));
            pernis_points.Add(new PointLatLng(51.8814305424, 4.39007804695));
            pernis_points.Add(new PointLatLng(51.8814204229, 4.39004624079));
            pernis_points.Add(new PointLatLng(51.8814118782, 4.39001325068));
            pernis_points.Add(new PointLatLng(51.8814049614, 4.38997928027));
            pernis_points.Add(new PointLatLng(51.8813958577, 4.3899235558));
            pernis_points.Add(new PointLatLng(51.8813947772, 4.38991638051));
            pernis_points.Add(new PointLatLng(51.8813938501, 4.38990914953));
            pernis_points.Add(new PointLatLng(51.8813930763, 4.38990187157));
            pernis_points.Add(new PointLatLng(51.8813924576, 4.3898945553));
            pernis_points.Add(new PointLatLng(51.8813919943, 4.38988720945));
            pernis_points.Add(new PointLatLng(51.8813916863, 4.38987984271));
            pernis_points.Add(new PointLatLng(51.8813915355, 4.38987246232));
            pernis_points.Add(new PointLatLng(51.8813915401, 4.38986507703));
            pernis_points.Add(new PointLatLng(51.8813917013, 4.38985769844));
            pernis_points.Add(new PointLatLng(51.8814056572, 4.38986382114));
            pernis_points.Add(new PointLatLng(51.8814199059, 4.38986780198));
            pernis_points.Add(new PointLatLng(51.881434324, 4.38986960592));
            pernis_points.Add(new PointLatLng(51.8814487828, 4.38986921548));
            pernis_points.Add(new PointLatLng(51.8814631546, 4.38986663495));
            pernis_points.Add(new PointLatLng(51.8814773139, 4.38986188888));
            pernis_points.Add(new PointLatLng(51.8814911351, 4.3898550164));
            pernis_points.Add(new PointLatLng(51.8815044964, 4.38984607974));
            pernis_points.Add(new PointLatLng(51.8815172799, 4.38983515706));
            pernis_points.Add(new PointLatLng(51.88154986, 4.38980770583));
            pernis_points.Add(new PointLatLng(51.8815882609, 4.38978489881));
            pernis_points.Add(new PointLatLng(51.8816405636, 4.38948974433));
            pernis_points.Add(new PointLatLng(51.8816073834, 4.38948888269));
            pernis_points.Add(new PointLatLng(51.881476239, 4.38942773149));
            pernis_points.Add(new PointLatLng(51.8811839111, 4.38930362736));
            pernis_points.Add(new PointLatLng(51.8811468281, 4.38928951882));
            pernis_points.Add(new PointLatLng(51.8811096866, 4.38927582561));
            pernis_points.Add(new PointLatLng(51.8810724867, 4.38926255061));
            pernis_points.Add(new PointLatLng(51.881035231, 4.38924969088));
            pernis_points.Add(new PointLatLng(51.8809979212, 4.38923724927));
            pernis_points.Add(new PointLatLng(51.8809605584, 4.38922522721));
            pernis_points.Add(new PointLatLng(51.8809231452, 4.38921362173));
            pernis_points.Add(new PointLatLng(51.8808856826, 4.38920243718));
            pernis_points.Add(new PointLatLng(51.880848174, 4.38919167348));
            pernis_points.Add(new PointLatLng(51.8808090488, 4.38918055782));
            pernis_points.Add(new PointLatLng(51.8807698761, 4.38916988483));
            pernis_points.Add(new PointLatLng(51.8807306586, 4.38915965445));
            pernis_points.Add(new PointLatLng(51.8806913981, 4.38914986519));
            pernis_points.Add(new PointLatLng(51.8806520965, 4.38914051844));
            pernis_points.Add(new PointLatLng(51.8806127545, 4.38913161711));
            pernis_points.Add(new PointLatLng(51.8805733759, 4.3891231582));
            pernis_points.Add(new PointLatLng(51.8805339615, 4.38911514314));
            pernis_points.Add(new PointLatLng(51.880494514, 4.38910757332));
            pernis_points.Add(new PointLatLng(51.8803312192, 4.38907800324));
            pernis_points.Add(new PointLatLng(51.8800177156, 4.38903854341));
            pernis_points.Add(new PointLatLng(51.8799880607, 4.38903688047));
            pernis_points.Add(new PointLatLng(51.8799886638, 4.3890181563));
            pernis_points.Add(new PointLatLng(51.8799733106, 4.38901760378));
            pernis_points.Add(new PointLatLng(51.8798890696, 4.38901317254));
            pernis_points.Add(new PointLatLng(51.8798047997, 4.38901064048));
            pernis_points.Add(new PointLatLng(51.8797205154, 4.38901000582));
            pernis_points.Add(new PointLatLng(51.8796362338, 4.38901127107));
            pernis_points.Add(new PointLatLng(51.8795519719, 4.38901443439));
            pernis_points.Add(new PointLatLng(51.879467745, 4.38901949398));
            pernis_points.Add(new PointLatLng(51.8793835702, 4.38902645089));
            pernis_points.Add(new PointLatLng(51.8792994637, 4.38903530477));
            pernis_points.Add(new PointLatLng(51.8792154416, 4.38904605088));
            pernis_points.Add(new PointLatLng(51.8791907745, 4.38904969966));
            pernis_points.Add(new PointLatLng(51.8791479809, 4.38905682442));
            pernis_points.Add(new PointLatLng(51.8791439851, 4.38897660395));
            pernis_points.Add(new PointLatLng(51.87913822, 4.38886593497));
            pernis_points.Add(new PointLatLng(51.8791362678, 4.38882845868));
            pernis_points.Add(new PointLatLng(51.8791280773, 4.38865471533));
            pernis_points.Add(new PointLatLng(51.8791187449, 4.38847644217));
            pernis_points.Add(new PointLatLng(51.8791137157, 4.38841100711));
            pernis_points.Add(new PointLatLng(51.8791076745, 4.38833240675));
            pernis_points.Add(new PointLatLng(51.8791016613, 4.38815472817));
            pernis_points.Add(new PointLatLng(51.8791855363, 4.38815691585));
            pernis_points.Add(new PointLatLng(51.8791236825, 4.38781309352));
            pernis_points.Add(new PointLatLng(51.879118912, 4.38777798078));
            pernis_points.Add(new PointLatLng(51.8791022528, 4.3876008105));
            pernis_points.Add(new PointLatLng(51.879094793, 4.38749545516));
            pernis_points.Add(new PointLatLng(51.8790874959, 4.38726726056));
            pernis_points.Add(new PointLatLng(51.8791699079, 4.38720618809));
            pernis_points.Add(new PointLatLng(51.8791738885, 4.38732162909));
            pernis_points.Add(new PointLatLng(51.8791930441, 4.38736425709));
            pernis_points.Add(new PointLatLng(51.8792270551, 4.38744123188));
            pernis_points.Add(new PointLatLng(51.8793438893, 4.38742961523));
            pernis_points.Add(new PointLatLng(51.8793336465, 4.38709045066));
            pernis_points.Add(new PointLatLng(51.8793291549, 4.38709084107));
            pernis_points.Add(new PointLatLng(51.8792977247, 4.38612466274));

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

            GMapPolygon pernis = new GMapPolygon(pernis_points, "Charlois");
            pernis.Fill = new SolidBrush(Color.FromArgb(100, Color.Blue));
            pernis.Stroke = new Pen(Color.Blue, 1);

            GMapPolygon rozenburg = new GMapPolygon(rozenburg_points, "Rozenburg");
            rozenburg.Fill = new SolidBrush(Color.FromArgb(100, Color.Yellow));
            rozenburg.Stroke = new Pen(Color.Yellow, 1);

            GMapPolygon hoekvanholland = new GMapPolygon(hoekvanholland_points, "Hoek van Holland");
            hoekvanholland.Fill = new SolidBrush(Color.FromArgb(100, Color.Purple));
            hoekvanholland.Stroke = new Pen(Color.Purple, 1);

            //Hier zet je de variabele die je hiervoor hebt aangemaakt in. // De variabelen kunnen ergens anders, zodat ze niet steeds opnieuw worden aangemaakt(de coordinaten blijven altijd hetzelfde).
            //foreach (Borough deelgemeente in Rdam.Deelgemeenten)
            //{
            //    if (deelgemeente.Draw == true)
            //    {
            //        Heatmaps.Polygons.Add(new GMapPolygon(deelgemeente.Deelgemeente, "x"));
            //    }
            //}

            Heatmaps.Polygons.Add(hoekvanholland);
            Heatmaps.Polygons.Add(rozenburg);
            Heatmaps.Polygons.Add(schiebroek);
            Heatmaps.Polygons.Add(noord);
            Heatmaps.Polygons.Add(feijenoord);
            Heatmaps.Polygons.Add(pernis);
            gmap.Overlays.Add(Heatmaps);
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



        // DIT IS MARC ZIJN STUKKIE, NIET AANKOMME, HIJ ZAL HET AFMAKEN ;)
        //public class ComboboxItem
        //{
        //    public string Text { get; set; }
        //    public string Value { get; set; }
        //    public override string ToString() { return Text; }
        //}

        //private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    ComboBox cmb = (ComboBox)sender;
        //    int selectedIndex = cmb.SelectedIndex;
        //    int selectedValue = (int)cmb.SelectedValue;

        //    ComboboxItem selectedArea = (ComboboxItem)cmb.SelectedItem;           
        //}
    }
}