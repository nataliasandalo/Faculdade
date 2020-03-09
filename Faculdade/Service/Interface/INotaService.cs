using Modelos.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Interface
{
    public interface INotaService : IDisposable
    {
        ICollection<Nota> Pesquisar(Nota t);
        Nota Guardar(Nota t);
        Nota Atualizar(Nota t);
        void Deletar(Nota t);
    }
}
