using System;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace VolleyballRecruitmentApp
{
    public class DataBase : IDisposable
    {
        private static DataBase? instance = null;
        private readonly string connectionString;
        public SqlConnection Connection { get; private set; }

        public static DataBase Instance
        {
            get
            {
                instance ??= new DataBase();
                return instance;
            }
        }

        private DataBase()
        {
            connectionString = "Server=127.0.0.1;Database=VolleyballRecruitmentAgency;User ID=your_username;Password=your_password;";
            try
            {
                Connection = new SqlConnection(connectionString);
                Connection.Open();
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Database connection failed: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw; // Optionally rethrow to handle this in the application
            }
        }

        public void Dispose()
        {
            Connection?.Dispose();
            instance = null;
        }
    }
}
