﻿using Oracle.ManagedDataAccess.Client;
using System.Data;
using System.Windows.Forms;

namespace ShreeWellnessCenter
{
    internal class db
    {
        public OracleConnection GetConnection()
        {
            OracleConnection conn = new OracleConnection
            {
                ConnectionString = "Data Source = localhost:1521 / XEPDB1; User ID = kalash; Password = kalash"
            };
            return conn;
        }
        public DataSet GetData(string query)
        {
            OracleConnection conn = GetConnection();
            OracleCommand cmd = new OracleCommand
            {
                Connection = conn,
                CommandText = query
            };
            OracleDataAdapter da = new OracleDataAdapter(cmd);
            DataSet dataSet = new DataSet();
            da.Fill(dataSet);
            return dataSet;
        }
        public void SetData(string query, string msg)
        {
            OracleConnection conn = GetConnection();
            OracleCommand cmd = new OracleCommand
            {
                Connection = conn
            };
            conn.Open();
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();
              
            conn.Close();
            MessageBox.Show(msg, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
          
        }
        public void SetData(string query)
        {
            OracleConnection conn = GetConnection();
            OracleCommand cmd = new OracleCommand
            {
                Connection = conn
            };
            conn.Open();
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();
            conn.Close();
        }


    }

}
