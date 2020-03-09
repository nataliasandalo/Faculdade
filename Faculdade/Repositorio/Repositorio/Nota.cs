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
    public class Nota : INota
    {
        private ApplicationContext context;
        public Nota(ApplicationContext context)
        {
            this.context = context;
        }
        public Modelos.Model.Nota Atualizar(Modelos.Model.Nota t)
        {
            this.context.Entry(t).State = EntityState.Modified;
            return t;
        }

        public void Deletar(Modelos.Model.Nota t)
        {
            Modelos.Model.Nota nota = this.context.Nota.Find(t.Id);
            this.context.Nota.Remove(nota);
        }

        public Modelos.Model.Nota Guardar(Modelos.Model.Nota t)
        {
            this.context.Nota.Add(t);
            return t;
        }

        public ICollection<Modelos.Model.Nota> Pesquisar(Modelos.Model.Nota t)
        {
            return this.context.Nota.ToList();
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
