
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FinalProg3_prueba2.Controllers
{
    public class DepartamentoController : Controller
    {
        //Objects
        ADOContextDB_Final Db;
        //Builder
        public DepartamentoController()
        {
            Db = new ADOContextDB_Final();
        }
        // GET: Departamento
        public ActionResult Index()
        {
            var model = Db.Departamentos.ToList();
            return View(model);
        }

        // GET: Departamento/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Departamento/Create
        [HttpPost]
        public ActionResult Create(Departamentos model)
        {
            try
            {
                // TODO: Add insert logic here
                Db.Departamentos.Add(model);
                Db.SaveChanges();

                return RedirectToAction("Index", model);
            }
            catch
            {
                return View();
            }
        }

        // GET: Departamento/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Departamento/Edit/5
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

        // GET: Departamento/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Departamento/Delete/5
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
