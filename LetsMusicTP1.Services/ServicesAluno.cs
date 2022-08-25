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
    }
}
