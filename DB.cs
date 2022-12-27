using System.Data.SqlClient;

namespace DataBase
{
    class DB
    {
        SqlConnection sqlConnection = new SqlConnection(@"Data source=DESKTOP-LN1UKBQ\SQLEXPRESS;Initial Catalog=MinchenkoAN_shopbase;Integrated Security=True");

        public void openConnection()
        {
            if (sqlConnection.State == System.Data.ConnectionState.Closed)
            {
                sqlConnection.Open();
            }
        }

        public void closeConnection()
        {
            if (sqlConnection.State == System.Data.ConnectionState.Open)
            {
                sqlConnection.Close();
            }
        }

        public SqlConnection getConnection()
        {
            return sqlConnection;
        }
    }
}
