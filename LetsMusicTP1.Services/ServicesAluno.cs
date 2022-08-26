using LetsMusicTP1.Domain;
using LetsMusicTP1.Repositories;

namespace LetsMusicTP1.Services
{
    public static class ServicesAluno
    {
        public static string CadastrarAluno(List<string> dadosAluno)
        {
            Aluno novoAluno = new Aluno()
            {
                Email = dadosAluno[0],
                Nome = dadosAluno[1],
                Telefone = dadosAluno[2],
                Cpf = dadosAluno[3]
            };
            if (RepositorioAluno.BuscarAlunoPorCpf(novoAluno.Cpf) != null)
            {
                return "Aluno já cadastrado!";
            }
            else
            {
                RepositorioAluno.RegistrarAluno(novoAluno);
                return "Aluno Cadastrado com Sucesso";
            }
        }
        public static List<Aluno> PesquisarAlunosPorNome(string textoDigitado)
        {
            return RepositorioAluno.BuscaAlunosPorNome(textoDigitado);
        }
        public static Aluno PesuisaAlunoPorCpf(string cpf)
        {
            return RepositorioAluno.BuscarAlunoPorCpf(cpf);
        }
        public static List<Aluno> BuscaTodosAlunos()
        {
            return RepositorioAluno.ListaTodosAlunos();
        }
        public static List<Aluno> BuscaAlunoPorCamposGerais(string textoPesquisa)
        {
            return RepositorioAluno.BuscaAluno(textoPesquisa);
        }
        public static void RemoveAluno(string cpf, string nome)
        {
            RepositorioAluno.RemoveAlunoPorCpf(cpf);
            RepositorioTurma.RemoveAlunoTurma(nome);
        }

    }
}
