using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ClubeDoCarro.Areas.Proprietario.Models;
using ClubeDoCarro.Models;

namespace ClubeDoCarro.Areas.Proprietario.Controllers
{
    public class VendasController : Controller
    {
        private ClubeDoCarroContext db = new ClubeDoCarroContext();

        // GET: Proprietario/Vendas
        public ActionResult Index()
        {
            return View(db.Veiculos.ToList());
        }

        // GET: Proprietario/Vendas/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Proprietario/Vendas/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "VendaId,VeiculoId,UsuarioVenda,UsuarioCompra,DataVenda,ValorVenda")] Venda venda)
        {
            if (ModelState.IsValid)
            {
                db.Vendas.Add(venda);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(venda);
        }

    }
}