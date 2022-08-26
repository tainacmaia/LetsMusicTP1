using LetsMusicTP1.Domain;
using LetsMusicTP1.Repositories;

namespace LetsMusicTP1.Services
{
    public class ServicesCurso
    {
        public static string CadastrarCurso(List<string> dadosCurso)
        {
            Curso novoCurso = new()
            {
                Nome = dadosCurso[0],
                CargaHoraria = dadosCurso[1],
                Vagas = dadosCurso[2]
            };
            if (RepositorioCurso.BuscarCursoPorNome(novoCurso.Nome) != null)
            {
                return "Curso já cadastrado!";
            }
            else
            {
                RepositorioCurso.RegistrarCurso(novoCurso);
                return "Curso Cadastrado com Sucesso";
            }
        }
        public static string PesquisaVagasCurso(string curso)
        {
            return RepositorioCurso.BuscaVagasCurso(curso);
        }
        public static List<Curso> BuscaoTodosCursos()
        {
            return RepositorioCurso.ListaTodosCursos();
        }
        public static List<Curso> BuscaCursoGeral(string textoPesquisa)
        {
            return RepositorioCurso.BuscaCurso(textoPesquisa);
        }
        public static Curso PesquisaCursoPorNome(string nome)
        {
            return RepositorioCurso.BuscarCursoPorNome(nome);
        }
        public static bool AtualizaCurso(Curso curso, string novaCarga, string novasVagas)
        {
            int inscritos = ServicesTurma.ListaTurmasCurso(curso.Nome).Count;
            if (int.Parse(novasVagas) < inscritos)
            {
                return false;
            }
            RepositorioCurso.AtualizaCurso(curso, novaCarga, novasVagas);
            return true;
        }

        public static void RemoveCurso(string nomeCurso)
        {
            RepositorioTurma.RemoveTurmasCurso(nomeCurso);
            RepositorioCurso.RemoveCurso(nomeCurso);
        }
    }
}
