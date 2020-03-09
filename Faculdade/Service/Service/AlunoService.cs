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
    public class AlunoService : IAlunoService<Aluno>
    {
        private readonly IAluno<Aluno> _alunoRepository;

        public AlunoService(IAluno<Aluno> alunoRepository)
        {
            _alunoRepository = alunoRepository;
        }

        public Aluno Atualizar(Aluno t)
        {
            return _alunoRepository.Atualizar(t);
        }

        public void Deletar(Aluno t)
        {
            _alunoRepository.Deletar(t);
        }

        public void Dispose()
        {
            _alunoRepository.Dispose();
        }

        public Aluno Guardar(Aluno t)
        {
            return _alunoRepository.Guardar(t);
        }

        public ICollection<Aluno> Pesquisar(Aluno t)
        {
            return _alunoRepository.Pesquisar(t);
        }
    }
}
