namespace PROYECTO_MAD
{
    partial class IniciarSesion
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
            this.InicarSesion_correoTxt = new System.Windows.Forms.TextBox();
            this.InicarSesion_contrasenaTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.InicarSesion_Btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // InicarSesion_correoTxt
            // 
            this.InicarSesion_correoTxt.Location = new System.Drawing.Point(218, 47);
            this.InicarSesion_correoTxt.Name = "InicarSesion_correoTxt";
            this.InicarSesion_correoTxt.Size = new System.Drawing.Size(100, 22);
            this.InicarSesion_correoTxt.TabIndex = 19;
            // 
            // InicarSesion_contrasenaTxt
            // 
            this.InicarSesion_contrasenaTxt.Location = new System.Drawing.Point(218, 98);
            this.InicarSesion_contrasenaTxt.Name = "InicarSesion_contrasenaTxt";
            this.InicarSesion_contrasenaTxt.Size = new System.Drawing.Size(100, 22);
            this.InicarSesion_contrasenaTxt.TabIndex = 18;
            this.InicarSesion_contrasenaTxt.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(92, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 16);
            this.label3.TabIndex = 17;
            this.label3.Text = "Correo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(92, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 16);
            this.label2.TabIndex = 16;
            this.label2.Text = "Contraseña";
            // 
            // InicarSesion_Btn
            // 
            this.InicarSesion_Btn.Location = new System.Drawing.Point(131, 181);
            this.InicarSesion_Btn.Name = "InicarSesion_Btn";
            this.InicarSesion_Btn.Size = new System.Drawing.Size(148, 61);
            this.InicarSesion_Btn.TabIndex = 22;
            this.InicarSesion_Btn.Text = "Inicar Sesion";
            this.InicarSesion_Btn.UseVisualStyleBackColor = true;
            this.InicarSesion_Btn.Click += new System.EventHandler(this.InicarSesion_Btn_Click);
            // 
            // IniciarSesion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 279);
            this.Controls.Add(this.InicarSesion_Btn);
            this.Controls.Add(this.InicarSesion_correoTxt);
            this.Controls.Add(this.InicarSesion_contrasenaTxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "IniciarSesion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IniciarSesion";
            this.Load += new System.EventHandler(this.IniciarSesion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox InicarSesion_correoTxt;
        private System.Windows.Forms.TextBox InicarSesion_contrasenaTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button InicarSesion_Btn;
    }
}