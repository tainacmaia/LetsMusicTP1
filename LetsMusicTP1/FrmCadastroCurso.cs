using LetsMusicTP1.Services;

namespace LetsMusicTP1
{
    public partial class FrmCadastroCurso : Form
    {
        public FrmCadastroCurso()
        {
            InitializeComponent();
        }

        private void btnCadastrarCurso_Click(object sender, EventArgs e)
        {
            List<string> dadosCurso = new() { txtNomeCurso.Text.Trim(), mskCarga.Text.Trim(), mskVagas.Text.Trim() };
            if (txtNomeCurso.Text == string.Empty || mskCarga.Text == string.Empty || mskVagas.Text == string.Empty || int.Parse(mskVagas.Text) <= 0)
            {
                MessageBox.Show("Preencha todos os campos obrigatórios!");
            }
            else
            {
                string msg = ServicesCurso.CadastrarCurso(dadosCurso);
                MessageBox.Show(msg);
                txtNomeCurso.Clear();
                mskCarga.Clear();
                mskVagas.Clear();
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
