using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetsMusicTP1.Domain
{
    public class Aluno
    {
        public int Cpf { get; set; }
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }

        public Aluno(int cpf, string nome, string telefone, string email)
        {
            Cpf = cpf;
            Nome = nome;
            Telefone = telefone;
            Email = email;
        }
    }
}
