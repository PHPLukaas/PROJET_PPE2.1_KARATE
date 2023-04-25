namespace PROJET_PPE2._1_KARATE
{
    partial class Frm_GestionEntraineur_MODIFCOMPET
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
            this.label1 = new System.Windows.Forms.Label();
            this.TXT_Result = new System.Windows.Forms.Label();
            this.Grid_Result = new System.Windows.Forms.DataGridView();
            this.Grid_Jury = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_Result)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_Jury)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(441, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 16);
            this.label1.TabIndex = 0;
            // 
            // TXT_Result
            // 
            this.TXT_Result.AutoSize = true;
            this.TXT_Result.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXT_Result.Location = new System.Drawing.Point(216, 30);
            this.TXT_Result.Name = "TXT_Result";
            this.TXT_Result.Size = new System.Drawing.Size(359, 29);
            this.TXT_Result.TabIndex = 12;
            this.TXT_Result.Text = "Résultats de la competition n°";
            // 
            // Grid_Result
            // 
            this.Grid_Result.AllowUserToAddRows = false;
            this.Grid_Result.AllowUserToDeleteRows = false;
            this.Grid_Result.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid_Result.Enabled = false;
            this.Grid_Result.Location = new System.Drawing.Point(32, 81);
            this.Grid_Result.Name = "Grid_Result";
            this.Grid_Result.ReadOnly = true;
            this.Grid_Result.RowHeadersWidth = 51;
            this.Grid_Result.RowTemplate.Height = 24;
            this.Grid_Result.Size = new System.Drawing.Size(725, 243);
            this.Grid_Result.TabIndex = 13;
            this.Grid_Result.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Grid_Result_CellContentClick);
            // 
            // Grid_Jury
            // 
            this.Grid_Jury.AllowUserToAddRows = false;
            this.Grid_Jury.AllowUserToDeleteRows = false;
            this.Grid_Jury.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid_Jury.Enabled = false;
            this.Grid_Jury.Location = new System.Drawing.Point(32, 390);
            this.Grid_Jury.Name = "Grid_Jury";
            this.Grid_Jury.ReadOnly = true;
            this.Grid_Jury.RowHeadersWidth = 51;
            this.Grid_Jury.RowTemplate.Height = 24;
            this.Grid_Jury.Size = new System.Drawing.Size(725, 159);
            this.Grid_Jury.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 349);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(269, 29);
            this.label2.TabIndex = 15;
            this.label2.Text = "Jury de la competition";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Frm_GestionEntraineur_MODIFCOMPET
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 561);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Grid_Jury);
            this.Controls.Add(this.Grid_Result);
            this.Controls.Add(this.TXT_Result);
            this.Controls.Add(this.label1);
            this.Name = "Frm_GestionEntraineur_MODIFCOMPET";
            this.Text = "Frm_GestionEntraineur_MODIFCOMPET";
            this.Load += new System.EventHandler(this.Frm_GestionEntraineur_MODIFCOMPET_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Grid_Result)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_Jury)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        internal System.Windows.Forms.Label TXT_Result;
        private System.Windows.Forms.DataGridView Grid_Result;
        private System.Windows.Forms.DataGridView Grid_Jury;
        internal System.Windows.Forms.Label label2;
    }
}