using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
