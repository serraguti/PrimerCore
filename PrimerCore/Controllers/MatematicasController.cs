using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrimerCore.Controllers
{
    public class MatematicasController : Controller
    {
        //HACEMOS UN METODO PRIVADO PARA RECUPERAR
        //NUMEROS ALEATORIOS List<int>
        private List<int> GetNumerosRandom()
        {
            List<int> numeros = new List<int>();
            Random random = new Random();
            for (int i = 1; i <= 7; i++)
            {
                int num = random.Next(1, 100);
                numeros.Add(num);
            }
            return numeros;
        }

        //METODO PARA DEVOLVER LA COLECCION DE NUMEROS
        //DE COLLATZ
        private List<int> GetNumerosCollatz(int numero) {
            List<int> numeros = new List<int>();
            numeros.Add(numero);
            while (numero != 1)
            {
                if (numero % 2 == 0)
                {
                    numero = numero / 2;
                }
                else
                {
                    numero = numero * 3 + 1;
                }
                numeros.Add(numero);
            }
            return numeros;
        }

        //GET
        public IActionResult ConjeturaCollatz()
        {
            //AQUI QUEREMOS ENVIAR NUMEROS EN VIEWBAG
            //PARA DIBUJARLOS EN LA PAGINA CON UN DESPLEGABLE
            List<int> aleatorios = this.GetNumerosRandom();
            ViewBag.Random = aleatorios;
            return View();
        }

        [HttpPost]
        public IActionResult ConjeturaCollatz(int numero)
        {
            //CUANDO ENVIAMOS VARIOS OBJETOS PARA SER DIBUJADOS
            //POR VIEWBAG/VIEWDATA Y MODEL DEBEN SER ENVIADOS
            //DE NUEVO TAMBIEN EN EL POST
            List<int> collatz = this.GetNumerosCollatz(numero);
            List<int> aleatorios = this.GetNumerosRandom();
            ViewBag.Random = aleatorios;
            //ENVIAMOS LOS DATOS POR MODEL
            return View(collatz);
        }
    }
}
