namespace LetsMusicTP1
{
    partial class FrmPesquisaAluno
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
            this.txtValorPesquisa = new System.Windows.Forms.TextBox();
            this.dtgAlunos = new System.Windows.Forms.DataGridView();
            this.btnRemoverAluno = new System.Windows.Forms.Button();
            this.btnAlterarAluno = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgAlunos)).BeginInit();
            this.SuspendLayout();
            // 
            // txtValorPesquisa
            // 
            this.txtValorPesquisa.Location = new System.Drawing.Point(34, 46);
            this.txtValorPesquisa.Name = "txtValorPesquisa";
            this.txtValorPesquisa.PlaceholderText = "Digite dado para busca...";
            this.txtValorPesquisa.Size = new System.Drawing.Size(175, 23);
            this.txtValorPesquisa.TabIndex = 3;
            this.txtValorPesquisa.TextChanged += new System.EventHandler(this.txtValorPesquisa_TextChanged);
            // 
            // dtgAlunos
            // 
            this.dtgAlunos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtgAlunos.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dtgAlunos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgAlunos.Location = new System.Drawing.Point(34, 92);
            this.dtgAlunos.Name = "dtgAlunos";
            this.dtgAlunos.ReadOnly = true;
            this.dtgAlunos.RowTemplate.Height = 25;
            this.dtgAlunos.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dtgAlunos.Size = new System.Drawing.Size(615, 213);
            this.dtgAlunos.TabIndex = 1;
            this.dtgAlunos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnRemoverAluno
            // 
            this.btnRemoverAluno.Location = new System.Drawing.Point(442, 339);
            this.btnRemoverAluno.Name = "btnRemoverAluno";
            this.btnRemoverAluno.Size = new System.Drawing.Size(75, 23);
            this.btnRemoverAluno.TabIndex = 17;
            this.btnRemoverAluno.Text = "Remover";
            this.btnRemoverAluno.UseVisualStyleBackColor = true;
            // 
            // btnAlterarAluno
            // 
            this.btnAlterarAluno.Location = new System.Drawing.Point(227, 339);
            this.btnAlterarAluno.Name = "btnAlterarAluno";
            this.btnAlterarAluno.Size = new System.Drawing.Size(75, 23);
            this.btnAlterarAluno.TabIndex = 16;
            this.btnAlterarAluno.Text = "Alterar";
            this.btnAlterarAluno.UseVisualStyleBackColor = true;
            // 
            // FrmPesquisaAluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(684, 411);
            this.Controls.Add(this.btnRemoverAluno);
            this.Controls.Add(this.btnAlterarAluno);
            this.Controls.Add(this.dtgAlunos);
            this.Controls.Add(this.txtValorPesquisa);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmPesquisaAluno";
            this.Text = "Pesquisa Alunos";
            this.Load += new System.EventHandler(this.FrmPesquisaAluno_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgAlunos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtValorPesquisa;
        private DataGridView dtgAlunos;
        private Button btnRemoverAluno;
        private Button btnAlterarAluno;
    }
}