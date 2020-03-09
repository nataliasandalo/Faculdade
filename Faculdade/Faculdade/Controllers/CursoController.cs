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

        //public ActionResult Pesquisar()
        //{
        //    var pesquisar = new Modelos.Model.CursoFaculdade();
        //    var post = _curso.Pesquisar(pesquisar);

        //    return View(post);
        //}

        [HttpGet]
        public ActionResult Pesquisar()
        {
            var pesquisar = new Modelos.Model.CursoFaculdade();
            var data = _curso.Pesquisar(pesquisar);

            return Json(data, JsonRequestBehavior.AllowGet);
        }
    }
}