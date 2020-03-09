using Service.Interface;
using Modelos.Model;
using System.Web.Mvc;

namespace Faculdade.Controllers
{
    public class DisciplinarController : Controller
    {
        private readonly IDisciplinaFaculdadeService<DisciplinaFaculdade> _disciplina;

        public DisciplinarController(IDisciplinaFaculdadeService<DisciplinaFaculdade> disciplina)
        {
            this._disciplina = disciplina;
        }

        // GET: Curso
        public ActionResult Index()
        {
            return View();
        }
    }
}