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

        public JsonResult Pesquisar()
        {
            var pesquisar = new Modelos.Model.Aluno();
            var data = _aluno.Pesquisar(pesquisar);

            return Json(data, JsonRequestBehavior.AllowGet);
        }

        public ActionResult Adicionar()
        {
            return View();
        }

        public JsonResult Atualizar(Aluno aluno)
        {
            var data = _aluno.Atualizar(aluno);

            return Json(data, JsonRequestBehavior.AllowGet);
        }

        public JsonResult AdicionarAluno(Aluno aluno)
        {
            var data = _aluno.Guardar(aluno);

            return Json(data, JsonRequestBehavior.AllowGet);
        }

        public ActionResult Excluir(Aluno aluno)
        {
            _aluno.Deletar(aluno);

            return View();
        }
    }
}