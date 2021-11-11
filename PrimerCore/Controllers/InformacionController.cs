using Microsoft.AspNetCore.Mvc;
using PrimerCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrimerCore.Controllers
{
    public class InformacionController : Controller
    {
        //VOY A UTILIZAR LA VISTA INDEX COMO UN MENU
        public IActionResult Index()
        {
            //AQUI ENVIAMOS LA INFORMACION
            return View();
        }

        public IActionResult Menu()
        {
            //AQUI ENVIAMOS LA INFORMACION
            return View();
        }

        public IActionResult InformacionControllerView()
        {
            ViewBag.Nombre = "Alumno";
            ViewData["Descripcion"] = "Estoy aprendiendo Net Core";
            ViewBag.Year = 2021;
            return View();
        }

        public IActionResult InformacionControllerViewModel()
        {
            List<Persona> listapersonas = new List<Persona>();
            for (int i = 1; i <= 10; i++)
            {
                Persona person = new Persona();
                person.Nombre = "Persona " + i;
                person.Edad = 20 + i;
                person.Email = "persona" + i + "@gmail.com";
                listapersonas.Add(person);
            }
            return View(listapersonas);
        }

        public IActionResult InformacionGetViewController(String nombre, int edad)
        {
            ViewBag.Nombre = nombre;
            ViewBag.Edad = edad;
            return View();
        }

        [HttpGet]
        public IActionResult InformacionPostViewController()
        {
            return View();
        }

        //TENEMOS QUE CREAR UN METODO CON EL MISMO NOMBRE
        //QUE LA VISTA, PERO CON LA DECORACION [HttpPost]
        [HttpPost]
        public IActionResult 
            InformacionPostViewController
            (Persona persona)
        {
            return View(persona);
        }
    }
}
