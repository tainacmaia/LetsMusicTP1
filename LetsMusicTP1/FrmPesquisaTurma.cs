using LetsMusicTP1.Domain;
using LetsMusicTP1.Services;

namespace LetsMusicTP1.Presentation
{
    public partial class FrmPesquisaTurma : Form
    {
        public FrmPesquisaTurma()
        {
            InitializeComponent();
        }

        private void InicializaGrid()
        {
            var listaGeral = ServicesTurma.BuscarTodasTurmas();
            AtualizaDataGrid(listaGeral);
        }
        private void AtualizaDataGrid(List<Turma> listaTurmas)
        {
            var source = new BindingSource();
            source.DataSource = listaTurmas;
            dtgTurma.DataSource = source;
        }
        private void FrmPesquisaTurma_Load(object sender, EventArgs e)
        {
            InicializaGrid();
        }

        private async void txtPesquisaTurma_TextChanged(object sender, EventArgs e)
        {
            string textoDigitado = txtPesquisaTurma.Text;
            lblStatusBusca.Text = "Buscando...Por favor aguarde";
            await Task.Delay(2000);
            var listaFiltrada = ServicesTurma.BuscaTurmaGeral(textoDigitado);
            AtualizaDataGrid(listaFiltrada);
            lblStatusBusca.Text = "";
        }

        private void btnAlterarTurma_Click(object sender, EventArgs e)
        {
            var formCadastro = new FrmAlterarTurma();
            formCadastro.ShowDialog();
            InicializaGrid();
        }
    }
}
