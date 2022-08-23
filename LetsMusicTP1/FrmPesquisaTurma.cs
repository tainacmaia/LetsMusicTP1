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

        private void txtPesquisaTurma_TextChanged(object sender, EventArgs e)
        {
            string textoDigitado = txtPesquisaTurma.Text;
            var source = new BindingSource();
            source.DataSource = RepositorioTurma.BuscaTurma(textoDigitado);
            dtgTurma.DataSource = source;
        }

        private void btnRemoverTurma_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Deseja mesmo remover uma turma completa?", "Aviso", MessageBoxButtons.OKCancel);
            if (result == DialogResult.Cancel)
            {
                return;
            }

            if (dtgTurma.SelectedRows.Count > 0)
            {
                Turma selected = (Turma)dtgTurma.CurrentRow.DataBoundItem;

                RepositorioTurma.listaTurma.RemoveAll(x => x.NomeCurso == selected.NomeCurso);

                var bindingList = new BindingList<Turma>(RepositorioTurma.listaTurma);
                var source = new BindingSource(bindingList, null);
                dtgTurma.DataSource = source;
            }
        }

        private void btnRemoverAluno_Click(object sender, EventArgs e)
        {
            if (dtgTurma.SelectedRows.Count > 0)
            {
                Turma selected = (Turma)dtgTurma.CurrentRow.DataBoundItem;
                RepositorioTurma.listaTurma.Remove(selected);

                var bindingList = new BindingList<Turma>(RepositorioTurma.listaTurma);
                var source = new BindingSource(bindingList, null);
                dtgTurma.DataSource = source;
            }
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
