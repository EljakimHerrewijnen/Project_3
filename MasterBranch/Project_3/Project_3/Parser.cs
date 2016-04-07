using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections;
using Project_3.Properties;

namespace Project_3
{
    class Parser
    {
        public void CreateQuery()
        {
            string StreamReaderFile = Form1._Form1.GetParserTextBox;
            string OutputFile = "";
            string Subject = "";
            string TempLine = "";
            string DeelGemeente = "";
            string ReadLine1 = "";
            string ReadLine2 = "";
            string ReadLine3 = "";
            string PreviousLine1 = "";
            int CountDoublePunt = 0;
            string PreviousLine2 = "";
            StringReader strReader = new StringReader(StreamReaderFile);
            int Counter = 0;

            while (true)
            {
                TempLine = strReader.ReadLine();
                PreviousLine2 = PreviousLine1;
                Counter++;
                CountDoublePunt = TempLine.Count(x => x == ';');

                if (TempLine != null)
                {
                    if (Counter == 1) { DeelGemeente = TempLine; }
                    else if (Counter != 1 && TempLine.EndsWith(";;;;;") && TempLine.StartsWith(";;") && TempLine.Contains("2006") == false && CountDoublePunt == 7 || TempLine.EndsWith(";;;;;") && CountDoublePunt == 8 && TempLine.EndsWith(";") == true && TempLine.StartsWith(";;") && TempLine.Contains("2006") == false) { ReadLine1 = TempLine; }
                    else if (TempLine.StartsWith(";;%") == true || TempLine.Contains("absoluut") == true || TempLine.Contains("genormaliseerd") == true)
                    {
                        ReadLine1 = PreviousLine1;
                        string Templine1 = "";
                        Templine1 = ReadLine1;
                        ReadLine2 = TempLine;
                        string Line1String = "";
                        ReadLine1 = "";
                        ReadLine2 = "";
                        foreach (char c in Templine1) {
                            Line1String += c;
                            if (Line1String.Contains(";")== false) { ReadLine1 += c; }
                                }

                    }
                    else if (TempLine.StartsWith(";;") == true && TempLine.EndsWith(";") == false) { }
                    
                    OutputFile += "\n";

                }
                PreviousLine1 = TempLine;
                if (TempLine == ";;;;;;;") { break; }
            }
            Form1._Form1.update(OutputFile);
            CountDoublePunt = 0;
            //Form1._Form1.update(StreamReaderFile);
            //foreach (char c in TempLine)
            //{
            //    int puntkomma = 0;
            //    int letters = 0;
            //    string astring = "";
            //    astring += c;

            //    if (astring.Contains(";") == true) { puntkomma += 1; }
            //    else if (c.GetType == string) { }
            //    astring = "";
            //}
        }
    }
}
