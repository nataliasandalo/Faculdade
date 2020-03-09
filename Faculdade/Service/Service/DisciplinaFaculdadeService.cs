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
    public class DisciplinaFaculdadeService : IDisciplinaFaculdadeService<DisciplinaFaculdade>
    {
        private readonly IDisciplinaFaculdade<DisciplinaFaculdade> _disciplinaFaculdadeRepository;

        public DisciplinaFaculdadeService(IDisciplinaFaculdade<DisciplinaFaculdade> disciplinaFaculdadeRepository)
        {
            _disciplinaFaculdadeRepository = disciplinaFaculdadeRepository;
        }
        public DisciplinaFaculdade Atualizar(DisciplinaFaculdade t)
        {
            return _disciplinaFaculdadeRepository.Atualizar(t);
        }

        public void Deletar(DisciplinaFaculdade t)
        {
            _disciplinaFaculdadeRepository.Deletar(t);
        }

        public void Dispose()
        {
            _disciplinaFaculdadeRepository.Dispose();
        }

        public DisciplinaFaculdade Guardar(DisciplinaFaculdade t)
        {
            return _disciplinaFaculdadeRepository.Guardar(t);
        }

        public ICollection<DisciplinaFaculdade> Pesquisar(DisciplinaFaculdade t)
        {
            return _disciplinaFaculdadeRepository.Pesquisar(t);
        }
    }
}
