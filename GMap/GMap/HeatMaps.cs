using GMap.NET;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using GMap.NET.WindowsForms.ToolTips;


namespace GMap
{

    //Maak een Heatmaps GMapOverlay instance--
    //GMapOverlay Heatmaps = new GMapOverlay("Heatmaps");

    
    //List<PointLatLng> feijenoord_points = new List<PointLatLng>();

    //Borough Feijenoord = new Borough("Feijenoord", feijenoord_points, true);

    //Rotterdam Rdam = new Rotterdam();
    //Rdam.AddtoRotterdam(Feijenoord);

    //GMapPolygon feijenoord = new GMapPolygon(feijenoord_points, "Feijenoord");
    //feijenoord.Fill = new SolidBrush(Color.FromArgb(100, Color.Green));
    //feijenoord.Stroke = new Pen(Color.Green, 1);

    //Heatmaps.Polygons.Add(feijenoord);

    //gmap.Overlays.Add(Heatmaps);

    class Heatmap
    {
        private GMapOverlay heatmaps;

        public Heatmap(GMapOverlay heatmaps)
        {
            this.heatmaps = heatmaps;
        }

        public void AddtoHeatmap(List<PointLatLng> polygon, string name)
        {
            this.heatmaps.Polygons.Add(new GMapPolygon(polygon, name));
        }

        //Misschien alle values per deelgemeente in een list plaatsen en op die manier alles te maken.

        //GMapOverlay Heatmaps = new GMapOverlay("Heatmaps");
        //List<PointLatLng> schiebroek_points = new List<PointLatLng>();

