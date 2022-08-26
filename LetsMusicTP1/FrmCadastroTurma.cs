using LetsMusicTP1.Domain;
using LetsMusicTP1.Services;
using System.Data;

namespace LetsMusicTP1
{
    public partial class FrmCadastroTurma : Form
    {
        List<string> alunosCad = ServicesAluno.BuscaTodosAlunos().Select(x => x.Nome).ToList();
        public FrmCadastroTurma()
        {
            InitializeComponent();
        }

        private void FrmCadastroTurma_Load(object sender, EventArgs e)
        {
            List<string> cursos = ServicesCurso.BuscaoTodosCursos().Select(x => x.Nome).ToList();
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

        private void btnAdicionaAluno_Click(object sender, EventArgs e)
        {
            if (!ltbAlunosMat.Items.Contains(ltbAlunosCad.SelectedItem) &&
                ltbAlunosMat.Items.Count < int.Parse(lblVagasCurso.Text))
            {
                ltbAlunosMat.Items.Add(ltbAlunosCad.SelectedItem);
            }
        }

        private void btnRemoveAluno_Click(object sender, EventArgs e)
        {
            ltbAlunosMat.Items.Remove(ltbAlunosMat.SelectedItem);
        }

        private void btnCadastrarTurma_Click(object sender, EventArgs e)
        {
            if (ltbAlunosMat.Items.Count == 0 || cbbCurso.SelectedItem.ToString() == "")
            {
                MessageBox.Show("Preencha todos os campos obrigatórios!");
                return;
            }
            if (ServicesTurma.ListaTurmasCurso(cbbCurso.SelectedItem.ToString()).Any())
            {
                MessageBox.Show("Curso já possui turma cadastrada!");
                return;
            }
            foreach (var aluno in ltbAlunosMat.Items)
            {
                Turma turma = new Turma() { NomeAluno = aluno.ToString(), NomeCurso = cbbCurso.SelectedItem.ToString() };
                ServicesTurma.CadastrarTurma(turma);
            }
            MessageBox.Show("Turma cadastrada com sucesso!");
            cbbCurso.ResetText();
            ltbAlunosMat.Items.Clear();
            txtPesquisaAluno.Clear();
            lblVagasCurso.Text = "";
        }

        private void cbbCurso_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblVagasCurso.Text = ServicesCurso.PesquisaVagasCurso(cbbCurso.SelectedItem.ToString());
        }
    }
}
