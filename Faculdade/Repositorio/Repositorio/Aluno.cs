using Data.Data;
using Interfaces.Interface;
using Modelos.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositorio.Repositorio
{
    public class Aluno : IAluno<Modelos.Model.Aluno>
    {
        private ApplicationContext context;
        public Aluno(ApplicationContext context)
        {
            this.context = context;
        }
        public Modelos.Model.Aluno Atualizar(Modelos.Model.Aluno t)
        {
            this.context.Entry(t).State = EntityState.Modified;
            return t;
        }
        public void Deletar(Modelos.Model.Aluno t)
        {
            Modelos.Model.Aluno aluno = this.context.Aluno.Find(t.Id);
            this.context.Aluno.Remove(aluno);
        }
        public Modelos.Model.Aluno Guardar(Modelos.Model.Aluno t)
        {
            this.context.Aluno.Add(t);
            return t;
        }
        public ICollection<Modelos.Model.Aluno> Pesquisar(Modelos.Model.Aluno t)
        {
            return this.context.Aluno.ToList();
        }
        public void Save()
        {
            this.context.SaveChanges();
        }
        private bool disposed = false;
        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    this.context.Dispose();
                }
            }
            this.disposed = true;
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
