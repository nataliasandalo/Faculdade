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
    public class CursoFaculdadeService : ICursoFaculdadeService<CursoFaculdade>
    {
        private readonly ICursoFaculdade<CursoFaculdade> _cursoFaculdadeRepository;

        public CursoFaculdadeService(ICursoFaculdade<CursoFaculdade> cursoFaculdadeRepository)
        {
            _cursoFaculdadeRepository = cursoFaculdadeRepository;
        }
        public CursoFaculdade Atualizar(CursoFaculdade t)
        {
            return _cursoFaculdadeRepository.Atualizar(t);
        }

        public void Deletar(CursoFaculdade t)
        {
            _cursoFaculdadeRepository.Deletar(t);
        }

        public void Dispose()
        {
            _cursoFaculdadeRepository.Dispose();
        }

        public CursoFaculdade Guardar(CursoFaculdade t)
        {
            return _cursoFaculdadeRepository.Guardar(t);
        }

        public ICollection<CursoFaculdade> Pesquisar(CursoFaculdade t)
        {
            return _cursoFaculdadeRepository.Pesquisar(t);
        }
    }
}
