using Fiap.Web.Aula02.Exemplo01.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fiap.Web.Aula02.Exemplo01.Controllers
{
    public class PlanetaController : Controller
    {
        static IList<Planeta> _banco = new List<Planeta>();
        [HttpGet]
        public IActionResult Cadastrar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Cadastrar(Planeta planeta)
        {
            _banco.Add(planeta);
            ViewBag.banco = _banco;
            return RedirectToAction("Cadastrar");
        }

        public IActionResult Listar()
        {
            ViewBag.banco = _banco;
            return View();
        }
    }
}
