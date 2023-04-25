using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace PROJET_PPE2._1_KARATE
{
    public partial class Frm_GestionEntraineur_COMPET : Form
    {
        public Frm_GestionEntraineur_COMPET()
        {
            InitializeComponent();
            MySqlConnection conn = DB.ConnectionBD();
            conn.Open();

            string sql = "SELECT compet.NUM_COMPETITION, compet.DATE_COMPETITION, c.NOM_CLUB FROM competition compet INNER JOIN club c ON c.NUM_CLUB = compet.NUM_CLUB;";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            MySqlDataReader reader = cmd.ExecuteReader();
            Grid_ListeCompet.Columns.Add("Numéro", "Numéro");
            Grid_ListeCompet.Columns.Add("Club", "Club");
            Grid_ListeCompet.Columns.Add("Date compet", "Date compet");

            while (reader.Read())
            {
                Grid_ListeCompet.Rows.Add(reader["NUM_COMPETITION"], reader["NOM_CLUB"], reader["DATE_COMPETITION"]);
            }



            conn.Close();
        }

        private void Grid_ListeCompet_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Frm_GestionEntraineur_MODIFCOMPET modif = new Frm_GestionEntraineur_MODIFCOMPET();
            modif.Infos(Grid_ListeCompet.CurrentRow.Cells[0].Value.ToString());
            modif.Show();
        }

        private void Frm_GestionEntraineur_COMPET_Load(object sender, EventArgs e)
        {

        }
    }
}
