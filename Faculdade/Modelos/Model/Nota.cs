using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos.Model
{
    public class Nota
    {
        public int Id { get; set; }
        public Aluno Aluno { get; set; }
        public Professor Professor { get; set; }
        public decimal Notas { get; set; }
    }
}
