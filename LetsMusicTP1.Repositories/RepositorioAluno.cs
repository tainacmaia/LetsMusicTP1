using LetsMusicTP1.Domain;

namespace LetsMusicTP1.Repositories
{
    public static class RepositorioAluno
    {
        public static List<Aluno> listaAlunos = new()
        {
            new Aluno { Nome = "Maria de Lourdes", Telefone = "(11) 99875-6321", Email = "lourdes@email.com", Cpf = "762.700.768-20" },
            new Aluno { Nome = "Angelo Pontes", Telefone = "(11) 99667-1355", Email = "angelo@email.com", Cpf = "156.038.648-69" },
            new Aluno { Nome = "Bernardo Santos", Telefone = "(11) 99224-8775", Email = "bernardo@email.com", Cpf = "376.312.248-62" },
            new Aluno { Nome = "Carlos R. Silva", Telefone = "(11) 99635-9977", Email = "carlos@email.com", Cpf = "658.797.368-06" },
            new Aluno { Nome = "Daniela Alves", Telefone = "(11) 99585-1447", Email = "daniela@email.com", Cpf = "884.997.568-67" },
            new Aluno { Nome = "Erika Martins", Telefone = "(11) 98558-4669", Email = "erika@email.com", Cpf = "288.395.598-09" },
            new Aluno { Nome = "Fabiano Mesquita", Telefone = "(11) 95874-3356", Email = "fabiano@email.com", Cpf = "230.920.738-19" },
            new Aluno { Nome = "Gislaine Cavalcante", Telefone = "(11) 98228-5679", Email = "gislaine@email.com", Cpf = "263.761.118-74" },
            new Aluno { Nome = "Helio Pires", Telefone = "(11) 96994-1622", Email = "helio@email.com", Cpf = "615.997.488-27" },
            new Aluno { Nome = "Arnaldo Carvalho", Telefone = "(11) 91522-4228", Email = "arnaldo.carvalo@email.br", Cpf = "511.838.288-29" },
            new Aluno { Nome = "Marília Galvão de Castro", Telefone = "(11) 90406-7108", Email = "marilialiliu@hotmail.com", Cpf = "464.085.218-19" },
            new Aluno { Nome = "Natalia Fontanezi", Telefone = "(11) 97165-0488", Email = "natalia.fontanezi@gmail.com", Cpf = "349.342.958-10" },
            new Aluno { Nome = "Nathan Lubawski", Telefone = "(11) 98381-5347", Email = "nathanlubawski1@gmail.com", Cpf = "560.255.518-80" },
            new Aluno { Nome = "Víctor Gonçalves", Telefone = "(11) 90210-9819", Email = "victor.gsantos@hotmail.com", Cpf = "333.716.228-27" },
            new Aluno { Nome = "Jhuliani Cristina Amorim dos Santos", Telefone = "(11) 95412-9168", Email = "jhulianisantos@gmail.com", Cpf = "420.862.938-01" },
            new Aluno { Nome = "Luiza Motta Campello", Telefone = "(11) 91819-0634", Email = "lumcampello@gmail.com", Cpf = "521.584.948-08" },
            new Aluno { Nome = "Marco Antônio Batista de Souza", Telefone = "(11) 91472-4716", Email = "cootoonhoo@gmail.com", Cpf = "260.950.198-69" },
            new Aluno { Nome = "Marcus Fábio Abel Pinto", Telefone = "(11) 96227-5291", Email = "mfabio.abel@gmail.com", Cpf = "774.834.988-62" },
            new Aluno { Nome = "Roberto Avelino Alves Junio", Telefone = "(11) 90181-1874", Email = "roberto.avelino97@gmail.com", Cpf = "371.326.718-98" },
            new Aluno { Nome = "Thayssa Afonso Souza", Telefone = "(11) 99467-7148", Email = "thayssa.souzaf@gmail.com", Cpf = "636.193.858-15" },
            new Aluno { Nome = "Lucas Henriques Pereira", Telefone = "(11) 96448-2902", Email = "lucasphenriques@hotmail.com", Cpf = "404.286.508-25" },
            new Aluno { Nome = "Lugan Thierry Fernandes da Costa", Telefone = "(11) 91120-2490", Email = "luganthierry@hotmail.com", Cpf = "175.194.168-01" },
            new Aluno { Nome = "Marcella Roverato Pastore", Telefone = "(11) 92869-6311", Email = "marcella.rpastore@gmail.com", Cpf = "511.525.338-00" },
            new Aluno { Nome = "Taina Costa Maia", Telefone = "(11) 93847-6677", Email = "taina.cmaia@hotmail.com", Cpf = "759.634.428-34" },
            new Aluno { Nome = "Viviane Perrotti", Telefone = "(11) 98001-0359", Email = "viperrotti@gmail.com", Cpf = "326.908.148-03" },
            new Aluno { Nome = "Marcelo Oliveira Silva", Telefone = "(11) 92738-7028", Email = "marcelo.olisi@gmail.com", Cpf = "146.154.368-15" },
            new Aluno { Nome = "Mariane de Souza Carvalho", Telefone = "(11) 98422-2989", Email = "mscarvall@gmail.com", Cpf = "453.667.408-00" },
            new Aluno { Nome = "Robson Takeshi Nishikawa", Telefone = "(11) 99479-6831", Email = "takeshinishikawa@gmail.com", Cpf = "329.675.338-90" },
            new Aluno { Nome = "Sathya de Camargo Andrade Gimenes", Telefone = "(11) 96050-9201", Email = "sathya.gimenes@gmail.com", Cpf = "430.332.238-50" },
            new Aluno { Nome = "Sérgio Fleury Dias Filho", Telefone = "(11) 96978-1980", Email = "sergiofdf@gmail.com", Cpf = "872.251.208-08" },
            new Aluno { Nome = "Mateus Augusto dos Santos Fonseca", Telefone = "(11) 97894-8532", Email = "mateus.asfonseca@gmail.com", Cpf = "900.268.808-30" },
            new Aluno { Nome = "Matheus Alencastro Braner Kenderessy", Telefone = "(11) 90316-4095", Email = "alencastromatheus@gmail.com", Cpf = "261.196.398-37" },
            new Aluno { Nome = "Matheus Amaro Silva", Telefone = "(11) 97804-7245", Email = "mat.amaro427@gmail.com", Cpf = "211.534.648-37" },
            new Aluno { Nome = "Natália Cristina de Campos da Silva", Telefone = "(11) 90029-5048", Email = "nataliacamposnccs@gmail.com", Cpf = "506.695.988-28" },
            new Aluno { Nome = "Thiago Conceição da Silva Costa", Telefone = "(11) 91234-5698", Email = "thiago_291@zoho.com", Cpf = "813.280.138-55" }
        };

        public static void RegistrarAluno(Aluno novoAluno)
        {
            listaAlunos.Add(novoAluno);
        }

        public static List<Aluno> BuscaAluno(string textoBusca)
        {
            return listaAlunos.FindAll(x => (x.Nome.Contains(textoBusca) ||
                 x.Telefone.Contains(textoBusca) ||
                 x.Email.Contains(textoBusca) ||
                 x.Cpf.Contains(textoBusca)
             )).ToList();
        }
        public static Aluno BuscarAlunoPorCpf(string cpf)
        {
            return listaAlunos.Find(a => a.Cpf == cpf);
        }
        public static Aluno BuscaAlunoPorNome(string nome)
        {
            return listaAlunos.Find(a => a.Nome == nome);
        }
    }
}
