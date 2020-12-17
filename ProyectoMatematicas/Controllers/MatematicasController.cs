using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProyectoMatematicas.Models;

namespace ProyectoMatematicas.Controllers
{
    public class MatematicasController : Controller
    {
        public IActionResult IndexPaco()
        {
            return View();
        }

        public IActionResult SumarNumeros()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SumarNumeros(int num1, int num2)
        {
            ViewBag.Suma = num1 + num2;
            return View();
        }

        public IActionResult SumarNumerosPaco(int numero1, int numero2)
        {
            int suma = numero1 + numero2;
            ViewData["mensaje"] = "La suma es " + suma;
            return View();
        }

        public IActionResult TablaMultiplicar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult TablaMultiplicar(int numero)
        {
            List<TablaMultiplicar> tablas = new List<TablaMultiplicar>();
            for (int i = 1; i <= 10; i++)
            {
                TablaMultiplicar tabla = new TablaMultiplicar();
                tabla.Operacion = numero + " * " + i;
                tabla.Resultado = numero * i;
                tablas.Add(tabla);
            }
            return View(tablas);
        }

        public IActionResult TablaMultiplicarPaco()
        {
            return View();
        }

        [HttpPost]
        public IActionResult TablaMultiplicarPaco(int numero)
        {
            List<FilaMultiplicar> tabla = new List<FilaMultiplicar>();
            for (int i = 1; i <= 10; i++)
            {
                FilaMultiplicar f = new FilaMultiplicar();
                f.Operacion = numero + " * " + i;
                f.Resultado = numero * i;
                tabla.Add(f);
            }
            return View(tabla);
        }

        public IActionResult ConjeturaCollatz(String numero)
        {
            List<int> numeros = new List<int>();
            if (numero != null)
            {
                int num = int.Parse(numero);
                numeros.Add(num);
                while (num > 1)
                {
                    if (num % 2 == 0)
                    {
                        num /= 2;
                        numeros.Add(num);
                    }
                    else
                    {
                        num = (num * 3) + 1;
                        numeros.Add(num);
                    }
                }
                //ViewBag.Numero = int.Parse(numero
            }
            return View(numeros);
        }

        //public IActionResult CollatzPaco(System.Nullable<int> numero)
        public IActionResult CollatzPaco(int? numero)
        {
            //ESTAMOS RECIBIENDO EL PARÁMETRO 100%
            if (numero != null)
            {
                List<int> collatz = new List<int>();
                collatz.Add(numero.Value);
                while (numero != 1)
                {
                    if (numero % 2 == 0)
                    {
                        numero /= 2;
                    }
                    else
                    {
                        numero = numero * 3 + 1;
                    }
                    collatz.Add(numero.Value);
                }
                //CÓMO DEVUELVO ESTO A LA VISTA????
                ViewData["collatz"] = collatz;
            }
            //SIEMPRE DEVOLVEREMOS LOS ALEATORIOS
            //ViewData["numero"] = numero;
            List<int> aleatorios = new List<int>();
            Random random = new Random();
            for (int i = 1; i <= 10; i++)
            {
                int aleat = random.Next(1, 15);
                aleatorios.Add(aleat);
            }
            return View(aleatorios);
        }
    }
}