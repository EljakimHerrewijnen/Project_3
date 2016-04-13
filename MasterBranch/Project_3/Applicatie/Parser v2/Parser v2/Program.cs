using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Parser_v2;
using System.IO;

namespace Parser_v2
{
    class Program
    {
        static void Main(string[] args)
        {

            string filepath = "cijfersetje Pernis.csv";// args[0];
            string FileToParse;
            string Query;


            var fileStream = new FileStream(filepath, FileMode.Open, FileAccess.Read);
            using (StreamReader reader = new StreamReader(fileStream, Encoding.ASCII))
            {
                FileToParse = reader.ReadToEnd();
            }

            //System.Console.Write(FileToParse);

            Parser parser = new Parser(FileToParse);
            Query = parser.dataToSql();
            System.Console.Write(Query);
            int x = 0;
        }
    }
}
