using LetsMusicTP1.Presentation;

namespace LetsMusicTP1
{
    public partial class frmMenuLetsMusic : Form
    {
        public frmMenuLetsMusic()
        {
            InitializeComponent();
        }

        private void cadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Deseja mesmo sair?", "Aviso", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new frmSobre();
            form.ShowDialog();
        }

        private void alunoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new frmCadastroAluno();
            form.ShowDialog();
        }

        private void cursoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new FrmCadastroCurso();
            form.ShowDialog();
        }

        private void turmaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new FrmCadastroTurma();
            form.ShowDialog();
        }

        private void alunoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var form = new FrmPesquisaAluno();
            form.ShowDialog();
        }

        private void cursoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var form = new FrmPesquisaCurso();
            form.ShowDialog();
        }

        private void turmaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var form = new FrmPesquisaTurma();
            form.ShowDialog();
        }

        private void frmMenuLetsMusic_Load(object sender, EventArgs e)
        {

        }
    }
}