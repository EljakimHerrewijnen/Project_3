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
            listofboroughs.Add(new Borough("delfshaven", false, "Deelgemeente"));
            listofboroughs.Add(new Borough("overschie", false, "Deelgemeente"));
            listofboroughs.Add(new Borough("kralingen", false, "Deelgemeente"));
            listofboroughs.Add(new Borough("prins_alexander", false, "Deelgemeente"));
            listofboroughs.Add(new Borough("hoek_van_holland", false, "Deelgemeente"));
            listofboroughs.Add(new Borough("hoogvliet", false, "Deelgemeente"));
            listofboroughs.Add(new Borough("schiebroek", false, "Deelgemeente"));
            listofboroughs.Add(new Borough("ijsselmonde", false, "Deelgemeente"));
            listofboroughs.Add(new Borough("feijenoord", false, "Deelgemeente"));
            listofboroughs.Add(new Borough("stadscentrum", false, "Deelgemeente"));
            listofboroughs.Add(new Borough("pernis", false, "Deelgemeente"));
            listofboroughs.Add(new Borough("rozenburg", false, "Deelgemeente"));
            listofboroughs.Add(new Borough("noord", false, "Deelgemeente"));
            // Deze twee horen bij elkaar
            listofboroughs.Add(new Borough("charlois1", false, "Deelgemeente"));
            listofboroughs.Add(new Borough("charlois2", false, "Deelgemeente"));

            listofboroughs.Add(new Borough("tarwewijk", false, "Wijk"));
            listofboroughs.Add(new Borough("carnisse", false, "Wijk"));
            listofboroughs.Add(new Borough("zuidwijk", false, "Wijk"));
            listofboroughs.Add(new Borough("oud_charlois", false, "Wijk"));
            listofboroughs.Add(new Borough("wielewaal", false, "Wijk"));
            listofboroughs.Add(new Borough("zuidplein", false, "Wijk"));
            listofboroughs.Add(new Borough("pendrecht", false, "Wijk"));
            listofboroughs.Add(new Borough("heijplaat", false, "Wijk"));

            // Wijken Delfshaven
            listofboroughs.Add(new Borough("delfshavenwijk", false, "Wijk"));
            listofboroughs.Add(new Borough("bospolder", false, "Wijk"));
            listofboroughs.Add(new Borough("tussendijken", false, "Wijk"));
            listofboroughs.Add(new Borough("spangen", false, "Wijk"));
            listofboroughs.Add(new Borough("nieuwe_westen", false, "Wijk"));
            listofboroughs.Add(new Borough("middelland", false, "Wijk"));
            listofboroughs.Add(new Borough("schiemond", false, "Wijk"));
            // Deze drie horen bij elkaar
            listofboroughs.Add(new Borough("mathenesse1", false, "Wijk"));
            listofboroughs.Add(new Borough("mathenesse2", false, "Wijk"));
            listofboroughs.Add(new Borough("mathenesse3", false, "Wijk"));

            // Wijken Feijenoord
            listofboroughs.Add(new Borough("feijenoordwijk", false, "Wijk"));
            listofboroughs.Add(new Borough("kop_van_zuid", false, "Wijk"));
            listofboroughs.Add(new Borough("bloemenhof", false, "Wijk"));
            listofboroughs.Add(new Borough("hillesluis", false, "Wijk"));
            listofboroughs.Add(new Borough("katendrecht", false, "Wijk"));
            listofboroughs.Add(new Borough("afrikaanderwijk", false, "Wijk"));
            listofboroughs.Add(new Borough("vreewijk", false, "Wijk"));
            listofboroughs.Add(new Borough("noordereiland", false, "Wijk"));

            // Wijken Hoogvliet
            listofboroughs.Add(new Borough("hoogvliet_noord", false, "Wijk"));
            listofboroughs.Add(new Borough("hoogvliet_zuid", false, "Wijk"));

            // Wijken Ijsselmonde
            listofboroughs.Add(new Borough("oud_ijsselmonde", false, "Wijk"));
            listofboroughs.Add(new Borough("lombardijen", false, "Wijk"));
            listofboroughs.Add(new Borough("groot_ijsselmonde", false, "Wijk"));
            listofboroughs.Add(new Borough("beverwaard", false, "Wijk"));

            // Wijken Kralingen-Crooswijk
            listofboroughs.Add(new Borough("rubroek", false, "Wijk"));
            listofboroughs.Add(new Borough("nieuw_crooswijk", false, "Wijk"));
            listofboroughs.Add(new Borough("oud_crooswijk", false, "Wijk"));
            listofboroughs.Add(new Borough("kralingen_west", false, "Wijk"));
            listofboroughs.Add(new Borough("kralingen_oost", false, "Wijk"));
            listofboroughs.Add(new Borough("de_esch", false, "Wijk"));
            listofboroughs.Add(new Borough("struisenburg", false, "Wijk"));

            // Wijken Noord
            listofboroughs.Add(new Borough("agniesebuurt", false, "Wijk"));
            listofboroughs.Add(new Borough("provenierswijk", false, "Wijk"));
            listofboroughs.Add(new Borough("bergpolder", false, "Wijk"));
            listofboroughs.Add(new Borough("blijdorp", false, "Wijk"));
            listofboroughs.Add(new Borough("liskwartier", false, "Wijk"));
            listofboroughs.Add(new Borough("oude_noorden", false, "Wijk"));

            // Wijken Overschie
            listofboroughs.Add(new Borough("kleinpolder", false, "Wijk"));
            listofboroughs.Add(new Borough("overschiewijk", false, "Wijk"));

            // Wijken Prins-Alexander
            listofboroughs.Add(new Borough("sgravenland", false, "Wijk"));
            listofboroughs.Add(new Borough("kralingse_veer", false, "Wijk"));
            listofboroughs.Add(new Borough("prinsenland", false, "Wijk"));
            listofboroughs.Add(new Borough("het_lage_land", false, "Wijk"));
            listofboroughs.Add(new Borough("ommoord", false, "Wijk"));
            listofboroughs.Add(new Borough("oosterflank", false, "Wijk"));
            listofboroughs.Add(new Borough("zevenkamp", false, "Wijk"));
            listofboroughs.Add(new Borough("nesselande", false, "Wijk"));

            // Wijken Hillegersberg-Schiebroek
            listofboroughs.Add(new Borough("schiebroekwijk", false, "Wijk"));
            listofboroughs.Add(new Borough("hillegersberg_noord", false, "Wijk"));
            listofboroughs.Add(new Borough("hillegersberg_zuid", false, "Wijk"));
            listofboroughs.Add(new Borough("terbregge", false, "Wijk"));
            listofboroughs.Add(new Borough("molenlaankwartier", false, "Wijk"));

            // Wijken stadscentrum
            listofboroughs.Add(new Borough("stadsdriehoek1", false, "Wijk"));
            listofboroughs.Add(new Borough("stadsdriehoek2", false, "Wijk"));
            listofboroughs.Add(new Borough("oude_westen", false, "Wijk"));
            listofboroughs.Add(new Borough("cool1", false, "Wijk"));
            listofboroughs.Add(new Borough("cool2", false, "Wijk"));
            listofboroughs.Add(new Borough("cool3", false, "Wijk"));

            foreach (Borough gebied in Deelgemeenten)
            {
                gebied.AssignCoords(@"Coordinates\Deelgemeenten_coords.txt", gebied.Name);
            }

            foreach (Borough gebied in Deelgemeenten)
            {
                Polygons.Add(new GMapPolygon(gebied.Deelgemeente, gebied.Name));
            }
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

