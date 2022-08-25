namespace LetsMusicTP1
{
    partial class frmCadastroAluno
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadastroAluno));
            this.btnCadastrarAluno = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.lblCpf = new System.Windows.Forms.Label();
            this.txbNome = new System.Windows.Forms.TextBox();
            this.txbEmail = new System.Windows.Forms.TextBox();
            this.mskTelefone = new System.Windows.Forms.MaskedTextBox();
            this.mskCpf = new System.Windows.Forms.MaskedTextBox();
            this.lblTituloCadAluno = new System.Windows.Forms.Label();
            this.lblCampoObrig1 = new System.Windows.Forms.Label();
            this.lblInstrucoes = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCadastrarAluno
            // 
            this.btnCadastrarAluno.Location = new System.Drawing.Point(109, 308);
            this.btnCadastrarAluno.Name = "btnCadastrarAluno";
            this.btnCadastrarAluno.Size = new System.Drawing.Size(75, 23);
            this.btnCadastrarAluno.TabIndex = 5;
            this.btnCadastrarAluno.Text = "Cadastrar";
            this.btnCadastrarAluno.UseVisualStyleBackColor = true;
            this.btnCadastrarAluno.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.Location = new System.Drawing.Point(242, 308);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(75, 23);
            this.btnFechar.TabIndex = 6;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNome.Location = new System.Drawing.Point(79, 93);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(49, 15);
            this.lblNome.TabIndex = 2;
            this.lblNome.Text = "Nome:*";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblEmail.Location = new System.Drawing.Point(79, 138);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(49, 15);
            this.lblEmail.TabIndex = 3;
            this.lblEmail.Text = "E-mail:*";
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTelefone.Location = new System.Drawing.Point(79, 185);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(64, 15);
            this.lblTelefone.TabIndex = 4;
            this.lblTelefone.Text = "Telefone:*";
            // 
            // lblCpf
            // 
            this.lblCpf.AutoSize = true;
            this.lblCpf.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCpf.Location = new System.Drawing.Point(79, 231);
            this.lblCpf.Name = "lblCpf";
            this.lblCpf.Size = new System.Drawing.Size(35, 15);
            this.lblCpf.TabIndex = 5;
            this.lblCpf.Text = "CPF:*";
            // 
            // txbNome
            // 
            this.txbNome.Location = new System.Drawing.Point(142, 90);
            this.txbNome.Name = "txbNome";
            this.txbNome.Size = new System.Drawing.Size(205, 23);
            this.txbNome.TabIndex = 1;
            // 
            // txbEmail
            // 
            this.txbEmail.Location = new System.Drawing.Point(142, 137);
            this.txbEmail.Name = "txbEmail";
            this.txbEmail.Size = new System.Drawing.Size(205, 23);
            this.txbEmail.TabIndex = 2;
            // 
            // mskTelefone
            // 
            this.mskTelefone.Location = new System.Drawing.Point(142, 185);
            this.mskTelefone.Mask = "(00)00000-0000";
            this.mskTelefone.Name = "mskTelefone";
            this.mskTelefone.Size = new System.Drawing.Size(129, 23);
            this.mskTelefone.TabIndex = 3;
            this.mskTelefone.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals;
            // 
            // mskCpf
            // 
            this.mskCpf.Culture = new System.Globalization.CultureInfo("");
            this.mskCpf.Location = new System.Drawing.Point(142, 228);
            this.mskCpf.Mask = "000.000.000-00";
            this.mskCpf.Name = "mskCpf";
            this.mskCpf.Size = new System.Drawing.Size(129, 23);
            this.mskCpf.TabIndex = 4;
            this.mskCpf.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals;
            // 
            // lblTituloCadAluno
            // 
            this.lblTituloCadAluno.AutoSize = true;
            this.lblTituloCadAluno.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTituloCadAluno.Location = new System.Drawing.Point(146, 25);
            this.lblTituloCadAluno.Name = "lblTituloCadAluno";
            this.lblTituloCadAluno.Size = new System.Drawing.Size(122, 17);
            this.lblTituloCadAluno.TabIndex = 10;
            this.lblTituloCadAluno.Text = "Cadastro de Aluno";
            // 
            // lblCampoObrig1
            // 
            this.lblCampoObrig1.AutoSize = true;
            this.lblCampoObrig1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCampoObrig1.Location = new System.Drawing.Point(84, 265);
            this.lblCampoObrig1.Name = "lblCampoObrig1";
            this.lblCampoObrig1.Size = new System.Drawing.Size(115, 13);
            this.lblCampoObrig1.TabIndex = 11;
            this.lblCampoObrig1.Text = "* Campo Obrigatório";
            // 
            // lblInstrucoes
            // 
            this.lblInstrucoes.AutoSize = true;
            this.lblInstrucoes.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblInstrucoes.Location = new System.Drawing.Point(79, 62);
            this.lblInstrucoes.Name = "lblInstrucoes";
            this.lblInstrucoes.Size = new System.Drawing.Size(161, 15);
            this.lblInstrucoes.TabIndex = 12;
            this.lblInstrucoes.Text = "Preencha os campos abaixo:";
            // 
            // frmCadastroAluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::LetsMusicTP1.Presentation.Properties.Resources.fundo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(414, 361);
            this.Controls.Add(this.lblInstrucoes);
            this.Controls.Add(this.lblCampoObrig1);
            this.Controls.Add(this.lblTituloCadAluno);
            this.Controls.Add(this.mskCpf);
            this.Controls.Add(this.mskTelefone);
            this.Controls.Add(this.txbEmail);
            this.Controls.Add(this.txbNome);
            this.Controls.Add(this.lblCpf);
            this.Controls.Add(this.lblTelefone);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.btnCadastrarAluno);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCadastroAluno";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Aluno";
            this.Load += new System.EventHandler(this.frmCadastroAluno_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnCadastrarAluno;
        private Button btnFechar;
        private Label lblNome;
        private Label lblEmail;
        private Label lblTelefone;
        private Label lblCpf;
        private TextBox txbNome;
        private TextBox txbEmail;
        private MaskedTextBox mskTelefone;
        private MaskedTextBox mskCpf;
        private Label lblTituloCadAluno;
        private Label lblCampoObrig1;
        private Label lblInstrucoes;
    }
}