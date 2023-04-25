namespace PROJET_PPE2._1_KARATE
{
    partial class Frm_GestionEntraineur_CS
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.Txt_Liste = new System.Windows.Forms.Label();
            this.Grid_Membres = new System.Windows.Forms.DataGridView();
            this.BTN_ListCompet = new System.Windows.Forms.Button();
            this.GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_Membres)).BeginInit();
            this.SuspendLayout();
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.Txt_Liste);
            this.GroupBox1.Location = new System.Drawing.Point(62, 19);
            this.GroupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GroupBox1.Size = new System.Drawing.Size(514, 58);
            this.GroupBox1.TabIndex = 14;
            this.GroupBox1.TabStop = false;
            // 
            // Txt_Liste
            // 
            this.Txt_Liste.AutoSize = true;
            this.Txt_Liste.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Liste.Location = new System.Drawing.Point(116, 17);
            this.Txt_Liste.Name = "Txt_Liste";
            this.Txt_Liste.Size = new System.Drawing.Size(279, 29);
            this.Txt_Liste.TabIndex = 10;
            this.Txt_Liste.Text = "LISTE DES MEMBRES";
            this.Txt_Liste.Click += new System.EventHandler(this.Label1_Click);
            // 
            // Grid_Membres
            // 
            this.Grid_Membres.AllowUserToAddRows = false;
            this.Grid_Membres.AllowUserToDeleteRows = false;
            this.Grid_Membres.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid_Membres.Location = new System.Drawing.Point(62, 97);
            this.Grid_Membres.MultiSelect = false;
            this.Grid_Membres.Name = "Grid_Membres";
            this.Grid_Membres.ReadOnly = true;
            this.Grid_Membres.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.Grid_Membres.RowTemplate.Height = 24;
            this.Grid_Membres.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Grid_Membres.ShowCellToolTips = false;
            this.Grid_Membres.ShowEditingIcon = false;
            this.Grid_Membres.Size = new System.Drawing.Size(514, 324);
            this.Grid_Membres.TabIndex = 15;
            this.Grid_Membres.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // BTN_ListCompet
            // 
            this.BTN_ListCompet.Location = new System.Drawing.Point(62, 432);
            this.BTN_ListCompet.Name = "BTN_ListCompet";
            this.BTN_ListCompet.Size = new System.Drawing.Size(181, 26);
            this.BTN_ListCompet.TabIndex = 16;
            this.BTN_ListCompet.Text = "Liste des competitions";
            this.BTN_ListCompet.UseVisualStyleBackColor = true;
            this.BTN_ListCompet.Click += new System.EventHandler(this.BTN_ListCompet_Click);
            // 
            // Frm_GestionEntraineur_CS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(640, 465);
            this.Controls.Add(this.BTN_ListCompet);
            this.Controls.Add(this.Grid_Membres);
            this.Controls.Add(this.GroupBox1);
            this.Name = "Frm_GestionEntraineur_CS";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Frm_GestionEntraineur_CS_Load);
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_Membres)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.Label Txt_Liste;
        private System.Windows.Forms.DataGridView Grid_Membres;
        private System.Windows.Forms.Button BTN_ListCompet;
    }
}