        // Charlois
        //charlois_points.Add(new PointLatLng(4.42392461328,51.895026578,0);
        //charlois_points.Add(new PointLatLng(4.42602602129,51.8925244559,0);
        //charlois_points.Add(new PointLatLng(4.42607640035,51.8924597141,0);
        //charlois_points.Add(new PointLatLng(4.42612755111,51.8923750472,0);
        //charlois_points.Add(new PointLatLng(4.42617153133,51.8922614253,0);
        //charlois_points.Add(new PointLatLng(4.42618425189,51.8921523644,0);
        //charlois_points.Add(new PointLatLng(4.42617739014,51.8920779205,0);
        //charlois_points.Add(new PointLatLng(4.42614808271,51.8919587724,0);
        //charlois_points.Add(new PointLatLng(4.42608625061,51.8917847983,0);
        //charlois_points.Add(new PointLatLng(4.42600227548,51.8915287667,0);
        //charlois_points.Add(new PointLatLng(4.42594198927,51.8913765896,0);
        //charlois_points.Add(new PointLatLng(4.4258806461,51.8912217454,0);
        //charlois_points.Add(new PointLatLng(4.42579070897,51.8909631953,0);
        //charlois_points.Add(new PointLatLng(4.4257366719,51.8908189623,0);
        //charlois_points.Add(new PointLatLng(4.42570902207,51.8907653269,0);
        //charlois_points.Add(new PointLatLng(4.42568008962,51.8907198987,0);
        //charlois_points.Add(new PointLatLng(4.42558371583,51.8906109441,0);
        //charlois_points.Add(new PointLatLng(4.42549678032,51.8905378625,0);
        //charlois_points.Add(new PointLatLng(4.42532120586,51.8904282292,0);
        //charlois_points.Add(new PointLatLng(4.42499474679,51.890235936,0);
        //charlois_points.Add(new PointLatLng(4.42497437068,51.8902226546,0);
        //charlois_points.Add(new PointLatLng(4.42495439616,51.8902091427,0);
        //charlois_points.Add(new PointLatLng(4.42493482897,51.890195404,0);
        //charlois_points.Add(new PointLatLng(4.42491567772,51.890181443,0);
        //charlois_points.Add(new PointLatLng(4.4248969452,51.8901672653,0);
        //charlois_points.Add(new PointLatLng(4.42487864148,51.8901528753,0);
        //charlois_points.Add(new PointLatLng(4.42486077082,51.8901382785,0);
        //charlois_points.Add(new PointLatLng(4.42484334037,51.8901234794,0);
        //charlois_points.Add(new PointLatLng(4.42482635584,51.8901084826,0);
        //charlois_points.Add(new PointLatLng(4.42481500668,51.8900981231,0);
        //charlois_points.Add(new PointLatLng(4.42480387154,51.8900876746,0);
        //charlois_points.Add(new PointLatLng(4.42479295039,51.8900771397,0);
        //charlois_points.Add(new PointLatLng(4.42478224461,51.8900665212,0);
        //charlois_points.Add(new PointLatLng(4.42477175856,51.8900558191,0);
        //charlois_points.Add(new PointLatLng(4.42476149075,51.8900450352,0);
        //charlois_points.Add(new PointLatLng(4.42475144546,51.8900341731,0);
        //charlois_points.Add(new PointLatLng(4.42474162271,51.8900232319,0);
        //charlois_points.Add(new PointLatLng(4.42473202388,51.8900122152,0);
        //charlois_points.Add(new PointLatLng(4.42471927031,51.8899885319,0);
        //charlois_points.Add(new PointLatLng(4.42470769418,51.8899646183,0);
        //charlois_points.Add(new PointLatLng(4.4246973081,51.889940496,0);
        //charlois_points.Add(new PointLatLng(4.42468812027,51.8899161894,0);
        //charlois_points.Add(new PointLatLng(4.4246801404,51.8898917191,0);
        //charlois_points.Add(new PointLatLng(4.42467337526,51.8898671087,0);
        //charlois_points.Add(new PointLatLng(4.42466783159,51.8898423824,0);
        //charlois_points.Add(new PointLatLng(4.42466351329,51.8898175619,0);
        //charlois_points.Add(new PointLatLng(4.42466042707,51.8897926723,0);
        //charlois_points.Add(new PointLatLng(4.4246613255,51.8897849124,0);
        //charlois_points.Add(new PointLatLng(4.42466162318,51.8897764383,0);
        //charlois_points.Add(new PointLatLng(4.42466141951,51.8897586735,0);
        //charlois_points.Add(new PointLatLng(4.42466212002,51.8897186311,0);
        //charlois_points.Add(new PointLatLng(4.42466232398,51.8897150089,0);
        //charlois_points.Add(new PointLatLng(4.4246625512,51.8897113861,0);
        //charlois_points.Add(new PointLatLng(4.42466279872,51.8897077652,0);
        //charlois_points.Add(new PointLatLng(4.42466306803,51.8897041445,0);
        //charlois_points.Add(new PointLatLng(4.42466335768,51.8897005239,0);
        //charlois_points.Add(new PointLatLng(4.42466367055,51.8896969045,0);
        //charlois_points.Add(new PointLatLng(4.42466400376,51.8896932852,0);
        //charlois_points.Add(new PointLatLng(4.42466435872,51.8896896679,0);
        //charlois_points.Add(new PointLatLng(4.42466473404,51.8896860498,0);
        //charlois_points.Add(new PointLatLng(4.42466716975,51.889666274,0);
        //charlois_points.Add(new PointLatLng(4.42467024254,51.8896465323,0);
        //charlois_points.Add(new PointLatLng(4.42467395226,51.8896268326,0);
        //charlois_points.Add(new PointLatLng(4.42467829872,51.889607183,0);
        //charlois_points.Add(new PointLatLng(4.42468327742,51.8895875899,0);
        //charlois_points.Add(new PointLatLng(4.42468888816,51.8895680631,0);
        //charlois_points.Add(new PointLatLng(4.42469512933,51.8895486098,0);
        //charlois_points.Add(new PointLatLng(4.42470199787,51.8895292372,0);
        //charlois_points.Add(new PointLatLng(4.4247094907,51.8895099533,0);
        //charlois_points.Add(new PointLatLng(4.42471860891,51.88948777,0);
        //charlois_points.Add(new PointLatLng(4.42472857696,51.8894657267,0);
        //charlois_points.Add(new PointLatLng(4.42473939022,51.8894438359,0);
        //charlois_points.Add(new PointLatLng(4.42475104113,51.8894221112,0);
        //charlois_points.Add(new PointLatLng(4.42476352511,51.8894005632,0);
        //charlois_points.Add(new PointLatLng(4.42477683313,51.8893792062,0);
        //charlois_points.Add(new PointLatLng(4.42479095772,51.8893580501,0);
        //charlois_points.Add(new PointLatLng(4.42480589132,51.8893371083,0);
        //charlois_points.Add(new PointLatLng(4.42482162787,51.8893163925,0);
        //charlois_points.Add(new PointLatLng(4.4255370778,51.8883781024,0);
        //charlois_points.Add(new PointLatLng(4.42555649213,51.8883526403,0);
        //charlois_points.Add(new PointLatLng(4.42560883211,51.8882836544,0);
        //charlois_points.Add(new PointLatLng(4.42589896215,51.8878870671,0);
        //charlois_points.Add(new PointLatLng(4.42593376372,51.8878401713,0);
        //charlois_points.Add(new PointLatLng(4.42597650273,51.8877860407,0);
        //charlois_points.Add(new PointLatLng(4.42633898408,51.8873406452,0);
        //charlois_points.Add(new PointLatLng(4.42634139206,51.8873375553,0);
        //charlois_points.Add(new PointLatLng(4.42634372207,51.8873344432,0);
        //charlois_points.Add(new PointLatLng(4.42634597556,51.8873313089,0);
        //charlois_points.Add(new PointLatLng(4.42634815104,51.8873281533,0);
        //charlois_points.Add(new PointLatLng(4.42635024704,51.8873249781,0);
        //charlois_points.Add(new PointLatLng(4.42635226502,51.8873217825,0);
        //charlois_points.Add(new PointLatLng(4.42635420205,51.8873185683,0);
        //charlois_points.Add(new PointLatLng(4.42635605954,51.8873153364,0);
        //charlois_points.Add(new PointLatLng(4.42635783461,51.8873120867,0);
        //charlois_points.Add(new PointLatLng(4.42636022988,51.8873074163,0);
        //charlois_points.Add(new PointLatLng(4.42636245875,51.8873027148,0);
        //charlois_points.Add(new PointLatLng(4.42636451971,51.8872979841,0);
        //charlois_points.Add(new PointLatLng(4.42636641126,51.8872932269,0);
        //charlois_points.Add(new PointLatLng(4.42636813335,51.8872884449,0);
        //charlois_points.Add(new PointLatLng(4.42636968596,51.8872836399,0);
        //charlois_points.Add(new PointLatLng(4.4263710661,51.8872788155,0);
        //charlois_points.Add(new PointLatLng(4.42637227518,51.8872739736,0);
        //charlois_points.Add(new PointLatLng(4.42637331172,51.8872691158,0);
        //charlois_points.Add(new PointLatLng(4.42637569604,51.8872512949,0);
        //charlois_points.Add(new PointLatLng(4.42637604245,51.8872483419,0);
        //charlois_points.Add(new PointLatLng(4.42637665438,51.8872454054,0);
        //charlois_points.Add(new PointLatLng(4.42637752725,51.8872424953,0);
        //charlois_points.Add(new PointLatLng(4.42637865945,51.8872396188,0);
        //charlois_points.Add(new PointLatLng(4.42638004787,51.8872367858,0);
        //charlois_points.Add(new PointLatLng(4.42638168653,51.8872340042,0);
        //charlois_points.Add(new PointLatLng(4.42638357233,51.8872312831,0);
        //charlois_points.Add(new PointLatLng(4.42638569781,51.8872286314,0);
        //charlois_points.Add(new PointLatLng(4.42638805847,51.8872260563,0);
        //charlois_points.Add(new PointLatLng(4.42646841606,51.887125672,0);
        //charlois_points.Add(new PointLatLng(4.42647053458,51.8871230059,0);
        //charlois_points.Add(new PointLatLng(4.42647276998,51.8871203766,0);
        //charlois_points.Add(new PointLatLng(4.42647512224,51.8871177861,0);
        //charlois_points.Add(new PointLatLng(4.42647758983,51.887115237,0);
        //charlois_points.Add(new PointLatLng(4.42648017126,51.887112732,0);
        //charlois_points.Add(new PointLatLng(4.42648286359,51.8871102719,0);
        //charlois_points.Add(new PointLatLng(4.42648566388,51.8871078585,0);
        //charlois_points.Add(new PointLatLng(4.4264885721,51.8871054937,0);
        //charlois_points.Add(new PointLatLng(4.42649158526,51.887103181,0);
        //charlois_points.Add(new PointLatLng(4.42656415878,51.8870536265,0);
        //charlois_points.Add(new PointLatLng(4.42656722795,51.8870513439,0);
        //charlois_points.Add(new PointLatLng(4.42657019074,51.8870490083,0);
        //charlois_points.Add(new PointLatLng(4.42657304566,51.8870466215,0);
        //charlois_points.Add(new PointLatLng(4.42657578976,51.8870441861,0);
        //charlois_points.Add(new PointLatLng(4.42657842155,51.8870417031,0);
        //charlois_points.Add(new PointLatLng(4.42658093808,51.887039175,0);
        //charlois_points.Add(new PointLatLng(4.42658333788,51.8870366029,0);
        //charlois_points.Add(new PointLatLng(4.42658561939,51.8870339911,0);
        //charlois_points.Add(new PointLatLng(4.42658777971,51.8870313397,0);
        //charlois_points.Add(new PointLatLng(4.42660751452,51.8870070738,0);
        //charlois_points.Add(new PointLatLng(4.42661556987,51.8869971691,0);
        //charlois_points.Add(new PointLatLng(4.42661602643,51.8869966073,0);
        //charlois_points.Add(new PointLatLng(4.42661628798,51.8869961294,0);
        //charlois_points.Add(new PointLatLng(4.42661640351,51.886995822,0);
        //charlois_points.Add(new PointLatLng(4.42661648663,51.8869954676,0);
        //charlois_points.Add(new PointLatLng(4.42663208407,51.8869560271,0);
        //charlois_points.Add(new PointLatLng(4.42672286743,51.8868058655,0);
        //charlois_points.Add(new PointLatLng(4.42672317295,51.8868054374,0);
        //charlois_points.Add(new PointLatLng(4.42672344378,51.8868050009,0);
        //charlois_points.Add(new PointLatLng(4.42675655799,51.8867518,0);
        //charlois_points.Add(new PointLatLng(4.42675412886,51.8867511904,0);
        //charlois_points.Add(new PointLatLng(4.42654940304,51.886699804,0);
        //charlois_points.Add(new PointLatLng(4.42654508957,51.8866987214,0);
        //charlois_points.Add(new PointLatLng(4.42654295459,51.8866978759,0);
        //charlois_points.Add(new PointLatLng(4.42654101194,51.8866968685,0);
        //charlois_points.Add(new PointLatLng(4.4265392976,51.8866957145,0);
        //charlois_points.Add(new PointLatLng(4.42653783586,51.8866944332,0);
        //charlois_points.Add(new PointLatLng(4.42653665386,51.8866930463,0);
        //charlois_points.Add(new PointLatLng(4.42653577146,51.8866915764,0);
        //charlois_points.Add(new PointLatLng(4.42653520121,51.8866900479,0);
        //charlois_points.Add(new PointLatLng(4.42653495416,51.886688488,0);
        //charlois_points.Add(new PointLatLng(4.42653503414,51.8866869208,0);
        //charlois_points.Add(new PointLatLng(4.42652103287,51.8866262413,0);
        //charlois_points.Add(new PointLatLng(4.42639884307,51.886621258,0);
        //charlois_points.Add(new PointLatLng(4.42631129578,51.886619985,0);
        //charlois_points.Add(new PointLatLng(4.42626708247,51.8866202075,0);
        //charlois_points.Add(new PointLatLng(4.42612060034,51.8866295716,0);
        //charlois_points.Add(new PointLatLng(4.42611688002,51.8866299655,0);
        //charlois_points.Add(new PointLatLng(4.42609049535,51.8866329769,0);
        //charlois_points.Add(new PointLatLng(4.42606418271,51.8866362199,0);
        //charlois_points.Add(new PointLatLng(4.42603794795,51.8866396937,0);
        //charlois_points.Add(new PointLatLng(4.42601179398,51.8866433973,0);
        //charlois_points.Add(new PointLatLng(4.42598572953,51.886647331,0);
        //charlois_points.Add(new PointLatLng(4.42595975607,51.8866514928,0);
        //charlois_points.Add(new PointLatLng(4.42593388233,51.8866558829,0);
        //charlois_points.Add(new PointLatLng(4.42590811123,51.8866605004,0);
        //charlois_points.Add(new PointLatLng(4.42588244862,51.8866653434,0);
        //charlois_points.Add(new PointLatLng(4.42523891087,51.8868055279,0);
        //charlois_points.Add(new PointLatLng(4.42507250589,51.8868490248,0);
        //charlois_points.Add(new PointLatLng(4.42483634832,51.8869272791,0);
        //charlois_points.Add(new PointLatLng(4.42482681539,51.8869246829,0);
        //charlois_points.Add(new PointLatLng(4.424816763,51.8869056327,0);
        //charlois_points.Add(new PointLatLng(4.42343653241,51.8872068892,0);
        //charlois_points.Add(new PointLatLng(4.4234470258,51.8872256744,0);
        //charlois_points.Add(new PointLatLng(4.42344724022,51.8872260411,0);
        //charlois_points.Add(new PointLatLng(4.42344740062,51.88722642,0);
        //charlois_points.Add(new PointLatLng(4.42344750568,51.8872268056,0);
        //charlois_points.Add(new PointLatLng(4.42344755253,51.8872271953,0);
        //charlois_points.Add(new PointLatLng(4.42344754124,51.8872275863,0);
        //charlois_points.Add(new PointLatLng(4.4234474748,51.887227975,0);
        //charlois_points.Add(new PointLatLng(4.42344735034,51.8872283587,0);
        //charlois_points.Add(new PointLatLng(4.42344716943,51.887228733,0);
        //charlois_points.Add(new PointLatLng(4.42344693501,51.8872290961,0);
        //charlois_points.Add(new PointLatLng(4.42344664861,51.8872294443,0);
        //charlois_points.Add(new PointLatLng(4.42344631173,51.8872297751,0);
        //charlois_points.Add(new PointLatLng(4.42344592733,51.8872300857,0);
        //charlois_points.Add(new PointLatLng(4.42344549985,51.8872303734,0);
        //charlois_points.Add(new PointLatLng(4.42344503078,51.8872306357,0);
        //charlois_points.Add(new PointLatLng(4.42344452597,51.8872308707,0);
        //charlois_points.Add(new PointLatLng(4.42344398837,51.8872310766,0);
        //charlois_points.Add(new PointLatLng(4.42344342385,51.8872312509,0);
        //charlois_points.Add(new PointLatLng(4.42344283531,51.8872313935,0);
        //charlois_points.Add(new PointLatLng(4.42321221491,51.8872815516,0);
        //charlois_points.Add(new PointLatLng(4.42192859699,51.8875344091,0);
        //charlois_points.Add(new PointLatLng(4.4206227747,51.8878192536,0);
        //charlois_points.Add(new PointLatLng(4.42046723049,51.8878572588,0);
        //charlois_points.Add(new PointLatLng(4.42030809156,51.8879002685,0);
        //charlois_points.Add(new PointLatLng(4.4200439102,51.8879579509,0);
        //charlois_points.Add(new PointLatLng(4.42014342384,51.8881934509,0);
        //charlois_points.Add(new PointLatLng(4.42052656543,51.8888679418,0);
        //charlois_points.Add(new PointLatLng(4.42049357406,51.8888752208,0);
        //charlois_points.Add(new PointLatLng(4.42049623349,51.8888799183,0);
        //charlois_points.Add(new PointLatLng(4.42048090222,51.8889375063,0);
        //charlois_points.Add(new PointLatLng(4.42068880791,51.8893024105,0);
        //charlois_points.Add(new PointLatLng(4.42090133678,51.8896754425,0);
        //charlois_points.Add(new PointLatLng(4.42088323606,51.8896793884,0);
        //charlois_points.Add(new PointLatLng(4.42101415618,51.8897186054,0);
        //charlois_points.Add(new PointLatLng(4.42158076374,51.890712108,0);
        //charlois_points.Add(new PointLatLng(4.42161819923,51.8907777472,0);
        //charlois_points.Add(new PointLatLng(4.41577469598,51.8920527713,0);
        //charlois_points.Add(new PointLatLng(4.41583181862,51.892260772,0);
        //charlois_points.Add(new PointLatLng(4.41586542514,51.8922722434,0);
        //charlois_points.Add(new PointLatLng(4.41742561595,51.8927781906,0);
        //charlois_points.Add(new PointLatLng(4.41817080986,51.8930196534,0);
        //charlois_points.Add(new PointLatLng(4.41891774057,51.8932618,0);
        //charlois_points.Add(new PointLatLng(4.41966761785,51.8935058091,0);
        //charlois_points.Add(new PointLatLng(4.42034898044,51.8937266242,0);
        //charlois_points.Add(new PointLatLng(4.42093530967,51.8939162145,0);
        //charlois_points.Add(new PointLatLng(4.42096689204,51.8939320647,0);
        //charlois_points.Add(new PointLatLng(4.42098674057,51.8939538919,0);
        //charlois_points.Add(new PointLatLng(4.42098814854,51.8939567317,0);
        //charlois_points.Add(new PointLatLng(4.42098934793,51.8939596084,0);
        //charlois_points.Add(new PointLatLng(4.42099033597,51.8939625158,0);
        //charlois_points.Add(new PointLatLng(4.42099110988,51.8939654483,0);
        //charlois_points.Add(new PointLatLng(4.42099166835,51.8939683989,0);
        //charlois_points.Add(new PointLatLng(4.42099201004,51.8939713621,0);
        //charlois_points.Add(new PointLatLng(4.42099213363,51.8939743325,0);
        //charlois_points.Add(new PointLatLng(4.42099204072,51.8939773029,0);
        //charlois_points.Add(new PointLatLng(4.42099173141,51.8939802679,0);
        //charlois_points.Add(new PointLatLng(4.42099120298,51.8939832203,0);
        //charlois_points.Add(new PointLatLng(4.42099045985,51.8939861557,0);
        //charlois_points.Add(new PointLatLng(4.42098950366,51.8939890668,0);
        //charlois_points.Add(new PointLatLng(4.4209883345,51.8939919484,0);
        //charlois_points.Add(new PointLatLng(4.42098695542,51.893994794,0);
        //charlois_points.Add(new PointLatLng(4.42098537091,51.8939975984,0);
        //charlois_points.Add(new PointLatLng(4.42098358253,51.8940003553,0);
        //charlois_points.Add(new PointLatLng(4.4209815933,51.8940030601,0);
        //charlois_points.Add(new PointLatLng(4.4209794092,51.894005705,0);
        //charlois_points.Add(new PointLatLng(4.42094630923,51.8940448991,0);
        //charlois_points.Add(new PointLatLng(4.42091197271,51.8940334691,0);
        //charlois_points.Add(new PointLatLng(4.42057440163,51.8944335274,0);
        //charlois_points.Add(new PointLatLng(4.4205621515,51.8944297875,0);
        //charlois_points.Add(new PointLatLng(4.420498745,51.8944988904,0);
        //charlois_points.Add(new PointLatLng(4.42045664458,51.894532655,0);
        //charlois_points.Add(new PointLatLng(4.42042940063,51.8945545062,0);
        //charlois_points.Add(new PointLatLng(4.42023649684,51.8946664601,0);
        //charlois_points.Add(new PointLatLng(4.42019780502,51.8946953586,0);
        //charlois_points.Add(new PointLatLng(4.42012624039,51.8947595863,0);
        //charlois_points.Add(new PointLatLng(4.4200024881,51.8949069693,0);
        //charlois_points.Add(new PointLatLng(4.41940221272,51.8956218643,0);
        //charlois_points.Add(new PointLatLng(4.41932688162,51.895978951,0);
        //charlois_points.Add(new PointLatLng(4.41925956392,51.896298018,0);
        //charlois_points.Add(new PointLatLng(4.41905510972,51.8972524654,0);
        //charlois_points.Add(new PointLatLng(4.41905866402,51.8972665,0);
        //charlois_points.Add(new PointLatLng(4.41945499036,51.8972906721,0);
        //charlois_points.Add(new PointLatLng(4.42043989114,51.8973701349,0);
        //charlois_points.Add(new PointLatLng(4.42057223648,51.8973851875,0);
        //charlois_points.Add(new PointLatLng(4.42067762518,51.8973971737,0);
        //charlois_points.Add(new PointLatLng(4.4209349415,51.8974382302,0);
        //charlois_points.Add(new PointLatLng(4.42290329255,51.897752536,0);
        //charlois_points.Add(new PointLatLng(4.42393601145,51.897917526,0);
        //charlois_points.Add(new PointLatLng(4.42409534,51.8977015044,0);
        //charlois_points.Add(new PointLatLng(4.42356981701,51.8975513294,0);
        //charlois_points.Add(new PointLatLng(4.42290665083,51.8973714466,0);
        //charlois_points.Add(new PointLatLng(4.42278098774,51.8973345917,0);
        //charlois_points.Add(new PointLatLng(4.42268501382,51.8972858271,0);
        //charlois_points.Add(new PointLatLng(4.4226012833,51.8972328416,0);
        //charlois_points.Add(new PointLatLng(4.42238685146,51.8970511384,0);
        //charlois_points.Add(new PointLatLng(4.42232135872,51.8969891419,0);
        //charlois_points.Add(new PointLatLng(4.42230241714,51.8969627465,0);
        //charlois_points.Add(new PointLatLng(4.42229682813,51.8969111176,0);
        //charlois_points.Add(new PointLatLng(4.42230503682,51.8968712538,0);
        //charlois_points.Add(new PointLatLng(4.42230509516,51.8968709729,0);
        //charlois_points.Add(new PointLatLng(4.42231129535,51.8968408681,0);
        //charlois_points.Add(new PointLatLng(4.42233734628,51.8967975829,0);
        //charlois_points.Add(new PointLatLng(4.42265814011,51.8963812881,0);
        //charlois_points.Add(new PointLatLng(4.42268614838,51.8963435269,0);
        //charlois_points.Add(new PointLatLng(4.42271461294,51.896305898,0);
        //charlois_points.Add(new PointLatLng(4.4227435338,51.8962684014,0);
        //charlois_points.Add(new PointLatLng(4.42277290654,51.8962310398,0);
        //charlois_points.Add(new PointLatLng(4.42280273109,51.8961938158,0);
        //charlois_points.Add(new PointLatLng(4.42283300598,51.8961567313,0);
        //charlois_points.Add(new PointLatLng(4.42286372969,51.8961197879,0);
        //charlois_points.Add(new PointLatLng(4.4228948993,51.8960829876,0);
        //charlois_points.Add(new PointLatLng(4.42292651472,51.8960463339,0);
        //charlois_points.Add(new PointLatLng(4.42296746904,51.8960012192,0);
        //charlois_points.Add(new PointLatLng(4.42300963468,51.8959565333,0);
        //charlois_points.Add(new PointLatLng(4.42305300118,51.8959122897,0);
        //charlois_points.Add(new PointLatLng(4.42309755521,51.8958684999,0);
        //charlois_points.Add(new PointLatLng(4.42314328487,51.8958251764,0);
        //charlois_points.Add(new PointLatLng(4.42319017683,51.8957823308,0);
        //charlois_points.Add(new PointLatLng(4.42323821774,51.8957399766,0);
        //charlois_points.Add(new PointLatLng(4.42328739573,51.8956981242,0);
        //charlois_points.Add(new PointLatLng(4.42333769604,51.8956567845,0);
        //charlois_points.Add(new PointLatLng(4.42339378268,51.8956076414,0);
        //charlois_points.Add(new PointLatLng(4.42344834004,51.8955578448,0);
        //charlois_points.Add(new PointLatLng(4.42350135034,51.8955074106,0);
        //charlois_points.Add(new PointLatLng(4.42355279279,51.8954563594,0);
        //charlois_points.Add(new PointLatLng(4.42360264666,51.8954047099,0);
        //charlois_points.Add(new PointLatLng(4.42365089706,51.8953524791,0);
        //charlois_points.Add(new PointLatLng(4.42369752464,51.8952996883,0);
        //charlois_points.Add(new PointLatLng(4.42374251303,51.8952463555,0);
        //charlois_points.Add(new PointLatLng(4.42378584584,51.8951925003,0);
        //charlois_points.Add(new PointLatLng(4.42392461328,51.895026578,0);




