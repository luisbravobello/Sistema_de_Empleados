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
              new Empleado { Id=1, Nombre="María García", Departamento="RRHH", Salario=35000m, Activo=true },
              new Empleado { Id=2, Nombre="Juan Pérez", Departamento="Tecnología", Salario=42000m, Activo=true },
              new Empleado { Id=3, Nombre="Carlos Reyes", Departamento="Finanzas", Salario=38500m, Activo=true },
              new Empleado { Id=4, Nombre="Ana Sánchez", Departamento="Operaciones", Salario=29500m, Activo=false },
            };

            return View(lista);
        }
    }
}
