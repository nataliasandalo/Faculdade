using Service.Interface;
using Modelos.Model;
using System.Web.Mvc;

namespace Faculdade.Controllers
{
    public class AlunoController : Controller
    {
        private readonly IAlunoService<Aluno> _aluno;

        public AlunoController(IAlunoService<Aluno> aluno)
        {
            this._aluno = aluno;
        }

        // GET: Curso
        public ActionResult Index()
        {
            return View();
        }
    }
}