        // Schiebroek
        //schiebroek_points.Add(new PointLatLng(51.96708905110036, 4.457037448883057));
        //schiebroek_points.Add(new PointLatLng(51.96708905110036, 4.457037448883057));
        //schiebroek_points.Add(new PointLatLng(51.96340041540989, 4.4614577293396));
        //schiebroek_points.Add(new PointLatLng(51.956141245872814, 4.461522102355957));
        //schiebroek_points.Add(new PointLatLng(51.95209464118261, 4.45995569229126));
        //schiebroek_points.Add(new PointLatLng(51.94066696241652, 4.4599127769470215));
        //schiebroek_points.Add(new PointLatLng(51.939390426323214, 4.460556507110596));
        //schiebroek_points.Add(new PointLatLng(51.93884143849165, 4.457112550735474));
        //schiebroek_points.Add(new PointLatLng(51.94281648774292, 4.485737085342407)); 
        //schiebroek_points.Add(new PointLatLng(51.94873541741756, 4.530315399169922));
        //schiebroek_points.Add(new PointLatLng(51.95075891698686, 4.529628753662109));
        //schiebroek_points.Add(new PointLatLng(51.95328485694294, 4.530315399169922));
        //schiebroek_points.Add(new PointLatLng(51.95328485694294, 4.530315399169922));
        //schiebroek_points.Add(new PointLatLng(51.956273481693835, 4.528083801269531));
        //schiebroek_points.Add(new PointLatLng(51.95944702439491, 4.526302814483643));
        //schiebroek_points.Add(new PointLatLng(51.96432590808907, 4.524843692779541)); 
        //schiebroek_points.Add(new PointLatLng(51.96354585123928, 4.523191452026367));
        //schiebroek_points.Add(new PointLatLng(51.96341363686843, 4.521174430847168));
        //schiebroek_points.Add(new PointLatLng(51.95965858592097, 4.518256187438965));
        //schiebroek_points.Add(new PointLatLng(51.965714111277784, 4.505832195281982));
        //schiebroek_points.Add(new PointLatLng(51.96630904233955, 4.5064544677734375));
        //schiebroek_points.Add(new PointLatLng(51.971689504568346, 4.49589729309082));
        //schiebroek_points.Add(new PointLatLng(51.967452609867486, 4.495221376419067));
        //schiebroek_points.Add(new PointLatLng(51.969415776248084, 4.490629434585571));
        //schiebroek_points.Add(new PointLatLng(51.972780060062085, 4.4836342334747314));
        //schiebroek_points.Add(new PointLatLng(51.9733352417543, 4.482904672622681));
        //schiebroek_points.Add(new PointLatLng(51.97995062752042, 4.469332695007324));
        //schiebroek_points.Add(new PointLatLng(51.97850338883613, 4.466832876205444));
        //schiebroek_points.Add(new PointLatLng(51.97885363810285, 4.465835094451904));
        //schiebroek_points.Add(new PointLatLng(51.9782654821121, 4.46420431137085));
        //schiebroek_points.Add(new PointLatLng(51.977498885184865, 4.463227987289429));
        //schiebroek_points.Add(new PointLatLng(51.97728740786198, 4.463539123535156));
        //schiebroek_points.Add(new PointLatLng(51.975919389814905, 4.461961984634399));
        //schiebroek_points.Add(new PointLatLng(51.975195711201444, 4.460878372192383));
        //schiebroek_points.Add(new PointLatLng(51.97238349749894, 4.46169376373291));
        //schiebroek_points.Add(new PointLatLng(51.97236366927866, 4.4615113735198975));
        //schiebroek_points.Add(new PointLatLng(51.972039807105304, 4.4615864753723145));
        //schiebroek_points.Add(new PointLatLng(51.971861351438115, 4.46044921875));
        //schiebroek_points.Add(new PointLatLng(51.97034775442492, 4.461854696273804));
        //schiebroek_points.Add(new PointLatLng(51.96937611717232, 4.4620585441589355));
        //schiebroek_points.Add(new PointLatLng(51.96708905110036, 4.457037448883057));

