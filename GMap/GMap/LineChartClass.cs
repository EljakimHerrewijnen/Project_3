using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;

namespace GMap
{
    class LineChartClass
    {
        public static Series CreateNewChart(string gebied, string Data_type)
        {
            Series series = new Series();
            series.Name = Data_type;
            series.ChartType = SeriesChartType.Line;

            string table_name = DictionairContainer.ChangeName(Data_type);
            string echtegebied = DictionairContainer.getAreaName(gebied.ToLower());
            double data06 = double.Parse((DatabaseRequester.getDataFromYear(table_name, echtegebied, "2006")), CultureInfo.GetCultureInfo("de-DE"));
            double data07 = double.Parse((DatabaseRequester.getDataFromYear(table_name, echtegebied, "2007")), CultureInfo.GetCultureInfo("de-DE"));
            double data08 = double.Parse((DatabaseRequester.getDataFromYear(table_name, echtegebied, "2008")), CultureInfo.GetCultureInfo("de-DE"));
            double data09 = double.Parse((DatabaseRequester.getDataFromYear(table_name, echtegebied, "2009")), CultureInfo.GetCultureInfo("de-DE"));
            double data11 = double.Parse((DatabaseRequester.getDataFromYear(table_name, echtegebied, "2011")), CultureInfo.GetCultureInfo("de-DE"));


            series.Points.DataBindXY(new[] { 2006, 2007, 2008, 2009, 2011 }, new[] { data06, data07, data08, data09, data11});



            return series;
        }
    }
}
