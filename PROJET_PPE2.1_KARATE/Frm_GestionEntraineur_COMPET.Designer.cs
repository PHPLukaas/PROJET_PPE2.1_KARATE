namespace PROJET_PPE2._1_KARATE
{
    partial class Frm_GestionEntraineur_COMPET
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TXT_COMPET = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Grid_ListeCompet = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_ListeCompet)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TXT_COMPET);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(38, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(578, 64);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // TXT_COMPET
            // 
            this.TXT_COMPET.AutoSize = true;
            this.TXT_COMPET.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXT_COMPET.Location = new System.Drawing.Point(123, 18);
            this.TXT_COMPET.Name = "TXT_COMPET";
            this.TXT_COMPET.Size = new System.Drawing.Size(348, 29);
            this.TXT_COMPET.TabIndex = 11;
            this.TXT_COMPET.Text = "LISTE DES COMPETITIONS";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(285, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 16);
            this.label1.TabIndex = 0;
            // 
            // Grid_ListeCompet
            // 
            this.Grid_ListeCompet.AllowUserToAddRows = false;
            this.Grid_ListeCompet.AllowUserToDeleteRows = false;
            this.Grid_ListeCompet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid_ListeCompet.Location = new System.Drawing.Point(38, 101);
            this.Grid_ListeCompet.MultiSelect = false;
            this.Grid_ListeCompet.Name = "Grid_ListeCompet";
            this.Grid_ListeCompet.ReadOnly = true;
            this.Grid_ListeCompet.RowHeadersWidth = 51;
            this.Grid_ListeCompet.RowTemplate.Height = 24;
            this.Grid_ListeCompet.Size = new System.Drawing.Size(578, 275);
            this.Grid_ListeCompet.TabIndex = 1;
            this.Grid_ListeCompet.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Grid_ListeCompet_CellClick);
            // 
            // Frm_GestionEntraineur_COMPET
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(657, 450);
            this.Controls.Add(this.Grid_ListeCompet);
            this.Controls.Add(this.groupBox1);
            this.Name = "Frm_GestionEntraineur_COMPET";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Frm_GestionEntraineur_COMPET_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_ListeCompet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        internal System.Windows.Forms.Label TXT_COMPET;
        private System.Windows.Forms.DataGridView Grid_ListeCompet;
    }
}