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
    public class Professor : IProfessor<Modelos.Model.Professor>
    {
        private ApplicationContext context;
        public Professor(ApplicationContext context)
        {
            this.context = context;
        }
        public Modelos.Model.Professor Atualizar(Modelos.Model.Professor t)
        {
            this.context.Entry(t).State = EntityState.Modified;
            return t;
        }

        public void Deletar(Modelos.Model.Professor t)
        {
            Modelos.Model.Professor professor = this.context.Professor.Find(t.Id);
            this.context.Professor.Remove(professor);
        }

        public Modelos.Model.Professor Guardar(Modelos.Model.Professor t)
        {
            this.context.Professor.Add(t);
            return t;
        }

        public ICollection<Modelos.Model.Professor> Pesquisar(Modelos.Model.Professor t)
        {
            return this.context.Professor.ToList();
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
