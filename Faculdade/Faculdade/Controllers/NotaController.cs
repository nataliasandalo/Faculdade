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
    }
}