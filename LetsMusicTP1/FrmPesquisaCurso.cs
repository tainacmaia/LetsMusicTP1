using LetsMusicTP1.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LetsMusicTP1.Domain;

namespace LetsMusicTP1.Presentation
{
    public partial class FrmPesquisaCurso : Form
    {
        public FrmPesquisaCurso()
        {
            InitializeComponent();
        }

        private void FrmPesquisaCurso_Load(object sender, EventArgs e)
        {
            var source = new BindingSource();
            source.DataSource = RepositorioCurso.listaCurso;
            dtgCursos.DataSource = source;
        }

        private async void txtPesquisaCurso_TextChanged(object sender, EventArgs e)
        {
            string textoDigitado = txtPesquisaCurso.Text;
            var source = new BindingSource();
            lblStatusBusca.Text = "Buscando...Por favor aguarde";
            await Task.Delay(2000);
            lblStatusBusca.Text = "";
            source.DataSource = RepositorioCurso.BuscaCurso(textoDigitado);
            dtgCursos.DataSource = source;
        }

        private void dtgCursos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dtgCursos_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            textBox1.Text = dtgCursos.SelectedRows[0].Cells[0].Value.ToString();
            textBox2.Text = dtgCursos.SelectedRows[0].Cells[1].Value.ToString();
            textBox3.Text = dtgCursos.SelectedRows[0].Cells[2].Value.ToString();
        }

        private void btnAlterarCurso_Click(object sender, EventArgs e)
        {
            if (dtgCursos.SelectedRows.Count > 0)
            {
                var atualizaCurso = RepositorioCurso.listaCurso.Find(x => x.Nome == textBox1.Text);
                if (atualizaCurso.CargaHoraria != textBox2.Text || atualizaCurso.Vagas != textBox3.Text)
                {
                    var result = MessageBox.Show("Deseja mesmo alterar informações do curso?", "Aviso", MessageBoxButtons.OKCancel);
                    if (result == DialogResult.Cancel)
                    {
                        textBox1.Clear();
                        textBox2.Clear();
                        textBox3.Clear();
                        return;
                    }
                    atualizaCurso.CargaHoraria = textBox2.Text;
                    atualizaCurso.Vagas = textBox3.Text;
                }
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                var bindingList = new BindingList<Curso>(RepositorioCurso.listaCurso);
                var source = new BindingSource(bindingList, null);
                dtgCursos.DataSource = source;
            }
        }

        private void btnRemoverCurso_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Deseja mesmo remover esse curso?", "Aviso", MessageBoxButtons.OKCancel);
            if (result == DialogResult.Cancel)
            {
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                return;
            }
            RepositorioCurso.listaCurso.RemoveAll(x => x.Nome == textBox1.Text);
            RepositorioTurma.listaTurma.RemoveAll(x => x.NomeCurso == textBox1.Text);
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            var bindingList = new BindingList<Curso>(RepositorioCurso.listaCurso);
            var source = new BindingSource(bindingList, null);
            dtgCursos.DataSource = source;
        }
    }
}
