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
            this.context.SaveChanges();
            return t;
        }

        public void Deletar(Modelos.Model.Professor t)
        {
            Modelos.Model.Professor professor = this.context.Professor.Where(p => p.Id == t.Id).FirstOrDefault();
            this.context.Professor.Remove(professor);
            this.context.SaveChanges();
        }

        public Modelos.Model.Professor Guardar(Modelos.Model.Professor t)
        {
            this.context.Professor.Add(t);
            this.context.SaveChanges();
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
