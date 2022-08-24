namespace LetsMusicTP1.Presentation
{
    partial class FrmAlterarTurma
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
            this.components = new System.ComponentModel.Container();
            this.ltbAlunosMat = new System.Windows.Forms.ListBox();
            this.ltbAlunosCad = new System.Windows.Forms.ListBox();
            this.btnRemoveAluno = new System.Windows.Forms.Button();
            this.lblAlunosMatr = new System.Windows.Forms.Label();
            this.lblAlunosCad = new System.Windows.Forms.Label();
            this.lblVagasCurso = new System.Windows.Forms.Label();
            this.lblTotVagas = new System.Windows.Forms.Label();
            this.txtPesquisaAluno = new System.Windows.Forms.TextBox();
            this.btnFechar = new System.Windows.Forms.Button();
            this.lblTituloCadTurma = new System.Windows.Forms.Label();
            this.btnAtualizarTurma = new System.Windows.Forms.Button();
            this.cbbCurso = new System.Windows.Forms.ComboBox();
            this.btnAdicionaAluno = new System.Windows.Forms.Button();
            this.lblCurso = new System.Windows.Forms.Label();
            this.btnRemoverTurma = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.lblStatusBusca = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ltbAlunosMat
            // 
            this.ltbAlunosMat.FormattingEnabled = true;
            this.ltbAlunosMat.ItemHeight = 15;
            this.ltbAlunosMat.Location = new System.Drawing.Point(431, 167);
            this.ltbAlunosMat.Name = "ltbAlunosMat";
            this.ltbAlunosMat.Size = new System.Drawing.Size(282, 184);
            this.ltbAlunosMat.TabIndex = 41;
            // 
            // ltbAlunosCad
            // 
            this.ltbAlunosCad.FormattingEnabled = true;
            this.ltbAlunosCad.ItemHeight = 15;
            this.ltbAlunosCad.Location = new System.Drawing.Point(87, 167);
            this.ltbAlunosCad.Name = "ltbAlunosCad";
            this.ltbAlunosCad.Size = new System.Drawing.Size(282, 184);
            this.ltbAlunosCad.TabIndex = 40;
            // 
            // btnRemoveAluno
            // 
            this.btnRemoveAluno.Location = new System.Drawing.Point(385, 261);
            this.btnRemoveAluno.Name = "btnRemoveAluno";
            this.btnRemoveAluno.Size = new System.Drawing.Size(30, 23);
            this.btnRemoveAluno.TabIndex = 39;
            this.btnRemoveAluno.Text = "<";
            this.btnRemoveAluno.UseVisualStyleBackColor = true;
            this.btnRemoveAluno.Click += new System.EventHandler(this.btnRemoveAluno_Click);
            // 
            // lblAlunosMatr
            // 
            this.lblAlunosMatr.AutoSize = true;
            this.lblAlunosMatr.Location = new System.Drawing.Point(431, 130);
            this.lblAlunosMatr.Name = "lblAlunosMatr";
            this.lblAlunosMatr.Size = new System.Drawing.Size(170, 15);
            this.lblAlunosMatr.TabIndex = 38;
            this.lblAlunosMatr.Text = "Alunos Matriculados no Curso:";
            // 
            // lblAlunosCad
            // 
            this.lblAlunosCad.AutoSize = true;
            this.lblAlunosCad.Location = new System.Drawing.Point(87, 120);
            this.lblAlunosCad.Name = "lblAlunosCad";
            this.lblAlunosCad.Size = new System.Drawing.Size(115, 15);
            this.lblAlunosCad.TabIndex = 37;
            this.lblAlunosCad.Text = "Alunos Cadastrados:";
            // 
            // lblVagasCurso
            // 
            this.lblVagasCurso.AutoSize = true;
            this.lblVagasCurso.Location = new System.Drawing.Point(515, 146);
            this.lblVagasCurso.Name = "lblVagasCurso";
            this.lblVagasCurso.Size = new System.Drawing.Size(14, 15);
            this.lblVagasCurso.TabIndex = 36;
            this.lblVagasCurso.Text = "X";
            // 
            // lblTotVagas
            // 
            this.lblTotVagas.AutoSize = true;
            this.lblTotVagas.Location = new System.Drawing.Point(431, 146);
            this.lblTotVagas.Name = "lblTotVagas";
            this.lblTotVagas.Size = new System.Drawing.Size(87, 15);
            this.lblTotVagas.TabIndex = 35;
            this.lblTotVagas.Text = "Total de Vagas: ";
            // 
            // txtPesquisaAluno
            // 
            this.txtPesquisaAluno.Location = new System.Drawing.Point(87, 138);
            this.txtPesquisaAluno.Name = "txtPesquisaAluno";
            this.txtPesquisaAluno.PlaceholderText = "Digite dado para busca...";
            this.txtPesquisaAluno.Size = new System.Drawing.Size(282, 23);
            this.txtPesquisaAluno.TabIndex = 34;
            this.txtPesquisaAluno.TextChanged += new System.EventHandler(this.txtPesquisaAluno_TextChanged);
            // 
            // btnFechar
            // 
            this.btnFechar.Location = new System.Drawing.Point(515, 385);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(75, 23);
            this.btnFechar.TabIndex = 33;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // lblTituloCadTurma
            // 
            this.lblTituloCadTurma.AutoSize = true;
            this.lblTituloCadTurma.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTituloCadTurma.Location = new System.Drawing.Point(338, 42);
            this.lblTituloCadTurma.Name = "lblTituloCadTurma";
            this.lblTituloCadTurma.Size = new System.Drawing.Size(126, 17);
            this.lblTituloCadTurma.TabIndex = 32;
            this.lblTituloCadTurma.Text = "Alteração de turma";
            // 
            // btnAtualizarTurma
            // 
            this.btnAtualizarTurma.Location = new System.Drawing.Point(226, 385);
            this.btnAtualizarTurma.Name = "btnAtualizarTurma";
            this.btnAtualizarTurma.Size = new System.Drawing.Size(75, 23);
            this.btnAtualizarTurma.TabIndex = 31;
            this.btnAtualizarTurma.Text = "Atualizar";
            this.toolTip1.SetToolTip(this.btnAtualizarTurma, "Adiciona e remove alunos de uma turma");
            this.btnAtualizarTurma.UseVisualStyleBackColor = true;
            this.btnAtualizarTurma.Click += new System.EventHandler(this.btnAtualizarTurma_Click);
            // 
            // cbbCurso
            // 
            this.cbbCurso.FormattingEnabled = true;
            this.cbbCurso.Location = new System.Drawing.Point(351, 75);
            this.cbbCurso.Name = "cbbCurso";
            this.cbbCurso.Size = new System.Drawing.Size(228, 23);
            this.cbbCurso.TabIndex = 30;
            this.cbbCurso.SelectedIndexChanged += new System.EventHandler(this.cbbCurso_SelectedIndexChanged);
            // 
            // btnAdicionaAluno
            // 
            this.btnAdicionaAluno.Location = new System.Drawing.Point(385, 217);
            this.btnAdicionaAluno.Name = "btnAdicionaAluno";
            this.btnAdicionaAluno.Size = new System.Drawing.Size(30, 23);
            this.btnAdicionaAluno.TabIndex = 29;
            this.btnAdicionaAluno.Text = ">";
            this.btnAdicionaAluno.UseVisualStyleBackColor = true;
            this.btnAdicionaAluno.Click += new System.EventHandler(this.btnAdicionaAluno_Click);
            // 
            // lblCurso
            // 
            this.lblCurso.AutoSize = true;
            this.lblCurso.Location = new System.Drawing.Point(242, 78);
            this.lblCurso.Name = "lblCurso";
            this.lblCurso.Size = new System.Drawing.Size(104, 15);
            this.lblCurso.TabIndex = 28;
            this.lblCurso.Text = "Selecione o Curso:";
            // 
            // btnRemoverTurma
            // 
            this.btnRemoverTurma.Location = new System.Drawing.Point(351, 385);
            this.btnRemoverTurma.Name = "btnRemoverTurma";
            this.btnRemoverTurma.Size = new System.Drawing.Size(121, 23);
            this.btnRemoverTurma.TabIndex = 42;
            this.btnRemoverTurma.Tag = "";
            this.btnRemoverTurma.Text = "Remover Turma";
            this.toolTip1.SetToolTip(this.btnRemoverTurma, "Remove uma turma inteira");
            this.btnRemoverTurma.UseVisualStyleBackColor = true;
            this.btnRemoverTurma.Click += new System.EventHandler(this.btnRemoverTurma_Click);
            // 
            // lblStatusBusca
            // 
            this.lblStatusBusca.AutoSize = true;
            this.lblStatusBusca.Location = new System.Drawing.Point(202, 120);
            this.lblStatusBusca.Name = "lblStatusBusca";
            this.lblStatusBusca.Size = new System.Drawing.Size(0, 15);
            this.lblStatusBusca.TabIndex = 43;
            // 
            // FrmAlterarTurma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblStatusBusca);
            this.Controls.Add(this.btnRemoverTurma);
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
            this.Controls.Add(this.btnAtualizarTurma);
            this.Controls.Add(this.cbbCurso);
            this.Controls.Add(this.btnAdicionaAluno);
            this.Controls.Add(this.lblCurso);
            this.Name = "FrmAlterarTurma";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAlterarTurma";
            this.Load += new System.EventHandler(this.FrmAlterarTurma_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox ltbAlunosMat;
        private ListBox ltbAlunosCad;
        private Button btnRemoveAluno;
        private Label lblAlunosMatr;
        private Label lblAlunosCad;
        private Label lblVagasCurso;
        private Label lblTotVagas;
        private TextBox txtPesquisaAluno;
        private Button btnFechar;
        private Label lblTituloCadTurma;
        private Button btnAtualizarTurma;
        private ComboBox cbbCurso;
        private Button btnAdicionaAluno;
        private Label lblCurso;
        private ToolTip toolTip1;
        private Button btnRemoverTurma;
        private Label lblStatusBusca;
    }
}