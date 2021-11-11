using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrimerCore.Controllers
{
    public class PruebaController : Controller
    {
        //ESTAMOS INDICANDO QUE TENDREMOS UNA VISTA 
        //LLAMADA Index DENTRO DE Views/Prueba
        public IActionResult Index()
        {
            return View();
        }
    }
}
