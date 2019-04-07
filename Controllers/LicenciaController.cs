
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FinalProg3_prueba2.Controllers
{
    public class LicenciaController : Controller
    {
        //Objects
        ADOContextDB_Final Db;
        //Builder
        public LicenciaController()
        {
            Db = new ADOContextDB_Final();
            MostrarAllBox();
        }
        // GET: Licencia
        public ActionResult Index()
        {
            var model = Db.Licencias.ToList();
            return View(model);
        }


        // GET: Licencia/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Licencia/Create
        [HttpPost]
        public ActionResult Create(Licencias model)
        {
            try
            {
                // TODO: Add insert logic here
                Db.Licencias.Add(model);
                Db.SaveChanges();
                return RedirectToAction("Index", model);
            }
            catch
            {
                return View();
            }
        }

        private void MostrarAllBox()
        {
            ViewBag.Grupos = Db.Empleados.Select(x => new { IdGrupo = x.Id_empleado, Grupo = x.Id_empleado }).ToList();
        }

        // GET: Licencia/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Licencia/Edit/5
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

        // GET: Licencia/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Licencia/Delete/5
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
