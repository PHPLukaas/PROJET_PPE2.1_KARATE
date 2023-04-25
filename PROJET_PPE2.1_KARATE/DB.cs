using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace PROJET_PPE2._1_KARATE
{
    internal class DB
    {
        public static MySqlConnection ConnectionBD()
        {
            // Création de la chaîne de connexion
            string connectionString = "SERVER=localhost; DATABASE=karate; UID=root; PASSWORD=";
            MySqlConnection conn = new MySqlConnection(connectionString);
            return conn;
        }
    }
}
