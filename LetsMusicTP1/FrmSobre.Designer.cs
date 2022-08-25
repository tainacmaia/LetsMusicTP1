namespace LetsMusicTP1
{
    partial class frmSobre
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
            this.btnFechar = new System.Windows.Forms.Button();
            this.lblTituloSobre = new System.Windows.Forms.Label();
            this.lblSobre = new System.Windows.Forms.Label();
            this.lblSobreTexto = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnFechar
            // 
            this.btnFechar.Location = new System.Drawing.Point(166, 208);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(66, 23);
            this.btnFechar.TabIndex = 1;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // lblTituloSobre
            // 
            this.lblTituloSobre.AutoSize = true;
            this.lblTituloSobre.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTituloSobre.Location = new System.Drawing.Point(156, 20);
            this.lblTituloSobre.Name = "lblTituloSobre";
            this.lblTituloSobre.Size = new System.Drawing.Size(86, 20);
            this.lblTituloSobre.TabIndex = 1;
            this.lblTituloSobre.Text = "Let\'s Music";
            // 
            // lblSobre
            // 
            this.lblSobre.AutoSize = true;
            this.lblSobre.Location = new System.Drawing.Point(92, 150);
            this.lblSobre.Name = "lblSobre";
            this.lblSobre.Size = new System.Drawing.Size(216, 30);
            this.lblSobre.TabIndex = 2;
            this.lblSobre.Text = "Desenvolvido por: \r\nSérgio Dias, Taina Maia , Viviane Perrotti\r\n";
            this.lblSobre.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblSobreTexto
            // 
            this.lblSobreTexto.AutoSize = true;
            this.lblSobreTexto.Location = new System.Drawing.Point(84, 54);
            this.lblSobreTexto.Name = "lblSobreTexto";
            this.lblSobreTexto.Size = new System.Drawing.Size(224, 90);
            this.lblSobreTexto.TabIndex = 3;
            this.lblSobreTexto.Text = "Programa Desenvolvido para Cadastro \r\nde Alunos, Cursos e Turmas da Escola de \r\nM" +
    "úsica Let\'s Music.\r\n\r\nVersão: 1.0\r\n\r\n";
            this.lblSobreTexto.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // frmSobre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 261);
            this.ControlBox = false;
            this.Controls.Add(this.lblSobreTexto);
            this.Controls.Add(this.lblSobre);
            this.Controls.Add(this.lblTituloSobre);
            this.Controls.Add(this.btnFechar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmSobre";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sobre";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnFechar;
        private Label lblTituloSobre;
        private Label lblSobre;
        private Label lblSobreTexto;
    }
}