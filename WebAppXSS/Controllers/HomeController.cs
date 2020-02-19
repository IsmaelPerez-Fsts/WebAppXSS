using Ganss.XSS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebAppXSS.Models;
using WebAppXSS.Repositories;

namespace WebAppXSS.Controllers
{
    public class HomeController : Controller
    {

        ComentariosRepository repo;

        public HomeController()
        {
            this.repo = new ComentariosRepository();
        }

        public ActionResult Index()
        {
            ViewBag.comentarios = repo.GetComentarios();
            return View();
        }

        [HttpPost]
        public ActionResult Index(Comentario comentario)
        {
            HtmlSanitizer sanitizer = new HtmlSanitizer();

            comentario.textoComentario = sanitizer.Sanitize(comentario.textoComentario);

            repo.InsertComentarios(comentario);
            return RedirectToAction("index");
        }

    }
}