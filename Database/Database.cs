namespace ERP_System;
using TECHCOOL.UI;
using Microsoft.Data.SqlClient;


// Singleton-del af Database-klassen, sikrer én global instans
public partial class Database
{
    public static Database Instance { get; set; }

    public Database()
    {
        if (Instance == null)
        {
            Instance = this;
        }
    }

       private SqlConnection? _connection;
        private SqlConnection GetConnection()
        {
            try
            {
                SqlConnectionStringBuilder builder = new();
                builder.DataSource = "DESKTOP-0PBVOB5";
                builder.UserID = "Gruppe_Simon_Mikkel";
                builder.Password = "simon123";
                builder.InitialCatalog = "ERP_SYSTEM";
                builder.TrustServerCertificate = true;

                _connection = new SqlConnection(builder.ToString());
                _connection.Open();
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            return _connection;
        }
}
