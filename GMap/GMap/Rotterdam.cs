using GMap.NET;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using GMap.NET.WindowsForms.ToolTips;
using System.IO;

namespace GMap
{
    class Rotterdam
    {
        private List<Borough> listofboroughs = new List<Borough>();
        private List<GMapPolygon> listofpolygons = new List<GMapPolygon>();

        public Rotterdam()
        {
            listofboroughs.Add(new Borough("delfshaven", false));
            listofboroughs.Add(new Borough("delfshaven", false));
            listofboroughs.Add(new Borough("overschie", false));
            listofboroughs.Add(new Borough("kralingen", false));
            listofboroughs.Add(new Borough("prins_alexander", false));
            listofboroughs.Add(new Borough("hoek_van_holland", false));
            listofboroughs.Add(new Borough("hoogvliet", false));
            listofboroughs.Add(new Borough("schiebroek", false));
            listofboroughs.Add(new Borough("ijsselmonde", false));
            listofboroughs.Add(new Borough("feijenoord", false));
            listofboroughs.Add(new Borough("centrum", false));
            listofboroughs.Add(new Borough("pernis", false));
            listofboroughs.Add(new Borough("rozenburg", false));
            listofboroughs.Add(new Borough("noord", false));
            // Deze twee horen bij elkaar
            listofboroughs.Add(new Borough("charlois1", false));
            listofboroughs.Add(new Borough("charlois2", false));

            // Wijken Charlois
            listofboroughs.Add(new Borough("tarwewijk", false));
            listofboroughs.Add(new Borough("carnisse", false));
            listofboroughs.Add(new Borough("zuidwijk", false));
            listofboroughs.Add(new Borough("oud_charlois", false));
            listofboroughs.Add(new Borough("wielewaal", false));
            listofboroughs.Add(new Borough("zuidplein", false));
            listofboroughs.Add(new Borough("pendrecht", false));
            listofboroughs.Add(new Borough("heijplaat", false));

            // Wijken Delfshaven
            listofboroughs.Add(new Borough("delfshavenwijk", false));
            listofboroughs.Add(new Borough("bospolder", false));
            listofboroughs.Add(new Borough("tussendijken", false));
            listofboroughs.Add(new Borough("spangen", false));
            listofboroughs.Add(new Borough("nieuwe_westen", false));
            listofboroughs.Add(new Borough("middelland", false));
            listofboroughs.Add(new Borough("schiemond", false));
            // Deze drie horen bij elkaar
            listofboroughs.Add(new Borough("mathenesse1", false));
            listofboroughs.Add(new Borough("mathenesse2", false));
            listofboroughs.Add(new Borough("mathenesse3", false));

            // Wijken Feijenoord
            listofboroughs.Add(new Borough("feijenoordwijk", false));
            listofboroughs.Add(new Borough("kop_van_zuid", false));
            listofboroughs.Add(new Borough("bloemenhof", false));
            listofboroughs.Add(new Borough("hillesluis", false));
            listofboroughs.Add(new Borough("katendrecht", false));
            listofboroughs.Add(new Borough("afrikaanderwijk", false));
            listofboroughs.Add(new Borough("vreewijk", false));
            listofboroughs.Add(new Borough("noordereiland", false));

            // Wijken Hoogvliet
            listofboroughs.Add(new Borough("hoogvliet_noord", false));
            listofboroughs.Add(new Borough("hoogvliet_zuid", false));

            // Wijken Ijsselmonde
            listofboroughs.Add(new Borough("oud_ijsselmonde", false));
            listofboroughs.Add(new Borough("lombardijen", false));
            listofboroughs.Add(new Borough("groot_ijsselmonde", false));
            listofboroughs.Add(new Borough("beverwaard", false));

            // Wijken Kralingen-Crooswijk
            listofboroughs.Add(new Borough("rubroek", false));
            listofboroughs.Add(new Borough("nieuw_crooswijk", false));
            listofboroughs.Add(new Borough("oud_crooswijk", false));
            listofboroughs.Add(new Borough("kralingen_west", false));
            listofboroughs.Add(new Borough("kralingen_oost", false));
            listofboroughs.Add(new Borough("de_esch", false));
            listofboroughs.Add(new Borough("struisenburg ", false));

            // Wijken Noord
            listofboroughs.Add(new Borough("agniesebuurt", false));
            listofboroughs.Add(new Borough("provenierswijk", false));
            listofboroughs.Add(new Borough("bergpolder", false));
            listofboroughs.Add(new Borough("blijdorp", false));
            listofboroughs.Add(new Borough("liskwartier", false));
            listofboroughs.Add(new Borough("oude_noorden", false));

            // Wijken Overschie
            listofboroughs.Add(new Borough("kleinpolder", false));
            listofboroughs.Add(new Borough("overschiewijk", false));

            // Wijken Prins-Alexander
            listofboroughs.Add(new Borough("sgravenland", false));
            listofboroughs.Add(new Borough("kralingse_veer", false));
            listofboroughs.Add(new Borough("prinsenland", false));
            listofboroughs.Add(new Borough("het_lage_land", false));
            listofboroughs.Add(new Borough("ommoord", false));
            listofboroughs.Add(new Borough("oosterflank", false));
            listofboroughs.Add(new Borough("zevenkamp ", false));
            listofboroughs.Add(new Borough("nesselande", false));

            // Wijken Hillegersberg-Schiebroek
            listofboroughs.Add(new Borough("schiebroekwijk", false));
            listofboroughs.Add(new Borough("hillegersberg_noord", false));
            listofboroughs.Add(new Borough("hillegersberg_zuid", false));
            listofboroughs.Add(new Borough("terbregge", false));
            listofboroughs.Add(new Borough("molenlaankwartier", false));

            // Wijken stadscentrum
            listofboroughs.Add(new Borough("stadsdriehoek1", false));
            listofboroughs.Add(new Borough("stadsdriehoek2", false));
            listofboroughs.Add(new Borough("oude_westen", false));
            listofboroughs.Add(new Borough("cool1", false));
            listofboroughs.Add(new Borough("cool2", false));
            listofboroughs.Add(new Borough("cool3", false));
        }

        public void AddtoRotterdam(Borough deelgemeente)
        {
            listofboroughs.Add(deelgemeente);
        }

        public List<Borough> Deelgemeenten { get { return listofboroughs; }
        set { listofboroughs = value; } }

        public List<GMapPolygon> Polygons { get { return listofpolygons; } set { listofpolygons = value; } }

    }
}