        //GMapPolygon schiebroek = new GMapPolygon(schiebroek_points, "Schiebroek");
        //schiebroek.Fill = new SolidBrush(Color.FromArgb(100, Color.Blue));
        //schiebroek.Stroke = new Pen(Color.Blue, 1);
        //Heatmaps.Polygons.Add(schiebroek);
        //gmap.Overlays.Add(Heatmaps);


        // Noord
        //points.Add(new PointLatLng(51.94281648774292, 4.485737085342407));
        //points.Add(new PointLatLng(51.939390426323214, 4.460556507110596));
        //points.Add(new PointLatLng(51.93884143849165, 4.457112550735474));
        //points.Add(new PointLatLng(51.93828582950888, 4.455138444900513));
        //points.Add(new PointLatLng(51.93717459090055, 4.452981948852539));
        //points.Add(new PointLatLng(51.935210012449296, 4.451136589050293));
        //points.Add(new PointLatLng(51.93460805368726, 4.447542428970337));
        //points.Add(new PointLatLng(51.93406562239103, 4.445675611495972));
        //points.Add(new PointLatLng(51.93368856262664, 4.44597601890564));
        //points.Add(new PointLatLng(51.926060690953335, 4.432210922241211));
        //points.Add(new PointLatLng(51.92207754024217, 4.437103271484375)); // Noordelijke grens Delfshaven
        //points.Add(new PointLatLng(51.92310975276089, 4.450128078460693)); // Vervolg op grens Delfshaven(oostelijke richting)
        //points.Add(new PointLatLng(51.92322885267803, 4.454913139343262)); // Meest noordoostelijke punt Delfshaven (DIT PUNT KOMT BIJ CENTRUM NET ZUIDELIJKER DAN DE VOLGENDE)
        //points.Add(new PointLatLng(51.92396991172871, 4.454827308654785));
        //points.Add(new PointLatLng(51.92442645094639, 4.458222985267639));
        //points.Add(new PointLatLng(51.92452238975679, 4.460223913192749));
        //points.Add(new PointLatLng(51.924704342109806, 4.462412595748901));
        //points.Add(new PointLatLng(51.92521711295459, 4.465067982673645));
        //points.Add(new PointLatLng(51.92538913799029, 4.465384483337402));
        //points.Add(new PointLatLng(51.92584897090665, 4.468206167221069));
        //points.Add(new PointLatLng(51.92605738283531, 4.46969211101532));
        //points.Add(new PointLatLng(51.92602760976189, 4.470620155334473));
        //points.Add(new PointLatLng(51.92616655060219, 4.473280906677246)); 
        //points.Add(new PointLatLng(51.92624594517497, 4.475727081298828)); 
        //points.Add(new PointLatLng(51.92548507474302, 4.482454061508179)); 
        //points.Add(new PointLatLng(51.92498223155278, 4.485189914703369));
        //points.Add(new PointLatLng(51.925994528546035, 4.485372304916382));
        //points.Add(new PointLatLng(51.92711927620635, 4.484546184539795));
        //points.Add(new PointLatLng(51.92836969787115, 4.484760761260986));
        //points.Add(new PointLatLng(51.929428228664634, 4.485812187194824));
        //points.Add(new PointLatLng(51.93145921471352, 4.486391544342041));
        //points.Add(new PointLatLng(51.93317919615934, 4.4879150390625));
        //points.Add(new PointLatLng(51.93397962658333, 4.48941707611084));
        //points.Add(new PointLatLng(51.93466758843016, 4.489932060241699));
        //points.Add(new PointLatLng(51.935375384321524, 4.489953517913818));
        //points.Add(new PointLatLng(51.935792118736195, 4.48766827583313));
        //points.Add(new PointLatLng(51.93752516319531, 4.48691725730896));
        //points.Add(new PointLatLng(51.93860332119872, 4.48567271232605));
        //points.Add(new PointLatLng(51.93964176790779, 4.4857800006866455));
        //points.Add(new PointLatLng(51.94046853950135, 4.48667049407959));
        //points.Add(new PointLatLng(51.94117624388162, 4.486466646194458));
        //points.Add(new PointLatLng(51.94144741736775, 4.487013816833496));


