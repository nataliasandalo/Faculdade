using Data.Data;
using Interfaces.Interface;
using Modelos.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositorio.Repositorio
{
    public class CursoFaculdade : ICursoFaculdade<Modelos.Model.CursoFaculdade>
    {
        private ApplicationContext context;

        public CursoFaculdade(ApplicationContext context)
        {
            this.context = context;
        }
        public void Deletar(Modelos.Model.CursoFaculdade t)
        {
            Modelos.Model.CursoFaculdade cursoFaculdade = this.context.CursoFaculdade.Find(t.Id);
            this.context.CursoFaculdade.Remove(cursoFaculdade);
        }        
        public Modelos.Model.CursoFaculdade Guardar(Modelos.Model.CursoFaculdade t)
        {
            this.context.CursoFaculdade.Add(t);            
            return t;
        }
        public Modelos.Model.CursoFaculdade Atualizar(Modelos.Model.CursoFaculdade t)
        {
            this.context.Entry(t).State = EntityState.Modified;
            return t;
        }
        public ICollection<Modelos.Model.CursoFaculdade> Pesquisar(Modelos.Model.CursoFaculdade t)
        {
            return this.context.CursoFaculdade.ToList();
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
