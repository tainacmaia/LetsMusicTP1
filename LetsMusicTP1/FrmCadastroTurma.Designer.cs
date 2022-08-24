namespace LetsMusicTP1
{
    partial class FrmCadastroTurma
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
            this.btnAdicionaAluno = new System.Windows.Forms.Button();
            this.lblCurso = new System.Windows.Forms.Label();
            this.cbbCurso = new System.Windows.Forms.ComboBox();
            this.btnCadastrarTurma = new System.Windows.Forms.Button();
            this.lblTituloCadTurma = new System.Windows.Forms.Label();
            this.btnFechar = new System.Windows.Forms.Button();
            this.txtPesquisaAluno = new System.Windows.Forms.TextBox();
            this.lblVagasCurso = new System.Windows.Forms.Label();
            this.lblAlunosCad = new System.Windows.Forms.Label();
            this.lblAlunosMatr = new System.Windows.Forms.Label();
            this.lblTotVagas = new System.Windows.Forms.Label();
            this.btnRemoveAluno = new System.Windows.Forms.Button();
            this.ltbAlunosCad = new System.Windows.Forms.ListBox();
            this.ltbAlunosMat = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnAdicionaAluno
            // 
            this.btnAdicionaAluno.Location = new System.Drawing.Point(328, 197);
            this.btnAdicionaAluno.Name = "btnAdicionaAluno";
            this.btnAdicionaAluno.Size = new System.Drawing.Size(30, 23);
            this.btnAdicionaAluno.TabIndex = 2;
            this.btnAdicionaAluno.Text = ">";
            this.btnAdicionaAluno.UseVisualStyleBackColor = true;
            this.btnAdicionaAluno.Click += new System.EventHandler(this.btnAdicionaAluno_Click);
            // 
            // lblCurso
            // 
            this.lblCurso.AutoSize = true;
            this.lblCurso.Location = new System.Drawing.Point(185, 58);
            this.lblCurso.Name = "lblCurso";
            this.lblCurso.Size = new System.Drawing.Size(104, 15);
            this.lblCurso.TabIndex = 0;
            this.lblCurso.Text = "Selecione o Curso:";
            // 
            // cbbCurso
            // 
            this.cbbCurso.FormattingEnabled = true;
            this.cbbCurso.Location = new System.Drawing.Point(294, 55);
            this.cbbCurso.Name = "cbbCurso";
            this.cbbCurso.Size = new System.Drawing.Size(228, 23);
            this.cbbCurso.TabIndex = 4;
            this.cbbCurso.SelectedIndexChanged += new System.EventHandler(this.cbbCurso_SelectedIndexChanged);
            // 
            // btnCadastrarTurma
            // 
            this.btnCadastrarTurma.Location = new System.Drawing.Point(200, 365);
            this.btnCadastrarTurma.Name = "btnCadastrarTurma";
            this.btnCadastrarTurma.Size = new System.Drawing.Size(75, 23);
            this.btnCadastrarTurma.TabIndex = 6;
            this.btnCadastrarTurma.Text = "Cadastrar";
            this.btnCadastrarTurma.UseVisualStyleBackColor = true;
            this.btnCadastrarTurma.Click += new System.EventHandler(this.btnCadastrarTurma_Click);
            // 
            // lblTituloCadTurma
            // 
            this.lblTituloCadTurma.AutoSize = true;
            this.lblTituloCadTurma.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTituloCadTurma.Location = new System.Drawing.Point(281, 22);
            this.lblTituloCadTurma.Name = "lblTituloCadTurma";
            this.lblTituloCadTurma.Size = new System.Drawing.Size(124, 17);
            this.lblTituloCadTurma.TabIndex = 13;
            this.lblTituloCadTurma.Text = "Cadastro de Turma";
            // 
            // btnFechar
            // 
            this.btnFechar.Location = new System.Drawing.Point(400, 365);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(75, 23);
            this.btnFechar.TabIndex = 17;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // txtPesquisaAluno
            // 
            this.txtPesquisaAluno.Location = new System.Drawing.Point(30, 118);
            this.txtPesquisaAluno.Name = "txtPesquisaAluno";
            this.txtPesquisaAluno.PlaceholderText = "Digite dado para busca...";
            this.txtPesquisaAluno.Size = new System.Drawing.Size(282, 23);
            this.txtPesquisaAluno.TabIndex = 19;
            this.txtPesquisaAluno.TextChanged += new System.EventHandler(this.txtPesquisaAluno_TextChanged);
            // 
            // lblVagasCurso
            // 
            this.lblVagasCurso.AutoSize = true;
            this.lblVagasCurso.Location = new System.Drawing.Point(458, 126);
            this.lblVagasCurso.Name = "lblVagasCurso";
            this.lblVagasCurso.Size = new System.Drawing.Size(14, 15);
            this.lblVagasCurso.TabIndex = 22;
            this.lblVagasCurso.Text = "X";
            this.lblVagasCurso.Click += new System.EventHandler(this.lblVagasCurso_Click);
            // 
            // lblAlunosCad
            // 
            this.lblAlunosCad.AutoSize = true;
            this.lblAlunosCad.Location = new System.Drawing.Point(30, 100);
            this.lblAlunosCad.Name = "lblAlunosCad";
            this.lblAlunosCad.Size = new System.Drawing.Size(115, 15);
            this.lblAlunosCad.TabIndex = 23;
            this.lblAlunosCad.Text = "Alunos Cadastrados:";
            // 
            // lblAlunosMatr
            // 
            this.lblAlunosMatr.AutoSize = true;
            this.lblAlunosMatr.Location = new System.Drawing.Point(374, 110);
            this.lblAlunosMatr.Name = "lblAlunosMatr";
            this.lblAlunosMatr.Size = new System.Drawing.Size(170, 15);
            this.lblAlunosMatr.TabIndex = 24;
            this.lblAlunosMatr.Text = "Alunos Matriculados no Curso:";
            // 
            // lblTotVagas
            // 
            this.lblTotVagas.AutoSize = true;
            this.lblTotVagas.Location = new System.Drawing.Point(374, 126);
            this.lblTotVagas.Name = "lblTotVagas";
            this.lblTotVagas.Size = new System.Drawing.Size(87, 15);
            this.lblTotVagas.TabIndex = 21;
            this.lblTotVagas.Text = "Total de Vagas: ";
            // 
            // btnRemoveAluno
            // 
            this.btnRemoveAluno.Location = new System.Drawing.Point(328, 241);
            this.btnRemoveAluno.Name = "btnRemoveAluno";
            this.btnRemoveAluno.Size = new System.Drawing.Size(30, 23);
            this.btnRemoveAluno.TabIndex = 25;
            this.btnRemoveAluno.Text = "<";
            this.btnRemoveAluno.UseVisualStyleBackColor = true;
            this.btnRemoveAluno.Click += new System.EventHandler(this.btnRemoveAluno_Click);
            // 
            // ltbAlunosCad
            // 
            this.ltbAlunosCad.FormattingEnabled = true;
            this.ltbAlunosCad.ItemHeight = 15;
            this.ltbAlunosCad.Location = new System.Drawing.Point(30, 147);
            this.ltbAlunosCad.Name = "ltbAlunosCad";
            this.ltbAlunosCad.Size = new System.Drawing.Size(282, 184);
            this.ltbAlunosCad.TabIndex = 26;
            // 
            // ltbAlunosMat
            // 
            this.ltbAlunosMat.FormattingEnabled = true;
            this.ltbAlunosMat.ItemHeight = 15;
            this.ltbAlunosMat.Location = new System.Drawing.Point(374, 147);
            this.ltbAlunosMat.Name = "ltbAlunosMat";
            this.ltbAlunosMat.Size = new System.Drawing.Size(282, 184);
            this.ltbAlunosMat.TabIndex = 27;
            // 
            // FrmCadastroTurma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(684, 411);
            this.Controls.Add(this.ltbAlunosMat);
            this.Controls.Add(this.ltbAlunosCad);
            this.Controls.Add(this.btnRemoveAluno);
            this.Controls.Add(this.lblAlunosMatr);
            this.Controls.Add(this.lblAlunosCad);
            this.Controls.Add(this.lblVagasCurso);
            this.Controls.Add(this.lblTotVagas);
            this.Controls.Add(this.txtPesquisaAluno);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.lblTituloCadTurma);
            this.Controls.Add(this.btnCadastrarTurma);
            this.Controls.Add(this.cbbCurso);
            this.Controls.Add(this.btnAdicionaAluno);
            this.Controls.Add(this.lblCurso);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCadastroTurma";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro Turma";
            this.Load += new System.EventHandler(this.FrmCadastroTurma_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnAdicionaAluno;
        private Label lblCurso;
        private ComboBox cbbCurso;
        private Button btnCadastrarTurma;
        private Label lblTituloCadTurma;
        private Button btnFechar;
        private TextBox txtPesquisaAluno;
        private Label lblVagasCurso;
        private Label lblAlunosCad;
        private Label lblAlunosMatr;
        private Label lblTotVagas;
        private Button btnRemoveAluno;
        private ListBox ltbAlunosCad;
        private ListBox ltbAlunosMat;
    }
}