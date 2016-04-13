using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parser_v2
{
    class Parser
    {
        public int index = 0;
        public string datafile;
        public int datafilesize;

        public Parser(string Datafile)
        {
            datafile = Datafile;
            datafilesize = datafile.Length;
        }

        public string dataToSql()
        {
            string finishedQuery = "";
            string newQueryPart;

            List<List<string>> nextTable;

            while (true)
            {
                nextTable = getNextTable();

                if (nextTable[0][0] == null)
                {
                    return finishedQuery;       //list element is null, indicating that EOF is reached
                }

                newQueryPart = "found a table \n";
                //newQueryPart = getQuery(nextTable);
                finishedQuery += newQueryPart;
            }
        }

        private string getQuery(List<List<string>> Table)
        {
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

        private List<List<string>> getNextTable()
        {
            List<List<string>> table = new List<List<string>>();
            List<List<string>> emptylist = new List<List<string>>();
            emptylist.Add(new List<string>());
            emptylist[0].Add(null);


            bool done = false;
            bool ContainsValues = false;

            string newcell;
            List<string> newrow = new List<string>();
            bool endcell = false;
            bool endline = false;

            while (!done)
            {
                endline = false;
                while (!endline)
                {
                    newcell = "";
                    endcell = false;
                    while (!endcell)
                    {
                        if (index + 1 >= datafilesize)
                        {
                            done = true;
                            endcell = true;
                            endline = true;
                        }
                        else
                        {
                            switch (datafile[index])
                            {
                                case ';':
                                    endcell = true;
                                    break;
                                case '\n':
                                    endline = true;
                                    endcell = true;
                                    break;
                                default:
                                    newcell += datafile[index];
                                    break;
                            }
                        }
                        index++;
                    }
                    newrow.Add(newcell);
                }

                if (!(newrow[0] == "" && newrow.Count == 1)) // adds new row to table if it contains cells.
                {
                    table.Add(newrow);
                    newrow = new List<string>();
                }
                else
                {
                    done = true;
                }
            }


            foreach (List<string> list in table)
            {
                foreach (string cel in list)
                {
                    if (cel != "")
                    {
                        ContainsValues = true;
                    }
                }
            }

            if (ContainsValues)
            {
                return table;
            }
            else
            {
                //emptylist[0][0] = null;
                return emptylist;
            }
        }
    }
}
