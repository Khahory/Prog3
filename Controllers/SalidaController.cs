
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FinalProg3_prueba2.Controllers
{
    public class SalidaController : Controller
    {
        //objetos
        List<Empleados> empleados;
        ADOContextDB_Final Db;
        //constructor
        public SalidaController()
        {
            empleados = new List<Empleados>();
            Db = new ADOContextDB_Final();
        }

        // GET: Salida
        public ActionResult Index()
        {
            var model = Db.SalidaEmpleado.ToList();
            return View(model);
        }

        // GET: Salida/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Salida/Create
        public ActionResult Create()
        {
            //Aquí consultas los usuarios
            var ListaAllEmpleados = Db.Empleados.ToList();
            //Create list of active employees
            foreach (var item in Db.Empleados)//buscara a todos los empleados de la DB
            {
                if (item.Estatus == 1) //verifica que el empleado de ese momento tenga estatus = 1
                {
                    empleados.Add(item);
                }
            }
            //Aqui creo una lista de los Id de la tabla empleados
            var listaUsuarios = new SelectList(empleados, "Id_empleado", "Id_empleado");
            //Aqui creo un ViewData de la lista de los id de los empleados
            ViewData["Id_empleado"] = listaUsuarios;
            return View();
        }

        // POST: Salida/Create
        [HttpPost]
        public ActionResult Create(SalidaEmpleado model)
        {
            try
            {
                // TODO: Add insert logic here
                Db.SalidaEmpleado.Add(model);
                Db.SaveChanges();
                return RedirectToAction("Index", model);
            }
            catch
            {
                return View();
            }
        }

        // GET: Salida/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Salida/Edit/5
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

        // GET: Salida/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Salida/Delete/5
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
