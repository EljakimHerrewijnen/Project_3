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
            listofboroughs.Add(new Borough("delfshaven", false, "Deelgemeente", "none"));
            listofboroughs.Add(new Borough("overschie", false, "Deelgemeente", "none"));
            listofboroughs.Add(new Borough("kralingen", false, "Deelgemeente", "none"));
            listofboroughs.Add(new Borough("prins_alexander", false, "Deelgemeente", "none"));
            listofboroughs.Add(new Borough("hoek_van_holland", false, "Deelgemeente", "none"));
            listofboroughs.Add(new Borough("hoogvliet", false, "Deelgemeente", "none"));
            listofboroughs.Add(new Borough("schiebroek", false, "Deelgemeente", "none"));
            listofboroughs.Add(new Borough("ijsselmonde", false, "Deelgemeente", "none"));
            listofboroughs.Add(new Borough("feijenoord", false, "Deelgemeente", "none"));
            listofboroughs.Add(new Borough("stadscentrum", false, "Deelgemeente", "none"));
            listofboroughs.Add(new Borough("pernis", false, "Deelgemeente", "none"));
            listofboroughs.Add(new Borough("rozenburg", false, "Deelgemeente", "none"));
            listofboroughs.Add(new Borough("noord", false, "Deelgemeente", "none"));
            // Deze twee horen bij elkaar
            listofboroughs.Add(new Borough("charlois1", false, "Deelgemeente", "none"));
            listofboroughs.Add(new Borough("charlois2", false, "Deelgemeente", "none"));

            // Wijken in Charlois
            listofboroughs.Add(new Borough("tarwewijk", false, "Wijk", "charlois"));
            listofboroughs.Add(new Borough("carnisse", false, "Wijk", "charlois"));
            listofboroughs.Add(new Borough("zuidwijk", false, "Wijk", "charlois"));
            listofboroughs.Add(new Borough("oud_charlois", false, "Wijk", "charlois"));
            listofboroughs.Add(new Borough("wielewaal", false, "Wijk", "charlois"));
            listofboroughs.Add(new Borough("zuidplein", false, "Wijk", "charlois"));
            listofboroughs.Add(new Borough("pendrecht", false, "Wijk", "charlois"));
            listofboroughs.Add(new Borough("heijplaat", false, "Wijk", "charlois"));

            // Wijken Delfshaven
            listofboroughs.Add(new Borough("delfshavenwijk", false, "Wijk", "delfshaven"));
            listofboroughs.Add(new Borough("bospolder", false, "Wijk", "delfshaven"));
            listofboroughs.Add(new Borough("tussendijken", false, "Wijk", "delfshaven"));
            listofboroughs.Add(new Borough("spangen", false, "Wijk", "delfshaven"));
            listofboroughs.Add(new Borough("nieuwe_westen", false, "Wijk", "delfshaven"));
            listofboroughs.Add(new Borough("middelland", false, "Wijk", "delfshaven"));
            listofboroughs.Add(new Borough("schiemond", false, "Wijk", "delfshaven"));
            // Deze drie horen bij elkaar
            listofboroughs.Add(new Borough("mathenesse1", false, "Wijk", "delfshaven"));
            listofboroughs.Add(new Borough("mathenesse2", false, "Wijk", "delfshaven"));
            listofboroughs.Add(new Borough("mathenesse3", false, "Wijk", "delfshaven"));

            // Wijken Feijenoord
            listofboroughs.Add(new Borough("feijenoordwijk", false, "Wijk", "feijenoord"));
            listofboroughs.Add(new Borough("kop_van_zuid", false, "Wijk", "feijenoord"));
            listofboroughs.Add(new Borough("bloemenhof", false, "Wijk", "feijenoord"));
            listofboroughs.Add(new Borough("hillesluis", false, "Wijk", "feijenoord"));
            listofboroughs.Add(new Borough("katendrecht", false, "Wijk", "feijenoord"));
            listofboroughs.Add(new Borough("afrikaanderwijk", false, "Wijk", "feijenoord"));
            listofboroughs.Add(new Borough("vreewijk", false, "Wijk", "feijenoord"));
            listofboroughs.Add(new Borough("noordereiland", false, "Wijk", "feijenoord"));

            // Wijken Hoogvliet
            listofboroughs.Add(new Borough("hoogvliet_noord", false, "Wijk", "hoogvliet"));
            listofboroughs.Add(new Borough("hoogvliet_zuid", false, "Wijk", "hoogvliet"));

            // Wijken Ijsselmonde
            listofboroughs.Add(new Borough("oud_ijsselmonde", false, "Wijk", "ijsselmonde"));
            listofboroughs.Add(new Borough("lombardijen", false, "Wijk", "ijsselmonde"));
            listofboroughs.Add(new Borough("groot_ijsselmonde", false, "Wijk", "ijsselmonde"));
            listofboroughs.Add(new Borough("beverwaard", false, "Wijk", "ijsselmonde"));

            // Wijken Kralingen-Crooswijk
            listofboroughs.Add(new Borough("rubroek", false, "Wijk", "kralingen"));
            listofboroughs.Add(new Borough("nieuw_crooswijk", false, "Wijk", "kralingen"));
            listofboroughs.Add(new Borough("oud_crooswijk", false, "Wijk", "kralingen"));
            listofboroughs.Add(new Borough("kralingen_west", false, "Wijk", "kralingen"));
            listofboroughs.Add(new Borough("kralingen_oost", false, "Wijk", "kralingen"));
            listofboroughs.Add(new Borough("de_esch", false, "Wijk", "kralingen"));
            listofboroughs.Add(new Borough("struisenburg", false, "Wijk", "kralingen"));

            // Wijken Noord
            listofboroughs.Add(new Borough("agniesebuurt", false, "Wijk", "noord"));
            listofboroughs.Add(new Borough("provenierswijk", false, "Wijk", "noord"));
            listofboroughs.Add(new Borough("bergpolder", false, "Wijk", "noord"));
            listofboroughs.Add(new Borough("blijdorp", false, "Wijk", "noord"));
            listofboroughs.Add(new Borough("liskwartier", false, "Wijk", "noord"));
            listofboroughs.Add(new Borough("oude_noorden", false, "Wijk", "noord"));

            // Wijken Overschie
            listofboroughs.Add(new Borough("kleinpolder", false, "Wijk", "overschie"));
            listofboroughs.Add(new Borough("overschiewijk1", false, "Wijk", "overschie"));
            listofboroughs.Add(new Borough("overschiewijk2", false, "Wijk", "overschie"));
            listofboroughs.Add(new Borough("overschiewijk3", false, "Wijk", "overschie"));

            // Wijken Prins-Alexander
            listofboroughs.Add(new Borough("sgravenland", false, "Wijk", "prins_alexander"));
            listofboroughs.Add(new Borough("kralingse_veer", false, "Wijk", "prins_alexander"));
            listofboroughs.Add(new Borough("prinsenland", false, "Wijk", "prins_alexander"));
            listofboroughs.Add(new Borough("het_lage_land", false, "Wijk", "prins_alexander"));
            listofboroughs.Add(new Borough("ommoord", false, "Wijk", "prins_alexander"));
            listofboroughs.Add(new Borough("oosterflank", false, "Wijk", "prins_alexander"));
            listofboroughs.Add(new Borough("zevenkamp", false, "Wijk", "prins_alexander"));
            listofboroughs.Add(new Borough("nesselande", false, "Wijk", "prins_alexander"));

            // Wijken Hillegersberg-Schiebroek
            listofboroughs.Add(new Borough("schiebroekwijk", false, "Wijk", "schiebroek"));
            listofboroughs.Add(new Borough("hillegersberg_noord", false, "Wijk", "schiebroek"));
            listofboroughs.Add(new Borough("hillegersberg_zuid", false, "Wijk", "schiebroek"));
            listofboroughs.Add(new Borough("terbregge", false, "Wijk", "schiebroek"));
            listofboroughs.Add(new Borough("molenlaankwartier", false, "Wijk", "schiebroek"));

            // Wijken stadscentrum
            listofboroughs.Add(new Borough("stadsdriehoek1", false, "Wijk", "stadscentrum"));
            listofboroughs.Add(new Borough("stadsdriehoek2", false, "Wijk", "stadscentrum"));
            listofboroughs.Add(new Borough("oude_westen", false, "Wijk", "stadscentrum"));
            listofboroughs.Add(new Borough("cool1", false, "Wijk", "stadscentrum"));
            listofboroughs.Add(new Borough("cool2", false, "Wijk", "stadscentrum"));
            listofboroughs.Add(new Borough("cool3", false, "Wijk", "stadscentrum"));

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