        // Centrum
        //points.Add(new PointLatLng(51.92322885267803, 4.454913139343262)); // Meest noordoostelijke punt Delfshaven (DIT PUNT KOMT BIJ CENTRUM NET ZUIDELIJKER DAN DE VOLGENDE)
        //points.Add(new PointLatLng(51.92396991172871, 4.454827308654785)); // Meest noordwestelijke punt Centrum
        //points.Add(new PointLatLng(51.92442645094639, 4.458222985267639)); // Vervolg op de vorige in oostelijke richting
        //points.Add(new PointLatLng(51.92452238975679, 4.460223913192749)); // Vervolg op de vorige Centrum
        //points.Add(new PointLatLng(51.924704342109806, 4.462412595748901)); // Vervolg op de vorige Centrum
        //points.Add(new PointLatLng(51.92521711295459, 4.465067982673645)); // Vervolg op de vorige Centrum
        //points.Add(new PointLatLng(51.92538913799029, 4.465384483337402)); // Vervolg op de vorige Centrum
        //points.Add(new PointLatLng(51.92584897090665, 4.468206167221069)); // Vervolg op de vorige Centrum
        //points.Add(new PointLatLng(51.92605738283531, 4.46969211101532)); // Vervolg op de vorige Centrum
        //points.Add(new PointLatLng(51.92602760976189, 4.470620155334473)); // Vervolg op de vorige Centrum
        //points.Add(new PointLatLng(51.92616655060219, 4.473280906677246)); // Vervolg op de vorige Centrum
        //points.Add(new PointLatLng(51.92624594517497, 4.475727081298828)); // Vervolg op de vorige Centrum
        //points.Add(new PointLatLng(51.92548507474302, 4.482454061508179)); // Vervolg op de vorige Centrum
        //points.Add(new PointLatLng(51.92498223155278, 4.485189914703369)); 
        //points.Add(new PointLatLng(51.924353669643104, 4.488515853881836)); 
        //points.Add(new PointLatLng(51.923811114390645, 4.495596885681152));
        //points.Add(new PointLatLng(51.92338765207596, 4.497034549713135));
        //points.Add(new PointLatLng(51.92262011644831, 4.497731924057007)); 
        //points.Add(new PointLatLng(51.92228927807849, 4.498193264007568));
        //points.Add(new PointLatLng(51.92129674833909, 4.499598741531372)); 
        //points.Add(new PointLatLng(51.918279323170914, 4.500231742858887)); // Noordelijke grens Feijenoord
        //points.Add(new PointLatLng(51.917511700199704, 4.497056007385254));
        //points.Add(new PointLatLng(51.91086724263741, 4.486069679260254));
        //points.Add(new PointLatLng(51.90958324007934, 4.485383033752441));
        //points.Add(new PointLatLng(51.91032452438584, 4.483580589294434));
        //points.Add(new PointLatLng(51.906260547591316, 4.47866678237915));
        //points.Add(new PointLatLng(51.905651581278946, 4.478387832641602));
        //points.Add(new PointLatLng(51.90491021984195, 4.478774070739746));
        //points.Add(new PointLatLng(51.90448657924125, 4.479117393493652));
        //points.Add(new PointLatLng(51.90040883415434, 4.468538761138916));
        //points.Add(new PointLatLng(51.900475034270606, 4.467895030975342)); // Meest zuidoostelijke hoek Delfshaven
        //points.Add(new PointLatLng(51.90877575575075, 4.462466239929199)); // Vervolg vorige Delfshaven noordelijke richting
        //points.Add(new PointLatLng(51.90897431881701, 4.460556507110596)); // Vervolg vorige Delfshaven noordelijke richting
        //points.Add(new PointLatLng(51.908524241273234, 4.458281993865967)); // Vervolg vorige Delfshaven noordelijke richting
        //points.Add(new PointLatLng(51.909437629224215, 4.457638263702393)); // Vervolg vorige Delfshaven noordelijke richting
        //points.Add(new PointLatLng(51.91041718406383, 4.459633827209473)); // Vervolg vorige Delfshaven noordelijke richting
        //points.Add(new PointLatLng(51.91168792607201, 4.4635820388793945)); // Vervolg vorige Delfshaven noordelijke richting
        //points.Add(new PointLatLng(51.91351455471287, 4.463839530944824)); // Vervolg vorige Delfshaven noordelijke richting
        //points.Add(new PointLatLng(51.91639994711103, 4.462766647338867)); // Vervolg vorige Delfshaven noordelijke richting
        //points.Add(new PointLatLng(51.920343899143454, 4.463410377502441)); // Vervolg vorige Delfshaven noordelijke richting
        //points.Add(new PointLatLng(51.92344058508377, 4.462594985961914)); // Meest noordoostelijke hoek Delfshaven

