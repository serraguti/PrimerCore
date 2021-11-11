﻿using Microsoft.AspNetCore.Mvc;
using PrimerCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrimerCore.Controllers
{
    public class PracticasController : Controller
    {
        public IActionResult Menu()
        {
            return View();
        }

        public IActionResult EjemploColecciones()
        {
            List<Comic> listacomics = new List<Comic>();
            Comic comic = new Comic();
            comic.Nombre = "Spiderman";
            comic.Descripcion = "Hombre Araña";
            comic.Imagen = "https://3.bp.blogspot.com/-i70Zu_LAHwI/T290xxduu-I/AAAAAAAALq8/8bXDrdvW50o/s1600/spiderman1.jpg";
            listacomics.Add(comic);
            comic = new Comic();
            comic.Nombre = "Wolverine";
            comic.Descripcion = "Lobezno";
            comic.Imagen = "https://images-na.ssl-images-amazon.com/images/I/51c1Q1IdUBL._SX259_BO1,204,203,200_.jpg";
            listacomics.Add(comic);
            comic = new Comic();
            comic.Nombre = "Spawn";
            comic.Descripcion = "Diablo";
            comic.Imagen = "https://i.pinimg.com/originals/e1/d8/ff/e1d8ff4aeab5e567798635008fe98ee1.png";
            listacomics.Add(comic);
            return View(listacomics);
        }
    }
}