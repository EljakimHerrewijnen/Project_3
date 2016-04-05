using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;
using System.IO;

namespace Project_3
{
    class Parser
    {
        public void CreateQuery()
        {
            string FilePath = @"C:\Users\Eljakim Herrewijnen\Documents\0912374Eljakim_Herrewijnen.txt";
            using (StreamReader sr = new StreamReader(FilePath))
            {
                Console.WriteLine(sr.Read());
            }
        }
    }
}
