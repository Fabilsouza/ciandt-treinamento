using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ClubeDoCarro.Areas.Proprietario.Controllers
{
    public class VeiculoController : Controller
    {
        // GET: Proprietario/Veiculo
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Cadastrar()
        {
            return View();
        }
    }
}