        // Kralingen
        //points.Add(new PointLatLng(51.94144741736775, 4.487013816833496));
        //points.Add(new PointLatLng(51.94117624388162, 4.486466646194458));
        //points.Add(new PointLatLng(51.94046853950135, 4.48667049407959));
        //points.Add(new PointLatLng(51.93964176790779, 4.4857800006866455));
        //points.Add(new PointLatLng(51.93860332119872, 4.48567271232605));
        //points.Add(new PointLatLng(51.93752516319531, 4.48691725730896));
        //points.Add(new PointLatLng(51.935792118736195, 4.48766827583313));
        //points.Add(new PointLatLng(51.935375384321524, 4.489953517913818));
        //points.Add(new PointLatLng(51.93466758843016, 4.489932060241699));
        //points.Add(new PointLatLng(51.93397962658333, 4.48941707611084));
        //points.Add(new PointLatLng(51.93317919615934, 4.4879150390625));
        //points.Add(new PointLatLng(51.93145921471352, 4.486391544342041));
        //points.Add(new PointLatLng(51.929428228664634, 4.485812187194824));
        //points.Add(new PointLatLng(51.92836969787115, 4.484760761260986));
        //points.Add(new PointLatLng(51.92711927620635, 4.484546184539795));
        //points.Add(new PointLatLng(51.925994528546035, 4.485372304916382));
        //points.Add(new PointLatLng(51.92498223155278, 4.485189914703369)); 
        //points.Add(new PointLatLng(51.924353669643104, 4.488515853881836)); 
        //points.Add(new PointLatLng(51.923811114390645, 4.495596885681152)); 
        //points.Add(new PointLatLng(51.92338765207596, 4.497034549713135)); 
        //points.Add(new PointLatLng(51.92262011644831, 4.497731924057007)); 
        //points.Add(new PointLatLng(51.92228927807849, 4.498193264007568)); 
        //points.Add(new PointLatLng(51.92129674833909, 4.499598741531372)); 
        //points.Add(new PointLatLng(51.918279323170914, 4.500231742858887));
        //points.Add(new PointLatLng(51.917723459571604, 4.505767822265625));
        //points.Add(new PointLatLng(51.91616171072476, 4.509994983673096));
        //points.Add(new PointLatLng(51.913871929886554, 4.513943195343018));
        //points.Add(new PointLatLng(51.9103377614944, 4.5163679122924805));
        //points.Add(new PointLatLng(51.904407146183786, 4.5174407958984375)); Ijsselmonde noordgrens
        //points.Add(new PointLatLng(51.90027643362919, 4.523792266845703)); // Vervolg Ijsselmonde oostelijke richting
        //points.Add(new PointLatLng(51.900117552483934, 4.5284271240234375)); // Vervolg Ijsselmonde oostelijke richting
        //points.Add(new PointLatLng(51.90340098196446, 4.54310417175293)); // Vervolg Ijsselmonde oostelijke richting
        //points.Add(new PointLatLng(51.91600288576498, 4.53486442565918));
        //points.Add(new PointLatLng(51.919761592456524, 4.534950256347656));
        //points.Add(new PointLatLng(51.92828369114749, 4.538683891296387));
        //points.Add(new PointLatLng(51.94873541741756, 4.530315399169922));
        //points.Add(new PointLatLng(51.94281648774292, 4.485737085342407));

        // Prins Alexander
        //points.Add(new PointLatLng(51.931856139360136, 4.563467502593994));
        //points.Add(new PointLatLng(51.93350995426392, 4.562780857086182));
        //points.Add(new PointLatLng(51.934462523983136, 4.561986923217773));
        //points.Add(new PointLatLng(51.9352430868725, 4.560205936431885));
        //points.Add(new PointLatLng(51.93569289660759, 4.560742378234863));
        //points.Add(new PointLatLng(51.9361691608238, 4.562652111053467));
        //points.Add(new PointLatLng(51.94079924387242, 4.560699462890625));
        //points.Add(new PointLatLng(51.94230722489947, 4.570505619049072));
        //points.Add(new PointLatLng(51.94355060971912, 4.572758674621582));
        //points.Add(new PointLatLng(51.94963476183155, 4.565892219543457));
        //points.Add(new PointLatLng(51.958719774034286, 4.561343193054199));
        //points.Add(new PointLatLng(51.958838779446054, 4.561986923217773));
        //points.Add(new PointLatLng(51.95989659144437, 4.564390182495117));
        //points.Add(new PointLatLng(51.95830986408677, 4.5668792724609375));
        //points.Add(new PointLatLng(51.958362755903515, 4.567394256591797));
        //points.Add(new PointLatLng(51.95756937210035, 4.568295478820801));
        //points.Add(new PointLatLng(51.97192744621252, 4.602069854736328));
        //points.Add(new PointLatLng(51.975655033685634, 4.593958854675293));
        //points.Add(new PointLatLng(51.97684462398408, 4.594173431396484));
        //points.Add(new PointLatLng(51.97702966852504, 4.594473838806152));
        //points.Add(new PointLatLng(51.97774340459503, 4.594388008117676));
        //points.Add(new PointLatLng(51.98162910149888, 4.595761299133301));
        //points.Add(new PointLatLng(51.98221060537343, 4.596233367919922));
        //points.Add(new PointLatLng(51.98802522893029, 4.598937034606934));
        //points.Add(new PointLatLng(51.994156196026964, 4.5940446853637695));
        //points.Add(new PointLatLng(51.983452883814735, 4.556450843811035));
        //points.Add(new PointLatLng(51.971511047506056, 4.568220376968384));
        //points.Add(new PointLatLng(51.97124005579318, 4.566986560821533));
        //points.Add(new PointLatLng(51.97144495211745, 4.565838575363159));
        //points.Add(new PointLatLng(51.97045350958927, 4.5669543743133545));
        //points.Add(new PointLatLng(51.969766096559695, 4.5627593994140625));
        //points.Add(new PointLatLng(51.97057909352279, 4.561793804168701));
        //points.Add(new PointLatLng(51.97038741264079, 4.561225175857544));
        //points.Add(new PointLatLng(51.9702023406664, 4.561289548873901));
        //points.Add(new PointLatLng(51.9700899751662, 4.56057071685791));
        //points.Add(new PointLatLng(51.96991812150323, 4.560592174530029));
        //points.Add(new PointLatLng(51.969759486767856, 4.560270309448242));
        //points.Add(new PointLatLng(51.968847326141706, 4.557309150695801));
        //points.Add(new PointLatLng(51.96878122682417, 4.556429386138916));
        //points.Add(new PointLatLng(51.96867546771329, 4.55557107925415));
        //points.Add(new PointLatLng(51.968741567186825, 4.554476737976074));
        //points.Add(new PointLatLng(51.97273379461056, 4.547438621520996));
        //points.Add(new PointLatLng(51.969812365075384, 4.539499282836914));
        //points.Add(new PointLatLng(51.97048655802696, 4.536259174346924));
        //points.Add(new PointLatLng(51.97036758353723, 4.5355939865112305));
        //points.Add(new PointLatLng(51.968278868824726, 4.535164833068848));
        //points.Add(new PointLatLng(51.96778972536177, 4.532203674316406));
        //points.Add(new PointLatLng(51.967260915612385, 4.530401229858398));
        //points.Add(new PointLatLng(51.9667056586601, 4.528212547302246));
        //points.Add(new PointLatLng(51.96568766971397, 4.528083801269531));
        //points.Add(new PointLatLng(51.96432590808907, 4.524843692779541));
        //points.Add(new PointLatLng(51.95944702439491, 4.526302814483643));
        //points.Add(new PointLatLng(51.956273481693835, 4.528083801269531));
        //points.Add(new PointLatLng(51.95328485694294, 4.530315399169922));
        //points.Add(new PointLatLng(51.95075891698686, 4.529628753662109));
        //points.Add(new PointLatLng(51.94873541741756, 4.530315399169922));
        //points.Add(new PointLatLng(51.92828369114749, 4.538683891296387));
        //+
        // points.Add(new PointLatLng(51.92498223155278, 4.485189914703369));
        // points.Add(new PointLatLng(51.914758737475964, 4.554133415222168));
        // points.Add(new PointLatLng(51.91479844486881, 4.556794166564941));
        // points.Add(new PointLatLng(51.910946664270455, 4.557008743286133));
        // points.Add(new PointLatLng(51.91101284885733, 4.558660984039307));
        // points.Add(new PointLatLng(51.90987446037327, 4.558875560760498));
        // points.Add(new PointLatLng(51.91000683260988, 4.5548200607299805));
        // points.Add(new PointLatLng(51.90975532502674, 4.553039073944092));
        // points.Add(new PointLatLng(51.90893460627399, 4.550528526306152));
        // points.Add(new PointLatLng(51.90778292725111, 4.550142288208008));
        // points.Add(new PointLatLng(51.9050161293678, 4.550571441650391));
        // points.Add(new PointLatLng(51.90379815474336, 4.543061256408691));
        // points.Add(new PointLatLng(51.906009019028346, 4.541409015655518));
        // points.Add(new PointLatLng(51.906379692208475, 4.545764923095703));
        // points.Add(new PointLatLng(51.90698864864919, 4.547717571258545));
        // points.Add(new PointLatLng(51.9075975968337, 4.548039436340332));
        // points.Add(new PointLatLng(51.90897431881701, 4.547975063323975));
        // points.Add(new PointLatLng(51.9096229520488, 4.548532962799072));
        // points.Add(new PointLatLng(51.91520875253877, 4.55059289932251));

