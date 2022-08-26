using LetsMusicTP1.Domain;
using LetsMusicTP1.Services;

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
            InicializaGrid();
        }
        private void InicializaGrid()
        {
            var listaGeral = ServicesCurso.BuscaoTodosCursos();
            AtualizaDataGrid(listaGeral);
        }
        private void AtualizaDataGrid(List<Curso> listaCursos)
        {
            var source = new BindingSource();
            source.DataSource = listaCursos;
            dtgCursos.DataSource = source;
        }

        private async void txtPesquisaCurso_TextChanged(object sender, EventArgs e)
        {
            string textoDigitado = txtPesquisaCurso.Text;
            lblStatusBusca.Text = "Buscando...Por favor aguarde";
            await Task.Delay(2000);
            var listaFiltrada = ServicesCurso.BuscaCursoGeral(textoDigitado);
            AtualizaDataGrid(listaFiltrada);
            lblStatusBusca.Text = "";
        }

        private void dtgCursos_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            textBox1.Text = dtgCursos.SelectedRows[0].Cells[0].Value.ToString();
            textBox2.Text = dtgCursos.SelectedRows[0].Cells[1].Value.ToString();
            textBox3.Text = dtgCursos.SelectedRows[0].Cells[2].Value.ToString();
        }

        private void btnAlterarCurso_Click(object sender, EventArgs e)
        {
            if (dtgCursos.SelectedRows.Count > 0)
            {
                var atualizaCurso = ServicesCurso.PesquisaCursoPorNome(textBox1.Text);
                if (atualizaCurso.CargaHoraria != textBox2.Text || atualizaCurso.Vagas != textBox3.Text)
                {
                    var result = MessageBox.Show("Deseja mesmo alterar informações do curso?", "Aviso", MessageBoxButtons.OKCancel);
                    if (result == DialogResult.Cancel)
                    {
                        LimpaCamposAlteracao();
                        return;
                    }
                    bool cursoAtualizado = ServicesCurso.AtualizaCurso(atualizaCurso, textBox2.Text, textBox3.Text);
                    if (!cursoAtualizado)
                    {
                        MessageBox.Show("Já existem mais alunos cadastrados nesse curso que o valor de vagas alterado.");
                    }
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
            txtPesquisaCurso.Clear();
        }

        private void btnRemoverCurso_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Deseja mesmo remover esse curso?", "Aviso", MessageBoxButtons.OKCancel);
            if (result == DialogResult.Cancel)
            {
                LimpaCamposAlteracao();
                return;
            }
            ServicesCurso.RemoveCurso(textBox1.Text);

            LimpaCamposAlteracao();
            InicializaGrid();
        }
    }
}
