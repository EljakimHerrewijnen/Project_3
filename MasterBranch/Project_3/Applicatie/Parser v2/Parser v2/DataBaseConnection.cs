using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using System.Data;
using System.Windows.Forms;

namespace Parser_v2
{
    class DataBaseConnection
    {
        public void ConnectDatabase()
        {
            string ServerAddr = ParserGUI._ParserGUI.Get_ServerAddress;
            string ServerPort = ParserGUI._ParserGUI.Get_ServerPort;
            string ServerDatabase = ParserGUI._ParserGUI.Get_ServerDatabase;
            string ServerUname = ParserGUI._ParserGUI.Get_ServerUname;
            string ServerPassword = ParserGUI._ParserGUI.Get_Output;
            try
            {
                // PostgeSQL-style connection string
                string connstring = String.Format("Server={0};Port={1};" +
                "User Id={2};Password={3};Database={4};",
                ServerAddr, ServerPort, ServerUname,
                ServerPassword, ServerDatabase);
                // Making connection with Npgsql provider
                NpgsqlConnection conn = new NpgsqlConnection(connstring);
                conn.Open();
                if (conn.State == ConnectionState.Open) { MessageBox.Show("Connection Open!"); ParserGUI._ParserGUI.update_LB_Server("Connected to database"); }
                else { MessageBox.Show("Connection not open!"); ParserGUI._ParserGUI.update_LB_Server("Not connected"); }
                conn.Close();
            }
            catch (Exception msg)
            {
                // something went wrong, and you wanna know why
                MessageBox.Show(msg.ToString());
            }
        }

        public void SendQuery()
        {
            string ServerAddr = ParserGUI._ParserGUI.Get_ServerAddress;
            string ServerPort = ParserGUI._ParserGUI.Get_ServerPort;
            string ServerDatabase = ParserGUI._ParserGUI.Get_ServerDatabase;
            string ServerUname = ParserGUI._ParserGUI.Get_ServerUname;
            string ServerPassword = ParserGUI._ParserGUI.Get_ServerUpass;
            string Output_TB = ParserGUI._ParserGUI.Get_Output;
            try
            {
                // PostgeSQL-style connection string
                string connstring = String.Format("Server={0};Port={1};" +
                "User Id={2};Password={3};Database={4};",
                ServerAddr, ServerPort, ServerUname,
                ServerPassword, ServerDatabase);
                // Making connection with Npgsql provider
                NpgsqlConnection conn = new NpgsqlConnection(connstring);
                conn.Open();
                if (conn.State == ConnectionState.Open) { MessageBox.Show("Connection Open!"); ParserGUI._ParserGUI.update_LB_Server("Connected to database"); }
                else { MessageBox.Show("Connection not open!"); ParserGUI._ParserGUI.update_LB_Server("Not connected"); }

                //Starting to send the Query
                NpgsqlCommand command = new NpgsqlCommand(Output_TB, conn);
                command.ExecuteNonQuery();
                MessageBox.Show("sended");


            }
            catch (Exception msg)
            {
                // something went wrong, and you wanna know why
                MessageBox.Show(msg.ToString());
            }

        }
    }
}
