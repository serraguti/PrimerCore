using Microsoft.AspNetCore.Mvc;
using PrimerCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrimerCore.Controllers
{
    public class PracticasController : Controller
    {
        //ESTE METODO SE LLAMA GET
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

        public IActionResult SumarNumerosGet(int numero1, int numero2)
        {
            ViewBag.Suma = numero1 + numero2;
            return View();
        }

        public IActionResult SumarNumerosPost()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SumarNumerosPost(int numero1, int numero2)
        {
            int suma = numero1 + numero2;
            ViewBag.Suma = suma;
            return View();
        }

        public IActionResult TablaMultiplicar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult TablaMultiplicar(int numero)
        {
            //CREAMOS UNA COLECCION DE FilaTabla
            List<FilaTabla> filas = new List<FilaTabla>();
            for (int i = 1; i <= 10; i++)
            {
                //CREAMOS UN NUEVO OBJETO FILA PARA DIBUJAR
                FilaTabla f = new FilaTabla();
                f.Operacion = numero + " * " + i;
                f.Resultado = numero * i;
                //GUARDAMOS CADA FILA EN LA COLECCION
                filas.Add(f);
            }
            //DEVOLVEMOS EL MODELO A LA VISTA
            return View(filas);
        }
    }
}
