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
            this.context.SaveChanges();
            return t;
        }
        public void Deletar(Modelos.Model.DisciplinaFaculdade t)
        {
            Modelos.Model.DisciplinaFaculdade disciplinaFaculdade = this.context.DisciplinaFaculdade.Where(p => p.Id == t.Id).FirstOrDefault(); ;
            this.context.DisciplinaFaculdade.Remove(disciplinaFaculdade);
            this.context.SaveChanges();
        }        
        public Modelos.Model.DisciplinaFaculdade Guardar(Modelos.Model.DisciplinaFaculdade t)
        {
            this.context.DisciplinaFaculdade.Add(t);
            this.context.SaveChanges();
            return t;
        }
        public ICollection<Modelos.Model.DisciplinaFaculdade> Pesquisar(Modelos.Model.DisciplinaFaculdade t)
        {
            var list = this.context.DisciplinaFaculdade.ToList();
            
            foreach (var item in list)
            {
                item.CursoFaculdade = this.context.CursoFaculdade.Where(p => p.Id == item.CursoFaculdade.Id).FirstOrDefault();
            }

            var ver = this.context.CursoFaculdade.ToList();
            return list;
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
