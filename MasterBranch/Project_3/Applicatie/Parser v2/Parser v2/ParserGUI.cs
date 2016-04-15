﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Npgsql;

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
        public void update_output(string message) { TB_Output.Text = message; }
        public string Get_Input { get { return TB_Input.Text; } }
        public string Get_ServerAddress { get { return TB_ServerAddr.Text; } }
        public string Get_ServerPort { get { return TB_ServerPort.Text; } }
        public string Get_ServerDatabase { get { return TB_DataName.Text; } }
        public string Get_ServerUname { get { return TB_ServerUname.Text; } }
        public string Get_ServerUpass { get { return TB_ServerUpass.Text; } }
        public void update_LB_Server(string message) { LB_ServerConnected.Text = message; }
        public string Get_LB_Server { get { return LB_ServerConnected.Text; } }

        public void button3_Click(object sender, EventArgs e)
        {
            DataBaseConnection Connected = new DataBaseConnection();
            Connected.ConnectDatabase();
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
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (TB_Output.Text != "") { System.Windows.Forms.Clipboard.SetText(TB_Output.Text); }
        }

        private void Btn_Copy_Input_Click(object sender, EventArgs e)
        {
            if (TB_Output.Text != "") { System.Windows.Forms.Clipboard.SetText(TB_Output.Text); }
            DataBaseConnection Connected = new DataBaseConnection();
            Connected.ConnectDatabase();
            Connected.SendQuery();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TB_Input.Text = "";
        }
    }
}

