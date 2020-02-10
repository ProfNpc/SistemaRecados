using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SistemaRecados.Models;

namespace SistemaRecados.Controllers
{
    public class RecadoController : Controller
    {
        private static IList<Recado> recados = new List<Recado>();


        public IActionResult Index()
        {

            return View(recados.OrderByDescending(r => r.Horario));
        }

        public ActionResult NovoRecado()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult NovoRecado(Recado recado)
        {
            if (recado.Autor == null)
            {
                recado.Autor = "Anônimo";
            }
            recado.Horario = DateTime.Now;
            recado.Mensagem = recado.Mensagem.Trim();
            recados.Add(recado);
            recado.RecadoID = recados.Select(r => r.RecadoID).Max() + 1;
            return RedirectToAction("Index");
        }
    }
}