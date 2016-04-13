using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parser_v2
{
    class Parser
    {
        public string datafile;
        public int datafilesize;

        public Parser(string Datafile)
        {
            datafile = Datafile;
            datafilesize = datafile.Length;
        }

        public string dataToSql()
        {
            string Query = "";
            List<List<string>> Table;
            int currentrow = 0;

            Table = toTable();

            while (currentrow < Table.Count)
            {
                currentrow = findNextTableStart(currentrow, Table);
                System.Console.WriteLine(currentrow);
                currentrow++;
            }
            return Query;
        }

        private string getQuery(List<List<string>> Table)
        {
            int currentrow = 0;


            //string

            //read title
            
            //read field names

            //read values and put in lists

            //read value types (only if not empty)

            //create if not exists
            
            //write values

            //make if not exist
            //


            throw new NotImplementedException();
        }
        
        //Turns a string from data into a table
        private List<List<string>> toTable()
        {
            List<List<string>> table = new List<List<string>>();
            List<string> row = new List<string>();
            string celdata = "";
            for (int index = 0; index + 1 < datafilesize; index++)
            {
                switch (datafile[index])
                {
                    case ';':
                        row.Add(celdata);
                        celdata = "";
                        break;

                    case '\n':
                        row.Add(celdata);
                        celdata = "";

                        for (int i = row.Count; i < 13; i++)
                        {
                            row.Add("");
                        }

                        table.Add(row);
                        row = new List<string>();
                        break;

                    case '\r':
                        break;
                    default:
                        celdata += datafile[index];
                        break;
                }
            }
            return table;
        }
        
        //Finds the  starts of the next table, given A starting point (current row) and a table.
        private int findNextTableStart(int currentrow, List<List<string>> Table)
        {
            bool elementfound = false;

            while (currentrow < Table.Count)
            {
                if (Table[currentrow][2] != "") //element of discriptions table is not blank
                {
                    for(int i = 0; i<13; i++)   //check all cells in row
                    {
                        if (i != 2) //do is this is not the element of discription
                        {
                            if(Table[currentrow][i] != "")  //is element in row is not blank, turn element found true
                            {
                                elementfound = true;
                            }
                        }
                    }

                    if (elementfound == false)   //no element found other than cel 2, meaning this is the starts of a table
                    {
                        return currentrow;
                    }
                    elementfound = false;
                }
                currentrow++;
            }
            return Table.Count;
        }
    }
}
