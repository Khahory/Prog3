
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FinalProg3_prueba2.Controllers
{
    public class VacacionesController : Controller
    {
        //Objects
        ADOContextDB_Final Db;
        //Builder
        public VacacionesController()
        {
            Db = new ADOContextDB_Final();
            MostrarAllBox();
        }
        // GET: Vacaciones
        public ActionResult Index()
        {
            var model = Db.Vacaciones.ToList();
            return View(model);
        }


        // GET: Vacaciones/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Vacaciones/Create
        [HttpPost]
        public ActionResult Create(Vacaciones model)
        {
            try
            {
                // TODO: Add insert logic here
                Db.Vacaciones.Add(model);
                Db.SaveChanges();
                return RedirectToAction("Index", model);
            }
            catch
            {
                return View();
            }
        }

        // GET: Vacaciones/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Vacaciones/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //create box
        private void MostrarAllBox()
        {
            ViewBag.Grupos = Db.Empleados.Select(x => new { IdGrupo = x.Id_empleado, Grupo = x.Id_empleado }).ToList();
        }

        // GET: Vacaciones/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Vacaciones/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
