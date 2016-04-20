using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GMap
{
    class Heatmap
    {
        //Misschien alle values per deelgemeente in een list plaatsen en op die manier alles te maken.

        //GMapOverlay Heatmaps = new GMapOverlay("Heatmaps");
        //List<PointLatLng> schiebroek_points = new List<PointLatLng>();

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
