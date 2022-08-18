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
            List<string> dadosCurso = new() { txtNomeCurso.Text, mskCarga.Text, mskVagas.Text };
            if (txtNomeCurso.Text == string.Empty)
            {
                MessageBox.Show("Preencha todos os campos obrigatórios!");
            }
            else
            {
                string msg = ServicesCurso.CadastrarCurso(dadosCurso);
                MessageBox.Show(msg);
            }
        }
    }
}
