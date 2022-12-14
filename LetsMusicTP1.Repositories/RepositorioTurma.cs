using LetsMusicTP1.Domain;

namespace LetsMusicTP1.Repositories
{
    public static class RepositorioTurma
    {
        public static Curso curso = RepositorioCurso.listaCurso.First(x => x.Nome == "Violão");
        public static List<Aluno> alunos = RepositorioAluno.listaAlunos.Where(x => x.Nome.StartsWith('M')).ToList();

        public static Curso curso2 = RepositorioCurso.listaCurso.First(x => x.Nome == "Saxofone");
        public static List<Aluno> alunos2 = new List<Aluno>(RepositorioAluno.listaAlunos.GetRange(10, 25));

        public static List<Turma> listaTurma = new();


        public static void IniciaLista()
        {
            foreach (Aluno aluno in alunos)
            {
                Turma turma = new Turma { NomeCurso = curso.Nome, NomeAluno = aluno.Nome };
                listaTurma.Add(turma);
            }

            foreach (Aluno aluno in alunos2)
            {
                Turma turma = new Turma { NomeCurso = curso2.Nome, NomeAluno = aluno.Nome };
                listaTurma.Add(turma);
            }
        }
        public static List<Turma> ListaTodasTurmas()
        {
            return listaTurma;
        }

        public static void RegistrarTurma(Turma novaTurma)
        {
            listaTurma.Add(novaTurma);
        }

        public static List<Turma> BuscaTurma(string textoBusca)
        {
            textoBusca = textoBusca.ToLower();
            return listaTurma.FindAll(x => (x.NomeCurso.ToLower().Contains(textoBusca)) ||
                 x.NomeAluno.ToLower().Contains(textoBusca)).ToList();
        }
        public static List<Turma> BuscaTurmaPorCurso(string textoBusca)
        {
            textoBusca = textoBusca.ToLower();

            return listaTurma.FindAll(x => x.NomeCurso.ToLower() == textoBusca).ToList();
        }
        public static List<string> ListaCursosComTurma()
        {
            return listaTurma.Select(x => x.NomeCurso).Distinct().ToList();
        }

        public static void RemoveTurmasCurso(string curso)
        {
            listaTurma.RemoveAll(x => x.NomeCurso == curso);
        }
        public static void RemoveAlunoTurma(string nomeAluno)
        {
            listaTurma.RemoveAll(x => x.NomeAluno == nomeAluno);
        }
    }
}
