namespace LetsMusicTP1
{
    partial class FrmCadastroCurso
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
            this.lblNome = new System.Windows.Forms.Label();
            this.lblCargaHoraria = new System.Windows.Forms.Label();
            this.lblVagas = new System.Windows.Forms.Label();
            this.mskCarga = new System.Windows.Forms.MaskedTextBox();
            this.mskVagas = new System.Windows.Forms.MaskedTextBox();
            this.txtNomeCurso = new System.Windows.Forms.TextBox();
            this.lblCampoObrig1 = new System.Windows.Forms.Label();
            this.lblTituloCadCurso = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnFechar = new System.Windows.Forms.Button();
            this.btnCadastrarCurso = new System.Windows.Forms.Button();
            this.lblInstrucoes = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(85, 98);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(48, 15);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome:*";
            // 
            // lblCargaHoraria
            // 
            this.lblCargaHoraria.AutoSize = true;
            this.lblCargaHoraria.Location = new System.Drawing.Point(85, 141);
            this.lblCargaHoraria.Name = "lblCargaHoraria";
            this.lblCargaHoraria.Size = new System.Drawing.Size(80, 15);
            this.lblCargaHoraria.TabIndex = 1;
            this.lblCargaHoraria.Text = "Carga Horária";
            // 
            // lblVagas
            // 
            this.lblVagas.AutoSize = true;
            this.lblVagas.Location = new System.Drawing.Point(85, 179);
            this.lblVagas.Name = "lblVagas";
            this.lblVagas.Size = new System.Drawing.Size(37, 15);
            this.lblVagas.TabIndex = 2;
            this.lblVagas.Text = "Vagas";
            // 
            // mskCarga
            // 
            this.mskCarga.Location = new System.Drawing.Point(190, 138);
            this.mskCarga.Mask = "00000";
            this.mskCarga.Name = "mskCarga";
            this.mskCarga.Size = new System.Drawing.Size(86, 23);
            this.mskCarga.TabIndex = 3;
            this.mskCarga.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.mskCarga.ValidatingType = typeof(int);
            // 
            // mskVagas
            // 
            this.mskVagas.Location = new System.Drawing.Point(164, 176);
            this.mskVagas.Mask = "00000";
            this.mskVagas.Name = "mskVagas";
            this.mskVagas.Size = new System.Drawing.Size(112, 23);
            this.mskVagas.TabIndex = 4;
            this.mskVagas.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.mskVagas.ValidatingType = typeof(int);
            // 
            // txtNomeCurso
            // 
            this.txtNomeCurso.Location = new System.Drawing.Point(139, 95);
            this.txtNomeCurso.Name = "txtNomeCurso";
            this.txtNomeCurso.Size = new System.Drawing.Size(137, 23);
            this.txtNomeCurso.TabIndex = 5;
            // 
            // lblCampoObrig1
            // 
            this.lblCampoObrig1.AutoSize = true;
            this.lblCampoObrig1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCampoObrig1.Location = new System.Drawing.Point(91, 214);
            this.lblCampoObrig1.Name = "lblCampoObrig1";
            this.lblCampoObrig1.Size = new System.Drawing.Size(115, 13);
            this.lblCampoObrig1.TabIndex = 13;
            this.lblCampoObrig1.Text = "* Campo Obrigatório";
            // 
            // lblTituloCadCurso
            // 
            this.lblTituloCadCurso.AutoSize = true;
            this.lblTituloCadCurso.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTituloCadCurso.Location = new System.Drawing.Point(140, 25);
            this.lblTituloCadCurso.Name = "lblTituloCadCurso";
            this.lblTituloCadCurso.Size = new System.Drawing.Size(120, 17);
            this.lblTituloCadCurso.TabIndex = 12;
            this.lblTituloCadCurso.Text = "Cadastro de Curso";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(282, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 15);
            this.label1.TabIndex = 14;
            this.label1.Text = "horas-aula";
            // 
            // btnFechar
            // 
            this.btnFechar.Location = new System.Drawing.Point(236, 271);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(75, 23);
            this.btnFechar.TabIndex = 16;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            // 
            // btnCadastrarCurso
            // 
            this.btnCadastrarCurso.Location = new System.Drawing.Point(103, 271);
            this.btnCadastrarCurso.Name = "btnCadastrarCurso";
            this.btnCadastrarCurso.Size = new System.Drawing.Size(75, 23);
            this.btnCadastrarCurso.TabIndex = 15;
            this.btnCadastrarCurso.Text = "Cadastrar";
            this.btnCadastrarCurso.UseVisualStyleBackColor = true;
            this.btnCadastrarCurso.Click += new System.EventHandler(this.btnCadastrarCurso_Click);
            // 
            // lblInstrucoes
            // 
            this.lblInstrucoes.AutoSize = true;
            this.lblInstrucoes.Location = new System.Drawing.Point(85, 66);
            this.lblInstrucoes.Name = "lblInstrucoes";
            this.lblInstrucoes.Size = new System.Drawing.Size(157, 15);
            this.lblInstrucoes.TabIndex = 17;
            this.lblInstrucoes.Text = "Preencha os campos abaixo:";
            // 
            // FrmCadastroCurso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 361);
            this.Controls.Add(this.lblInstrucoes);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.btnCadastrarCurso);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblCampoObrig1);
            this.Controls.Add(this.lblTituloCadCurso);
            this.Controls.Add(this.txtNomeCurso);
            this.Controls.Add(this.mskVagas);
            this.Controls.Add(this.mskCarga);
            this.Controls.Add(this.lblVagas);
            this.Controls.Add(this.lblCargaHoraria);
            this.Controls.Add(this.lblNome);
            this.Name = "FrmCadastroCurso";
            this.Text = "Cadastro de Curso";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblNome;
        private Label lblCargaHoraria;
        private Label lblVagas;
        private MaskedTextBox mskCarga;
        private MaskedTextBox mskVagas;
        private TextBox txtNomeCurso;
        private Label lblCampoObrig1;
        private Label lblTituloCadCurso;
        private Label label1;
        private Button btnFechar;
        private Button btnCadastrarCurso;
        private Label lblInstrucoes;
    }
}