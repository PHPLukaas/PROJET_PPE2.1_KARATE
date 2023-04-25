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
    public partial class Frm_GestionEntraineur_CS : Form
    {
        public Frm_GestionEntraineur_CS()
        {
            InitializeComponent();
            MySqlConnection conn = DB.ConnectionBD();   
            conn.Open();

            string sql = "SELECT * FROM membre";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            MySqlDataReader reader = cmd.ExecuteReader();
            Grid_Membres.Columns.Add("Nom", "Nom");
            Grid_Membres.Columns.Add("Prenom", "Prénom");
            Grid_Membres.Columns.Add("Licsence", "Liscence");

            while (reader.Read())
            {
                Grid_Membres.Rows.Add(reader["NOM_MEMBRE"], reader["PRENOM_MEMBRE"], reader["NUM_LICENCE"]);
            }

            conn.Close();

        }

        internal string dataGridView1_CellContentClick(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        public void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Frm_GestionEntraineur_AJ inscription = new Frm_GestionEntraineur_AJ();
            inscription.Infos(Grid_Membres.CurrentRow.Cells[1].Value.ToString() + " " + Grid_Membres.CurrentRow.Cells[0].Value.ToString(), Grid_Membres.CurrentRow.Cells[2].Value.ToString());
            inscription.Show();


        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void BTN_ListCompet_Click(object sender, EventArgs e)
        {
            Frm_GestionEntraineur_COMPET liste = new Frm_GestionEntraineur_COMPET();
            liste.Show();
        }

        private void Frm_GestionEntraineur_CS_Load(object sender, EventArgs e)
        {

        }
    }
}
