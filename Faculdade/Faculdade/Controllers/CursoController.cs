using Service.Interface;
using Modelos.Model;
using System.Web.Mvc;

namespace Faculdade.Controllers
{
    public class CursoController : Controller
    {
        private readonly ICursoFaculdadeService<CursoFaculdade> _curso;

        public CursoController(ICursoFaculdadeService<CursoFaculdade> curso)
        {
            this._curso = curso;
        }

        // GET: Curso
        public ActionResult Index()
        {
            return View();
        }

        public JsonResult Pesquisar()
        {
            var pesquisar = new Modelos.Model.CursoFaculdade();
            var data = _curso.Pesquisar(pesquisar);

            return Json(data, JsonRequestBehavior.AllowGet);
        }

        public ActionResult Adicionar()
        {
            return View();
        }

        public JsonResult AdicionarCurso(CursoFaculdade curso)
        {
            var data = _curso.Guardar(curso);

            return Json(data, JsonRequestBehavior.AllowGet);
        }

        public ActionResult Excluir(CursoFaculdade curso)
        {
            _curso.Deletar(curso);

            return View();
        }
    }
}