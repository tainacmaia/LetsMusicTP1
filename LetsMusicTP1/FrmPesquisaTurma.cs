using LetsMusicTP1.Domain;
using LetsMusicTP1.Repositories;
using System.ComponentModel;

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
            var source = new BindingSource();
            source.DataSource = RepositorioTurma.listaTurma;
            dtgTurma.DataSource = source;
        }

        private async void txtPesquisaTurma_TextChanged(object sender, EventArgs e)
        {
            string textoDigitado = txtPesquisaTurma.Text;
            var source = new BindingSource();
            lblStatusBusca.Text = "Buscando...Por favor aguarde";
            await Task.Delay(2000);
            lblStatusBusca.Text = "";
            source.DataSource = RepositorioTurma.BuscaTurma(textoDigitado);
            dtgTurma.DataSource = source;
        }

        private void btnAlterarTurma_Click(object sender, EventArgs e)
        {
            var formCadastro = new FrmAlterarTurma();
            formCadastro.ShowDialog();

            var bindingList = new BindingList<Turma>(RepositorioTurma.listaTurma);
            var source = new BindingSource(bindingList, null);
            dtgTurma.DataSource = source;
        }
    }
}
