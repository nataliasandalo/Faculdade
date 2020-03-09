using Interfaces.Interface;
using Modelos.Model;
using Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Service
{
    public class NotaService : INotaService
    {
        private readonly INota _notaRepository;

        public NotaService(INota notaRepository)
        {
            _notaRepository = notaRepository;
        }

        public Nota Atualizar(Nota t)
        {
            return _notaRepository.Atualizar(t);
        }

        public void Deletar(Nota t)
        {
            _notaRepository.Deletar(t);
        }

        public void Dispose()
        {
            _notaRepository.Dispose();
        }

        public Nota Guardar(Nota t)
        {
            return _notaRepository.Guardar(t);
        }

        public ICollection<Nota> Pesquisar(Nota t)
        {
            return _notaRepository.Pesquisar(t);
        }
    }
}
