using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GMap
{
    class DatabaseRequester
    {
        private static NpgsqlConnection OpenDatabaseConnection()
        {
            string ServerAddr = "localhost";
            string ServerPort = "5432";
            string ServerDatabase = "huza";
            string ServerUname = "postgres";
            string ServerPassword = "password";
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
                if (conn.State == ConnectionState.Open) {
                    return conn;
                }
                else {
                    conn.Close();
                    throw new Exception("Connection made but not open");
                }
                
            }
            catch (Exception msg)
            {
                // something went wrong, and you wanna know why
                throw new Exception(msg.ToString());
            }
        }


        public static string getDataFromYear(string table, string wijk, string jaar)
        {
            string querystring;
            string data = "";
            NpgsqlConnection conn;
            NpgsqlCommand query;

            querystring = "select data from " + table + " where wijk='" + wijk + "' and year='" + jaar + "';";
            
            conn = OpenDatabaseConnection();
            
            query = new NpgsqlCommand(querystring, conn);
            
            data = (string)query.ExecuteScalar();
            conn.Close();
            return data;
        }
    }
}
