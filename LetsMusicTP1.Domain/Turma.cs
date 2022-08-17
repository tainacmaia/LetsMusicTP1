using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetsMusicTP1.Domain
{
    public class Turma
    {
        public List<Aluno> Alunos { get; set; }

        public Curso Curso { get; set; }
    }
}