        //Feijenoord
        //points.Add(new PointLatLng(51.918279323170914, 4.500231742858887));
        //points.Add(new PointLatLng(51.917723459571604, 4.505767822265625));
        //points.Add(new PointLatLng(51.91616171072476, 4.509994983673096)); 
        //points.Add(new PointLatLng(51.913871929886554, 4.513943195343018)); 
        //points.Add(new PointLatLng(51.9103377614944, 4.5163679122924805));
        //points.Add(new PointLatLng(51.904407146183786, 4.5174407958984375));
        //points.Add(new PointLatLng(51.90173281794483, 4.513213634490967));
        //points.Add(new PointLatLng(51.886663577703885, 4.524983167648315));
        //points.Add(new PointLatLng(51.88655100285276, 4.5240068435668945));
        //points.Add(new PointLatLng(51.886584113132336, 4.523524045944214));
        //points.Add(new PointLatLng(51.88641856149043, 4.522762298583984)); 
        //points.Add(new PointLatLng(51.88503452590689, 4.522022008895874)); 
        //points.Add(new PointLatLng(51.884041172664126, 4.521753787994385)); 
        //points.Add(new PointLatLng(51.882842497191916, 4.521356821060181)); 
        //points.Add(new PointLatLng(51.88221996803803, 4.516668319702148));
        //points.Add(new PointLatLng(51.88202790943132, 4.516110420227051)); 
        //points.Add(new PointLatLng(51.882465007138066, 4.515520334243774)); 
        //points.Add(new PointLatLng(51.88239878048598, 4.513835906982422)); 
        //points.Add(new PointLatLng(51.882114004770294, 4.513149261474609)); 
        //points.Add(new PointLatLng(51.881100718408575, 4.511518478393555)); 
        //points.Add(new PointLatLng(51.879637042231295, 4.5098876953125));
        //points.Add(new PointLatLng(51.87752423104397, 4.505993127822876)); // Grens oost Charlois
        //points.Add(new PointLatLng(51.878848889167095, 4.503611326217651));
        //points.Add(new PointLatLng(51.882551101639905, 4.498579502105713));
        //points.Add(new PointLatLng(51.883114023165284, 4.497431516647339));
        //points.Add(new PointLatLng(51.88438553760754, 4.493333101272583));
        //points.Add(new PointLatLng(51.88496168074829, 4.491895437240601));
        //points.Add(new PointLatLng(51.88848460230135, 4.492743015289307));
        //points.Add(new PointLatLng(51.88919974814752, 4.4939446449279785));
        //points.Add(new PointLatLng(51.894251796941376, 4.493805170059204));
        //points.Add(new PointLatLng(51.89796598165136, 4.4956183433532715));
        //points.Add(new PointLatLng(51.89989908999172, 4.496079683303833));
        //points.Add(new PointLatLng(51.8958275491638, 4.477636814117432));
        //points.Add(new PointLatLng(51.89838306343293, 4.469354152679443));
        //points.Add(new PointLatLng(51.90027643362919, 4.468109607696533));
        //points.Add(new PointLatLng(51.904274757442565, 4.478945732116699));
        //points.Add(new PointLatLng(51.905360333602275, 4.478559494018555));
        //points.Add(new PointLatLng(51.9062870242002, 4.4788384437561035));
        //points.Add(new PointLatLng(51.91036423569981, 4.483494758605957));
        //points.Add(new PointLatLng(51.9096759012868, 4.485254287719727));
        //points.Add(new PointLatLng(51.910331142940606, 4.485608339309692));
        //points.Add(new PointLatLng(51.91701538525815, 4.495725631713867));

        //Ijsselmonde
        //points.Add(new PointLatLng(51.873192326507535, 4.513342380523682));
        //points.Add(new PointLatLng(51.87119182606822, 4.515016078948975));
        //points.Add(new PointLatLng(51.86909849192174, 4.515423774719238));
        //points.Add(new PointLatLng(51.8687407605159, 4.529285430908203));
        //points.Add(new PointLatLng(51.86794579164924, 4.535937309265137));
        //points.Add(new PointLatLng(51.86901899629966, 4.536280632019043));
        //points.Add(new PointLatLng(51.86944297132701, 4.5352935791015625));
        //points.Add(new PointLatLng(51.870264411568975, 4.5403361320495605));
        //points.Add(new PointLatLng(51.87161578061247, 4.543919563293457));
        //points.Add(new PointLatLng(51.87268889769054, 4.544391632080078));
        //points.Add(new PointLatLng(51.87267564948768, 4.5450568199157715));
        //points.Add(new PointLatLng(51.87470257914353, 4.550292491912842));
        //points.Add(new PointLatLng(51.874808559880044, 4.551687240600586));
        //points.Add(new PointLatLng(51.87646447644538, 4.556665420532227));
        //points.Add(new PointLatLng(51.878107085426365, 4.560806751251221));
        //points.Add(new PointLatLng(51.87814682522275, 4.563724994659424));
        //points.Add(new PointLatLng(51.87638499384357, 4.56606388092041));
        //points.Add(new PointLatLng(51.877921632578825, 4.569282531738281));
        //points.Add(new PointLatLng(51.87868993225298, 4.569368362426758));
        //points.Add(new PointLatLng(51.899667386187645, 4.5761919021606445));
        //points.Add(new PointLatLng(51.903877588877755, 4.5748186111450195));
        //points.Add(new PointLatLng(51.904592489766, 4.562373161315918));
        //points.Add(new PointLatLng(51.904698400041035, 4.5531463623046875));
        //points.Add(new PointLatLng(51.90400997878952, 4.545679092407227));
        //points.Add(new PointLatLng(51.900038111700596, 4.525895118713379));
        //points.Add(new PointLatLng(51.90157394195024, 4.521002769470215));
        //points.Add(new PointLatLng(51.904407146183786, 4.5174407958984375)); 
        //points.Add(new PointLatLng(51.90173281794483, 4.513213634490967)); 
        //points.Add(new PointLatLng(51.886663577703885, 4.524983167648315));
        //points.Add(new PointLatLng(51.88655100285276, 4.5240068435668945));
        //points.Add(new PointLatLng(51.886584113132336, 4.523524045944214));
        //points.Add(new PointLatLng(51.88641856149043, 4.522762298583984));
        //points.Add(new PointLatLng(51.88503452590689, 4.522022008895874));
        //points.Add(new PointLatLng(51.884041172664126, 4.521753787994385));
        //points.Add(new PointLatLng(51.882842497191916, 4.521356821060181));
        //points.Add(new PointLatLng(51.88221996803803, 4.516668319702148));
        //points.Add(new PointLatLng(51.88202790943132, 4.516110420227051));
        //points.Add(new PointLatLng(51.882465007138066, 4.515520334243774));
        //points.Add(new PointLatLng(51.88239878048598, 4.513835906982422));
        //points.Add(new PointLatLng(51.882114004770294, 4.513149261474609));
        //points.Add(new PointLatLng(51.881100718408575, 4.511518478393555));
        //points.Add(new PointLatLng(51.879637042231295, 4.5098876953125));
        //points.Add(new PointLatLng(51.87752423104397, 4.505993127822876)); // Grens oost Charlois


