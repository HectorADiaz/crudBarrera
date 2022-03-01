using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using appEjercicio.Models;
using appEjercicio.Models.TableViewModels;
using appEjercicio.Models.ViewModels;

namespace appEjercicio.Controllers
{
    public class DocentesController : Controller
    {
        // GET: Docentes
        public ActionResult Index()
        {
            List<DocentesTableViewModels> lst = null;
            using (crudEntities db = new crudEntities())
            {

                lst = (from d in db.docente

                       orderby d.nombre
                       select new DocentesTableViewModels
                       {
                           idDocente = d.idDocente,
                           nombre = d.nombre
                       }).ToList();

            }
            return View(lst);
        }


        [HttpGet]
        public ActionResult Add()
        {
            return View();// generamos las vistas de add
        }
        [HttpPost]
        public ActionResult Add(DocenteViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            using (var db = new crudEntities())
            {
                docente oDocente = new docente();
                oDocente.nombre = model.nombre;
                oDocente.idRol = 2;

                db.docente.Add(oDocente);
                db.SaveChanges();

            }
            return Redirect(Url.Content("~/Docentes/"));


        }
    }
}