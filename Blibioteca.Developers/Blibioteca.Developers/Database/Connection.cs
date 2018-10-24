using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blibioteca.Developers.Database
{
    class Connection
    {
        public MySqlConnection Create()
        {
            string connectionString = "server=ENDEREÇO;database=NOMEDOBANCO;uid=LOGIN;password=SENHA;sslmode=none";

            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            return connection;
        }
    }
}
