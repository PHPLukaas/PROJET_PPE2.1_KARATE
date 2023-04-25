using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace PROJET_PPE2._1_KARATE
{
    public partial class Frm_GestionEntraineur_MODIFCOMPET : Form
    {
        string numeroCompet;
        public Frm_GestionEntraineur_MODIFCOMPET()
        {
            InitializeComponent();
        }

        private void Frm_GestionEntraineur_MODIFCOMPET_Load(object sender, EventArgs e)
        {
            TXT_Result.Text = "Résultats de la competition n°" + numeroCompet;
            MySqlConnection conn = DB.ConnectionBD();
            MySqlConnection conn1 = DB.ConnectionBD();
            MySqlConnection conn2 = DB.ConnectionBD();
            conn.Open();
            conn1.Open();
            conn2.Open();

            string sql = "SELECT m.NUM_LICENCE, m.NOM_MEMBRE, m.PRENOM_MEMBRE, c.NOM_CLUB, i.NOTE_GLOBALE FROM inscription i INNER JOIN membre m ON i.NUM_LICENCE = m.NUM_LICENCE INNER JOIN club c ON m.NUM_CLUB = c.NUM_CLUB INNER JOIN competition com ON com.NUM_COMPETITION = i.NUM_COMPETITION WHERE i.NUM_COMPETITION = @IdCompet;";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@IdCompet", numeroCompet);
            using (MySqlDataReader reader = cmd.ExecuteReader())
            {
                Grid_Result.Columns.Add("Nom", "Prenom");
                Grid_Result.Columns.Add("Prénom", "Prénom");
                Grid_Result.Columns.Add("Club", "Club");
                Grid_Result.Columns.Add("Note Globale", "Note Globale");

                while (reader.Read())
                {
                    
                    string req = "SELECT * FROM note WHERE NUM_COMPETITION = @Compet AND NUM_LICENCE = @Num";
                    MySqlCommand cmdLOL = new MySqlCommand(req, conn1);
                    cmdLOL.Parameters.AddWithValue("@Compet", numeroCompet);
                    cmdLOL.Parameters.AddWithValue("@Num", reader["NUM_LICENCE"]);
                    float i = 0;
                    using (MySqlDataReader readerLOL = cmdLOL.ExecuteReader())
                    {                        
                        while (readerLOL.Read())
                        {
                            string note = readerLOL["NOTE"].ToString();
                            i = i + float.Parse(note);
                        }
                    }
                    string ins = "UPDATE inscription SET NOTE_GLOBALE = @Note WHERE NUM_COMPETITION = @Compet AND NUM_LICENCE = @Num";
                    MySqlCommand cmdBIGLOL = new MySqlCommand(ins, conn2);
                    cmdBIGLOL.Parameters.AddWithValue("@Note", i);
                    cmdBIGLOL.Parameters.AddWithValue("@Compet", numeroCompet);
                    cmdBIGLOL.Parameters.AddWithValue("@Num", reader["NUM_LICENCE"]);
                    cmdBIGLOL.ExecuteNonQuery();

                }
            }
            MySqlCommand cmd8 = new MySqlCommand(sql, conn);
            cmd8.Parameters.AddWithValue("@IdCompet", numeroCompet);
            using (MySqlDataReader reader8 = cmd8.ExecuteReader())
            {
                while (reader8.Read())
                {
                    Grid_Result.Rows.Add(reader8["NOM_MEMBRE"], reader8["PRENOM_MEMBRE"], reader8["NOM_CLUB"], reader8["NOTE_GLOBALE"]);
                }
            }
            conn1.Close();
            conn2.Close();

            string sql1 = "SELECT e.NOM_ENTRAINEUR, e.PRENOM_ENTRAINEUR, c.NOM_CLUB FROM juge j INNER JOIN entraineur e ON e.NUM_ENTRAINEUR = j.NUM_ENTRAINEUR INNER JOIN club c ON e.NUM_CLUB = c.NUM_CLUB WHERE j.NUM_COMPETITION = @IdCompeti;";
            MySqlCommand cmd1 = new MySqlCommand(sql1, conn);
            cmd1.Parameters.AddWithValue("@IdCompeti", numeroCompet);
            using (MySqlDataReader reader1 = cmd1.ExecuteReader())
            {
                Grid_Jury.Columns.Add("Nom", "Prenom");
                Grid_Jury.Columns.Add("Prénom", "Prénom");
                Grid_Jury.Columns.Add("Club", "Club");

                while (reader1.Read())
                {
                    Grid_Jury.Rows.Add(reader1["NOM_ENTRAINEUR"], reader1["PRENOM_ENTRAINEUR"], reader1["NOM_CLUB"]);
                }
            }
            conn.Close();
        }

        public void Infos(string numero)
        {
            numeroCompet = numero;
        }

        private void Grid_Result_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
