using LetsMusicTP1.Repositories;

namespace LetsMusicTP1
{
    public partial class FrmPesquisaAluno : Form
    {
        public FrmPesquisaAluno()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FrmPesquisaAluno_Load(object sender, EventArgs e)
        {
            var source = new BindingSource();
            source.DataSource = RepositorioAluno.listaAlunos;
            dtgAlunos.DataSource = source;
        }

        private void txtValorPesquisa_TextChanged(object sender, EventArgs e)
        {
            string textoDigitado = txtValorPesquisa.Text;
            var source = new BindingSource();
            source.DataSource = RepositorioAluno.BuscaAluno(textoDigitado);
            dtgAlunos.DataSource = source;
        }
    }
}
