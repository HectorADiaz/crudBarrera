using appEjercicio.Models;
using appEjercicio.Models.TableViewModels;
using appEjercicio.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace appEjercicio.Controllers
{
    public class AlumnosController : Controller
    {
        // GET: Alumnos
        public ActionResult Index()
        {
            List<AlumnoTableViewModel> lst = null;
            using (crudEntities db = new crudEntities())
            {

                lst = (from d in db.alumno
                      
                       select new AlumnoTableViewModel
                       {
                           idAlumno = d.idAlumno,
                           nombre = d.nombre,
                           idGrado=d.idGrado
                       }).ToList();

            }
            return View(lst);
        }

        [HttpGet]
        public ActionResult Add() {
            return View();
        }

        [HttpPost]
        public ActionResult Add(AlumnoViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            using (var db = new crudEntities())
            {
                alumno oAlumno = new alumno();
                oAlumno.nombre = model.nombre;
                oAlumno.idGrado = model.idGrado;
                oAlumno.idRol = 2;

                db.alumno.Add(oAlumno);
                db.SaveChanges();

            }
            return Redirect(Url.Content("~/Alumnos/"));
        }

        public ActionResult Edit(int id)
        {
            EditAlumnoViewModel model = new EditAlumnoViewModel();

            using (var db = new crudEntities())
            {
                var oAlumno = db.alumno.Find(id);
                model.nombre = oAlumno.nombre;
                model.idGrado = oAlumno.idGrado;
                model.idAlumno = oAlumno.idAlumno;
            }



            return View(model);// generamos las vistas de add
        }

        [HttpPost]
        public ActionResult Edit(EditAlumnoViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);

            }
            using (var db = new crudEntities())
            {
                var oAlumno = db.alumno.Find(model.idAlumno);
                oAlumno.nombre = model.nombre;
                oAlumno.idGrado = model.idGrado;
                oAlumno.idRol = 3;

                db.Entry(oAlumno).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();

            }

            return Redirect(Url.Content("~/Alumnos/"));

        }


        [HttpGet]
        public ActionResult Delete(int id)
        {
            using (var db = new crudEntities())
            {
                var oAlumno = db.alumno.Find(id);
                db.alumno.Remove(oAlumno);
                db.SaveChanges();
            }

            return Redirect("~/Alumnos/");
        }


    }
}