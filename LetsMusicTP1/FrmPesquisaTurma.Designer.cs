namespace LetsMusicTP1.Presentation
{
    partial class FrmPesquisaTurma
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnRemoverTurma = new System.Windows.Forms.Button();
            this.btnAlterarTurma = new System.Windows.Forms.Button();
            this.txtPesquisaTurma = new System.Windows.Forms.TextBox();
            this.lblTituloPesqTurma = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(35, 95);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView1.Size = new System.Drawing.Size(469, 185);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnRemoverTurma
            // 
            this.btnRemoverTurma.Location = new System.Drawing.Point(314, 307);
            this.btnRemoverTurma.Name = "btnRemoverTurma";
            this.btnRemoverTurma.Size = new System.Drawing.Size(75, 23);
            this.btnRemoverTurma.TabIndex = 3;
            this.btnRemoverTurma.Text = "Remover";
            this.btnRemoverTurma.UseVisualStyleBackColor = true;
            // 
            // btnAlterarTurma
            // 
            this.btnAlterarTurma.Location = new System.Drawing.Point(157, 307);
            this.btnAlterarTurma.Name = "btnAlterarTurma";
            this.btnAlterarTurma.Size = new System.Drawing.Size(75, 23);
            this.btnAlterarTurma.TabIndex = 2;
            this.btnAlterarTurma.Text = "Alterar";
            this.btnAlterarTurma.UseVisualStyleBackColor = true;
            // 
            // txtPesquisaTurma
            // 
            this.txtPesquisaTurma.Location = new System.Drawing.Point(35, 55);
            this.txtPesquisaTurma.Name = "txtPesquisaTurma";
            this.txtPesquisaTurma.PlaceholderText = "Digite dado para busca...";
            this.txtPesquisaTurma.Size = new System.Drawing.Size(175, 23);
            this.txtPesquisaTurma.TabIndex = 1;
            // 
            // lblTituloPesqTurma
            // 
            this.lblTituloPesqTurma.AutoSize = true;
            this.lblTituloPesqTurma.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTituloPesqTurma.Location = new System.Drawing.Point(200, 25);
            this.lblTituloPesqTurma.Name = "lblTituloPesqTurma";
            this.lblTituloPesqTurma.Size = new System.Drawing.Size(124, 17);
            this.lblTituloPesqTurma.TabIndex = 12;
            this.lblTituloPesqTurma.Text = "Pesquisa de Turma";
            // 
            // FrmPesquisaTurma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 361);
            this.Controls.Add(this.lblTituloPesqTurma);
            this.Controls.Add(this.txtPesquisaTurma);
            this.Controls.Add(this.btnRemoverTurma);
            this.Controls.Add(this.btnAlterarTurma);
            this.Controls.Add(this.dataGridView1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmPesquisaTurma";
            this.Text = "Pesquisa Turma";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataGridView1;
        private Button btnRemoverTurma;
        private Button btnAlterarTurma;
        private TextBox txtPesquisaTurma;
        private Label lblTituloPesqTurma;
    }
}