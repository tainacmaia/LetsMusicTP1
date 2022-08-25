using LetsMusicTP1.Repositories;
using LetsMusicTP1.Domain;
using System.ComponentModel;

namespace LetsMusicTP1
{
    public partial class FrmPesquisaAluno : Form
    {
        public FrmPesquisaAluno()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FrmPesquisaAluno_Load(object sender, EventArgs e)
        {
            var source = new BindingSource();
            source.DataSource = RepositorioAluno.listaAlunos;
            dtgAlunos.DataSource = source;
        }

        private async void txtValorPesquisa_TextChanged(object sender, EventArgs e)
        {
            string textoDigitado = txtValorPesquisa.Text;
            var source = new BindingSource();
            lblStatusBusca.Text = "Buscando...Por favor aguarde";
            await Task.Delay(2000);
            lblStatusBusca.Text = "";
            source.DataSource = RepositorioAluno.BuscaAluno(textoDigitado);
            dtgAlunos.DataSource = source;
        }

        private void btnAlterarAluno_Click(object sender, EventArgs e)
        {
            if (dtgAlunos.SelectedRows.Count > 0)
            {
                var atualizaAluno = RepositorioAluno.listaAlunos.Find(x => x.Cpf == textBox1.Text);
                if (atualizaAluno.Nome != textBox2.Text ||
                    atualizaAluno.Telefone != textBox3.Text ||
                    atualizaAluno.Email != textBox4.Text)
                {
                    var result = MessageBox.Show("Deseja mesmo alterar informações do aluno?", "Aviso", MessageBoxButtons.OKCancel);
                    if (result == DialogResult.Cancel)
                    {
                        textBox1.Clear();
                        textBox2.Clear();
                        textBox3.Clear();
                        textBox4.Clear();
                        return;
                    }
                    atualizaAluno.Nome = textBox2.Text;
                    atualizaAluno.Telefone = textBox3.Text;
                    atualizaAluno.Email = textBox4.Text;
                }
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();

                var bindingList = new BindingList<Aluno>(RepositorioAluno.listaAlunos);
                var source = new BindingSource(bindingList, null);
                dtgAlunos.DataSource = source;
            }
        }

        private void dtgAlunos_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            textBox1.Text = dtgAlunos.SelectedRows[0].Cells[0].Value.ToString();
            textBox2.Text = dtgAlunos.SelectedRows[0].Cells[1].Value.ToString();
            textBox3.Text = dtgAlunos.SelectedRows[0].Cells[2].Value.ToString();
            textBox4.Text = dtgAlunos.SelectedRows[0].Cells[3].Value.ToString();
        }

        private void btnRemoverAluno_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Deseja mesmo remover esse aluno?", "Aviso", MessageBoxButtons.OKCancel);
            if (result == DialogResult.Cancel)
            {
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
                return;
            }
            RepositorioAluno.listaAlunos.RemoveAll(x => x.Cpf == textBox1.Text);
            RepositorioTurma.listaTurma.RemoveAll(x => x.NomeAluno == textBox2.Text);
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            var bindingList = new BindingList<Aluno>(RepositorioAluno.listaAlunos);
            var source = new BindingSource(bindingList, null);
            dtgAlunos.DataSource = source;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
