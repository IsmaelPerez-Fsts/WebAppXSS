using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebAppXSS.Models
{
    public class Comentario
    {
        [AllowHtml]
        public string textoComentario { get; set; }
        public string tipo { get; set; } // publico o privado
    }
}