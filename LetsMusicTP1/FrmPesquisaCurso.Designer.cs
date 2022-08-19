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
            ((System.ComponentModel.ISupportInitialize)(this.dtgCursos)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgCursos
            // 
            this.dtgCursos.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dtgCursos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgCursos.Location = new System.Drawing.Point(35, 95);
            this.dtgCursos.Name = "dtgCursos";
            this.dtgCursos.RowTemplate.Height = 25;
            this.dtgCursos.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dtgCursos.Size = new System.Drawing.Size(456, 153);
            this.dtgCursos.TabIndex = 0;
            // 
            // btnRemoverCurso
            // 
            this.btnRemoverCurso.Location = new System.Drawing.Point(316, 286);
            this.btnRemoverCurso.Name = "btnRemoverCurso";
            this.btnRemoverCurso.Size = new System.Drawing.Size(75, 23);
            this.btnRemoverCurso.TabIndex = 3;
            this.btnRemoverCurso.Text = "Remover";
            this.btnRemoverCurso.UseVisualStyleBackColor = true;
            // 
            // btnAlterarCurso
            // 
            this.btnAlterarCurso.Location = new System.Drawing.Point(159, 286);
            this.btnAlterarCurso.Name = "btnAlterarCurso";
            this.btnAlterarCurso.Size = new System.Drawing.Size(75, 23);
            this.btnAlterarCurso.TabIndex = 2;
            this.btnAlterarCurso.Text = "Alterar";
            this.btnAlterarCurso.UseVisualStyleBackColor = true;
            // 
            // txtPesquisaCurso
            // 
            this.txtPesquisaCurso.Location = new System.Drawing.Point(35, 55);
            this.txtPesquisaCurso.Name = "txtPesquisaCurso";
            this.txtPesquisaCurso.PlaceholderText = "Digite dado para busca...";
            this.txtPesquisaCurso.Size = new System.Drawing.Size(175, 23);
            this.txtPesquisaCurso.TabIndex = 1;
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
            // FrmPesquisaCurso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 361);
            this.Controls.Add(this.lblTituloPesqCurso);
            this.Controls.Add(this.txtPesquisaCurso);
            this.Controls.Add(this.btnRemoverCurso);
            this.Controls.Add(this.btnAlterarCurso);
            this.Controls.Add(this.dtgCursos);
            this.Name = "FrmPesquisaCurso";
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
    }
}