using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace WarehouseProject
{
    class Db
    {
        SqlConnection sqlConnection = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=warehouse;Integrated Security=True");

        public void openConnection() {
            if (sqlConnection.State == System.Data.ConnectionState.Closed)
            {
                sqlConnection.Open();
            }
        }

        public void closeConnection() {
            if (sqlConnection.State != System.Data.ConnectionState.Closed) {
                sqlConnection.Close();
            }
        }

        public SqlConnection GetConnection() {
            return sqlConnection;
        }
    }
}
