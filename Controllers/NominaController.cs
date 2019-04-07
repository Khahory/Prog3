
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FinalProg3_prueba2.Controllers
{
    public class NominaController : Controller
    {
        //Objects
        ADOContextDB_Final Db;
        //Builder
        public NominaController()
        {
            Db = new ADOContextDB_Final();
            
        }
        // GET: Nomina
        public ActionResult Index()
        {
            var model = Db.Nominas.ToList();
            return View(model);
        }

        // GET: Nomina/Create
        public ActionResult Create()
        {
            CalculatePayroll();
            return View();
        }

        //Calculate payroll
        private void CalculatePayroll()
        {
            decimal? x = 0;
            //Create list of active employees
            foreach (var item in Db.Empleados)//buscara a todos los empleados de la DB
            {
                if (item.Estatus == 1) //verifica que el empleado de ese momento tenga estatus = 1
                {
                    x = x + item.Salario;
                }
            }
          //  foreach (var item in Db.Empleados)//buscara a todos los empleados de la DB
          //  {
          //      x = x + item.Salario;
          //  }

            ViewBag.Total = x;
        }

        // POST: Nomina/Create
        [HttpPost]
        public ActionResult Create(Nominas model)
        {
            try
            {
                // TODO: Add insert logic here
                Db.Nominas.Add(model);
                Db.SaveChanges();
                return RedirectToAction("Index", model);
            }
            catch
            {
                return View();
            }
        }

        // GET: Nomina/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Nomina/Edit/5
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

        // GET: Nomina/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Nomina/Delete/5
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
