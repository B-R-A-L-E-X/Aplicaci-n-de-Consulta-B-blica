namespace PROYECTO_MAD
{
    partial class DashBoard
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
            this.label3 = new System.Windows.Forms.Label();
            this.Dash_Editar_Btn = new System.Windows.Forms.Button();
            this.Dash_Favoritos_Btn = new System.Windows.Forms.Button();
            this.Dash_Versiculos_Btn = new System.Windows.Forms.Button();
            this.Dash_Busqueda_Btn = new System.Windows.Forms.Button();
            this.Dash_CerrarSesion_Btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(294, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 16);
            this.label3.TabIndex = 18;
            this.label3.Text = "Selecciona la Ventana ";
            // 
            // Dash_Editar_Btn
            // 
            this.Dash_Editar_Btn.Location = new System.Drawing.Point(110, 124);
            this.Dash_Editar_Btn.Name = "Dash_Editar_Btn";
            this.Dash_Editar_Btn.Size = new System.Drawing.Size(148, 61);
            this.Dash_Editar_Btn.TabIndex = 23;
            this.Dash_Editar_Btn.Text = "Edicion Usuario";
            this.Dash_Editar_Btn.UseVisualStyleBackColor = true;
            this.Dash_Editar_Btn.Click += new System.EventHandler(this.Dash_Editar_Btn_Click);
            // 
            // Dash_Favoritos_Btn
            // 
            this.Dash_Favoritos_Btn.Location = new System.Drawing.Point(467, 124);
            this.Dash_Favoritos_Btn.Name = "Dash_Favoritos_Btn";
            this.Dash_Favoritos_Btn.Size = new System.Drawing.Size(148, 61);
            this.Dash_Favoritos_Btn.TabIndex = 24;
            this.Dash_Favoritos_Btn.Text = "Versiculos Favoritos";
            this.Dash_Favoritos_Btn.UseVisualStyleBackColor = true;
            this.Dash_Favoritos_Btn.Click += new System.EventHandler(this.Dash_Favoritos_Btn_Click);
            // 
            // Dash_Versiculos_Btn
            // 
            this.Dash_Versiculos_Btn.Location = new System.Drawing.Point(110, 290);
            this.Dash_Versiculos_Btn.Name = "Dash_Versiculos_Btn";
            this.Dash_Versiculos_Btn.Size = new System.Drawing.Size(148, 61);
            this.Dash_Versiculos_Btn.TabIndex = 25;
            this.Dash_Versiculos_Btn.Text = "Versiculos";
            this.Dash_Versiculos_Btn.UseVisualStyleBackColor = true;
            this.Dash_Versiculos_Btn.Click += new System.EventHandler(this.Dash_Versiculos_Btn_Click);
            // 
            // Dash_Busqueda_Btn
            // 
            this.Dash_Busqueda_Btn.Location = new System.Drawing.Point(467, 290);
            this.Dash_Busqueda_Btn.Name = "Dash_Busqueda_Btn";
            this.Dash_Busqueda_Btn.Size = new System.Drawing.Size(148, 61);
            this.Dash_Busqueda_Btn.TabIndex = 26;
            this.Dash_Busqueda_Btn.Text = "Busqueda";
            this.Dash_Busqueda_Btn.UseVisualStyleBackColor = true;
            this.Dash_Busqueda_Btn.Click += new System.EventHandler(this.Dash_Busqueda_Btn_Click);
            // 
            // Dash_CerrarSesion_Btn
            // 
            this.Dash_CerrarSesion_Btn.Location = new System.Drawing.Point(297, 204);
            this.Dash_CerrarSesion_Btn.Name = "Dash_CerrarSesion_Btn";
            this.Dash_CerrarSesion_Btn.Size = new System.Drawing.Size(140, 59);
            this.Dash_CerrarSesion_Btn.TabIndex = 27;
            this.Dash_CerrarSesion_Btn.Text = "Cerrar Sesion";
            this.Dash_CerrarSesion_Btn.UseVisualStyleBackColor = true;
            this.Dash_CerrarSesion_Btn.Click += new System.EventHandler(this.Dash_CerrarSesion_Btn_Click);
            // 
            // DashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 450);
            this.Controls.Add(this.Dash_CerrarSesion_Btn);
            this.Controls.Add(this.Dash_Busqueda_Btn);
            this.Controls.Add(this.Dash_Versiculos_Btn);
            this.Controls.Add(this.Dash_Favoritos_Btn);
            this.Controls.Add(this.Dash_Editar_Btn);
            this.Controls.Add(this.label3);
            this.Name = "DashBoard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DashBoard";
            this.Load += new System.EventHandler(this.DashBoard_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Dash_Editar_Btn;
        private System.Windows.Forms.Button Dash_Favoritos_Btn;
        private System.Windows.Forms.Button Dash_Versiculos_Btn;
        private System.Windows.Forms.Button Dash_Busqueda_Btn;
        private System.Windows.Forms.Button Dash_CerrarSesion_Btn;
    }
}