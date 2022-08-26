using LetsMusicTP1.Domain;
using LetsMusicTP1.Services;

namespace LetsMusicTP1
{
    public partial class FrmPesquisaAluno : Form
    {
        public FrmPesquisaAluno()
        {
            InitializeComponent();
        }
        private void FrmPesquisaAluno_Load(object sender, EventArgs e)
        {
            InicializaGrid();
        }
        private void InicializaGrid()
        {
            var listaGeral = ServicesAluno.BuscaTodosAlunos();
            AtualizaDataGrid(listaGeral);
        }
        private void AtualizaDataGrid(List<Aluno> listaAlunos)
        {
            var source = new BindingSource();
            source.DataSource = listaAlunos;
            dtgAlunos.DataSource = source;
        }

        private async void txtValorPesquisa_TextChanged(object sender, EventArgs e)
        {
            string textoDigitado = txtValorPesquisa.Text;
            lblStatusBusca.Text = "Buscando...Por favor aguarde";
            await Task.Delay(2000);
            var listaFiltrada = ServicesAluno.BuscaAlunoPorCamposGerais(textoDigitado);
            AtualizaDataGrid(listaFiltrada);
            lblStatusBusca.Text = "";
        }

        private void btnAlterarAluno_Click(object sender, EventArgs e)
        {
            if (dtgAlunos.SelectedRows.Count > 0)
            {
                var atualizaAluno = ServicesAluno.PesuisaAlunoPorCpf(textBox1.Text);
                if (atualizaAluno.Nome != textBox2.Text ||
                    atualizaAluno.Telefone != textBox3.Text ||
                    atualizaAluno.Email != textBox4.Text)
                {
                    var result = MessageBox.Show("Deseja mesmo alterar informações do aluno?", "Aviso", MessageBoxButtons.OKCancel);
                    if (result == DialogResult.Cancel)
                    {
                        LimpaCamposAlteracao();
                        return;
                    }
                    atualizaAluno.Nome = textBox2.Text;
                    atualizaAluno.Telefone = textBox3.Text;
                    atualizaAluno.Email = textBox4.Text;
                }
                LimpaCamposAlteracao();

                InicializaGrid();
            }
        }

        private void LimpaCamposAlteracao()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            txtValorPesquisa.Clear();
        }

        private void dtgAlunos_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            textBox1.Text = dtgAlunos.SelectedRows[0].Cells[0].Value.ToString();
            textBox2.Text = dtgAlunos.SelectedRows[0].Cells[1].Value.ToString();
            textBox3.Text = dtgAlunos.SelectedRows[0].Cells[2].Value.ToString();
            textBox4.Text = dtgAlunos.SelectedRows[0].Cells[3].Value.ToString();
        }

        private void btnRemoverAluno_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Deseja mesmo remover esse aluno?", "Aviso", MessageBoxButtons.OKCancel);
            if (result == DialogResult.Cancel)
            {
                LimpaCamposAlteracao();
                return;
            }
            ServicesAluno.RemoveAluno(textBox1.Text, textBox2.Text);
            LimpaCamposAlteracao();
            InicializaGrid();
        }
    }
}
