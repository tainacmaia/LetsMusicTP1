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
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lblCurso = new System.Windows.Forms.Label();
            this.cbbCurso = new System.Windows.Forms.ComboBox();
            this.lblNomeAluno = new System.Windows.Forms.Label();
            this.btnCadastrarTurma = new System.Windows.Forms.Button();
            this.lblTituloCadTurma = new System.Windows.Forms.Label();
            this.btnFechar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(93, 133);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(114, 23);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "Adicionar aluno";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // lblCurso
            // 
            this.lblCurso.AutoSize = true;
            this.lblCurso.Location = new System.Drawing.Point(112, 82);
            this.lblCurso.Name = "lblCurso";
            this.lblCurso.Size = new System.Drawing.Size(38, 15);
            this.lblCurso.TabIndex = 0;
            this.lblCurso.Text = "Curso";
            // 
            // cbbCurso
            // 
            this.cbbCurso.FormattingEnabled = true;
            this.cbbCurso.Location = new System.Drawing.Point(173, 79);
            this.cbbCurso.Name = "cbbCurso";
            this.cbbCurso.Size = new System.Drawing.Size(121, 23);
            this.cbbCurso.TabIndex = 4;
            // 
            // lblNomeAluno
            // 
            this.lblNomeAluno.AutoSize = true;
            this.lblNomeAluno.Location = new System.Drawing.Point(240, 137);
            this.lblNomeAluno.Name = "lblNomeAluno";
            this.lblNomeAluno.Size = new System.Drawing.Size(92, 15);
            this.lblNomeAluno.TabIndex = 5;
            this.lblNomeAluno.Text = "Nome do Aluno";
            // 
            // btnCadastrarTurma
            // 
            this.btnCadastrarTurma.Location = new System.Drawing.Point(112, 188);
            this.btnCadastrarTurma.Name = "btnCadastrarTurma";
            this.btnCadastrarTurma.Size = new System.Drawing.Size(75, 23);
            this.btnCadastrarTurma.TabIndex = 6;
            this.btnCadastrarTurma.Text = "Cadastrar";
            this.btnCadastrarTurma.UseVisualStyleBackColor = true;
            // 
            // lblTituloCadTurma
            // 
            this.lblTituloCadTurma.AutoSize = true;
            this.lblTituloCadTurma.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTituloCadTurma.Location = new System.Drawing.Point(85, 40);
            this.lblTituloCadTurma.Name = "lblTituloCadTurma";
            this.lblTituloCadTurma.Size = new System.Drawing.Size(247, 17);
            this.lblTituloCadTurma.TabIndex = 13;
            this.lblTituloCadTurma.Text = "Insira os dados para cadastro do Curso";
            // 
            // btnFechar
            // 
            this.btnFechar.Location = new System.Drawing.Point(257, 188);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(75, 23);
            this.btnFechar.TabIndex = 17;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            // 
            // FrmCadastroTurma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 261);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.lblTituloCadTurma);
            this.Controls.Add(this.btnCadastrarTurma);
            this.Controls.Add(this.lblNomeAluno);
            this.Controls.Add(this.cbbCurso);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.lblCurso);
            this.Name = "FrmCadastroTurma";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmCadastroTurma";
            this.Load += new System.EventHandler(this.FrmCadastroTurma_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnBuscar;
        private Label lblCurso;
        private ComboBox cbbCurso;
        private Label lblNomeAluno;
        private Button btnCadastrarTurma;
        private Label lblTituloCadTurma;
        private Button btnFechar;
    }
}