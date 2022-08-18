using LetsMusicTP1.Domain;

namespace LetsMusicTP1.Repositories
{
    public class RepositorioCurso
    {
        public List<Curso> listaCurso = new()
        {
            new Curso{Nome = "Canto", CargaHoraria = 150, Vagas = 4},
            new Curso{Nome = "Violão", CargaHoraria = 80, Vagas = 6},
            new Curso{Nome = "Piano", CargaHoraria = 200, Vagas = 4},
            new Curso{Nome = "Bateria", CargaHoraria = 160, Vagas = 4},
            new Curso{Nome = "Harpa", CargaHoraria = 130, Vagas = 5},
            new Curso{Nome = "Violino", CargaHoraria = 90, Vagas = 5},
            new Curso{Nome = "Cavaquinho", CargaHoraria = 110, Vagas = 10},
            new Curso{Nome = "Saxofone", CargaHoraria = 190, Vagas = 25},
            new Curso{Nome = "Flauta", CargaHoraria = 50, Vagas = 10},
            new Curso{Nome = "Baixo", CargaHoraria = 70, Vagas = 10}

        };
    }
}
