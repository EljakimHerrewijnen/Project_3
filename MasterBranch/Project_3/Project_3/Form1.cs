using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Project_3
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }


        private void parserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Create an instance of the open file dialog box.
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            // Set filter options and filter index.
            openFileDialog1.Filter = "Text Files (.txt)|*.txt|All Files (*.*)|*.*";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.Multiselect = false;
            if (openFileDialog1.ShowDialog() == DialogResult.OK) {
                string file = openFileDialog1.FileName;
                Parser_Textbox.Text = file ;
                using (StreamReader sr = new StreamReader(file))
                {
                    Parser_Textbox.Text = sr.ReadToEnd();
                }
            }

            }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Parser_Button_Click(object sender, EventArgs e)
        {
            char[] Characters = new char[Parser_Textbox.Text.Length];

            string Temp = "";
            string ParsedQuery = "";
            int Counter = 0;
            int result = Parser_Textbox.Text.Length;
            string newString = Parser_Textbox.Text;
            string TempString1;
            string TempString2 = "";
            string TempString3 = "";
            int TempCounter = 0;
            bool AwaitingEndColumn = false;
            bool EndColumnReached = false;
            string CatagoryTemp = "";
            string PreviousChar = "";
            bool Doublepuntkomma = false;
            bool ValueChecker = false;

            foreach (char c in newString)
            {
                TempString1 = newString;
                Counter++;
                TempString2 += c;

                if (TempString2.Contains(";") == false && PreviousChar.Contains(";") == true)
                {
                    TempString3 += c;
                    EndColumnReached = true;

                }
                else if (TempString2.Contains(";") == false && PreviousChar.Contains(";") == false) { TempString3 += c; }
                else if (TempString2.Contains(";") == true) { TempCounter++; }

                if (EndColumnReached == true) {
                    if (TempCounter == 7)
                    {
                        CatagoryTemp = ""; CatagoryTemp = TempString3; TempCounter = 0; TempString3 = "";
                        ValueChecker = false; Doublepuntkomma = false;
                    }
                    else if (TempCounter == 5 && Doublepuntkomma == true)
                    {
                        TempCounter = 0;
                        ParsedQuery += "Create Table " + CatagoryTemp + "_" + TempString3 + "( \n";
                        TempString3 = ""; ValueChecker = false; Doublepuntkomma = false;
                    }
                    else if (TempCounter == 2)
                    {
                        EndColumnReached = false; Doublepuntkomma = true; TempCounter = 0;
                    }
                    else if (TempString2.Contains(";") == true && Doublepuntkomma == true)
                    {
                        EndColumnReached = false; Doublepuntkomma = false;
                        ParsedQuery += TempString3 + " varchar(256), \n"; TempString3 = ""; TempCounter = 0;
                    }

                   // else if (PreviousChar.Contains(";") == true && Doublepuntkomma == true) { Doublepuntkomma = false; ValueChecker = true; ParsedQuery += TempString3 + " varchar(256),\n"; }

                    //     else if (TempString2.Contains(";") == true && ValueChecker == true && TempCounter == 1) { ParsedQuery += TempString3 + " varchar(256),\n"; } 
                }

                PreviousChar = TempString2;
                TempString2 = "";
                textBox1.Text = ParsedQuery;
            }

        }

        private void Parser_Textbox_TextChanged(object sender, EventArgs e)
        {
            //fileName;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            WebBrowser secondbrowser = new WebBrowser();
            secondbrowser.Show();
        }

        private void restartToolStripMenuItem_Click(object sender, EventArgs e){Application.Restart();}
    }
}
