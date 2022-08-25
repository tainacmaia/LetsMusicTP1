using LetsMusicTP1.Domain;
using LetsMusicTP1.Repositories;

namespace LetsMusicTP1.Services
{
    public class ServicesTurma
    {
        public static List<string> ListaCursosTurma()
        {
            return RepositorioTurma.ListaCursosComTurma();
        }
        public static void CadastrarTurma(Turma novaTurma)
        {
            RepositorioTurma.RegistrarTurma(novaTurma);
        }
        public static void RemoveTurmasDeCurso(string curso)
        {
            RepositorioTurma.RemoveTurmasCurso(curso);
        }
        public static List<Turma> ListaTurmasCurso(string curso)
        {
            return RepositorioTurma.BuscaTurmaPorCurso(curso);
        }
    }
}
