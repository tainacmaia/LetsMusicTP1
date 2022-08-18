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
    }
}
