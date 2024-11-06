namespace PROYECTO_MAD
{
    partial class Form1
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
            this.insertarUsuarioBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.correoTxt = new System.Windows.Forms.TextBox();
            this.contrasenaTxt = new System.Windows.Forms.TextBox();
            this.nombreTxt = new System.Windows.Forms.TextBox();
            this.fechaNacimientoDtPk = new System.Windows.Forms.DateTimePicker();
            this.generoRdH = new System.Windows.Forms.RadioButton();
            this.generoRdM = new System.Windows.Forms.RadioButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // insertarUsuarioBtn
            // 
            this.insertarUsuarioBtn.Location = new System.Drawing.Point(539, 289);
            this.insertarUsuarioBtn.Name = "insertarUsuarioBtn";
            this.insertarUsuarioBtn.Size = new System.Drawing.Size(140, 81);
            this.insertarUsuarioBtn.TabIndex = 0;
            this.insertarUsuarioBtn.Text = "Agregar Usuario";
            this.insertarUsuarioBtn.UseVisualStyleBackColor = true;
            this.insertarUsuarioBtn.Click += new System.EventHandler(this.insertarUsuarioBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Correo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Contraseña";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nombre";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 242);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Fecha Nacimiento";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 331);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "Genero";
            // 
            // correoTxt
            // 
            this.correoTxt.Location = new System.Drawing.Point(158, 60);
            this.correoTxt.Name = "correoTxt";
            this.correoTxt.Size = new System.Drawing.Size(100, 22);
            this.correoTxt.TabIndex = 7;
            this.correoTxt.TextChanged += new System.EventHandler(this.correoTxt_TextChanged);
            // 
            // contrasenaTxt
            // 
            this.contrasenaTxt.Location = new System.Drawing.Point(158, 114);
            this.contrasenaTxt.Name = "contrasenaTxt";
            this.contrasenaTxt.Size = new System.Drawing.Size(100, 22);
            this.contrasenaTxt.TabIndex = 8;
            this.contrasenaTxt.UseSystemPasswordChar = true;
            // 
            // nombreTxt
            // 
            this.nombreTxt.Location = new System.Drawing.Point(158, 166);
            this.nombreTxt.Name = "nombreTxt";
            this.nombreTxt.Size = new System.Drawing.Size(100, 22);
            this.nombreTxt.TabIndex = 9;
            // 
            // fechaNacimientoDtPk
            // 
            this.fechaNacimientoDtPk.Location = new System.Drawing.Point(58, 278);
            this.fechaNacimientoDtPk.Name = "fechaNacimientoDtPk";
            this.fechaNacimientoDtPk.Size = new System.Drawing.Size(200, 22);
            this.fechaNacimientoDtPk.TabIndex = 10;
            // 
            // generoRdH
            // 
            this.generoRdH.AutoSize = true;
            this.generoRdH.Location = new System.Drawing.Point(115, 331);
            this.generoRdH.Name = "generoRdH";
            this.generoRdH.Size = new System.Drawing.Size(77, 20);
            this.generoRdH.TabIndex = 11;
            this.generoRdH.TabStop = true;
            this.generoRdH.Text = "Hombre";
            this.generoRdH.UseVisualStyleBackColor = true;
            // 
            // generoRdM
            // 
            this.generoRdM.AutoSize = true;
            this.generoRdM.Location = new System.Drawing.Point(231, 331);
            this.generoRdM.Name = "generoRdM";
            this.generoRdM.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.generoRdM.Size = new System.Drawing.Size(61, 20);
            this.generoRdM.TabIndex = 12;
            this.generoRdM.TabStop = true;
            this.generoRdM.Text = "Mujer";
            this.generoRdM.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(296, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(583, 271);
            this.dataGridView1.TabIndex = 13;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 392);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.generoRdM);
            this.Controls.Add(this.generoRdH);
            this.Controls.Add(this.fechaNacimientoDtPk);
            this.Controls.Add(this.nombreTxt);
            this.Controls.Add(this.contrasenaTxt);
            this.Controls.Add(this.correoTxt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.insertarUsuarioBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button insertarUsuarioBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox correoTxt;
        private System.Windows.Forms.TextBox contrasenaTxt;
        private System.Windows.Forms.TextBox nombreTxt;
        private System.Windows.Forms.DateTimePicker fechaNacimientoDtPk;
        private System.Windows.Forms.RadioButton generoRdH;
        private System.Windows.Forms.RadioButton generoRdM;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

