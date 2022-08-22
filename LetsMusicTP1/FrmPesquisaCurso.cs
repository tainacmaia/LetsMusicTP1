using LetsMusicTP1.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LetsMusicTP1.Presentation
{
    public partial class FrmPesquisaCurso : Form
    {
        public FrmPesquisaCurso()
        {
            InitializeComponent();
        }

        private void FrmPesquisaCurso_Load(object sender, EventArgs e)
        {
            var source = new BindingSource();
            source.DataSource = RepositorioCurso.listaCurso;
            dtgCursos.DataSource = source;
        }

        private void txtPesquisaCurso_TextChanged(object sender, EventArgs e)
        {
            string textoDigitado = txtPesquisaCurso.Text;
            var source = new BindingSource();
            source.DataSource = RepositorioCurso.BuscaCurso(textoDigitado);
            dtgCursos.DataSource = source;
        }
    }
}
