using Service.Interface;
using Modelos.Model;
using System.Web.Mvc;

namespace Faculdade.Controllers
{
    public class ProfessorController : Controller
    {
        private readonly IProfessorService<Professor> _professor;

        public ProfessorController(IProfessorService<Professor> professor)
        {
            this._professor = professor;
        }

        // GET: Curso
        public ActionResult Index()
        {
            return View();
        }
    }
}