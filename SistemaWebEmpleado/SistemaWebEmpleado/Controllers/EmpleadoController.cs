using Microsoft.AspNetCore.Mvc;
using SistemaWebEmpleado.Data;
using SistemaWebEmpleado.Models;
using System.Linq;



namespace SistemaWebEmpleado.Controllers
{
    public class EmpleadoController : Controller
    {
        //inyeccion de dependencia
        private readonly DBEmpleadosContext context;

        public EmpleadoController(DBEmpleadosContext context)
        {
            this.context = context;
        }

        //Get/Empleado/index
        [HttpGet]
        public IActionResult Index(string titulo = null)
        {
            //lista de empleados
            var empleados = context.Empleados.ToList();
            ViewBag.Filtrado = false;
            if (!string.IsNullOrEmpty(titulo))
            {
                ViewBag.Filtrado = true;
                empleados = empleados.FindAll(c=>c.Titulo.ToUpper() == titulo.ToUpper());
            }

            //enviar los empleados a la vista
            return View(empleados);
        }

        //Get: Empleado/insert
        [HttpGet]
        public ActionResult Insert()
        {
            Empleado empleado = new Empleado();

            return View("Insert", empleado);
        }

        //post: Empleado/insert
        [HttpPost]
        public ActionResult Insert(Empleado empleado)
        {
            if (ModelState.IsValid)
            {
                context.Empleados.Add(empleado);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(empleado);
        }

        private Empleado BuscarPorId(int id)
        {
            return context.Empleados.Find(id);
        }


        //GET Empleado/Edit
        [HttpGet]
        public ActionResult Editar(int id)
        {
            Empleado empleado = BuscarPorId(id);
            if (empleado == null)
            {
                return NotFound();
            }
            else
            {
                return View("Editar", empleado);
            }

        }

        //POST Empleado/Edit
        [HttpPost]
        public ActionResult Editar(int id, Empleado empleado)
        {

            if (empleado == null)
            {
                return NotFound();
            }
            else
            {
                context.Empleados.Update(empleado);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
        }

        // GET empleado/delete/1
        [HttpGet]
        public ActionResult Delete(int id)
        {
            var empleado = context.Empleados.Find(id);
            if (empleado == null)
            {
                return NotFound();
            }
            else
            {
                return View("Delete", empleado);
            }
        }

        //POST empleado/delete/1
        [ActionName("Delete")]
        [HttpPost]
        public ActionResult DeleteConfirmed(int id)
        {
            var empleado = context.Empleados.Find(id);
            if (empleado == null)
            {
                return NotFound();
            }
            else
            {
                context.Empleados.Remove(empleado);
                context.SaveChanges();
                return RedirectToAction("Index");
            }

        }

        [HttpGet]
        public ActionResult TraerUno(int id)
        {
            Empleado empleado = BuscarPorId(id);
            if (empleado == null)
            {
                return NotFound();
            }
            else
            {
                return View("TraerUno", empleado);
            }
        }

        [HttpGet]
        public ActionResult BuscarUno()
        {
            Empleado empleado = new Empleado();

            return View("BuscarUno", empleado);
        }

        [HttpPost]
        public ActionResult BuscarUno(Empleado empleado)
        {
            Empleado _empleado = BuscarPorId(empleado.Id);

            if (_empleado == null)
            {
                return NotFound();
            }
            else
            {
                context.Empleados.Update(_empleado);
                context.SaveChanges();
                return RedirectToAction("TraerUno", new { id = empleado.Id});
            }
        }



    }
}
