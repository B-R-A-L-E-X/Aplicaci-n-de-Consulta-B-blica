namespace PROYECTO_MAD
{
    partial class Busqueda
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
            this.Busqueda_DG = new System.Windows.Forms.DataGridView();
            this.Busqueda_Buscar_Btn = new System.Windows.Forms.Button();
            this.Busqueda_Volver_Btn = new System.Windows.Forms.Button();
            this.Busqueda_Historial_Btn = new System.Windows.Forms.Button();
            this.Busqueda_Generaltext = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Busqueda_Test_CB = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Busqueda_Libro_CB = new System.Windows.Forms.ComboBox();
            this.Busqueda_LibroAct_RB = new System.Windows.Forms.RadioButton();
            this.Busqueda_TestamentoAct_RB = new System.Windows.Forms.RadioButton();
            this.Busqueda_GeneralAct_RB = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.Busqueda_DG)).BeginInit();
            this.SuspendLayout();
            // 
            // Busqueda_DG
            // 
            this.Busqueda_DG.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.Busqueda_DG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Busqueda_DG.Location = new System.Drawing.Point(277, 12);
            this.Busqueda_DG.Name = "Busqueda_DG";
            this.Busqueda_DG.RowHeadersWidth = 51;
            this.Busqueda_DG.RowTemplate.Height = 24;
            this.Busqueda_DG.Size = new System.Drawing.Size(962, 396);
            this.Busqueda_DG.TabIndex = 18;
            // 
            // Busqueda_Buscar_Btn
            // 
            this.Busqueda_Buscar_Btn.Location = new System.Drawing.Point(63, 279);
            this.Busqueda_Buscar_Btn.Name = "Busqueda_Buscar_Btn";
            this.Busqueda_Buscar_Btn.Size = new System.Drawing.Size(140, 30);
            this.Busqueda_Buscar_Btn.TabIndex = 19;
            this.Busqueda_Buscar_Btn.Text = "Buscar";
            this.Busqueda_Buscar_Btn.UseVisualStyleBackColor = true;
            this.Busqueda_Buscar_Btn.Click += new System.EventHandler(this.Busqueda_Buscar_Btn_Click);
            // 
            // Busqueda_Volver_Btn
            // 
            this.Busqueda_Volver_Btn.Location = new System.Drawing.Point(63, 379);
            this.Busqueda_Volver_Btn.Name = "Busqueda_Volver_Btn";
            this.Busqueda_Volver_Btn.Size = new System.Drawing.Size(140, 29);
            this.Busqueda_Volver_Btn.TabIndex = 20;
            this.Busqueda_Volver_Btn.Text = "Volver";
            this.Busqueda_Volver_Btn.UseVisualStyleBackColor = true;
            this.Busqueda_Volver_Btn.Click += new System.EventHandler(this.Busqueda_Volver_Btn_Click);
            // 
            // Busqueda_Historial_Btn
            // 
            this.Busqueda_Historial_Btn.Location = new System.Drawing.Point(63, 333);
            this.Busqueda_Historial_Btn.Name = "Busqueda_Historial_Btn";
            this.Busqueda_Historial_Btn.Size = new System.Drawing.Size(140, 25);
            this.Busqueda_Historial_Btn.TabIndex = 21;
            this.Busqueda_Historial_Btn.Text = "Historial";
            this.Busqueda_Historial_Btn.UseVisualStyleBackColor = true;
            this.Busqueda_Historial_Btn.Click += new System.EventHandler(this.Busqueda_Historial_Btn_Click);
            // 
            // Busqueda_Generaltext
            // 
            this.Busqueda_Generaltext.Location = new System.Drawing.Point(139, 203);
            this.Busqueda_Generaltext.Name = "Busqueda_Generaltext";
            this.Busqueda_Generaltext.Size = new System.Drawing.Size(100, 22);
            this.Busqueda_Generaltext.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 203);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 16);
            this.label3.TabIndex = 24;
            this.label3.Text = "Texto a Buscar;";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 16);
            this.label1.TabIndex = 29;
            this.label1.Text = "Testamento";
            // 
            // Busqueda_Test_CB
            // 
            this.Busqueda_Test_CB.FormattingEnabled = true;
            this.Busqueda_Test_CB.Items.AddRange(new object[] {
            "Antiguo Testamento",
            "",
            "Nuevo Testamento",
            "",
            "The Old Testament",
            "",
            "The New Testament"});
            this.Busqueda_Test_CB.Location = new System.Drawing.Point(118, 111);
            this.Busqueda_Test_CB.Name = "Busqueda_Test_CB";
            this.Busqueda_Test_CB.Size = new System.Drawing.Size(121, 24);
            this.Busqueda_Test_CB.TabIndex = 28;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 16);
            this.label2.TabIndex = 27;
            this.label2.Text = "Libro";
            // 
            // Busqueda_Libro_CB
            // 
            this.Busqueda_Libro_CB.FormattingEnabled = true;
            this.Busqueda_Libro_CB.Items.AddRange(new object[] {
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
            this.Busqueda_Libro_CB.Location = new System.Drawing.Point(118, 23);
            this.Busqueda_Libro_CB.Name = "Busqueda_Libro_CB";
            this.Busqueda_Libro_CB.Size = new System.Drawing.Size(121, 24);
            this.Busqueda_Libro_CB.TabIndex = 26;
            // 
            // Busqueda_LibroAct_RB
            // 
            this.Busqueda_LibroAct_RB.AutoSize = true;
            this.Busqueda_LibroAct_RB.Location = new System.Drawing.Point(21, 70);
            this.Busqueda_LibroAct_RB.Name = "Busqueda_LibroAct_RB";
            this.Busqueda_LibroAct_RB.Size = new System.Drawing.Size(191, 20);
            this.Busqueda_LibroAct_RB.TabIndex = 30;
            this.Busqueda_LibroAct_RB.TabStop = true;
            this.Busqueda_LibroAct_RB.Text = "Activar Busqueda Por Libro";
            this.Busqueda_LibroAct_RB.UseVisualStyleBackColor = true;
            // 
            // Busqueda_TestamentoAct_RB
            // 
            this.Busqueda_TestamentoAct_RB.AutoSize = true;
            this.Busqueda_TestamentoAct_RB.Location = new System.Drawing.Point(21, 153);
            this.Busqueda_TestamentoAct_RB.Name = "Busqueda_TestamentoAct_RB";
            this.Busqueda_TestamentoAct_RB.Size = new System.Drawing.Size(233, 20);
            this.Busqueda_TestamentoAct_RB.TabIndex = 31;
            this.Busqueda_TestamentoAct_RB.TabStop = true;
            this.Busqueda_TestamentoAct_RB.Text = "Activar Busqueda Por Testamento";
            this.Busqueda_TestamentoAct_RB.UseVisualStyleBackColor = true;
            // 
            // Busqueda_GeneralAct_RB
            // 
            this.Busqueda_GeneralAct_RB.AutoSize = true;
            this.Busqueda_GeneralAct_RB.Location = new System.Drawing.Point(21, 233);
            this.Busqueda_GeneralAct_RB.Name = "Busqueda_GeneralAct_RB";
            this.Busqueda_GeneralAct_RB.Size = new System.Drawing.Size(185, 20);
            this.Busqueda_GeneralAct_RB.TabIndex = 32;
            this.Busqueda_GeneralAct_RB.TabStop = true;
            this.Busqueda_GeneralAct_RB.Text = "Activar Busqueda General";
            this.Busqueda_GeneralAct_RB.UseVisualStyleBackColor = true;
            // 
            // Busqueda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1269, 450);
            this.Controls.Add(this.Busqueda_GeneralAct_RB);
            this.Controls.Add(this.Busqueda_TestamentoAct_RB);
            this.Controls.Add(this.Busqueda_LibroAct_RB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Busqueda_Test_CB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Busqueda_Libro_CB);
            this.Controls.Add(this.Busqueda_Generaltext);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Busqueda_Historial_Btn);
            this.Controls.Add(this.Busqueda_Volver_Btn);
            this.Controls.Add(this.Busqueda_Buscar_Btn);
            this.Controls.Add(this.Busqueda_DG);
            this.Name = "Busqueda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Busqueda";
            this.Load += new System.EventHandler(this.Busqueda_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Busqueda_DG)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Busqueda_DG;
        private System.Windows.Forms.Button Busqueda_Buscar_Btn;
        private System.Windows.Forms.Button Busqueda_Volver_Btn;
        private System.Windows.Forms.Button Busqueda_Historial_Btn;
        private System.Windows.Forms.TextBox Busqueda_Generaltext;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox Busqueda_Test_CB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox Busqueda_Libro_CB;
        private System.Windows.Forms.RadioButton Busqueda_LibroAct_RB;
        private System.Windows.Forms.RadioButton Busqueda_TestamentoAct_RB;
        private System.Windows.Forms.RadioButton Busqueda_GeneralAct_RB;
    }
}