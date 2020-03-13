using Service.Interface;
using Modelos.Model;
using System.Web.Mvc;

namespace Faculdade.Controllers
{
    public class NotaController : Controller
    {
        private readonly INotaService _nota;

        public NotaController(INotaService nota)
        {
            this._nota = nota;
        }

        // GET: Curso
        public ActionResult Index()
        {
            return View();
        }

        public JsonResult Pesquisar()
        {
            var pesquisar = new Modelos.Model.Nota();
            var data = _nota.Pesquisar(pesquisar);

            return Json(data, JsonRequestBehavior.AllowGet);
        }

        public ActionResult Adicionar()
        {
            return View();
        }

        public JsonResult Atualizar(Nota nota)
        {
            var data = _nota.Atualizar(nota);

            return Json(data, JsonRequestBehavior.AllowGet);
        }

        public JsonResult AdicionarNota(Nota nota)
        {
            var data = _nota.Guardar(nota);

            return Json(data, JsonRequestBehavior.AllowGet);
        }

        public ActionResult Excluir(Nota nota)
        {
            _nota.Deletar(nota);

            return View();
        }
    }
}