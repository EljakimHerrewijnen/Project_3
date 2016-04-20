using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*  Deze file is van: "Marc Harreman"
*
*/

namespace GMap
{
    class Dictionary
    {
        public static string ChangeName(string input)
        {
            string change;
            Dictionary<string, string> dictionary = new Dictionary<string, string>();
            dictionary.Add("aangiften diefstal van brom- en snorfietsen", "_aangiften_diefstal_van_brom___snor___fietsen");
            dictionary.Add("slachtofferschap diefstal vanaf de auto", "slachtofferschap_diefstal_vanaf_de_auto");
            dictionary.Add("buurtprobleem fietsendiefstal", "buurtprobleem_fietsendiefstal");
            dictionary.Add("buurtprobleem diefstal uit de auto", "buurtprobleem_diefstal_uit_de_auto");
            dictionary.Add("aangiften diefstal van motorvoertuigen", "_aangiften_diefstal_van_motorvoertuigen");
            dictionary.Add("slachtofferschap fietsendiefstal", "slachtofferschap_fietsendiefstal");
            dictionary.Add("buurtprobleem beschadiging aan of diefstal vanaf de auto", "buurtprobleem_beschadiging_aan_of_diefstal_vanaf_de_auto");
            dictionary.Add("slachtofferschap autodiefstal", "slachtofferschap_autodiefstal");
            dictionary.Add("slachtofferschap diefstal uit de auto", "slachtofferschap_diefstal_uit_de_auto");
            dictionary.Add("slachtofferschap overige diefstal", "slachtofferschap_overige_diefstal");
            dictionary.Add("aangiften winkeldiefstal", "_aangiften_winkeldiefstal");
            dictionary.Add("aangiften diefstal vanuit motorvoertuigen", "_aangiften_diefstal_uit_vanaf_motorvoertuigen");
            dictionary.Add("aangiften diefstal uit overige voertuigen", "_aangiften_diefstal_af_uit_van_overige_voertuigen");
            dictionary.Add("aangiften zakkenrollerij", "_aangiften_zakkenrollerij");
            dictionary.Add("aangiften overige vermogensdelicten", "_aangiften_overige_vermogensdelicten");
            dictionary.Add("buurtprobleem drugsoverlast", "buurtprobleem_drugsoverlast");
            dictionary.Add("meldingen drugsoverlast", "_meldingen_drugsoverlast");
            dictionary.Add("buurtprobleem bedreigingen", "buurtprobleem_bedreiging");
            dictionary.Add("buurtprobleem geweldsdelicten", "buurtprobleem_geweldsdelicten");
            dictionary.Add("buurtprobleem tasjesroof", "buurtprobleem_tasjesroof");
            dictionary.Add("slachtofferschap tasjesroof met geweld", "slachtofferschap_tasjesroof_met_geweld");
            dictionary.Add("aangiften zedenmisdrijven", "_aangiften_zedenmisdrijven");
            dictionary.Add("slachtofferschap tasjesroof zonder geweld", "slachtofferschap_tasjesroof_zonder_geweld");
            dictionary.Add("slachtofferschap bedreiging met geweld", "slachtofferschap_bedreiging_met_geweld");
            dictionary.Add("slachtofferschap mishandeling", "slachtofferschap_mishandeling");
            dictionary.Add("aangiften openlijke geweldpleging tegen personen", "_aangiften_openlijke_geweldpleging_tegen_personen");
            dictionary.Add("aangiften straatroof", "_aangiften_straatroof");
            dictionary.Add("aangiften overval", "_aangiften_overval");
            dictionary.Add("meldingen bedreigingen", "_meldingen_bedreiging");
            dictionary.Add("meldingen mishandeling", "_meldingen_mishandeling");
            dictionary.Add("buurtprobleem woninginbraak", "buurtprobleem_woninginbraak");
            dictionary.Add("aangiften inbraak in garages, schuren en tuinhuisjes", "_aangiften_inbraak_in_garages__schuren_en_tuinhuizen");
            dictionary.Add("slachtofferschap poging tot inbraak", "slachtofferschap_poging_tot_inbraak");
            dictionary.Add("slachtofferschap woninginbraak", "slachtofferschap_woninginbraak");
            dictionary.Add("aangiften woninginbraak", "_aangiften_woninginbraak");
            dictionary.Add("buurtprobleem bekladding muren / gebouwen", "buurtprobleem_bekladding_muren_gebouwen");
            dictionary.Add("aangiften inbraak in bedrijven / instellingen", "_aangiften_inbraak_in_bedrijven_instellingen");
            dictionary.Add("buurtprobleem vernielingtelefooncellen / bus- of tramhokjes", "buurtprobleem_vernieling_telefooncellen_bus__of_tramhokjes_");
            dictionary.Add("slachtofferschap overige beschadiging / vernieling", "slachtofferschap_overige_beschadiging_vernieling");
            dictionary.Add("meldingen vernieling cq zaakbeschadiging", "_meldingen_vernieling_cq_zaakbeschadiging");
            dictionary.Add("meldingen kleine buitenbranden", "meldingen_kleine_buitenbranden");
            dictionary.Add("buurtprobleem overlast van groepen jongeren", "buurtprobleem_overlast_van_groepen_jongeren");
            dictionary.Add("buurtprobleem dronken mensen op straat", "buurtprobleem_dronken_mensen_op_straat");
            dictionary.Add("buurtprobleem lastig gevallen worden op straat", "buurtprobleem_lastig_gevallen_worden_op_straat");
            dictionary.Add("meldingen burengerucht relatieproblemen", "_meldingen_burengerucht_relatieproblemen");
            dictionary.Add("meldingen overlast", "_meldingen_overlast");
            dictionary.Add("buurtprobleem vervuiling op straat", "buurtprobleem_vervuiling_op_straat");
            dictionary.Add("buurtprobleem hondenpoep op straat", "buurtprobleem_hondenpoep_op_straat");
            dictionary.Add("buurtprobleem vuil naast de container", "buurtprobleem_vuil_naast_de_container");
            dictionary.Add("score op de productnormering","score_op_de_productnormering");
            dictionary.Add("buurtprobleem wildplassen", "buurtprobleem_wildplassen");
            dictionary.Add("buurtprobleem gaten of verzakkingen in de bestrating", "buurtprobleem_gaten_of_verzakkingen_in_de_bestrating");
            dictionary.Add("buurtprobleem agressief verkeersgedrag", "buurtprobleem_agressief_verkeersgedrag");
            dictionary.Add("buurtprobleem vernield of kapot straatmeubilair", "buurtprobleem_vernield_of_kapot_straatmeubilair");
            dictionary.Add("buurtprobleem aanrijdingen", "buurtprobleem_aanrijdingen");
            dictionary.Add("slachtofferschap aanrijdingen met doorrijden", "slachtofferschap_aanrijding_met_doorrijden");
            dictionary.Add("slachtofferschap aanrijdingen zonder doorrijden", "slachtofferschap_aanrijding_zonder_doorrijden");
            dictionary.Add("meldingen verkeersongevallen", "_meldingen_verkeersongevallen");
            dictionary.Add("tevredenheid met het wonen in de buurt", "tevredenheid_met_het_wonen_in_de_buurt_");

            change = dictionary[input];
            return change;
        }
        public static string getAreaName ( string input)
        {
            string output = "";

            Dictionary<string, string> dictionary = new Dictionary<string, string>();

            dictionary.Add("tarwewijk", "Tarwewijk");
            dictionary.Add("nesselande", "Nesselande");
            dictionary.Add("kleinpolder", "Kleinpolder");
            dictionary.Add("hillegersberg_zuid", "Hillegersberg Zuid");
            dictionary.Add("nieuwe_westen", "Nieuwe Westen");
            dictionary.Add("hoogvliet_zuid", "Hoogvliet Zuid");
            dictionary.Add("spangen", "Spangen");
            dictionary.Add("delfshaven", "Delfshaven");
            dictionary.Add("kralingen_west", "Kralingen West");
            dictionary.Add("het_lage_land", "Het Lage Land");
            dictionary.Add("pernis", "Pernis");
            dictionary.Add("pernis1", "Pernis");
            dictionary.Add("kralingen", "Kralingen-Crooswijk");
            dictionary.Add("hillegersberg_noord", "Hillegersberg Noord");
            dictionary.Add("oosterflank", "Oosterflank");
            dictionary.Add("beverwaard", "Beverwaard");
            dictionary.Add("ommoord", "Ommoord");
            dictionary.Add("zuidwijk", "Zuidwijk");
            dictionary.Add("rozenburg", "Rozenburg");
            dictionary.Add("rozenburg1", "Rozenburg");
            dictionary.Add("tussendijken", "Tussendijken");
            dictionary.Add("schiebroekwijk", "Schiebroek");
            dictionary.Add("oud_charlois", "Oud Charlois");
            dictionary.Add("prinsenland", "Prinsenland");
            dictionary.Add("bospolder", "Bospolder");
            dictionary.Add("overschie", "Overschie");
            dictionary.Add("schiebroek", "Hillegersberg-Schiebroek");
            dictionary.Add("agniesebuurt", "Agniesebuurt");
            dictionary.Add("heijplaat", "Heijplaat");
            dictionary.Add("mathenesse1", "Oud/Nieuw Mathenesse/Witte Dorp");
            dictionary.Add("mathenesse2", "Oud/Nieuw Mathenesse/Witte Dorp");
            dictionary.Add("mathenesse3", "Oud/Nieuw Mathenesse/Witte Dorp");
            dictionary.Add("katendrecht", "Katendrecht");
            dictionary.Add("blijdorp", "Blijdorp");
            dictionary.Add("kralingse_veer", "Kralingse Veer");
            dictionary.Add("afrikaanderwijk", "Afrikaanderwijk");
            dictionary.Add("stadsdriehoek1", "Stadsdriehoek/C.S. Kwartier");
            dictionary.Add("stadsdriehoek2", "Stadsdriehoek/C.S. Kwartier");
            dictionary.Add("wielewaal", "Wielewaal");
            dictionary.Add("hoek_van_holland", "Hoek van Holland");
            dictionary.Add("hoek_van_holland1", "Hoek van Holland");
            dictionary.Add("provenierswijk", "Provenierswijk");
            dictionary.Add("hillesluis", "Hillesluis");
            dictionary.Add("groot_ijsselmonde", "Groot IJsselmonde");
            dictionary.Add("liskwartier", "Liskwartier");
            dictionary.Add("sgravenland", "s-Gravenland");
            dictionary.Add("delfshavenwijk", "Delfshavenwijk");
            dictionary.Add("schiemond", "Schiemond");
            dictionary.Add("oud_ijsselmonde", "Oud IJsselmonde");
            dictionary.Add("hoogvliet_noord", "Hoogvliet Noord");
            dictionary.Add("vreewijk", "Vreewijk");
            dictionary.Add("overschiewijk1", "Overschie eo");
            dictionary.Add("overschiewijk2", "Overschie eo");
            dictionary.Add("overschiewijk3", "Overschie eo");
            dictionary.Add("carnisse", "Carnisse");
            dictionary.Add("cool1", "Cool/Nieuwe Werk/Dijkzigt");
            dictionary.Add("cool2", "Cool/Nieuwe Werk/Dijkzigt");
            dictionary.Add("cool3", "Cool/Nieuwe Werk/Dijkzigt");
            dictionary.Add("feijenoord", "Feijenoord");
            dictionary.Add("hoogvliet", "Hoogvliet");
            dictionary.Add("middelland", "Middelland");
            dictionary.Add("lombardijen", "Lombardijen");
            dictionary.Add("ijsselmonde", "IJsselmonde");
            dictionary.Add("terbregge", "Terbregge");
            dictionary.Add("bergpolder", "Bergpolder");
            dictionary.Add("prins_alexander", "Prins Alexander");
            dictionary.Add("bloemenhof", "Bloemhof");
            dictionary.Add("kop_van_zuid_entrepot", "Kop van Zuid Entrepot");
            dictionary.Add("kop_van_zuid", "Kop van Zuid Entrepot");
            dictionary.Add("zuidplein", "Zuidplein");
            dictionary.Add("kralingen_oost", "Kralingen Oost/Kralingse Bos");
            dictionary.Add("struisenburg", "Struisenburg");
            dictionary.Add("rubroek", "Rubroek");
            dictionary.Add("charlois1", "Charlois");
            dictionary.Add("charlois2", "Charlois");
            dictionary.Add("de_esch", "De Esch");
            dictionary.Add("stadscentrum", "Stadscentrum");
            dictionary.Add("molenlaankwartier", "Molenlaankwartier");
            dictionary.Add("oud_crooswijk", "Oud Crooswijk");
            dictionary.Add("oude_noorden", "Oude Noorden");
            dictionary.Add("pendrecht", "Pendrecht");
            dictionary.Add("noordereiland", "Noordereiland");
            dictionary.Add("zevenkamp", "Zevenkamp");
            dictionary.Add("noord", "Noord");
            dictionary.Add("feijenoordwijk", "Feijenoordwijk");
            dictionary.Add("oude_westen", "Oude Westen");
            dictionary.Add("nieuw_crooswijk", "Nieuw Crooswijk");

            output = dictionary[input];

            return output;
        }
    }
}
