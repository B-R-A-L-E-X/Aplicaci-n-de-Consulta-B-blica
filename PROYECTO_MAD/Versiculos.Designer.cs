namespace PROYECTO_MAD
{
    partial class Versiculos
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
            this.Versiculos_Volver_Btn = new System.Windows.Forms.Button();
            this.Versiculos_DG = new System.Windows.Forms.DataGridView();
            this.Versiculos_idTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Versiculos_Fav_Btn = new System.Windows.Forms.Button();
            this.Versiculo_Libro_CB = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Versiculo_Capitulo_CB = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Versiculo_Versiculo_CB = new System.Windows.Forms.ComboBox();
            this.Versiculos_IdiomaE_RB = new System.Windows.Forms.RadioButton();
            this.Versiculos_NuevoTestamento_RB = new System.Windows.Forms.RadioButton();
            this.Versiculos_IdiomaI_RB = new System.Windows.Forms.RadioButton();
            this.Versiculos_ViejoTestamento_RB = new System.Windows.Forms.RadioButton();
            this.Versiculos_NewTestament_RB = new System.Windows.Forms.RadioButton();
            this.Versiculos_OldTestament_RB = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.Versiculos_DG)).BeginInit();
            this.SuspendLayout();
            // 
            // Versiculos_Volver_Btn
            // 
            this.Versiculos_Volver_Btn.Location = new System.Drawing.Point(76, 353);
            this.Versiculos_Volver_Btn.Name = "Versiculos_Volver_Btn";
            this.Versiculos_Volver_Btn.Size = new System.Drawing.Size(140, 52);
            this.Versiculos_Volver_Btn.TabIndex = 17;
            this.Versiculos_Volver_Btn.Text = "Volver";
            this.Versiculos_Volver_Btn.UseVisualStyleBackColor = true;
            this.Versiculos_Volver_Btn.Click += new System.EventHandler(this.Versiculos_Volver_Btn_Click);
            // 
            // Versiculos_DG
            // 
            this.Versiculos_DG.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.Versiculos_DG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Versiculos_DG.Location = new System.Drawing.Point(76, 39);
            this.Versiculos_DG.Name = "Versiculos_DG";
            this.Versiculos_DG.RowHeadersWidth = 51;
            this.Versiculos_DG.RowTemplate.Height = 24;
            this.Versiculos_DG.Size = new System.Drawing.Size(881, 271);
            this.Versiculos_DG.TabIndex = 16;
            this.Versiculos_DG.SelectionChanged += new System.EventHandler(this.Versiculos_DG_SelectionChanged);
            // 
            // Versiculos_idTxt
            // 
            this.Versiculos_idTxt.Enabled = false;
            this.Versiculos_idTxt.Location = new System.Drawing.Point(1127, 36);
            this.Versiculos_idTxt.Name = "Versiculos_idTxt";
            this.Versiculos_idTxt.Size = new System.Drawing.Size(100, 22);
            this.Versiculos_idTxt.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1006, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 16);
            this.label1.TabIndex = 18;
            this.label1.Text = "Versiculo ID";
            // 
            // Versiculos_Fav_Btn
            // 
            this.Versiculos_Fav_Btn.Location = new System.Drawing.Point(1046, 86);
            this.Versiculos_Fav_Btn.Name = "Versiculos_Fav_Btn";
            this.Versiculos_Fav_Btn.Size = new System.Drawing.Size(140, 56);
            this.Versiculos_Fav_Btn.TabIndex = 20;
            this.Versiculos_Fav_Btn.Text = "Hacer Versiculo Favorito";
            this.Versiculos_Fav_Btn.UseVisualStyleBackColor = true;
            this.Versiculos_Fav_Btn.Click += new System.EventHandler(this.Versiculos_Fav_Btn_Click);
            // 
            // Versiculo_Libro_CB
            // 
            this.Versiculo_Libro_CB.FormattingEnabled = true;
            this.Versiculo_Libro_CB.Items.AddRange(new object[] {
            "Génesis",
            "Éxodo",
            "Levítico",
            "Números",
            "Deuteronomio",
            "Mateo",
            "Marcos",
            "Lucas",
            "Juan",
            "Hechos De Los Apóstoles",
            "Genesis",
            "Exodus",
            "Leviticus",
            "Numbers",
            "Deuteronomy",
            "Matthew",
            "Mark",
            "Luke",
            "John",
            "Acts"});
            this.Versiculo_Libro_CB.Location = new System.Drawing.Point(1106, 177);
            this.Versiculo_Libro_CB.Name = "Versiculo_Libro_CB";
            this.Versiculo_Libro_CB.Size = new System.Drawing.Size(121, 24);
            this.Versiculo_Libro_CB.TabIndex = 21;
            this.Versiculo_Libro_CB.SelectedIndexChanged += new System.EventHandler(this.Versiculo_Libro_CB_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1006, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 16);
            this.label2.TabIndex = 22;
            this.label2.Text = "Libro";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1006, 252);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 16);
            this.label3.TabIndex = 24;
            this.label3.Text = "Capitulo";
            // 
            // Versiculo_Capitulo_CB
            // 
            this.Versiculo_Capitulo_CB.FormattingEnabled = true;
            this.Versiculo_Capitulo_CB.Items.AddRange(new object[] {
            "1",
            "2"});
            this.Versiculo_Capitulo_CB.Location = new System.Drawing.Point(1106, 249);
            this.Versiculo_Capitulo_CB.Name = "Versiculo_Capitulo_CB";
            this.Versiculo_Capitulo_CB.Size = new System.Drawing.Size(121, 24);
            this.Versiculo_Capitulo_CB.TabIndex = 23;
            this.Versiculo_Capitulo_CB.SelectedIndexChanged += new System.EventHandler(this.Versiculo_Capitulo_CB_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1006, 312);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 16);
            this.label4.TabIndex = 26;
            this.label4.Text = "Versiculo";
            // 
            // Versiculo_Versiculo_CB
            // 
            this.Versiculo_Versiculo_CB.FormattingEnabled = true;
            this.Versiculo_Versiculo_CB.Items.AddRange(new object[] {
            "1",
            "2"});
            this.Versiculo_Versiculo_CB.Location = new System.Drawing.Point(1106, 304);
            this.Versiculo_Versiculo_CB.Name = "Versiculo_Versiculo_CB";
            this.Versiculo_Versiculo_CB.Size = new System.Drawing.Size(121, 24);
            this.Versiculo_Versiculo_CB.TabIndex = 25;
            this.Versiculo_Versiculo_CB.SelectedIndexChanged += new System.EventHandler(this.Versiculo_Versiculo_CB_SelectedIndexChanged);
            // 
            // Versiculos_IdiomaE_RB
            // 
            this.Versiculos_IdiomaE_RB.AutoSize = true;
            this.Versiculos_IdiomaE_RB.Location = new System.Drawing.Point(257, 369);
            this.Versiculos_IdiomaE_RB.Name = "Versiculos_IdiomaE_RB";
            this.Versiculos_IdiomaE_RB.Size = new System.Drawing.Size(78, 20);
            this.Versiculos_IdiomaE_RB.TabIndex = 27;
            this.Versiculos_IdiomaE_RB.TabStop = true;
            this.Versiculos_IdiomaE_RB.Text = "Español";
            this.Versiculos_IdiomaE_RB.UseVisualStyleBackColor = true;
            this.Versiculos_IdiomaE_RB.CheckedChanged += new System.EventHandler(this.Versiculos_IdiomaE_RB_CheckedChanged);
            // 
            // Versiculos_NuevoTestamento_RB
            // 
            this.Versiculos_NuevoTestamento_RB.AutoSize = true;
            this.Versiculos_NuevoTestamento_RB.Location = new System.Drawing.Point(411, 369);
            this.Versiculos_NuevoTestamento_RB.Name = "Versiculos_NuevoTestamento_RB";
            this.Versiculos_NuevoTestamento_RB.Size = new System.Drawing.Size(143, 20);
            this.Versiculos_NuevoTestamento_RB.TabIndex = 28;
            this.Versiculos_NuevoTestamento_RB.TabStop = true;
            this.Versiculos_NuevoTestamento_RB.Text = "Nuevo Testamento";
            this.Versiculos_NuevoTestamento_RB.UseVisualStyleBackColor = true;
            this.Versiculos_NuevoTestamento_RB.CheckedChanged += new System.EventHandler(this.Versiculos_NuevoTestamento_RB_CheckedChanged);
            // 
            // Versiculos_IdiomaI_RB
            // 
            this.Versiculos_IdiomaI_RB.AutoSize = true;
            this.Versiculos_IdiomaI_RB.Location = new System.Drawing.Point(341, 369);
            this.Versiculos_IdiomaI_RB.Name = "Versiculos_IdiomaI_RB";
            this.Versiculos_IdiomaI_RB.Size = new System.Drawing.Size(64, 20);
            this.Versiculos_IdiomaI_RB.TabIndex = 32;
            this.Versiculos_IdiomaI_RB.TabStop = true;
            this.Versiculos_IdiomaI_RB.Text = "Ingles";
            this.Versiculos_IdiomaI_RB.UseVisualStyleBackColor = true;
            this.Versiculos_IdiomaI_RB.CheckedChanged += new System.EventHandler(this.Versiculos_IdiomaI_RB_CheckedChanged);
            // 
            // Versiculos_ViejoTestamento_RB
            // 
            this.Versiculos_ViejoTestamento_RB.AutoSize = true;
            this.Versiculos_ViejoTestamento_RB.Location = new System.Drawing.Point(560, 369);
            this.Versiculos_ViejoTestamento_RB.Name = "Versiculos_ViejoTestamento_RB";
            this.Versiculos_ViejoTestamento_RB.Size = new System.Drawing.Size(148, 20);
            this.Versiculos_ViejoTestamento_RB.TabIndex = 33;
            this.Versiculos_ViejoTestamento_RB.TabStop = true;
            this.Versiculos_ViejoTestamento_RB.Text = "Antiguo Testamento";
            this.Versiculos_ViejoTestamento_RB.UseVisualStyleBackColor = true;
            this.Versiculos_ViejoTestamento_RB.CheckedChanged += new System.EventHandler(this.Versiculos_ViejoTestamento_RB_CheckedChanged);
            // 
            // Versiculos_NewTestament_RB
            // 
            this.Versiculos_NewTestament_RB.AutoSize = true;
            this.Versiculos_NewTestament_RB.Location = new System.Drawing.Point(714, 369);
            this.Versiculos_NewTestament_RB.Name = "Versiculos_NewTestament_RB";
            this.Versiculos_NewTestament_RB.Size = new System.Drawing.Size(122, 20);
            this.Versiculos_NewTestament_RB.TabIndex = 34;
            this.Versiculos_NewTestament_RB.TabStop = true;
            this.Versiculos_NewTestament_RB.Text = "New Testament";
            this.Versiculos_NewTestament_RB.UseVisualStyleBackColor = true;
            this.Versiculos_NewTestament_RB.CheckedChanged += new System.EventHandler(this.Versiculos_NewTestament_RB_CheckedChanged);
            // 
            // Versiculos_OldTestament_RB
            // 
            this.Versiculos_OldTestament_RB.AutoSize = true;
            this.Versiculos_OldTestament_RB.Location = new System.Drawing.Point(842, 369);
            this.Versiculos_OldTestament_RB.Name = "Versiculos_OldTestament_RB";
            this.Versiculos_OldTestament_RB.Size = new System.Drawing.Size(116, 20);
            this.Versiculos_OldTestament_RB.TabIndex = 35;
            this.Versiculos_OldTestament_RB.TabStop = true;
            this.Versiculos_OldTestament_RB.Text = "Old Testament";
            this.Versiculos_OldTestament_RB.UseVisualStyleBackColor = true;
            this.Versiculos_OldTestament_RB.CheckedChanged += new System.EventHandler(this.Versiculos_OldTestament_RB_CheckedChanged);
            // 
            // Versiculos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1340, 450);
            this.Controls.Add(this.Versiculos_OldTestament_RB);
            this.Controls.Add(this.Versiculos_NewTestament_RB);
            this.Controls.Add(this.Versiculos_ViejoTestamento_RB);
            this.Controls.Add(this.Versiculos_IdiomaI_RB);
            this.Controls.Add(this.Versiculos_NuevoTestamento_RB);
            this.Controls.Add(this.Versiculos_IdiomaE_RB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Versiculo_Versiculo_CB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Versiculo_Capitulo_CB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Versiculo_Libro_CB);
            this.Controls.Add(this.Versiculos_Fav_Btn);
            this.Controls.Add(this.Versiculos_idTxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Versiculos_Volver_Btn);
            this.Controls.Add(this.Versiculos_DG);
            this.Name = "Versiculos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Versiculos";
            this.Load += new System.EventHandler(this.Versiculos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Versiculos_DG)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Versiculos_Volver_Btn;
        private System.Windows.Forms.DataGridView Versiculos_DG;
        private System.Windows.Forms.TextBox Versiculos_idTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Versiculos_Fav_Btn;
        private System.Windows.Forms.ComboBox Versiculo_Libro_CB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox Versiculo_Capitulo_CB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox Versiculo_Versiculo_CB;
        private System.Windows.Forms.RadioButton Versiculos_IdiomaE_RB;
        private System.Windows.Forms.RadioButton Versiculos_NuevoTestamento_RB;
        private System.Windows.Forms.RadioButton Versiculos_IdiomaI_RB;
        private System.Windows.Forms.RadioButton Versiculos_ViejoTestamento_RB;
        private System.Windows.Forms.RadioButton Versiculos_NewTestament_RB;
        private System.Windows.Forms.RadioButton Versiculos_OldTestament_RB;
    }
}