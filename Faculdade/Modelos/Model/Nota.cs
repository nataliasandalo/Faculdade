using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos.Model
{
    public class Nota
    {
        public int Id { get; set; }

        [ForeignKey("Aluno")]
        public int AlunoId { get; set; }
        public Aluno Aluno { get; set; }

        public decimal Notas { get; set; }
    }
}
