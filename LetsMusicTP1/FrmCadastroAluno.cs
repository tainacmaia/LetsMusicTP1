using LetsMusicTP1.Services;

namespace LetsMusicTP1
{
    public partial class frmCadastroAluno : Form
    {
        public frmCadastroAluno()
        {
            InitializeComponent();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            List<string> dadosAluno = new() { txbEmail.Text.Trim(), txbNome.Text.Trim(), mskTelefone.Text, mskCpf.Text };
            if (dadosAluno.Any(x => x == string.Empty) || mskCpf.Text.Contains('_') || mskTelefone.Text.Contains('_'))
            {
                MessageBox.Show("Preencha todos os campos obrigatórios!");
            }
            else
            {
                string msg = ServicesAluno.CadastrarAluno(dadosAluno);
                MessageBox.Show(msg);
                txbNome.Clear();
                txbEmail.Clear();
                mskCpf.Clear();
                mskTelefone.Clear();
            }
        }
    }
}
