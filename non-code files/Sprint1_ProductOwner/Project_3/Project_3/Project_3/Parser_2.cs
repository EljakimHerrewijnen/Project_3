using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_3
{
    class Parser_2
    {
        //==========================================  By Eljakim
        //This is a character controlled code. This code checks every character and changes then. It's ugly so I changed it!
        //==========================================
        //    char[] Characters = new char[Parser_Textbox.Text.Length];
        //    string ParsedQuery = "";
        //    int Counter = 0;
        //    int result = Parser_Textbox.Text.Length;
        //    string newString = Parser_Textbox.Text;
        //    string TempString1;
        //    string TempString2 = "";
        //    string TempString3 = "";
        //    int TempCounter = 0;
        //    bool AwaitingEndColumn = false;
        //    bool EndColumnReached = false;
        //    string CatagoryTemp = "";
        //    string PreviousChar = "";
        //    bool Doublepuntkomma = false;
        //    bool ValueChecker = false;

        //    foreach (char c in newString)
        //    {
        //        Counter++;
        //        TempString2 += c;

        //        if (TempString2.Contains(";") == false && PreviousChar.Contains(";") == true)
        //        {
        //            TempString3 += c;
        //            EndColumnReached = true;
        //        }
        //        else if (TempString2.Contains(";") == false && PreviousChar.Contains(";") == false) { TempString3 += c; }
        //        else if (TempString2.Contains(";") == true) { TempCounter++; }

        //        if (EndColumnReached == true) {
        //            if (TempCounter == 7)
        //            {
        //                CatagoryTemp = ""; CatagoryTemp = TempString3; TempCounter = 0; TempString3 = "";
        //                ValueChecker = false; Doublepuntkomma = false;
        //            }
        //            else if (TempCounter == 5 && Doublepuntkomma == true)
        //            {
        //                TempCounter = 0;
        //                ParsedQuery += "Create Table " + CatagoryTemp + "_" + TempString3 + "( \n";
        //                TempString3 = ""; ValueChecker = false; Doublepuntkomma = false;
        //            }
        //            else if (TempCounter == 2)
        //            {
        //                EndColumnReached = false; Doublepuntkomma = true; TempCounter = 0;
        //            }
        //            else if (TempCounter == 1 && Doublepuntkomma == false && AwaitingEndColumn == true) { AwaitingEndColumn = false; }
        //            else if (TempCounter == 1 && Doublepuntkomma == true )
        //            {
        //                EndColumnReached = false; Doublepuntkomma = false; AwaitingEndColumn = false;
        //                ParsedQuery += TempString3 + " varchar(256), \n"; TempString3 = ""; TempCounter = 0;
        //            }




        //            //     else if (TempString2.Contains(";") == true && ValueChecker == true && TempCounter == 1) { ParsedQuery += TempString3 + " varchar(256),\n"; } 
        //        }

        //        PreviousChar = TempString2;
        //        TempString2 = "";
        //        textBox1.Text = ParsedQuery;
        //    }

    }
}
