using Modelos.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces.Interface
{
    public interface INota : IDisposable
    {
        ICollection<Nota> Pesquisar(Nota t);
        Nota Guardar(Nota t);
        Nota Atualizar(Nota t);
        void Deletar(Nota t);
    }
}
