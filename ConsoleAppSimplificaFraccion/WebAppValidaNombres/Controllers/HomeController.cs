using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebAppValidaNombres.Models;

namespace WebAppValidaNombres.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }



        [HttpPost]
        public ActionResult Index(WebAppValidaNombres.Models.FullName Names)
        {
            //
            ValidatedFullName Completo = new ValidatedFullName()
            {
                NombreCompletoValidado = ""
            };

            if (ModelState.IsValid) {
                Completo.NombreCompletoValidado = string.Format("{0} {1} {2}", Names.priNombre, 
                    (Names.segNombre==null || (Names.segNombre.Length==0))?"": Names.segNombre, Names.apellido);

                return View("ShowValidateFullName", Completo);
            }
            else
            {
                return View();
            }                
        }

        public ActionResult About()
        {
            string Message = "Ejercicio nro. 2 de E3 ecommerce:" + Environment.NewLine +
                        "2) Validar Nombres" + Environment.NewLine +
                        "Tener en cuenta las siguientes definiciones" + Environment.NewLine +
                        "a) El termino ingresado pueden ser iniciales o palabras completas" + Environment.NewLine +
                        "b) Una inicial es solo un caracter mas un punto" + Environment.NewLine +
                        "c) Una palabra se comprende de 2 o mas caracteres, sin punto." + Environment.NewLine +
                        "Un nombre Válido se puede escribir de alguna de las siguientes formas:" + Environment.NewLine +
                        "E.Poe" + Environment.NewLine +
                        "E.A.Poe" + Environment.NewLine +
                        "Edgard Allan Poe" + Environment.NewLine +
                        "Edgard A. Poe"
                        ;

            //ViewBag.Message = HttpUtility.HtmlEncode(Message.Replace(Environment.NewLine, "<br/>"));
            //ViewBag.Message = Message.Replace(Environment.NewLine, "<br />");
            ViewBag.Message = Message;
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Email: mariolealfuentes@gmail.com.";

            return View();
        }
    }
}