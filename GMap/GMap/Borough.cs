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
    class Borough
    {
        private string name;
        public List<PointLatLng> deelgemeente = new List<PointLatLng>();
        public List<Area> has_areas;
        private bool draw; //True or False hier

        public Borough(string name, bool true_false)
        {
            this.name = name;
            draw = true_false;
        }

        public List<PointLatLng> Deelgemeente { get { return deelgemeente; } }

        public bool Draw
        {
            get { return draw; }
            set { draw = value; }
        }

        public void ReadCoords(string path, string naam)
        {
            string line;
            int endname;
            int endfirstcoord;
            int i;

            string name;
            string coord1;
            string coord2;
            double north, east;



            var fileStream = new FileStream(path, FileMode.Open, FileAccess.Read);
            using (StreamReader reader = new StreamReader(fileStream, Encoding.ASCII))
            {
                while (!reader.EndOfStream)
                {
                    line = reader.ReadLine();
                    if (line != "")
                    {
                        i = 0;
                        while (line[i] != ' ')
                        {
                            i++;
                        }
                        endname = i;
                        name = line.Substring(0, i);
                        i++;
                        if (naam == name)
                        {
                            while (line[i] != ',')
                            {
                                i++;
                            }
                            endfirstcoord = i;
                            coord1 = line.Substring(endname + 1, i - 1 - (endname));
                            coord2 = line.Substring(i + 2, line.Length - (i + 2));

                            north = double.Parse(coord1);
                            east = double.Parse(coord2);



                            deelgemeente.Add(new PointLatLng(north, east));
                        }
                    }
                }





            }
        }

    }
}



//Maak een lijst met alle List<PointLatLng> deelgemeenten
//Geef per deelgemeente de optie True/False of ze weergegeven moeten worden of niet. (Zou kunnen met checkboxen?)
//foreach(var deelgemeente in List<Borough>> { if (draw == True) {Heatmaps.Polygons.Add(deelgemeente); } }

