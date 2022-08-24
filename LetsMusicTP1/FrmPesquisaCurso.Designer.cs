namespace LetsMusicTP1.Presentation
{
    partial class FrmPesquisaCurso
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
            this.dtgCursos = new System.Windows.Forms.DataGridView();
            this.btnRemoverCurso = new System.Windows.Forms.Button();
            this.btnAlterarCurso = new System.Windows.Forms.Button();
            this.txtPesquisaCurso = new System.Windows.Forms.TextBox();
            this.lblTituloPesqCurso = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.lblStatusBusca = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgCursos)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgCursos
            // 
            this.dtgCursos.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dtgCursos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgCursos.Location = new System.Drawing.Point(35, 95);
            this.dtgCursos.Name = "dtgCursos";
            this.dtgCursos.ReadOnly = true;
            this.dtgCursos.RowTemplate.Height = 25;
            this.dtgCursos.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dtgCursos.Size = new System.Drawing.Size(456, 153);
            this.dtgCursos.TabIndex = 0;
            this.dtgCursos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgCursos_CellContentClick);
            this.dtgCursos.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dtgCursos_RowHeaderMouseClick);
            // 
            // btnRemoverCurso
            // 
            this.btnRemoverCurso.Location = new System.Drawing.Point(319, 309);
            this.btnRemoverCurso.Name = "btnRemoverCurso";
            this.btnRemoverCurso.Size = new System.Drawing.Size(75, 23);
            this.btnRemoverCurso.TabIndex = 3;
            this.btnRemoverCurso.Text = "Remover";
            this.btnRemoverCurso.UseVisualStyleBackColor = true;
            this.btnRemoverCurso.Click += new System.EventHandler(this.btnRemoverCurso_Click);
            // 
            // btnAlterarCurso
            // 
            this.btnAlterarCurso.Location = new System.Drawing.Point(160, 309);
            this.btnAlterarCurso.Name = "btnAlterarCurso";
            this.btnAlterarCurso.Size = new System.Drawing.Size(75, 23);
            this.btnAlterarCurso.TabIndex = 2;
            this.btnAlterarCurso.Text = "Alterar";
            this.btnAlterarCurso.UseVisualStyleBackColor = true;
            this.btnAlterarCurso.Click += new System.EventHandler(this.btnAlterarCurso_Click);
            // 
            // txtPesquisaCurso
            // 
            this.txtPesquisaCurso.Location = new System.Drawing.Point(35, 55);
            this.txtPesquisaCurso.Name = "txtPesquisaCurso";
            this.txtPesquisaCurso.PlaceholderText = "Digite dado para busca...";
            this.txtPesquisaCurso.Size = new System.Drawing.Size(175, 23);
            this.txtPesquisaCurso.TabIndex = 1;
            this.txtPesquisaCurso.TextChanged += new System.EventHandler(this.txtPesquisaCurso_TextChanged);
            // 
            // lblTituloPesqCurso
            // 
            this.lblTituloPesqCurso.AutoSize = true;
            this.lblTituloPesqCurso.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTituloPesqCurso.Location = new System.Drawing.Point(199, 22);
            this.lblTituloPesqCurso.Name = "lblTituloPesqCurso";
            this.lblTituloPesqCurso.Size = new System.Drawing.Size(120, 17);
            this.lblTituloPesqCurso.TabIndex = 12;
            this.lblTituloPesqCurso.Text = "Pesquisa de Curso";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 269);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 15);
            this.label1.TabIndex = 13;
            this.label1.Text = "Curso";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(85, 266);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(100, 23);
            this.textBox1.TabIndex = 14;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(232, 266);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 23);
            this.textBox2.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(202, 269);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 15);
            this.label2.TabIndex = 16;
            this.label2.Text = "CH";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(348, 269);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 15);
            this.label3.TabIndex = 17;
            this.label3.Text = "Vagas";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(391, 266);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 23);
            this.textBox3.TabIndex = 18;
            // 
            // lblStatusBusca
            // 
            this.lblStatusBusca.AutoSize = true;
            this.lblStatusBusca.Location = new System.Drawing.Point(216, 58);
            this.lblStatusBusca.Name = "lblStatusBusca";
            this.lblStatusBusca.Size = new System.Drawing.Size(0, 15);
            this.lblStatusBusca.TabIndex = 21;
            // 
            // FrmPesquisaCurso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 361);
            this.Controls.Add(this.lblStatusBusca);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTituloPesqCurso);
            this.Controls.Add(this.txtPesquisaCurso);
            this.Controls.Add(this.btnRemoverCurso);
            this.Controls.Add(this.btnAlterarCurso);
            this.Controls.Add(this.dtgCursos);
            this.Name = "FrmPesquisaCurso";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pesquisa Curso";
            this.Load += new System.EventHandler(this.FrmPesquisaCurso_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgCursos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dtgCursos;
        private Button btnRemoverCurso;
        private Button btnAlterarCurso;
        private TextBox txtPesquisaCurso;
        private Label lblTituloPesqCurso;
        private Label label1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label2;
        private Label label3;
        private TextBox textBox3;
        private Label lblStatusBusca;
    }
}