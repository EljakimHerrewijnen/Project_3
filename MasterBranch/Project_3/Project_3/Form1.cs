﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;
using Npgsql;

namespace Project_3
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            _Form1 = this;
        }
        public static Form1 _Form1;

        public void update(string message)
        {
            textBox1.Text = message;   }

        public string GetParserTextBox { get { return Parser_Textbox.Text; } }

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
            Parser TheParser = new Parser();
            TheParser.CreateQuery();

        }

        public void Parser_Textbox_TextChanged(object sender, EventArgs e){        }
        private void button1_Click(object sender, EventArgs e){
            WebBrowser secondbrowser = new WebBrowser();
            secondbrowser.Show();
        }

        private void restartToolStripMenuItem_Click(object sender, EventArgs e){Application.Restart();}

        private void button2_Click(object sender, EventArgs e)
        {
            Parser_Textbox.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string connetionString = null;
            connetionString = "Server=127.0.0.1; Port=5432; User ID=postgres; Password=; Database=Project3;";
            NpgsqlConnection conn = new NpgsqlConnection(connetionString);
            try
            {
                conn.Open();
                MessageBox.Show("Connection Open!");
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can not open connection!");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "") { System.Windows.Forms.Clipboard.SetText(textBox1.Text); }
        }
    }
}
