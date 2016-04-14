using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Parser_v2;
using System.IO;
using System.Windows.Forms;

namespace Parser_v2
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {

            string filepath = "cijfersetje Noord.csv";// args[0];
            string FileToParse;
            string Query;

            Application.Run(new ParserGUI());
            //var fileStream = new FileStream(filepath, FileMode.Open, FileAccess.Read);
            //using (StreamReader reader = new StreamReader(fileStream, Encoding.ASCII))
            //{
            //    FileToParse = reader.ReadToEnd();
            //}


            //System.Console.Write(FileToParse);


            Parser parser = new Parser(FileToParse);
            Query = parser.dataToSql();
            //System.Console.Write(Query);
            int x = 0;
        }
    }
}
