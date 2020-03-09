using Modelos;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Data
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext()
            : base("name=FaculdadeEntities")
        {
        }
        public DbSet<Modelos.Model.CursoFaculdade> CursoFaculdade { get; set; }
        public DbSet<Modelos.Model.DisciplinaFaculdade> DisciplinaFaculdade { get; set; }
        public DbSet<Modelos.Model.Professor> Professor { get; set; }
        public DbSet<Modelos.Model.Aluno> Aluno { get; set; }
        public DbSet<Modelos.Model.Nota> Nota { get; set; }
    }
}
