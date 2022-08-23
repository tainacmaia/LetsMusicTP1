using LetsMusicTP1.Domain;
using LetsMusicTP1.Repositories;
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

        private void txtPesquisaAluno_TextChanged(object sender, EventArgs e)
        {
            string textoDigitado = txtPesquisaAluno.Text.ToLower();
            ltbAlunosCad.Items.Clear();
            var listaFiltrada = alunosCad.Where(x => x.ToLower().Contains(textoDigitado));
            foreach (var aluno in listaFiltrada)
            {
                ltbAlunosCad.Items.Add(aluno);
            }
        }

        private void FrmAlterarTurma_Load(object sender, EventArgs e)
        {
            List<string> cursos = RepositorioTurma.listaTurma.Select(x => x.NomeCurso).Distinct().ToList();
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
            if (!ltbAlunosMat.Items.Contains(ltbAlunosCad.SelectedItem))
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
            RepositorioTurma.listaTurma.RemoveAll(x => x.NomeCurso == cbbCurso.SelectedItem.ToString());
            foreach (var aluno in ltbAlunosMat.Items)
            {
                Turma turma = new Turma() { NomeAluno = aluno.ToString(), NomeCurso = cbbCurso.SelectedItem.ToString() };
                RepositorioTurma.listaTurma.Add(turma);
            }
            MessageBox.Show("Turma atualizada com sucesso!");
        }

        private void cbbCurso_SelectedIndexChanged(object sender, EventArgs e)
        {
            ltbAlunosMat.Items.Clear();
            var lista = RepositorioTurma.listaTurma.FindAll(x => x.NomeCurso == cbbCurso.SelectedItem.ToString());
            foreach (var aluno in lista)
            {
                ltbAlunosMat.Items.Add(aluno.NomeAluno);
            }
        }

        private void btnRemoveAluno_Click(object sender, EventArgs e)
        {
            ltbAlunosMat.Items.Remove(ltbAlunosMat.SelectedItem);
        }
    }
}
