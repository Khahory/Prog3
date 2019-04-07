
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FinalProg3_prueba2.Controllers
{
    public class CargoController : Controller
    {
        //objetos
        ADOContextDB_Final Db;
        //Constructor
        public CargoController()
        {
            Db = new ADOContextDB_Final();
        }

        // GET: Cargo
        public ActionResult Index()
        {
            var model = Db.Cargos.ToList();
            return View(model);
        }

        // GET: Cargo/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Cargo/Create
        [HttpPost]
        public ActionResult Create(Cargos model)
        {
            try
            {
                // TODO: Add insert logic here
                Db.Cargos.Add(model);
                Db.SaveChanges();
                return RedirectToAction("Index", model);
            }
            catch
            {
                return View();
            }
        }

        // GET: Cargo/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Cargo/Edit/5
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

        // GET: Cargo/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Cargo/Delete/5
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
