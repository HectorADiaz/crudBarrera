using appEjercicio.Models;
using appEjercicio.Models.ViewModels;
using appEjercicio.Models.TableViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace appEjercicio.Controllers
{
    public class materiasController : Controller
    {
        // GET: materias
        public ActionResult Index()
        {
            List<materiaTableViewModel> lst = null;
            using (crudEntities db = new crudEntities())
            {

                lst = (from d in db.materia
                       
                       orderby d.nombre
                       select new materiaTableViewModel
                       {
                           idMateria = d.idMateria,
                           nombre = d.nombre
                       }).ToList();

            }
            return View(lst);
        }


        [HttpGet]
        public ActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Add(MateriaViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            using (var db = new crudEntities())
            {
                materia oMateria= new materia();
                oMateria.nombre = model.nombre;

                db.materia.Add(oMateria);
                db.SaveChanges();

            }
            return Redirect(Url.Content("~/materias/"));


        }


        public ActionResult Edit(int id)
        {
            EditMateriaViewModel model = new EditMateriaViewModel();

            using (var db= new crudEntities())
            {
                var oMaterias = db.materia.Find(id);
                model.nombre = oMaterias.nombre;
                model.idMateria = oMaterias.idMateria;
            }



                return View(model);// generamos las vistas de add
        }

        [HttpPost]
        public ActionResult Edit(EditMateriaViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);

            }
            using (var db = new crudEntities())
            {
                var oMaterias = db.materia.Find(model.idMateria);
                oMaterias.nombre = model.nombre;
                
            
                db.Entry(oMaterias).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();

            }

            return Redirect(Url.Content("~/materias/"));

        }



    }
}