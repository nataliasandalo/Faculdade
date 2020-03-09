using Modelos.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos.Model
{
    public class Aluno
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public DateTime Aniversario { get; set; }
        public int CodigoInscricao { get; set; }
        public Professor Professor { get; set; }
    }
}
