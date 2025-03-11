using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace LibrarySystem.DATABASE
{
    internal class Mydb
    {
        private MySqlConnection connection = new MySqlConnection("server=localhost;port=3306;username=root;password=;database=library_db");
        public void openConnection()
        {
            if (connection.State == System.Data.ConnectionState.Closed)
            {
                connection.Open();
            }
        }
        public void closeConnection()
        {
            if (connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
            }
        }

        public MySqlConnection getConnection()
        {
            return connection;
        }

        public DataTable getData(string query, MySqlParameter[] parameters)
        {
            DataTable table = new DataTable();
            try
            {
                using (MySqlCommand command = new MySqlCommand(query, getConnection()))
                {
                    if (parameters != null)
                    {
                        command.Parameters.AddRange(parameters);
                    }

                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                    {
                        openConnection();
                        adapter.Fill(table);
                    }
                }
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("MySQL Exception: " + ex.Message);
            }
            finally
            {
                closeConnection();
            }
            return table;
        }

        public int setData(string query, MySqlParameter[] parameters)
        {
            MySqlCommand command = new MySqlCommand(query, getConnection());
            if (parameters != null)
            {
                command.Parameters.AddRange(parameters);
            }
            openConnection();
            int commandState = command.ExecuteNonQuery();
            closeConnection();
            return commandState;
        }
    }
}
