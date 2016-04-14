using GMap.NET;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GMap
{
    class Borough
    {
        private string name;
        public List<PointLatLng> deelgemeente;
        private bool draw; //True or False hier

        public Borough(string name, List<PointLatLng> coordlist)
        {
            this.name = name;
            deelgemeente = coordlist;
            draw = false;
        }

        public bool Draw
        {
            get { return draw; }
            set { draw = value; }
        }
    }
}


//Maak een lijst met alle List<PointLatLng> deelgemeenten
//Geef per deelgemeente de optie True/False of ze weergegeven moeten worden of niet. (Zou kunnen met checkboxen?)
//foreach(var deelgemeente in List<Borough>> { if (draw == True) {Heatmaps.Polygons.Add(deelgemeente); } }

