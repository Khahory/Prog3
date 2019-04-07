
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FinalProg3_prueba2.Controllers
{
    public class EmpleadoController : Controller
    {
        ADOContextDB_Final Db;
        public EmpleadoController()
        {
            Db = new ADOContextDB_Final();
            MostrarAllBox();
        }

        // GET: Empleado
        public ActionResult Index(string Estatus)
        {
            var users = from s in Db.Empleados select s;
            if (!String.IsNullOrEmpty(Estatus))
            {
                return View(Db.Empleados.Where(x => x.Estatus.ToString() == Estatus));
            }
            return View(users);
        }

        // GET: Empleado/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Empleado/Create
        public ActionResult Create()
        {
            //Consultar los cargos
          //  var cargos = Db.Cargos.ToList();

          //  var listaCargos = new SelectList(cargos, "Cargo", "Cargo");
            //Consult the departments
            //Aqui creo un ViewData de la lista
          //  ViewData["Cargo"] = listaCargos;
            return View();
        }

        //Create box
        public void MostrarAllBox()
        {
            ViewBag.Grupos = Db.Departamentos.Select(x => new { IdGrupo = x.NombreDepartamento, Grupo = x.NombreDepartamento }).ToList();
            ViewBag.Grupos2 = Db.Cargos.Select(x => new { IdGrupo = x.Cargo, Grupo = x.Cargo }).ToList();
        }

        // POST: Empleado/Create
        [HttpPost]
        public ActionResult Create(Empleados model)
        {
            try
            {
                // TODO: Add insert logic here
                Db.Empleados.Add(model);
                Db.SaveChanges();
                return RedirectToAction("Index", model);
            }
            catch
            {
                return View();
            }
        }
    }
}
