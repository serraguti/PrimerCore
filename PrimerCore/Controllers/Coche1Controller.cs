using Microsoft.AspNetCore.Mvc;
using PrimerCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrimerCore.Controllers
{
    public class Coche1Controller : Controller
    {
        //DECLARAMOS UN COCHE PARA UTILIZAR
        private Coche car;

        public Coche1Controller()
        {
            //CONSTRUIMOS UN NUEVO COCHE Y LE DAMOS PROPIEDADES
            this.car = new Coche();
            this.car.Marca = "Volkswagen";
            this.car.Modelo = "Escarabajo";
            //IMAGEN EN LOCAL
            this.car.Imagen = "herbie.jpg";
            this.car.Velocidad = 0;
            this.car.VelocidadMaxima = 110;
        }

        public IActionResult Index()
        {
            return View(this.car);
        }

        [HttpPost]
        public IActionResult Index(string accion)
        {
            if (accion == "acelerar")
            {
                this.car.Acelerar();
            }
            else
            {
                this.car.Frenar();
            }
            return View(this.car);
        }
    }
}
