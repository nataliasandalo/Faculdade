using Autofac;
using Autofac.Integration.Mvc;
using Interfaces.Interface;
using Repositorio.Repositorio;
using Service.Interface;
using Service.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace Faculdade
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            AutofacRegister();
        }

        private void AutofacRegister()
        {
            var builder = new ContainerBuilder();

            // Register all controllers in the Mvc Application assembly
            builder.RegisterControllers(typeof(MvcApplication).Assembly);

            builder.RegisterType<Data.Data.ApplicationContext>().AsSelf();
           //.As<IdentityDbContext<ApplicationUser>>().InstancePerApiRequest();
            // Registered Warehouse Reservoir Service
            builder.RegisterType<CursoFaculdade>().As<ICursoFaculdade<Modelos.Model.CursoFaculdade>>();
            builder.RegisterType<DisciplinaFaculdade>().As<IDisciplinaFaculdade<Modelos.Model.DisciplinaFaculdade>>();
            builder.RegisterType<Aluno>().As<IAluno<Modelos.Model.Aluno>>();
            builder.RegisterType<Professor>().As<IProfessor<Modelos.Model.Professor>>();
            builder.RegisterType<Nota>().As<INota>();
            // Registration Service Layer Service
            builder.RegisterType<CursoFaculdadeService>().As<ICursoFaculdadeService<Modelos.Model.CursoFaculdade>>();
            builder.RegisterType<DisciplinaFaculdadeService>().As<IDisciplinaFaculdadeService<Modelos.Model.DisciplinaFaculdade>>();
            builder.RegisterType<AlunoService>().As<IAlunoService<Modelos.Model.Aluno>>();
            builder.RegisterType<ProfessorService>().As<IProfessorService<Modelos.Model.Professor>>();
            builder.RegisterType<NotaService>().As<INotaService>();

            // Registration filter
            builder.RegisterFilterProvider();

            var container = builder.Build();

            // Setting Dependency Injection Parser
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
        }
    }
}
