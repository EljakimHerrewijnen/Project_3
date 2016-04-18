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

namespace GMap
{
    class AreaFunctions
    {
        public static void DrawAreas(NET.WindowsForms.GMapControl gmap, CheckedListBox checkedListBox1)
        {
            // Haalt alle huidige polygons van de kaart.
            MapFunctions.Clear(gmap);

            // Maak een nieuwe GMapOverlay instance aan. 
            GMapOverlay Heatmaps = new GMapOverlay("Heatmaps");

            // Maak een Rotterdam instance aan die bestaat uit een list van boroughs en de daarbij behorende polygons.
            Rotterdam Rdam = new Rotterdam();

            // Deelgemeenten
            Borough delfshaven = new Borough("delfshaven", false);
            Borough overschie = new Borough("overschie", false);
            Borough kralingen = new Borough("kralingen", false);
            Borough prins_alexander = new Borough("prins_alexander", false);
            Borough hoek_van_holland = new Borough("hoek_van_holland", false);
            Borough hoogvliet = new Borough("hoogvliet", false);
            Borough schiebroek = new Borough("schiebroek", false);
            Borough ijsselmonde = new Borough("ijsselmonde", false);
            Borough feijenoord = new Borough("feijenoord", false);
            Borough centrum = new Borough("centrum", false);
            Borough pernis = new Borough("pernis", false);
            Borough rozenburg = new Borough("rozenburg", false);
            Borough noord = new Borough("noord", false);
            // Deze twee horen bij elkaar
            Borough charlois1 = new Borough("charlois1", false);
            Borough charlois2= new Borough("charlois2", false);

            // Wijken Charlois
            Borough tarwewijk = new Borough("tarwewijk", false);
            Borough carnisse = new Borough("carnisse", false);
            Borough zuidwijk = new Borough("zuidwijk", false);
            Borough oud_charlois = new Borough("oud_charlois", false);
            Borough wielewaal = new Borough("wielewaal", false);
            Borough zuidplein = new Borough("zuidplein", false);
            Borough pendrecht = new Borough("pendrecht", false);
            Borough heijplaat = new Borough("heijplaat", false);

            // Wijken Delfshaven
            Borough delfshavenwijk = new Borough("delfshavenwijk", false);
            Borough bospolder = new Borough("bospolder", false);
            Borough tussendijken = new Borough("tussendijken", false);
            Borough spangen = new Borough("spangen", false);
            Borough nieuwe_westen = new Borough("nieuwe_westen", false);
            Borough middelland = new Borough("middelland", false);
            Borough schiemond = new Borough("schiemond", false);
            // Deze drie horen bij elkaar
            Borough mathenesse1 = new Borough("mathenesse1", false);
            Borough mathenesse2 = new Borough("mathenesse2", false);
            Borough mathenesse3 = new Borough("mathenesse3", false);

            // Wijken Feijenoord
            Borough feijenoordwijk = new Borough("feijenoordwijk", false);
            Borough kop_van_zuid = new Borough("kop_van_zuid", false);
            Borough bloemenhof = new Borough("bloemenhof", false);
            Borough hillesluis = new Borough("hillesluis", false);
            Borough katendrecht= new Borough("katendrecht", false);
            Borough afrikaanderwijk = new Borough("afrikaanderwijk", false);
            Borough vreewijk = new Borough("vreewijk", false);
            Borough noordereiland = new Borough("noordereiland", false);

            // Wijken Hoogvliet
            Borough hoogvliet_noord = new Borough("hoogvliet_noord", false);
            Borough hoogvliet_zuid = new Borough("hoogvliet_zuid", false);

            // Wijken Ijsselmonde
            Borough oud_ijsselmonde = new Borough("oud_ijsselmonde", false);
            Borough lombardijen = new Borough("lombardijen", false);
            Borough groot_ijsselmonde = new Borough("groot_ijsselmonde", false);
            Borough beverwaard = new Borough("beverwaard", false);

            // Wijken Kralingen-Crooswijk
            Borough rubroek = new Borough("rubroek", false);
            Borough nieuw_crooswijk = new Borough("nieuw_crooswijk", false);
            Borough oud_crooswijk = new Borough("oud_crooswijk", false);
            Borough kralingen_west = new Borough("kralingen_west", false);
            Borough kralingen_oost = new Borough("kralingen_oost", false);
            Borough de_esch= new Borough("de_esch", false);
            Borough struisenburg= new Borough("struisenburg ", false);

            // Wijken Noord
            Borough agniesebuurt = new Borough("agniesebuurt", false);
            Borough provenierswijk = new Borough("provenierswijk", false);
            Borough bergpolder= new Borough("bergpolder", false);
            Borough blijdorp = new Borough("blijdorp", false);
            Borough liskwartier = new Borough("liskwartier", false);
            Borough oude_noorden = new Borough("oude_noorden", false);

            // Wijken Overschie
            Borough kleinpolder = new Borough("kleinpolder", false);
            Borough overschiewijk= new Borough("overschiewijk", false);

            // Wijken Prins-Alexander
            Borough sgravenland = new Borough("sgravenland", false);
            Borough kralingse_veer = new Borough("kralingse_veer", false);
            Borough prinsenland = new Borough("prinsenland", false);
            Borough het_lage_land = new Borough("het_lage_land", false);
            Borough ommoord = new Borough("ommoord", false);
            Borough oosterflank = new Borough("oosterflank", false);
            Borough zevenkamp = new Borough("zevenkamp ", false);
            Borough nesselande = new Borough("nesselande", false);

            // Wijken Hillegersberg-Schiebroek
            Borough schiebroekwijk = new Borough("schiebroekwijk", false);
            Borough hillegersberg_noord = new Borough("hillegersberg_noord", false);
            Borough hillegersberg_zuid = new Borough("hillegersberg_zuid", false);
            Borough terbregge = new Borough("terbregge", false);
            Borough molenlaankwartier = new Borough("molenlaankwartier", false);

            // Wijken stadscentrum
            Borough stadsdriehoek1 = new Borough("stadsdriehoek1", false);
            Borough stadsdriehoek2 = new Borough("stadsdriehoek2", false);
            Borough oude_westen = new Borough("oude_westen", false);
            Borough cool1 = new Borough("cool1", false);
            Borough cool2 = new Borough("cool2", false);
            Borough cool3 = new Borough("cool3", false);






            // Voeg de polygon toe
            delfshaven.AssignCoords(@"Coordinates\Deelgemeenten_coords.txt", "delfshaven");

            // Maar een GMapPolygon instance aan.
            GMapPolygon Delfshaven = new GMapPolygon(delfshaven.Deelgemeente, "delfshaven");

            // Voeg de eerder gecreerde polygon en borough instance toe aan de Rdam instance.
            Rdam.Polygons.Add(Delfshaven);
            Rdam.Deelgemeenten.Add(delfshaven);



            Delfshaven.Fill = new SolidBrush(Color.FromArgb(100, Color.Green));
            Delfshaven.Stroke = new Pen(Color.Green, 1);

            foreach (string Items in checkedListBox1.CheckedItems)
            {

                    foreach (GMapPolygon polygon in Rdam.Polygons)
                    {
                        if (polygon.Name == Items)
                        {
                            Heatmaps.Polygons.Add(polygon);
                        }
}
Debug.Write("Hallo");



                

            }

            gmap.Overlays.Add(Heatmaps);
            MapFunctions.UpdateMap(gmap);
        }
    }
}
