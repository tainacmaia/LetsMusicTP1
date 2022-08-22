using LetsMusicTP1.Repositories;
using System.Data;

namespace LetsMusicTP1
{
    public partial class FrmCadastroTurma : Form
    {
        public FrmCadastroTurma()
        {
            InitializeComponent();
        }

        private void FrmCadastroTurma_Load(object sender, EventArgs e)
        {
            List<string> cursos = RepositorioCurso.listaCurso.Select(x => x.Nome).ToList();
            foreach (var curso in cursos)
            {
                cbbCurso.Items.Add(curso);
            }

            List<string> alunosCad = RepositorioAluno.listaAlunos.Select(x => x.Nome).ToList();
            foreach (var aluno in alunosCad)
            {
                ltbAlunosCad.Items.Add(aluno);
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dtgAlunosCurso_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dtgAlunosCad_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
