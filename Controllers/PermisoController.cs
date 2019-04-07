
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FinalProg3_prueba2.Controllers
{
    public class PermisoController : Controller
    {
        //Objects
        ADOContextDB_Final Db;
        //Builder
        public PermisoController()
        {
            Db = new ADOContextDB_Final();
            MostrarAllBox();
        }
        // GET: Permiso
        public ActionResult Index(string BuscarPor)
        {
            var Permisos = from s in Db.Permisos select s;
            if (!String.IsNullOrEmpty(BuscarPor))
            {
                return View(Db.Permisos.Where(x => x.Empleados.Nombre.Contains(BuscarPor)));
            }
            return View(Permisos);

            //var model = Db.Permisos.ToList();
            //return View(model);
        }

        // GET: Permiso/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Permiso/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Permiso/Create
        [HttpPost]
        public ActionResult Create(Permisos model)
        {
            try
            {
                // TODO: Add insert logic here
                Db.Permisos.Add(model);
                Db.SaveChanges();
                return RedirectToAction("Index", model);
            }
            catch
            {
                return View();
            }
        }

        //Create box
        private void MostrarAllBox()
        {
            ViewBag.Grupos = Db.Empleados.Select(x => new { IdGrupo = x.Id_empleado, Grupo = x.Id_empleado }).ToList();
        }

        // GET: Permiso/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Permiso/Edit/5
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

        // GET: Permiso/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Permiso/Delete/5
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