        //points.Add(new PointLatLng());
        //points.Add(new PointLatLng());
        //points.Add(new PointLatLng());
        //points.Add(new PointLatLng());
        //points.Add(new PointLatLng());
        //points.Add(new PointLatLng());
        //points.Add(new PointLatLng());
        //points.Add(new PointLatLng());
        //points.Add(new PointLatLng());
        //points.Add(new PointLatLng());
        //points.Add(new PointLatLng());
        //points.Add(new PointLatLng());
        //points.Add(new PointLatLng());
        //points.Add(new PointLatLng());
        //points.Add(new PointLatLng());
        //points.Add(new PointLatLng());
        //points.Add(new PointLatLng());
        //points.Add(new PointLatLng());
        //points.Add(new PointLatLng());
        //points.Add(new PointLatLng());
        //points.Add(new PointLatLng());
        //points.Add(new PointLatLng());
        //points.Add(new PointLatLng());
        //points.Add(new PointLatLng());
        //points.Add(new PointLatLng());
        //points.Add(new PointLatLng());
        //points.Add(new PointLatLng());
        //points.Add(new PointLatLng());
        //points.Add(new PointLatLng());
        //points.Add(new PointLatLng());
        //points.Add(new PointLatLng());
        //points.Add(new PointLatLng());
        //points.Add(new PointLatLng());
        //points.Add(new PointLatLng());
        //points.Add(new PointLatLng());
        //points.Add(new PointLatLng());
        //points.Add(new PointLatLng());
        //points.Add(new PointLatLng());
        //points.Add(new PointLatLng());
        //points.Add(new PointLatLng());
        //points.Add(new PointLatLng());
        //points.Add(new PointLatLng());
        //points.Add(new PointLatLng());
        //points.Add(new PointLatLng());
        //points.Add(new PointLatLng());
        //points.Add(new PointLatLng());      
        //points.Add(new PointLatLng());
        //points.Add(new PointLatLng());
        //points.Add(new PointLatLng());
        //points.Add(new PointLatLng());
        //points.Add(new PointLatLng());
        //points.Add(new PointLatLng());
        //points.Add(new PointLatLng());
        //points.Add(new PointLatLng());
        //points.Add(new PointLatLng());
        //points.Add(new PointLatLng());
        //points.Add(new PointLatLng());
        //points.Add(new PointLatLng());
        //points.Add(new PointLatLng());
        //points.Add(new PointLatLng());
        //points.Add(new PointLatLng());
        //points.Add(new PointLatLng());
        //points.Add(new PointLatLng());
        //points.Add(new PointLatLng());
        //points.Add(new PointLatLng());
        //points.Add(new PointLatLng());
        //points.Add(new PointLatLng());
        //points.Add(new PointLatLng());
        //points.Add(new PointLatLng());
        //points.Add(new PointLatLng());
        //points.Add(new PointLatLng());
        //points.Add(new PointLatLng());
        //points.Add(new PointLatLng());
        //points.Add(new PointLatLng());
        //points.Add(new PointLatLng());
        //points.Add(new PointLatLng());
        //points.Add(new PointLatLng());
        //points.Add(new PointLatLng());
        //points.Add(new PointLatLng());
        //points.Add(new PointLatLng());
        //points.Add(new PointLatLng());
        //points.Add(new PointLatLng());
        //points.Add(new PointLatLng());
        //points.Add(new PointLatLng());
        //points.Add(new PointLatLng());
        //points.Add(new PointLatLng());
        //points.Add(new PointLatLng());
        //points.Add(new PointLatLng());
        //points.Add(new PointLatLng());
        //points.Add(new PointLatLng());
        //points.Add(new PointLatLng());        
        //points.Add(new PointLatLng());
        //points.Add(new PointLatLng());
        //points.Add(new PointLatLng());
        //points.Add(new PointLatLng());
        //points.Add(new PointLatLng());
        //points.Add(new PointLatLng());
        //points.Add(new PointLatLng());
        //points.Add(new PointLatLng());
        //points.Add(new PointLatLng());
        //points.Add(new PointLatLng());
        //points.Add(new PointLatLng());
        //points.Add(new PointLatLng());
        //points.Add(new PointLatLng());
        //points.Add(new PointLatLng());
        //points.Add(new PointLatLng());
        //points.Add(new PointLatLng());
        //points.Add(new PointLatLng());
        //points.Add(new PointLatLng());
        //points.Add(new PointLatLng());
        //points.Add(new PointLatLng());
        //points.Add(new PointLatLng());
        //points.Add(new PointLatLng());
        //points.Add(new PointLatLng());
        //points.Add(new PointLatLng());
        //points.Add(new PointLatLng());
        //points.Add(new PointLatLng());
        //points.Add(new PointLatLng());
        //points.Add(new PointLatLng());
        //points.Add(new PointLatLng());
        //points.Add(new PointLatLng());
        //points.Add(new PointLatLng());
        //points.Add(new PointLatLng());
        //points.Add(new PointLatLng());
        //points.Add(new PointLatLng());
        //points.Add(new PointLatLng());
        //points.Add(new PointLatLng());
        //points.Add(new PointLatLng());
        //points.Add(new PointLatLng());
        //points.Add(new PointLatLng());
        //points.Add(new PointLatLng());
        //points.Add(new PointLatLng());
        //points.Add(new PointLatLng());
        //points.Add(new PointLatLng());
        //points.Add(new PointLatLng());
        //points.Add(new PointLatLng());

        //Overschie
        //GMapOverlay polyOverlay = new GMapOverlay("polygons");
        //List<PointLatLng> overschie_points = new List<PointLatLng>();
        //points.Add(new PointLatLng(51.961377486308926, 4.380755424499512));
        //points.Add(new PointLatLng(51.964101147338184, 4.392213821411133));
        //points.Add(new PointLatLng(51.96239557315006, 4.393501281738281));
        //points.Add(new PointLatLng(51.976249832783076, 4.428069591522217));
        //points.Add(new PointLatLng(51.96271289419199, 4.446823596954346));
        //points.Add(new PointLatLng(51.965661228134564, 4.450814723968506));
        //points.Add(new PointLatLng(51.96708905110036, 4.457037448883057));
        //points.Add(new PointLatLng(51.96340041540989, 4.4614577293396));
        //points.Add(new PointLatLng(51.956141245872814, 4.461522102355957));
        //points.Add(new PointLatLng(51.95209464118261, 4.45995569229126));
        //points.Add(new PointLatLng(51.94066696241652, 4.4599127769470215));
        //points.Add(new PointLatLng(51.939390426323214, 4.460556507110596));
        //points.Add(new PointLatLng(51.93884143849165, 4.457112550735474));
        //points.Add(new PointLatLng(51.93828582950888, 4.455138444900513));
        //points.Add(new PointLatLng(51.93717459090055, 4.452981948852539));
        //points.Add(new PointLatLng(51.935210012449296, 4.451136589050293)); 
        //points.Add(new PointLatLng(51.93460805368726, 4.447542428970337));
        //points.Add(new PointLatLng(51.93406562239103, 4.445675611495972)); 
        //points.Add(new PointLatLng(51.93368856262664, 4.44597601890564)); 
        //points.Add(new PointLatLng(51.926060690953335, 4.432210922241211)); 
        //points.Add(new PointLatLng(51.93774674993097, 4.417362213134766));
        //points.Add(new PointLatLng(51.941053884576796, 4.4150930643081665));
        //points.Add(new PointLatLng(51.93961861808388, 4.413167238235474));
        //points.Add(new PointLatLng(51.9377037555753, 4.404058456420898));
        //points.Add(new PointLatLng(51.939830273172106, 4.400582313537598));
        //points.Add(new PointLatLng(51.94160615230633, 4.397969841957092));
        //points.Add(new PointLatLng(51.94308103758751, 4.395486116409302));
        //points.Add(new PointLatLng(51.944053244863525, 4.394702911376953));
        //points.Add(new PointLatLng(51.94412599422046, 4.394016265869141));
        //points.Add(new PointLatLng(51.944337628042454, 4.392986297607422));
        //points.Add(new PointLatLng(51.94179134235807, 4.391135573387146));
    }
}