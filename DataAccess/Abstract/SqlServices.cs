using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public class SqlServices
    {
        readonly string conString = "Data Source=.; Database=DataKUTEZ; Integrated Security=True";
        SqlConnection connection;

        public SqlServices()
        {
            connection = new SqlConnection();
            connection.ConnectionString = conString;
        }
        SqlConnection OpenConnection()
        {

            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
            return connection;
        }
        void CloseConnection()
        {
            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
            }
        }
        public SqlCommand Execute(string commandText, params SqlParameter[] parameters)
        {
            SqlCommand command = new SqlCommand();
            command.CommandText = commandText;
            command.Connection = OpenConnection();
            command.CommandType = CommandType.Text;
            if (parameters != null)
            {
                command.Parameters.AddRange(parameters);
            }
            command.ExecuteNonQuery();
            CloseConnection();
            return command;
        }
        public SqlCommand Stored(string commandText, params SqlParameter[] parameters)
        {
            SqlCommand command = new SqlCommand();
            command.CommandText = commandText;
            command.Connection = OpenConnection();
            command.CommandType = CommandType.StoredProcedure;
            if (parameters != null)
            {
                command.Parameters.AddRange(parameters);
            }
            command.ExecuteNonQuery();
            CloseConnection();
            return command;
        }
        public SqlDataReader StoreReader(string commandText, params SqlParameter[] parameters)
        {
            SqlCommand command = new SqlCommand();
            command.CommandText = commandText;
            command.Connection = OpenConnection();
            command.CommandType = CommandType.StoredProcedure;
            if (parameters != null)
            {
                command.Parameters.AddRange(parameters);
            }
            SqlDataReader dataReader = command.ExecuteReader();
            return dataReader;
        }
        public DataTable GetDataTable(string commandText, params SqlParameter[] parameters)
        {
            SqlDataAdapter dataAdapter = new SqlDataAdapter();
            dataAdapter.SelectCommand = Stored(commandText, parameters);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            return dataTable;
        }
    }
}
