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
    public partial class Frm_GestionEntraineur_AJ : Form
    {
        string nomMembre;
        string liscMembre;
        public Frm_GestionEntraineur_AJ()
        {
            InitializeComponent();
            
        }


        public void Infos(string nom, string lics)
        {
           nomMembre = nom;
           liscMembre = lics;
        }

        private void Frm_GestionEntraineur_AJ_Load(object sender, EventArgs e)
        {
            CheckVide();
            Txt_Nom.Text = nomMembre;
            txt_Desc.Text = "Liste des competitions ou " + nomMembre + " est déjà inscrit";
            Txt_Insc.Text = "Inscrire " + nomMembre + " à une compétition ou il n'est pas inscrit";
            TXT_Desinscrire.Text = "Désinscrire " + nomMembre + " d'une competition a laquelle il est inscrit";

            MySqlConnection conn = DB.ConnectionBD();
            conn.Open();

            string sql = "SELECT * FROM inscription i INNER JOIN competition c ON i.NUM_COMPETITION = c.NUM_COMPETITION INNER JOIN club l on l.NUM_CLUB = c.NUM_CLUB WHERE NUM_LICENCE = @Numliscense;";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@Numliscense", liscMembre);
            using (MySqlDataReader reader = cmd.ExecuteReader())
            {
                Grid_DejaInsc.Columns.Add("Competition", "Competition");
                Grid_DejaInsc.Columns.Add("Club organisateur", "Club");
                Grid_DejaInsc.Columns.Add("Note", "Note");

                while (reader.Read())
                {
                    Grid_DejaInsc.Rows.Add(reader["NUM_COMPETITION"], reader["NOM_CLUB"], reader["NOTE_GLOBALE"]);
                }
            }

            string sql1 = "SELECT compet.NUM_COMPETITION, club.NOM_CLUB FROM competition compet INNER JOIN club club ON compet.NUM_CLUB = club.NUM_CLUB WHERE compet.NUM_COMPETITION NOT IN ( SELECT NUM_COMPETITION FROM inscription WHERE NUM_LICENCE = @Numliscense );";
            MySqlCommand cmd1 = new MySqlCommand(sql1, conn);
            cmd1.Parameters.AddWithValue("@Numliscense", liscMembre);
            using (MySqlDataReader reader1 = cmd1.ExecuteReader())
            {

                while (reader1.Read())
                {
                    SEL_Compet.Items.Add(reader1["NUM_COMPETITION"]);
                    
                }

                
            }

            string sql4 = "SELECT NUM_COMPETITION FROM inscription WHERE NUM_LICENCE = @Numliscense;";
            MySqlCommand cmd4 = new MySqlCommand(sql4, conn);
            cmd4.Parameters.AddWithValue("@Numliscense", liscMembre);
            using (MySqlDataReader reader4 = cmd4.ExecuteReader())
            {

                while (reader4.Read())
                {
                    SEL_Desincrire.Items.Add(reader4["NUM_COMPETITION"]);

                }


            }

            conn.Close();
        }

        private void Txt_Inscription_Click(object sender, EventArgs e)
        {

        }

        private void Grid_DejaInsc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BTN_Ajouter_Click(object sender, EventArgs e)
        {

            string numCompet = SEL_Compet.SelectedItem.ToString();

            MySqlConnection conn = DB.ConnectionBD();
            conn.Open();

            string sql = "INSERT INTO inscription VALUES (@NumCompet, @Numliscense, NULL)";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@Numliscense", liscMembre);
            cmd.Parameters.AddWithValue("@NumCompet", numCompet);

            cmd.ExecuteNonQuery();
            

            SEL_Compet.Items.Remove(SEL_Compet.SelectedItem);
            CheckVide();
            Grid_DejaInsc.Rows.Clear();
            Grid_DejaInsc.Refresh();

            string sql3 = "SELECT * FROM inscription i INNER JOIN competition c ON i.NUM_COMPETITION = c.NUM_COMPETITION INNER JOIN club l on l.NUM_CLUB = c.NUM_CLUB WHERE NUM_LICENCE = @Numliscense;";
            MySqlCommand cmd3 = new MySqlCommand(sql3, conn);
            cmd3.Parameters.AddWithValue("@Numliscense", liscMembre);
            using (MySqlDataReader reader3 = cmd3.ExecuteReader())
            {
                Grid_DejaInsc.Columns.Add("Competition", "Competition");
                Grid_DejaInsc.Columns.Add("Club organisateur", "Club");
                Grid_DejaInsc.Columns.Add("Note", "Note");

                while (reader3.Read())
                {
                    Grid_DejaInsc.Rows.Add(reader3["NUM_COMPETITION"], reader3["NOM_CLUB"], reader3["NOTE_GLOBALE"]);
                }
            }

            SEL_Desincrire.Items.Clear();
            string sql4 = "SELECT NUM_COMPETITION FROM inscription WHERE NUM_LICENCE = @Numliscense;";
            MySqlCommand cmd4 = new MySqlCommand(sql4, conn);
            cmd4.Parameters.AddWithValue("@Numliscense", liscMembre);
            using (MySqlDataReader reader4 = cmd4.ExecuteReader())
            {

                while (reader4.Read())
                {
                    SEL_Desincrire.Items.Add(reader4["NUM_COMPETITION"]);

                }


            }
            conn.Close();

        }

        private void SEL_Compet_SelectedIndexChanged(object sender, EventArgs e)
        {
            CheckVide();
        }

        private void CheckVide()
        {
            Grid_DejaInsc.Refresh();
            if (SEL_Compet.SelectedItem == null)
            {
                BTN_Ajouter.Enabled = false;
            }
            else { 
                BTN_Ajouter.Enabled = true;
            }
            if (SEL_Desincrire.SelectedItem == null)
            {
                BTN_Del.Enabled = false;
            }
            else
            {
                BTN_Del.Enabled = true;
            }
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void BTN_Del_Click(object sender, EventArgs e)
        {
            string numCompet = SEL_Desincrire.SelectedItem.ToString();

            MySqlConnection conn = DB.ConnectionBD();
            conn.Open();

            string sql = "DELETE FROM inscription WHERE NUM_COMPETITION = @NumCompet AND NUM_LICENCE = @Numliscense";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@Numliscense", liscMembre);
            cmd.Parameters.AddWithValue("@NumCompet", numCompet);

            cmd.ExecuteNonQuery();


            SEL_Desincrire.Items.Remove(SEL_Desincrire.SelectedItem);
            CheckVide();
            Grid_DejaInsc.Rows.Clear();
            Grid_DejaInsc.Refresh();

            string sql3 = "SELECT * FROM inscription i INNER JOIN competition c ON i.NUM_COMPETITION = c.NUM_COMPETITION INNER JOIN club l on l.NUM_CLUB = c.NUM_CLUB WHERE NUM_LICENCE = @Numliscense;";
            MySqlCommand cmd3 = new MySqlCommand(sql3, conn);
            cmd3.Parameters.AddWithValue("@Numliscense", liscMembre);
            using (MySqlDataReader reader3 = cmd3.ExecuteReader())
            {
                Grid_DejaInsc.Columns.Add("Competition", "Competition");
                Grid_DejaInsc.Columns.Add("Club organisateur", "Club");
                Grid_DejaInsc.Columns.Add("Note", "Note");

                while (reader3.Read())
                {
                    Grid_DejaInsc.Rows.Add(reader3["NUM_COMPETITION"], reader3["NOM_CLUB"], reader3["NOTE_GLOBALE"]);
                }
            }

            SEL_Compet.Items.Clear();
            string sql1 = "SELECT compet.NUM_COMPETITION, club.NOM_CLUB FROM competition compet INNER JOIN club club ON compet.NUM_CLUB = club.NUM_CLUB WHERE compet.NUM_COMPETITION NOT IN ( SELECT NUM_COMPETITION FROM inscription WHERE NUM_LICENCE = @Numliscense );";
            MySqlCommand cmd1 = new MySqlCommand(sql1, conn);
            cmd1.Parameters.AddWithValue("@Numliscense", liscMembre);
            using (MySqlDataReader reader1 = cmd1.ExecuteReader())
            {

                while (reader1.Read())
                {
                    SEL_Compet.Items.Add(reader1["NUM_COMPETITION"]);

                }


            }

            conn.Close();
        }
    }
}
