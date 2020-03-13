using Modelos.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos.Model
{
    public class DisciplinaFaculdade
    {
        public int Id { get; set; }
        public string Nome { get; set; }

        [ForeignKey("CursoFaculdade")]
        public int CursoFaculdadeId { get; set; }
        public CursoFaculdade CursoFaculdade { get; set; }
    }
}
