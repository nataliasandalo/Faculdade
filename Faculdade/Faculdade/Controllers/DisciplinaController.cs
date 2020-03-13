using Service.Interface;
using Modelos.Model;
using System.Web.Mvc;

namespace Faculdade.Controllers
{
    public class DisciplinaController : Controller
    {
        private readonly IDisciplinaFaculdadeService<DisciplinaFaculdade> _disciplina;

        public DisciplinaController(IDisciplinaFaculdadeService<DisciplinaFaculdade> disciplina)
        {
            this._disciplina = disciplina;
        }

        // GET: Curso
        public ActionResult Index()
        {
            return View();
        }

        public JsonResult Pesquisar()
        {
            var pesquisar = new Modelos.Model.DisciplinaFaculdade();
            var data = _disciplina.Pesquisar(pesquisar);

            return Json(data, JsonRequestBehavior.AllowGet);
        }

        public ActionResult Adicionar()
        {
            return View();
        }

        public JsonResult Atualizar(DisciplinaFaculdade disciplina)
        {
            var data = _disciplina.Atualizar(disciplina);

            return Json(data, JsonRequestBehavior.AllowGet);
        }

        public JsonResult AdicionarDisciplina(DisciplinaFaculdade disciplina)
        {
            var data = _disciplina.Guardar(disciplina);

            return Json(data, JsonRequestBehavior.AllowGet);
        }

        public ActionResult Excluir(DisciplinaFaculdade disciplina)
        {
            _disciplina.Deletar(disciplina);

            return View();
        }
    }
}