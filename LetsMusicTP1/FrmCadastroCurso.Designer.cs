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
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox2 = new System.Windows.Forms.MaskedTextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblCampoObrig1 = new System.Windows.Forms.Label();
            this.lblTituloCadCurso = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnFechar = new System.Windows.Forms.Button();
            this.btnCadastrarCurso = new System.Windows.Forms.Button();
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
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(190, 138);
            this.maskedTextBox1.Mask = "00000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(86, 23);
            this.maskedTextBox1.TabIndex = 3;
            this.maskedTextBox1.ValidatingType = typeof(int);
            // 
            // maskedTextBox2
            // 
            this.maskedTextBox2.Location = new System.Drawing.Point(164, 176);
            this.maskedTextBox2.Mask = "00000";
            this.maskedTextBox2.Name = "maskedTextBox2";
            this.maskedTextBox2.Size = new System.Drawing.Size(112, 23);
            this.maskedTextBox2.TabIndex = 4;
            this.maskedTextBox2.ValidatingType = typeof(int);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(139, 95);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(137, 23);
            this.textBox1.TabIndex = 5;
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
            this.lblTituloCadCurso.Location = new System.Drawing.Point(85, 40);
            this.lblTituloCadCurso.Name = "lblTituloCadCurso";
            this.lblTituloCadCurso.Size = new System.Drawing.Size(247, 17);
            this.lblTituloCadCurso.TabIndex = 12;
            this.lblTituloCadCurso.Text = "Insira os dados para cadastro do Curso";
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
            // 
            // FrmCadastroCurso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 361);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.btnCadastrarCurso);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblCampoObrig1);
            this.Controls.Add(this.lblTituloCadCurso);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.maskedTextBox2);
            this.Controls.Add(this.maskedTextBox1);
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
        private MaskedTextBox maskedTextBox1;
        private MaskedTextBox maskedTextBox2;
        private TextBox textBox1;
        private Label lblCampoObrig1;
        private Label lblTituloCadCurso;
        private Label label1;
        private Button btnFechar;
        private Button btnCadastrarCurso;
    }
}