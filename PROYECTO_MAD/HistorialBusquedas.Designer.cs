namespace PROYECTO_MAD
{
    partial class HistorialBusquedas
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
            this.Historial_Eliminar_Btn = new System.Windows.Forms.Button();
            this.Historial_Historial_DG = new System.Windows.Forms.DataGridView();
            this.Historial_Volver_Btn = new System.Windows.Forms.Button();
            this.Historial_Versiculos_DG = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Historial_Historial_DG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Historial_Versiculos_DG)).BeginInit();
            this.SuspendLayout();
            // 
            // Historial_Eliminar_Btn
            // 
            this.Historial_Eliminar_Btn.Location = new System.Drawing.Point(77, 62);
            this.Historial_Eliminar_Btn.Name = "Historial_Eliminar_Btn";
            this.Historial_Eliminar_Btn.Size = new System.Drawing.Size(140, 56);
            this.Historial_Eliminar_Btn.TabIndex = 25;
            this.Historial_Eliminar_Btn.Text = "Eliminar Historial";
            this.Historial_Eliminar_Btn.UseVisualStyleBackColor = true;
            this.Historial_Eliminar_Btn.Click += new System.EventHandler(this.Historial_Eliminar_Btn_Click);
            // 
            // Historial_Historial_DG
            // 
            this.Historial_Historial_DG.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.Historial_Historial_DG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Historial_Historial_DG.Location = new System.Drawing.Point(426, 12);
            this.Historial_Historial_DG.Name = "Historial_Historial_DG";
            this.Historial_Historial_DG.RowHeadersWidth = 51;
            this.Historial_Historial_DG.RowTemplate.Height = 24;
            this.Historial_Historial_DG.Size = new System.Drawing.Size(521, 199);
            this.Historial_Historial_DG.TabIndex = 24;
            this.Historial_Historial_DG.SelectionChanged += new System.EventHandler(this.Historial_Historial_DG_SelectionChanged);
            // 
            // Historial_Volver_Btn
            // 
            this.Historial_Volver_Btn.Location = new System.Drawing.Point(77, 313);
            this.Historial_Volver_Btn.Name = "Historial_Volver_Btn";
            this.Historial_Volver_Btn.Size = new System.Drawing.Size(140, 59);
            this.Historial_Volver_Btn.TabIndex = 26;
            this.Historial_Volver_Btn.Text = "Volver";
            this.Historial_Volver_Btn.UseVisualStyleBackColor = true;
            this.Historial_Volver_Btn.Click += new System.EventHandler(this.Historial_Volver_Btn_Click);
            // 
            // Historial_Versiculos_DG
            // 
            this.Historial_Versiculos_DG.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.Historial_Versiculos_DG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Historial_Versiculos_DG.Location = new System.Drawing.Point(279, 230);
            this.Historial_Versiculos_DG.Name = "Historial_Versiculos_DG";
            this.Historial_Versiculos_DG.RowHeadersWidth = 51;
            this.Historial_Versiculos_DG.RowTemplate.Height = 24;
            this.Historial_Versiculos_DG.Size = new System.Drawing.Size(846, 199);
            this.Historial_Versiculos_DG.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(339, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 16);
            this.label1.TabIndex = 28;
            this.label1.Text = "Historial:";
            // 
            // HistorialBusquedas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1180, 461);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Historial_Versiculos_DG);
            this.Controls.Add(this.Historial_Volver_Btn);
            this.Controls.Add(this.Historial_Eliminar_Btn);
            this.Controls.Add(this.Historial_Historial_DG);
            this.Name = "HistorialBusquedas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HistorialBusquedas";
            this.Load += new System.EventHandler(this.HistorialBusquedas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Historial_Historial_DG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Historial_Versiculos_DG)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Historial_Eliminar_Btn;
        private System.Windows.Forms.DataGridView Historial_Historial_DG;
        private System.Windows.Forms.Button Historial_Volver_Btn;
        private System.Windows.Forms.DataGridView Historial_Versiculos_DG;
        private System.Windows.Forms.Label label1;
    }
}