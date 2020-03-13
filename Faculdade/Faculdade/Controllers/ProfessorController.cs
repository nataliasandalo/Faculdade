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

        public JsonResult Pesquisar()
        {
            var pesquisar = new Modelos.Model.Professor();
            var data = _professor.Pesquisar(pesquisar);

            return Json(data, JsonRequestBehavior.AllowGet);
        }

        public ActionResult Adicionar()
        {
            return View();
        }

        public JsonResult Atualizar(Professor professor)
        {
            var data = _professor.Atualizar(professor);

            return Json(data, JsonRequestBehavior.AllowGet);
        }

        public JsonResult AdicionarProfessor(Professor professor)
        {
            var data = _professor.Guardar(professor);

            return Json(data, JsonRequestBehavior.AllowGet);
        }

        public ActionResult Excluir(Professor professor)
        {
            _professor.Deletar(professor);

            return View();
        }
    }
}