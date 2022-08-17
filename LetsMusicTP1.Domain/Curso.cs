using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetsMusicTP1.Domain
{
    public class Curso
    {
        public int IdCurso { get; set; }
        public string Nome { get; set; }
        public int CargaHoraria { get; set; }
        public int Vagas { get; set; }
    }
}
