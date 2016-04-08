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
            string TempDeelgem = "";
            string TempDeelgem2 = "";
            string Columns = "";

            while (true)
            {
                TempLine = strReader.ReadLine();
                PreviousLine2 = PreviousLine1;
                Counter++;
                CountDoublePunt = TempLine.Count(x => x == ';');

                if (TempLine != null)
                {
                    if (Counter == 2 && DeelGemeente != null)
                    {
                        TempDeelgem2 = "";
                        foreach (char a in DeelGemeente) { TempDeelgem += a; if (TempDeelgem.Contains(";") == false) { TempDeelgem2 += a; } TempDeelgem = ""; }
                        DeelGemeente = TempDeelgem2;
                    }
                    if (Counter == 1) { DeelGemeente = TempLine; }
                    else if (Counter != 1 && TempLine.EndsWith(";;;;;") && TempLine.StartsWith(";;") && TempLine.Contains("2006") == false && CountDoublePunt == 7 || TempLine.EndsWith(";;;;;") && CountDoublePunt == 8 && TempLine.EndsWith(";") == true && TempLine.StartsWith(";;") && TempLine.Contains("2006") == false) { ReadLine1 = TempLine; }
                    else if (TempLine.StartsWith(";;%") == true || TempLine.Contains("absoluut") == true || TempLine.Contains("genormaliseerd") == true)
                    {
                        // De titel uitfilteren
                        ReadLine1 = PreviousLine1;
                        ReadLine1.Replace(" ", string.Empty);
                        string Templine1 = "";
                        Templine1 = PreviousLine1;
                        string Line1String = "";     //Gebruik ik als tussenbestand voor characters
                        ReadLine1 = "";
                        foreach (char c in Templine1)
                        {
                            Line1String += c;
                            if (Line1String.Contains(";")==false) { ReadLine1 += c; }
                            Line1String = "";
                        }
                        ReadLine1.Replace(" ", string.Empty);
                        OutputFile += "Create Table " + ReadLine1 + "( " + System.Environment.NewLine + "DeelGemeente" + " varchar(255),";
                        // de column namen uitfilteren
                        ReadLine2 = TempLine;
                        ReadLine2.Replace(" ", string.Empty);
                        string Templine2 = "";
                        Templine2 = TempLine;
                        int TempCounter1 = 0;
                        string Line2String = "";   //Gebruik ik als tussenbestand voor characters
                        string SaveString = "";

                        foreach (char c in Templine2) {
                            Line2String += c;
                            TempCounter1++;
                            if (Line2String.Contains(";") == false || Line2String.Contains(",")) { SaveString += c; }
                            else if (Line2String.Contains(";") && TempCounter1 > 2) { OutputFile += "'" + SaveString +"'"+  " varchar(255),"; Columns += SaveString + ", "; SaveString = "" + System.Environment.NewLine; }
                            Line2String = "";

                        }

                    }
                    else if (TempLine.StartsWith(";;") == true && TempLine.EndsWith(";") == false && TempLine != "") {
                        OutputFile = OutputFile.Remove(OutputFile.Length - 1)+ ")" + System.Environment.NewLine;
                        OutputFile += "Insert Into " + ReadLine1 + "("+ "DeelGemeente ," + Columns + ")" + System.Environment.NewLine + "Values (";
                        string TempString4 = "";
                        string TempString5 = "";
                        int TempCounter3 = 0;
                        foreach (char d in TempLine)
                        {
                            TempString4 += d;
                            if (TempCounter3 == 1) { OutputFile += DeelGemeente + " ,"; }
                            else if (TempString4.Contains(";") == false) { TempString5 += d; }
                            else if (TempString4.Contains(";") && TempCounter3 < 2) { OutputFile += "'" + TempString5 + "'" + " ,"; TempString5 = ""; }
                            TempString4 = "";
                        }
                    }

                    else if (TempLine == "") {
                        if (Counter > 3) {
                            OutputFile = OutputFile.TrimEnd(','); ; OutputFile += ")"; OutputFile += System.Environment.NewLine; }
                        if (Columns != null) { Columns.Replace(" ", string.Empty); }
                        Columns = ""; }
                    

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
