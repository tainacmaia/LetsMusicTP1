using LetsMusicTP1.Domain;
using LetsMusicTP1.Repositories;
using LetsMusicTP1.Services;
using System.Data;

namespace LetsMusicTP1.Presentation
{
    public partial class FrmAlterarTurma : Form
    {
        List<string> alunosCad = RepositorioAluno.listaAlunos.Select(x => x.Nome).ToList();
        public FrmAlterarTurma()
        {
            InitializeComponent();
        }

        private async void txtPesquisaAluno_TextChanged(object sender, EventArgs e)
        {
            string textoDigitado = txtPesquisaAluno.Text.ToLower();
            lblStatusBusca.Text = "Buscando...Por favor aguarde";
            await Task.Delay(2000);
            lblStatusBusca.Text = "";
            ltbAlunosCad.Items.Clear();
            var listaFiltrada = ServicesAluno.PesquisarAlunosPorNome(textoDigitado);
            foreach (var aluno in listaFiltrada)
            {
                ltbAlunosCad.Items.Add(aluno.Nome);
            }
        }

        private void FrmAlterarTurma_Load(object sender, EventArgs e)
        {
            List<string> cursos = ServicesTurma.ListaCursosTurma();
            foreach (var curso in cursos)
            {
                cbbCurso.Items.Add(curso);
            }

            foreach (var aluno in alunosCad)
            {
                ltbAlunosCad.Items.Add(aluno);
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdicionaAluno_Click(object sender, EventArgs e)
        {
            if (cbbCurso is not null && !ltbAlunosMat.Items.Contains(ltbAlunosCad.SelectedItem) &&
            ltbAlunosMat.Items.Count < int.Parse(lblVagasCurso.Text))
            {
                ltbAlunosMat.Items.Add(ltbAlunosCad.SelectedItem);
            }

        }

        private void btnAtualizarTurma_Click(object sender, EventArgs e)
        {
            if (ltbAlunosMat.Items.Count == 0 || cbbCurso.SelectedItem is null)
            {
                MessageBox.Show("Preencha todos os campos obrigatórios!");
                return;
            }
            ServicesTurma.RemoveTurmasDeCurso(cbbCurso.SelectedItem.ToString());
            foreach (var aluno in ltbAlunosMat.Items)
            {
                Turma turma = new Turma() { NomeAluno = aluno.ToString(), NomeCurso = cbbCurso.SelectedItem.ToString() };
                ServicesTurma.CadastrarTurma(turma);
            }
            MessageBox.Show("Turma atualizada com sucesso!");
            cbbCurso.ResetText();
            ltbAlunosMat.Items.Clear();
            txtPesquisaAluno.Clear();
            lblVagasCurso.Text = "";
        }

        private void cbbCurso_SelectedIndexChanged(object sender, EventArgs e)
        {
            ltbAlunosMat.Items.Clear();
            lblVagasCurso.Text = ServicesCurso.PesquisaVagasCurso(cbbCurso.SelectedItem.ToString());
            var lista = ServicesTurma.ListaTurmasCurso(cbbCurso.SelectedItem.ToString());

            foreach (var aluno in lista)
            {
                ltbAlunosMat.Items.Add(aluno.NomeAluno);
            }
        }

        private void btnRemoveAluno_Click(object sender, EventArgs e)
        {
            ltbAlunosMat.Items.Remove(ltbAlunosMat.SelectedItem);
        }

        private void btnRemoverTurma_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Deseja mesmo remover uma turma completa?", "Aviso", MessageBoxButtons.OKCancel);
            if (result == DialogResult.Cancel)
            {
                return;
            }

            if (cbbCurso.SelectedItem is not null)
            {
                ServicesTurma.RemoveTurmasDeCurso(cbbCurso.SelectedItem.ToString());
                ltbAlunosMat.Items.Clear();
                cbbCurso.Items.Remove(cbbCurso.SelectedItem);
            }
        }
    }
}
