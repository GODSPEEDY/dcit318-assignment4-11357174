using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PharmacyApp
{
    public class DataAccessLayer
    {
        private string connectionString = "Data Source= LEFAB-BLACK;Initial Catalog=PharmacyDB;Integrated Security=True"; 

        public SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }

        
        public void ExecuteNonQuery(string storedProcedureName, SqlParameter[] parameters = null)
        {
            using (SqlConnection connection = GetConnection())
            {
                using (SqlCommand command = new SqlCommand(storedProcedureName, connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    if (parameters != null)
                    {
                        command.Parameters.AddRange(parameters);
                    }

                    try
                    {
                        connection.Open();
                        command.ExecuteNonQuery();
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show("Database Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An unexpected error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        
        public DataTable ExecuteReader(string storedProcedureName, SqlParameter[] parameters = null)
        {
            DataTable dt = new DataTable();
            using (SqlConnection connection = GetConnection())
            {
                using (SqlCommand command = new SqlCommand(storedProcedureName, connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    if (parameters != null)
                    {
                        command.Parameters.AddRange(parameters);
                    }

                    try
                    {
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            dt.Load(reader);
                        }
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show("Database Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An unexpected error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            return dt;
        }

       
        public object ExecuteScalar(string storedProcedureName, SqlParameter[] parameters = null)
        {
            object result = null;
            using (SqlConnection connection = GetConnection())
            {
                using (SqlCommand command = new SqlCommand(storedProcedureName, connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    if (parameters != null)
                    {
                        command.Parameters.AddRange(parameters);
                    }

                    try
                    {
                        connection.Open();
                        result = command.ExecuteScalar();
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show("Database Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An unexpected error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            return result;
        }
    }
}


