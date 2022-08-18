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
        }
    }
}
