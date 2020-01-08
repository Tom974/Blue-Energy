
using MySql.Data.MySqlClient;

namespace Csharp_Login_And_Register
{
    // Je moet hiervoor xampp opstarten en apache + MySQL aanzetten, vervolgens moet je naar http://localhost/phpmyadmin gaan om de database te configureren.
    class DB
    {

       private MySqlConnection connection = new MySqlConnection("server=localhost;port=3306;username=iets;password=;database=Blue_Energy");


        // functie maken om de database mee te openen
        public void openConnection()
        {
            if(connection.State == System.Data.ConnectionState.Closed)
            {
                connection.Open();
            }
        }

        // functie maken om de database mee te sluiten
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
    }
}
