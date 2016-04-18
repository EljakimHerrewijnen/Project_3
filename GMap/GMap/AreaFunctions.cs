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
        public static void DrawAreas(NET.WindowsForms.GMapControl gmap, CheckedListBox checkedListBox1, Rotterdam Rdam)
        {


            // Deelgemeenten
            //Borough delfshaven = new Borough("delfshaven", false);
            //Borough overschie = new Borough("overschie", false);
            //Borough kralingen = new Borough("kralingen", false);
            //Borough prins_alexander = new Borough("prins_alexander", false);
            //Borough hoek_van_holland = new Borough("hoek_van_holland", false);
            //Borough hoogvliet = new Borough("hoogvliet", false);
            //Borough schiebroek = new Borough("schiebroek", false);
            //Borough ijsselmonde = new Borough("ijsselmonde", false);
            //Borough feijenoord = new Borough("feijenoord", false);
            //Borough centrum = new Borough("centrum", false);
            //Borough pernis = new Borough("pernis", false);
            //Borough rozenburg = new Borough("rozenburg", false);
            //Borough noord = new Borough("noord", false);
            //// Deze twee horen bij elkaar
            //Borough charlois1 = new Borough("charlois1", false);
            //Borough charlois2 = new Borough("charlois2", false);

            //// Wijken Charlois
            //Borough tarwewijk = new Borough("tarwewijk", false);
            //Borough carnisse = new Borough("carnisse", false);
            //Borough zuidwijk = new Borough("zuidwijk", false);
            //Borough oud_charlois = new Borough("oud_charlois", false);
            //Borough wielewaal = new Borough("wielewaal", false);
            //Borough zuidplein = new Borough("zuidplein", false);
            //Borough pendrecht = new Borough("pendrecht", false);
            //Borough heijplaat = new Borough("heijplaat", false);

            //// Wijken Delfshaven
            //Borough delfshavenwijk = new Borough("delfshavenwijk", false);
            //Borough bospolder = new Borough("bospolder", false);
            //Borough tussendijken = new Borough("tussendijken", false);
            //Borough spangen = new Borough("spangen", false);
            //Borough nieuwe_westen = new Borough("nieuwe_westen", false);
            //Borough middelland = new Borough("middelland", false);
            //Borough schiemond = new Borough("schiemond", false);
            //// Deze drie horen bij elkaar
            //Borough mathenesse1 = new Borough("mathenesse1", false);
            //Borough mathenesse2 = new Borough("mathenesse2", false);
            //Borough mathenesse3 = new Borough("mathenesse3", false);

            //// Wijken Feijenoord
            //Borough feijenoordwijk = new Borough("feijenoordwijk", false);
            //Borough kop_van_zuid = new Borough("kop_van_zuid", false);
            //Borough bloemenhof = new Borough("bloemenhof", false);
            //Borough hillesluis = new Borough("hillesluis", false);
            //Borough katendrecht = new Borough("katendrecht", false);
            //Borough afrikaanderwijk = new Borough("afrikaanderwijk", false);
            //Borough vreewijk = new Borough("vreewijk", false);
            //Borough noordereiland = new Borough("noordereiland", false);

            //// Wijken Hoogvliet
            //Borough hoogvliet_noord = new Borough("hoogvliet_noord", false);
            //Borough hoogvliet_zuid = new Borough("hoogvliet_zuid", false);

            //// Wijken Ijsselmonde
            //Borough oud_ijsselmonde = new Borough("oud_ijsselmonde", false);
            //Borough lombardijen = new Borough("lombardijen", false);
            //Borough groot_ijsselmonde = new Borough("groot_ijsselmonde", false);
            //Borough beverwaard = new Borough("beverwaard", false);

            //// Wijken Kralingen-Crooswijk
            //Borough rubroek = new Borough("rubroek", false);
            //Borough nieuw_crooswijk = new Borough("nieuw_crooswijk", false);
            //Borough oud_crooswijk = new Borough("oud_crooswijk", false);
            //Borough kralingen_west = new Borough("kralingen_west", false);
            //Borough kralingen_oost = new Borough("kralingen_oost", false);
            //Borough de_esch = new Borough("de_esch", false);
            //Borough struisenburg = new Borough("struisenburg ", false);

            //// Wijken Noord
            //Borough agniesebuurt = new Borough("agniesebuurt", false);
            //Borough provenierswijk = new Borough("provenierswijk", false);
            //Borough bergpolder = new Borough("bergpolder", false);
            //Borough blijdorp = new Borough("blijdorp", false);
            //Borough liskwartier = new Borough("liskwartier", false);
            //Borough oude_noorden = new Borough("oude_noorden", false);

            //// Wijken Overschie
            //Borough kleinpolder = new Borough("kleinpolder", false);
            //Borough overschiewijk = new Borough("overschiewijk", false);

            //// Wijken Prins-Alexander
            //Borough sgravenland = new Borough("sgravenland", false);
            //Borough kralingse_veer = new Borough("kralingse_veer", false);
            //Borough prinsenland = new Borough("prinsenland", false);
            //Borough het_lage_land = new Borough("het_lage_land", false);
            //Borough ommoord = new Borough("ommoord", false);
            //Borough oosterflank = new Borough("oosterflank", false);
            //Borough zevenkamp = new Borough("zevenkamp ", false);
            //Borough nesselande = new Borough("nesselande", false);

            //// Wijken Hillegersberg-Schiebroek
            //Borough schiebroekwijk = new Borough("schiebroekwijk", false);
            //Borough hillegersberg_noord = new Borough("hillegersberg_noord", false);
            //Borough hillegersberg_zuid = new Borough("hillegersberg_zuid", false);
            //Borough terbregge = new Borough("terbregge", false);
            //Borough molenlaankwartier = new Borough("molenlaankwartier", false);

            //// Wijken stadscentrum
            //Borough stadsdriehoek1 = new Borough("stadsdriehoek1", false);
            //Borough stadsdriehoek2 = new Borough("stadsdriehoek2", false);
            //Borough oude_westen = new Borough("oude_westen", false);
            //Borough cool1 = new Borough("cool1", false);
            //Borough cool2 = new Borough("cool2", false);
            //Borough cool3 = new Borough("cool3", false);





            //tarwewijk.AssignCoords(@"Coordinates\Deelgemeenten_coords.txt", "tarwewijk");
            //carnisse.AssignCoords(@"Coordinates\Deelgemeenten_coords.txt", "carnisse");
            //zuidwijk.AssignCoords(@"Coordinates\Deelgemeenten_coords.txt", "zuidwijk");
            //oud_charlois.AssignCoords(@"Coordinates\Deelgemeenten_coords.txt", "oud_charlois");
            //wielewaal.AssignCoords(@"Coordinates\Deelgemeenten_coords.txt", "wielewaal");
            //zuidplein.AssignCoords(@"Coordinates\Deelgemeenten_coords.txt", "zuidplein");
            //pendrecht.AssignCoords(@"Coordinates\Deelgemeenten_coords.txt", "pendrecht");
            //heijplaat.AssignCoords(@"Coordinates\Deelgemeenten_coords.txt", "heijplaat");
            //delfshavenwijk.AssignCoords(@"Coordinates\Deelgemeenten_coords.txt", "delfshavenwijk");
            //bospolder.AssignCoords(@"Coordinates\Deelgemeenten_coords.txt", "bospolder");
            //tussendijken.AssignCoords(@"Coordinates\Deelgemeenten_coords.txt", "tussendijken");
            //spangen.AssignCoords(@"Coordinates\Deelgemeenten_coords.txt", "spangen");
            //nieuwe_westen.AssignCoords(@"Coordinates\Deelgemeenten_coords.txt", "nieuwe_westen");
            //middelland.AssignCoords(@"Coordinates\Deelgemeenten_coords.txt", "middelland");
            //schiemond.AssignCoords(@"Coordinates\Deelgemeenten_coords.txt", "schiemond");
            //mathenesse1.AssignCoords(@"Coordinates\Deelgemeenten_coords.txt", "mathenesse1");
            //mathenesse2.AssignCoords(@"Coordinates\Deelgemeenten_coords.txt", "mathenesse2");
            //mathenesse3.AssignCoords(@"Coordinates\Deelgemeenten_coords.txt", "mathenesse3");
            //feijenoordwijk.AssignCoords(@"Coordinates\Deelgemeenten_coords.txt", "feijenoordwijk");
            //kop_van_zuid.AssignCoords(@"Coordinates\Deelgemeenten_coords.txt", "kop_van_zuid");
            //bloemenhof.AssignCoords(@"Coordinates\Deelgemeenten_coords.txt", "bloemenhof");
            //hillesluis.AssignCoords(@"Coordinates\Deelgemeenten_coords.txt", "hillesluis");
            //katendrecht.AssignCoords(@"Coordinates\Deelgemeenten_coords.txt", "katendrecht");
            //afrikaanderwijk.AssignCoords(@"Coordinates\Deelgemeenten_coords.txt", "afrikaanderwijk");
            //vreewijk.AssignCoords(@"Coordinates\Deelgemeenten_coords.txt", "vreewijk");
            //noordereiland.AssignCoords(@"Coordinates\Deelgemeenten_coords.txt", "noordereiland");
            //hoogvliet_noord.AssignCoords(@"Coordinates\Deelgemeenten_coords.txt", "hoogvliet_noord");
            //hoogvliet_zuid.AssignCoords(@"Coordinates\Deelgemeenten_coords.txt", "hoogvliet_zuid");
            //oud_ijsselmonde.AssignCoords(@"Coordinates\Deelgemeenten_coords.txt", "oud_ijssemonde");
            //lombardijen.AssignCoords(@"Coordinates\Deelgemeenten_coords.txt", "lombardijen");
            //groot_ijsselmonde.AssignCoords(@"Coordinates\Deelgemeenten_coords.txt", "groot_ijsselmonde");
            //beverwaard.AssignCoords(@"Coordinates\Deelgemeenten_coords.txt", "beverwaard");
            //rubroek.AssignCoords(@"Coordinates\Deelgemeenten_coords.txt", "rubroek");
            //nieuw_crooswijk.AssignCoords(@"Coordinates\Deelgemeenten_coords.txt", "nieuw_crooswijk");
            //oud_ijsselmonde.AssignCoords(@"Coordinates\Deelgemeenten_coords.txt", "oud_ijsselmonde");
            //kralingen_oost.AssignCoords(@"Coordinates\Deelgemeenten_coords.txt", "kralingen_oost");
            //kralingen_west.AssignCoords(@"Coordinates\Deelgemeenten_coords.txt", "kralingen_west");
            //de_esch.AssignCoords(@"Coordinates\Deelgemeenten_coords.txt", "de_esch");
            //struisenburg.AssignCoords(@"Coordinates\Deelgemeenten_coords.txt", "struisenburg");
            //agniesebuurt.AssignCoords(@"Coordinates\Deelgemeenten_coords.txt", "agniesebuurt");
            //provenierswijk.AssignCoords(@"Coordinates\Deelgemeenten_coords.txt", "provenierswijk");
            //bergpolder.AssignCoords(@"Coordinates\Deelgemeenten_coords.txt", "bergpolder");
            //blijdorp.AssignCoords(@"Coordinates\Deelgemeenten_coords.txt", "blijdorp");
            //liskwartier.AssignCoords(@"Coordinates\Deelgemeenten_coords.txt", "liskwartier");
            //oude_noorden.AssignCoords(@"Coordinates\Deelgemeenten_coords.txt", "oude_noorden");
            //kleinpolder.AssignCoords(@"Coordinates\overschie.txt", "kleinpolder");
            //overschiewijk.AssignCoords(@"Coordinates\overschie.txt", "overschiewijk");
            //sgravenland.AssignCoords(@"Coordinates\Deelgemeenten_coords.txt", "sgravenland");
            //kralingse_veer.AssignCoords(@"Coordinates\Deelgemeenten_coords.txt", "kralingse_veer");
            //prinsenland.AssignCoords(@"Coordinates\Deelgemeenten_coords.txt", "prinsenland");
            //het_lage_land.AssignCoords(@"Coordinates\Deelgemeenten_coords.txt", "het_lage_land");
            //ommoord.AssignCoords(@"Coordinates\Deelgemeenten_coords.txt", "ommoord");
            //oosterflank.AssignCoords(@"Coordinates\Deelgemeenten_coords.txt", "oosterflank");
            //zevenkamp.AssignCoords(@"Coordinates\Deelgemeenten_coords.txt", "zevenkamp");
            //nesselande.AssignCoords(@"Coordinates\Deelgemeenten_coords.txt", "nesselande");
            //schiebroekwijk.AssignCoords(@"Coordinates\Deelgemeenten_coords.txt.txt", "schiebroekwijk");
            //hillegersberg_noord.AssignCoords(@"Coordinates\Deelgemeenten_coords.txt.txt", "hillegersberg_noord");
            //hillegersberg_zuid.AssignCoords(@"Coordinates\Deelgemeenten_coords.txt.txt", "hillegersberg_zuid");
            //terbregge.AssignCoords(@"Coordinates\Deelgemeenten_coords.txt.txt", "terbregge");
            //molenlaankwartier.AssignCoords(@"Coordinates\Deelgemeenten_coords.txt.txt", "molenlaankwartier");
            //stadsdriehoek1.AssignCoords(@"Coordinates\Deelgemeenten_coords.txt", "stadsdriehoek1");
            //stadsdriehoek2.AssignCoords(@"Coordinates\Deelgemeenten_coords.txt", "stadsdriehoek2");
            //oude_westen.AssignCoords(@"Coordinates\Deelgemeenten_coords.txt", "oude_westen");
            //cool1.AssignCoords(@"Coordinates\Deelgemeenten_coords.txt", "cool1");
            //cool2.AssignCoords(@"Coordinates\Deelgemeenten_coords.txt", "cool2");
            //cool3.AssignCoords(@"Coordinates\Deelgemeenten_coords.txt", "cool3");

            // Voeg de polygon toe
            //tarwewijk.AssignCoords(@"Coordinates\Charlois.txt", "tarwewijk");
            //carnisse.AssignCoords(@"Coordinates\Charlois.txt", "carnisse");
            //zuidwijk.AssignCoords(@"Coordinates\Charlois.txt", "zuidwijk");
            //oud_charlois.AssignCoords(@"Coordinates\Charlois.txt", "oud_charlois");
            //wielewaal.AssignCoords(@"Coordinates\Charlois.txt", "wielewaal");
            //zuidplein.AssignCoords(@"Coordinates\Charlois.txt", "zuidplein");
            //pendrecht.AssignCoords(@"Coordinates\Charlois.txt", "pendrecht");
            //heijplaat.AssignCoords(@"Coordinates\Charlois.txt", "heijplaat");
            //delfshavenwijk.AssignCoords(@"Coordinates\Delfshaven.txt", "delfshavenwijk");
            //bospolder.AssignCoords(@"Coordinates\Delfshaven.txt", "bospolder");
            //tussendijken.AssignCoords(@"Coordinates\Delfshaven.txt", "tussendijken");
            //spangen.AssignCoords(@"Coordinates\Delfshaven.txt", "spangen");
            //nieuwe_westen.AssignCoords(@"Coordinates\Delfshaven.txt", "nieuwe_westen");
            //middelland.AssignCoords(@"Coordinates\Delfshaven.txt", "middelland");
            //schiemond.AssignCoords(@"Coordinates\Delfshaven.txt", "schiemond");
            //mathenesse1.AssignCoords(@"Coordinates\Delfshaven.txt", "mathenesse1");
            //mathenesse2.AssignCoords(@"Coordinates\Delfshaven.txt", "mathenesse2");
            //mathenesse3.AssignCoords(@"Coordinates\Delfshaven.txt", "mathenesse3");
            //feijenoordwijk.AssignCoords(@"Coordinates\feijenoord.txt", "feijenoordwijk");
            //kop_van_zuid.AssignCoords(@"Coordinates\feijenoord.txt", "kop_van_zuid");
            //bloemenhof.AssignCoords(@"Coordinates\feijenoord.txt", "bloemenhof");
            //hillesluis.AssignCoords(@"Coordinates\feijenoord.txt", "hillesluis");
            //katendrecht.AssignCoords(@"Coordinates\feijenoord.txt", "katendrecht");
            //afrikaanderwijk.AssignCoords(@"Coordinates\feijenoord.txt", "afrikaanderwijk");
            //vreewijk.AssignCoords(@"Coordinates\feijenoord.txt", "vreewijk");
            //noordereiland.AssignCoords(@"Coordinates\feijenoord.txt", "noordereiland");
            //hoogvliet_noord.AssignCoords(@"Coordinates\hoogvliet.txt", "hoogvliet_noord");
            //hoogvliet_zuid.AssignCoords(@"Coordinates\hoogvliet.txt", "hoogvliet_zuid");
            //oud_ijsselmonde.AssignCoords(@"Coordinates\ijsselmonde.txt", "oud_ijssemonde");
            //lombardijen.AssignCoords(@"Coordinates\ijsselmonde.txt", "lombardijen");
            //groot_ijsselmonde.AssignCoords(@"Coordinates\ijsselmonde.txt", "groot_ijsselmonde");
            //beverwaard.AssignCoords(@"Coordinates\ijsselmonde.txt", "beverwaard");
            //rubroek.AssignCoords(@"Coordinates\kralingen.txt", "rubroek");
            //nieuw_crooswijk.AssignCoords(@"Coordinates\kralingen.txt", "nieuw_crooswijk");
            //oud_ijsselmonde.AssignCoords(@"Coordinates\kralingen.txt", "oud_ijsselmonde");
            //kralingen_oost.AssignCoords(@"Coordinates\kralingen.txt", "kralingen_oost");
            //kralingen_west.AssignCoords(@"Coordinates\kralingen.txt", "kralingen_west");
            //de_esch.AssignCoords(@"Coordinates\kralingen.txt", "de_esch");
            //struisenburg.AssignCoords(@"Coordinates\kralingen.txt", "struisenburg");
            //agniesebuurt.AssignCoords(@"Coordinates\noord.txt", "agniesebuurt");
            //provenierswijk.AssignCoords(@"Coordinates\noord.txt", "provenierswijk");
            //bergpolder.AssignCoords(@"Coordinates\noord.txt", "bergpolder");
            //blijdorp.AssignCoords(@"Coordinates\noord.txt", "blijdorp");
            //liskwartier.AssignCoords(@"Coordinates\noord.txt", "liskwartier");
            //oude_noorden.AssignCoords(@"Coordinates\noord.txt", "oude_noorden");
            //kleinpolder.AssignCoords(@"Coordinates\overschie.txt", "kleinpolder");
            //overschiewijk.AssignCoords(@"Coordinates\overschie.txt", "overschiewijk");
            //sgravenland.AssignCoords(@"Coordinates\prinsenland.txt", "sgravenland");
            //kralingse_veer.AssignCoords(@"Coordinates\prinsenland.txt", "kralingse_veer");
            //prinsenland.AssignCoords(@"Coordinates\prinsenland.txt", "prinsenland");
            //het_lage_land.AssignCoords(@"Coordinates\prinsenland.txt", "het_lage_land");
            //ommoord.AssignCoords(@"Coordinates\prinsenland.txt", "ommoord");
            //oosterflank.AssignCoords(@"Coordinates\prinsenland.txt", "oosterflank");
            //zevenkamp.AssignCoords(@"Coordinates\prinsenland.txt", "zevenkamp");
            //nesselande.AssignCoords(@"Coordinates\prinsenland.txt", "nesselande");
            //schiebroekwijk.AssignCoords(@"Coordinates\schiebroek.txt", "schiebroekwijk");
            //hillegersberg_noord.AssignCoords(@"Coordinates\schiebroek.txt", "hillegersberg_noord");
            //hillegersberg_zuid.AssignCoords(@"Coordinates\schiebroek.txt", "hillegersberg_zuid");
            //terbregge.AssignCoords(@"Coordinates\schiebroek.txt", "terbregge");
            //molenlaankwartier.AssignCoords(@"Coordinates\schiebroek.txt", "molenlaankwartier");
            //stadsdriehoek1.AssignCoords(@"Coordinates\stadscentrum.txt", "stadsdriehoek1");
            //stadsdriehoek2.AssignCoords(@"Coordinates\stadscentrum.txt", "stadsdriehoek2");
            //oude_westen.AssignCoords(@"Coordinates\stadscentrum.txt", "oude_westen");
            //cool1.AssignCoords(@"Coordinates\stadscentrum.txt", "cool1");
            //cool2.AssignCoords(@"Coordinates\stadscentrum.txt", "cool2");
            //cool3.AssignCoords(@"Coordinates\stadscentrum.txt", "cool3");



            // Maar een GMapPolygon instance aan.
            //GMapPolygon Delfshaven = new GMapPolygon(delfshaven.Deelgemeente, "delfshaven");

            // Voeg de eerder gecreerde polygon instance toe aan de Rdam instance.
            //Rdam.Polygons.Add(Delfshaven);

            //Rdam.Deelgemeenten.Add(delfshaven); // Misschien niet nodig??

            //Delfshaven.Fill = new SolidBrush(Color.FromArgb(100, Color.Green));
            //Delfshaven.Stroke = new Pen(Color.Green, 1);

            // Haalt alle huidige polygons van de kaart.
            MapFunctions.Clear(gmap);

            // Maak een nieuwe GMapOverlay instance aan. 
            GMapOverlay Heatmaps = new GMapOverlay("Heatmaps");

            // Maak een Rotterdam instance aan die bestaat uit een list van boroughs en de daarbij behorende polygons.
            //Rotterdam Rdam = new Rotterdam();

            //foreach (Borough gebied in Rdam.Deelgemeenten)
            //{
            //    gebied.AssignCoords(@"Coordinates\Deelgemeenten_coords.txt", gebied.Name);
            //}

            //foreach (Borough gebied in Rdam.Deelgemeenten)
            //{
            //    Rdam.Polygons.Add(new GMapPolygon(gebied.Deelgemeente, gebied.Name));
            //}


            foreach (string Check in checkedListBox1.CheckedItems)
            {
                string new_check = Check.ToLower();
                Debug.Write("1");
                foreach (GMapPolygon polygon in Rdam.Polygons)
                    
                {

                    if (polygon.Name.Contains("3"))
                    {
                        string new_check3 = new_check + "3";

                        if (polygon.Name == new_check3)
                        {
                            Heatmaps.Polygons.Add(polygon);
                        }
                    }

                    if (polygon.Name.Contains("2"))
                    {
                        string new_check2 = new_check + "2";

                        if (polygon.Name == new_check2)
                        {
                            Heatmaps.Polygons.Add(polygon);
                        }
                    }
                    if (polygon.Name.Contains("1"))
                    {
                        string new_check1 = new_check + "1";

                        if (polygon.Name == new_check1)
                        {
                            Heatmaps.Polygons.Add(polygon);
                        }
        
                    }
                        Debug.Write("2");
                        if (polygon.Name == new_check)
                        {
                            Debug.Write("3");
                            Heatmaps.Polygons.Add(polygon);
                        }
                }    
            }

            gmap.Overlays.Add(Heatmaps);
            MapFunctions.UpdateMap(gmap);
        }
    }
}
