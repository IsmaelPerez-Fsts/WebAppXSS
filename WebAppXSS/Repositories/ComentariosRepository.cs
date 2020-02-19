using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebAppXSS.Models;

namespace WebAppXSS.Repositories
{
    public class ComentariosRepository
    {

        static List<Comentario> Comentarios { get; set; }
        
        public ComentariosRepository()
        {

            if(Comentarios == null)
            {
                Comentarios = new List<Comentario>();

                Comentario c1 = new Comentario();
                c1.textoComentario = "texto comentario 1";
                c1.tipo = "publico";

                Comentarios.Add(c1);

                Comentario c2 = new Comentario();
                c2.textoComentario = "texto comentario 2";
                c2.tipo = "privado";

                Comentarios.Add(c2);
            }
        }

        public List<Comentario> GetComentarios()
        {
            return Comentarios;
        }
        public void  InsertComentarios(Comentario c)
        {
            Comentarios.Add(c);
        }
    }
}