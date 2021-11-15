﻿using Microsoft.AspNetCore.Mvc;
using PrimerCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrimerCore.Controllers
{
    public class Coche2Controller : Controller
    {
        private Coche car;

        public Coche2Controller(Coche car)
        {
            //IGUALAMOS EL COCHE DE LA CLASE CON EL 
            //QUE NOS HAN ENVIADO
            this.car = car;
        }

        public IActionResult Index()
        {
            return View(this.car);
        }
    }
}
