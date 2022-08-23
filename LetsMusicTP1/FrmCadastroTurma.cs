﻿using LetsMusicTP1.Domain;
using LetsMusicTP1.Repositories;
using System.Data;

namespace LetsMusicTP1
{
    public partial class FrmCadastroTurma : Form
    {
        List<string> alunosCad = RepositorioAluno.listaAlunos.Select(x => x.Nome).ToList();
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
            if (!ltbAlunosMat.Items.Contains(ltbAlunosCad.SelectedItem))
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
            if (RepositorioTurma.BuscaTurmaPorCurso(cbbCurso.SelectedItem.ToString()).Any())
            {
                MessageBox.Show("Curso já possui turma cadastrada!");
                return;
            }
            foreach (var aluno in ltbAlunosMat.Items)
            {
                Turma turma = new Turma() { NomeAluno = aluno.ToString(), NomeCurso = cbbCurso.SelectedItem.ToString() };
                RepositorioTurma.listaTurma.Add(turma);
            }
            MessageBox.Show("Turma cadastrada com sucesso!");
        }
    }
}
