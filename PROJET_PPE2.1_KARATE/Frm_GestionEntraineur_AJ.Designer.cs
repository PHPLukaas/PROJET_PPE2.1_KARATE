namespace PROJET_PPE2._1_KARATE
{
    partial class Frm_GestionEntraineur_AJ
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Txt_Nom = new System.Windows.Forms.Label();
            this.txt_Desc = new System.Windows.Forms.Label();
            this.Grid_DejaInsc = new System.Windows.Forms.DataGridView();
            this.SEL_Compet = new System.Windows.Forms.ComboBox();
            this.Txt_Insc = new System.Windows.Forms.Label();
            this.BTN_Ajouter = new System.Windows.Forms.Button();
            this.TXT_Desinscrire = new System.Windows.Forms.Label();
            this.BTN_Del = new System.Windows.Forms.Button();
            this.SEL_Desincrire = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_DejaInsc)).BeginInit();
            this.SuspendLayout();
            // 
            // Txt_Nom
            // 
            this.Txt_Nom.AutoSize = true;
            this.Txt_Nom.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.Txt_Nom.Location = new System.Drawing.Point(90, 30);
            this.Txt_Nom.Name = "Txt_Nom";
            this.Txt_Nom.Size = new System.Drawing.Size(44, 39);
            this.Txt_Nom.TabIndex = 0;
            this.Txt_Nom.Text = "...";
            this.Txt_Nom.Click += new System.EventHandler(this.Txt_Inscription_Click);
            // 
            // txt_Desc
            // 
            this.txt_Desc.AutoSize = true;
            this.txt_Desc.Location = new System.Drawing.Point(94, 82);
            this.txt_Desc.Name = "txt_Desc";
            this.txt_Desc.Size = new System.Drawing.Size(255, 16);
            this.txt_Desc.TabIndex = 1;
            this.txt_Desc.Text = "LIste des competitions ou .. est déjà inscrit";
            // 
            // Grid_DejaInsc
            // 
            this.Grid_DejaInsc.AllowUserToAddRows = false;
            this.Grid_DejaInsc.AllowUserToDeleteRows = false;
            this.Grid_DejaInsc.AllowUserToOrderColumns = true;
            this.Grid_DejaInsc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid_DejaInsc.Enabled = false;
            this.Grid_DejaInsc.Location = new System.Drawing.Point(97, 123);
            this.Grid_DejaInsc.MultiSelect = false;
            this.Grid_DejaInsc.Name = "Grid_DejaInsc";
            this.Grid_DejaInsc.ReadOnly = true;
            this.Grid_DejaInsc.RowHeadersWidth = 100;
            this.Grid_DejaInsc.RowTemplate.Height = 24;
            this.Grid_DejaInsc.Size = new System.Drawing.Size(538, 191);
            this.Grid_DejaInsc.TabIndex = 2;
            this.Grid_DejaInsc.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Grid_DejaInsc_CellContentClick);
            // 
            // SEL_Compet
            // 
            this.SEL_Compet.FormattingEnabled = true;
            this.SEL_Compet.Location = new System.Drawing.Point(97, 368);
            this.SEL_Compet.Name = "SEL_Compet";
            this.SEL_Compet.Size = new System.Drawing.Size(444, 24);
            this.SEL_Compet.TabIndex = 3;
            this.SEL_Compet.SelectedIndexChanged += new System.EventHandler(this.SEL_Compet_SelectedIndexChanged);
            // 
            // Txt_Insc
            // 
            this.Txt_Insc.AutoSize = true;
            this.Txt_Insc.Location = new System.Drawing.Point(94, 337);
            this.Txt_Insc.Name = "Txt_Insc";
            this.Txt_Insc.Size = new System.Drawing.Size(288, 16);
            this.Txt_Insc.TabIndex = 4;
            this.Txt_Insc.Text = "Inscrire .. à une compétition ou il n\'est pas inscrit";
            this.Txt_Insc.Click += new System.EventHandler(this.label1_Click);
            // 
            // BTN_Ajouter
            // 
            this.BTN_Ajouter.Location = new System.Drawing.Point(560, 367);
            this.BTN_Ajouter.Name = "BTN_Ajouter";
            this.BTN_Ajouter.Size = new System.Drawing.Size(75, 24);
            this.BTN_Ajouter.TabIndex = 5;
            this.BTN_Ajouter.Text = "Ajouter";
            this.BTN_Ajouter.UseVisualStyleBackColor = true;
            this.BTN_Ajouter.Click += new System.EventHandler(this.BTN_Ajouter_Click);
            // 
            // TXT_Desinscrire
            // 
            this.TXT_Desinscrire.AutoSize = true;
            this.TXT_Desinscrire.Location = new System.Drawing.Point(94, 412);
            this.TXT_Desinscrire.Name = "TXT_Desinscrire";
            this.TXT_Desinscrire.Size = new System.Drawing.Size(324, 16);
            this.TXT_Desinscrire.TabIndex = 6;
            this.TXT_Desinscrire.Text = "Désinscrire ... d\'une competition a laquelle il est inscrit";
            this.TXT_Desinscrire.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // BTN_Del
            // 
            this.BTN_Del.Location = new System.Drawing.Point(548, 446);
            this.BTN_Del.Name = "BTN_Del";
            this.BTN_Del.Size = new System.Drawing.Size(87, 24);
            this.BTN_Del.TabIndex = 8;
            this.BTN_Del.Text = "Désinscrire";
            this.BTN_Del.UseVisualStyleBackColor = true;
            this.BTN_Del.Click += new System.EventHandler(this.BTN_Del_Click);
            // 
            // SEL_Desincrire
            // 
            this.SEL_Desincrire.FormattingEnabled = true;
            this.SEL_Desincrire.Location = new System.Drawing.Point(97, 447);
            this.SEL_Desincrire.Name = "SEL_Desincrire";
            this.SEL_Desincrire.Size = new System.Drawing.Size(433, 24);
            this.SEL_Desincrire.TabIndex = 7;
            this.SEL_Desincrire.SelectedIndexChanged += new System.EventHandler(this.SEL_Compet_SelectedIndexChanged);
            // 
            // Frm_GestionEntraineur_AJ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(813, 547);
            this.Controls.Add(this.BTN_Del);
            this.Controls.Add(this.SEL_Desincrire);
            this.Controls.Add(this.TXT_Desinscrire);
            this.Controls.Add(this.BTN_Ajouter);
            this.Controls.Add(this.Txt_Insc);
            this.Controls.Add(this.SEL_Compet);
            this.Controls.Add(this.Grid_DejaInsc);
            this.Controls.Add(this.txt_Desc);
            this.Controls.Add(this.Txt_Nom);
            this.Name = "Frm_GestionEntraineur_AJ";
            this.Text = "Frm_GestionEntraineur_AJ";
            this.Load += new System.EventHandler(this.Frm_GestionEntraineur_AJ_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Grid_DejaInsc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Txt_Nom;
        private System.Windows.Forms.Label txt_Desc;
        private System.Windows.Forms.DataGridView Grid_DejaInsc;
        private System.Windows.Forms.ComboBox SEL_Compet;
        private System.Windows.Forms.Label Txt_Insc;
        private System.Windows.Forms.Button BTN_Ajouter;
        private System.Windows.Forms.Label TXT_Desinscrire;
        private System.Windows.Forms.Button BTN_Del;
        private System.Windows.Forms.ComboBox SEL_Desincrire;
    }
}