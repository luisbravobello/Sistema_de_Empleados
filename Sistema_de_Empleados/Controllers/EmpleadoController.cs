using Microsoft.AspNetCore.Mvc;
using Sistema_de_Empleados.Models;

namespace Sistema_de_Empleados.Controllers
{
    public class EmpleadoController : Controller
    {
        public IActionResult Index()
        {

            var lista = new List<Empleado>
            {
              new Empleado { Id=1, Nombre="Luis Bravo", Departamento="Informática", Salario=35000m, Activo=true },
              new Empleado { Id=2, Nombre="Juan García", Departamento="Biología", Salario=42000m, Activo=true },
              new Empleado { Id=3, Nombre="Alexandra López", Departamento="Operaciones", Salario=38500m, Activo=true },
              new Empleado { Id=4, Nombre="Martin Rodríguez", Departamento="Servicios", Salario=29500m, Activo=false },
            };

            return View(lista);
        }
    }
}
