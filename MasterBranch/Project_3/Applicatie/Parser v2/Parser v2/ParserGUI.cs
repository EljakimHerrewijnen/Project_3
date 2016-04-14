using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parser_v2
{
    public partial class ParserGUI : Form
    {
        public string FileToParse;
        public string Query;
        public ParserGUI()
        {
            InitializeComponent();
            _ParserGUI = this;
        }
        public static ParserGUI _ParserGUI;
        public void update_output(string message){ TB_Output.Text = message; }
        public string Get_Input{ get{ return TB_Input.Text; }}

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void newFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Text Files (.txt)|*.txt|All Files (*.*)|*.*";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.Multiselect = false;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string file = openFileDialog1.FileName;
                TB_Input.Text = file;
                using (StreamReader sr = new StreamReader(file)) { TB_Input.Text = sr.ReadToEnd(); }
            }
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e){}

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            FileToParse = ParserGUI._ParserGUI.Get_Input;
            Parser parser = new Parser(FileToParse);
            Query = parser.dataToSql();
            TB_Output.Text = Query;
            System.Console.Write(Query);
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }
    }
}
