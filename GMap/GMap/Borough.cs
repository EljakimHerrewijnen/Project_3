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
using System.Globalization;

namespace GMap
{
    //Class Borough, however Borough has also instances for areas
    class Borough
    {
        private string name;
        private List<PointLatLng> deelgemeente = new List<PointLatLng>();
        private bool draw; //True or False hier
        private GMapPolygon polygon;
        private string type;
        private string inDeelgemeente;

        //Constructor
        public Borough(string name, bool true_false, string type, string deelgemeente)
        {
            this.name = name;
            draw = true_false;
            this.type = type;
            inDeelgemeente = deelgemeente;
        }

        //Returns the type of the area. It can either be 'Deelgemeente' or 'Wijk'
        public string Type { get { return type; } set { type = value; } }

        //Returns the name of the area.
        public string Name { get { return name; } set { name = value; } }

        //Makes a polygon for every area. A polygon contains a list with all the coordinates.
        public GMapPolygon Polygon { get { return polygon; } set { polygon = value; } }

        //Coordinates for every area individually
        public List<PointLatLng> Deelgemeente { get { return deelgemeente; } set { deelgemeente = value; } }

        //A method concerning the instances with type 'Wijk'. This method is used to know in which borough an area lays.
        public string InDeelgemeente { get { return inDeelgemeente; } }

        //Actually never used. This was going to decide whether to draw the area or not, however we found a better solution.
        public bool Draw
        {
            get { return draw; }
            set { draw = value; }
        }

        //Reads the coordinates and names from the textfile 'Deelgemeenten_coords.txt' and assigns them to the areas.
        public void AssignCoords(string path, string naam)
        {
            string line;
            int endname;
            int endfirstcoord;
            int i;

            string name;
            string coord1;
            string coord2;
            double north, east;

            //Reads from the file
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

                            north = double.Parse(coord1, CultureInfo.InvariantCulture);
                            east = double.Parse(coord2, CultureInfo.InvariantCulture);

                            north -= 0.00090704095;
                            east -= 0.00031113624;


                            deelgemeente.Add(new PointLatLng(north, east));
                        }
                    }
                }
            }
            //Creates the polygon with the retreived coordinates
            polygon = new GMapPolygon(this.deelgemeente, this.name);
        }

    }
}
