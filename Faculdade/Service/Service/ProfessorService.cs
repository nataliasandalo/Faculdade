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
    public class ProfessorService : IProfessorService<Professor>
    {
        private readonly IProfessor<Professor> _professorRepository;

        public ProfessorService(IProfessor<Professor> professorRepository)
        {
            _professorRepository = professorRepository;
        }
        public Professor Atualizar(Professor t)
        {
            return _professorRepository.Atualizar(t);
        }

        public void Deletar(Professor t)
        {
            _professorRepository.Deletar(t);
        }

        public void Dispose()
        {
            _professorRepository.Dispose();
        }

        public Professor Guardar(Professor t)
        {
            return _professorRepository.Guardar(t);
        }

        public ICollection<Professor> Pesquisar(Professor t)
        {
            return _professorRepository.Pesquisar(t);
        }
    }
}
