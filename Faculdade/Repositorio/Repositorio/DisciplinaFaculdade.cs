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
    public class DisciplinaFaculdade : IDisciplinaFaculdade<Modelos.Model.DisciplinaFaculdade>
    {
        private ApplicationContext context;
        public DisciplinaFaculdade(ApplicationContext context)
        {
            this.context = context;
        }
        public Modelos.Model.DisciplinaFaculdade Atualizar(Modelos.Model.DisciplinaFaculdade t)
        {
            this.context.Entry(t).State = EntityState.Modified;
            return t;
        }
        public void Deletar(Modelos.Model.DisciplinaFaculdade t)
        {
            Modelos.Model.DisciplinaFaculdade disciplinaFaculdade = this.context.DisciplinaFaculdade.Find(t.Id);
            this.context.DisciplinaFaculdade.Remove(disciplinaFaculdade);
        }        
        public Modelos.Model.DisciplinaFaculdade Guardar(Modelos.Model.DisciplinaFaculdade t)
        {
            this.context.DisciplinaFaculdade.Add(t);
            return t;
        }
        public ICollection<Modelos.Model.DisciplinaFaculdade> Pesquisar(Modelos.Model.DisciplinaFaculdade t)
        {
            return this.context.DisciplinaFaculdade.ToList();
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
