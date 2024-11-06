namespace PROYECTO_MAD
{
    partial class Favoritos
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
            this.Favoritos_DG = new System.Windows.Forms.DataGridView();
            this.Favs_Volver_Btn = new System.Windows.Forms.Button();
            this.Favoritos_Fav_Btn = new System.Windows.Forms.Button();
            this.Favoritos_idTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Favoritos_DG)).BeginInit();
            this.SuspendLayout();
            // 
            // Favoritos_DG
            // 
            this.Favoritos_DG.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.Favoritos_DG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Favoritos_DG.Location = new System.Drawing.Point(105, 34);
            this.Favoritos_DG.Name = "Favoritos_DG";
            this.Favoritos_DG.RowHeadersWidth = 51;
            this.Favoritos_DG.RowTemplate.Height = 24;
            this.Favoritos_DG.Size = new System.Drawing.Size(778, 271);
            this.Favoritos_DG.TabIndex = 14;
            this.Favoritos_DG.SelectionChanged += new System.EventHandler(this.Favoritos_DG_SelectionChanged);
            // 
            // Favs_Volver_Btn
            // 
            this.Favs_Volver_Btn.Location = new System.Drawing.Point(247, 340);
            this.Favs_Volver_Btn.Name = "Favs_Volver_Btn";
            this.Favs_Volver_Btn.Size = new System.Drawing.Size(140, 59);
            this.Favs_Volver_Btn.TabIndex = 15;
            this.Favs_Volver_Btn.Text = "Volver";
            this.Favs_Volver_Btn.UseVisualStyleBackColor = true;
            this.Favs_Volver_Btn.Click += new System.EventHandler(this.Favs_Volver_Btn_Click);
            // 
            // Favoritos_Fav_Btn
            // 
            this.Favoritos_Fav_Btn.Location = new System.Drawing.Point(950, 140);
            this.Favoritos_Fav_Btn.Name = "Favoritos_Fav_Btn";
            this.Favoritos_Fav_Btn.Size = new System.Drawing.Size(140, 56);
            this.Favoritos_Fav_Btn.TabIndex = 23;
            this.Favoritos_Fav_Btn.Text = "Eliminar Versiculo Favorito";
            this.Favoritos_Fav_Btn.UseVisualStyleBackColor = true;
            this.Favoritos_Fav_Btn.Click += new System.EventHandler(this.Favoritos_Fav_Btn_Click);
            // 
            // Favoritos_idTxt
            // 
            this.Favoritos_idTxt.Enabled = false;
            this.Favoritos_idTxt.Location = new System.Drawing.Point(1031, 90);
            this.Favoritos_idTxt.Name = "Favoritos_idTxt";
            this.Favoritos_idTxt.Size = new System.Drawing.Size(100, 22);
            this.Favoritos_idTxt.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(910, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 16);
            this.label1.TabIndex = 21;
            this.label1.Text = "Versiculo ID";
            // 
            // Favoritos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1179, 450);
            this.Controls.Add(this.Favoritos_Fav_Btn);
            this.Controls.Add(this.Favoritos_idTxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Favs_Volver_Btn);
            this.Controls.Add(this.Favoritos_DG);
            this.Name = "Favoritos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Favoritos";
            this.Load += new System.EventHandler(this.Favoritos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Favoritos_DG)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Favoritos_DG;
        private System.Windows.Forms.Button Favs_Volver_Btn;
        private System.Windows.Forms.Button Favoritos_Fav_Btn;
        private System.Windows.Forms.TextBox Favoritos_idTxt;
        private System.Windows.Forms.Label label1;
    }
}