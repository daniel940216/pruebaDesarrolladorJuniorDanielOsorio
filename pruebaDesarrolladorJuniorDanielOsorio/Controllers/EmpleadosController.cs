using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PagedList.Core;
using pruebaDesarrolladorJuniorDanielOsorio.Data;
using pruebaDesarrolladorJuniorDanielOsorio.Models;
using pruebaDesarrolladorJuniorDanielOsorio.Models.Paginador;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace pruebaDesarrolladorJuniorDanielOsorio.Controllers
{
    public class EmpleadosController : Controller
    {
        private readonly ApplicationDbContext _context;

        public EmpleadosController(ApplicationDbContext context)
        {
            _context = context;
        }

        // Http Get Index

        [HttpGet]
        public IActionResult Index()
        {
            IEnumerable<Empleado> listEmpleados = _context.Empleado;

            return View(listEmpleados);
        }

        // Http Get Create

        public IActionResult Create()
        {
            return View();
        }

        // Http Post Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Empleado empleado)
        {
            if(ModelState.IsValid)
            {
                _context.Empleado.Add(empleado);
                _context.SaveChanges();

                TempData["mensaje"] = "El empleado se ha creado correctamente";
                return RedirectToAction("Index");
            }
            return View();
        }

        // Http Get Edit

        public IActionResult Edit(int? id)
        {
            if(id == null || id == 0)
            {
                return NotFound();
            }

            // Obtener el empleado
            var empleado = _context.Empleado.Find(id);

            if(empleado == null)
            {
                return NotFound();
            }

            return View(empleado);
        }

        // Http Post Edit
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Empleado empleado)
        {
            if (ModelState.IsValid)
            {
                _context.Empleado.Update(empleado);
                _context.SaveChanges();

                TempData["mensaje"] = "El empleado se ha actualizado correctamente";
                return RedirectToAction("Index");
            }
            return View();
        }

        // Http Get Delete

        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            // Obtener el empleado
            var empleado = _context.Empleado.Find(id);

            if (empleado == null)
            {
                return NotFound();
            }

            return View(empleado);
        }

        // Http Post Delete
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteEmpleado(int? id)
        {
            //Obtener el empleado por Id
            var empleado = _context.Empleado.Find(id);

            if (empleado == null)
            {
                return NotFound();
            }

            _context.Empleado.Remove(empleado);
            _context.SaveChanges();

            TempData["mensaje"] = "El empleado se ha eliminado correctamente";
            return RedirectToAction("Index"); 

        }
    }
}
