using Modelos.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos.Model
{
    public class DisciplinaFaculdade
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public CursoFaculdade CursoFaculdade { get; set; }
    }
}
