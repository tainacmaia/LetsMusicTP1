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
    public partial class FrmPesquisaTurma : Form
    {
        public FrmPesquisaTurma()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FrmPesquisaTurma_Load(object sender, EventArgs e)
        {
            RepositorioTurma.IniciaLista();
            var source = new BindingSource();
            source.DataSource = RepositorioTurma.listaTurma;
            dtgTurma.DataSource = source;
        }

        private void txtPesquisaTurma_TextChanged(object sender, EventArgs e)
        {
            string textoDigitado = txtPesquisaTurma.Text;
            var source = new BindingSource();
            source.DataSource = RepositorioTurma.BuscaTurma(textoDigitado);
            dtgTurma.DataSource = source;
        }
    }
}
