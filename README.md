# Sistema de Empleados  Razor MVC & Blazor

Proyecto de laboratorio para la asignatura **ISW-311 Tecnologías de Internet I** — Universidad Central del Este.

Aplicación ASP.NET Core (.NET 8) que combina **Razor MVC** y **Blazor Server** en un mismo proyecto:

- **Parte 1 — Razor MVC:** listado de empleados en una tabla HTML, con datos hardcodeados (sin base de datos).
- **Parte 2 — Blazor:** calculadora de nómina que calcula en tiempo real el descuento de TSS (AFP y SFS) mientras el usuario escribe, sin recargar la página.

## Tecnologías

- ASP.NET Core 8.0 (MVC)
- Blazor Server
- C#, Razor Pages / Razor Views
- Bootstrap 5

## Estructura del proyecto

```
Sistema_de_Empleados/
├── Controllers/
│   └── EmpleadoController.cs      # Lista hardcodeada de empleados
├── Models/
│   └── Empleado.cs                 # Modelo de datos del empleado
├── Views/
│   ├── Empleado/Index.cshtml       # Tabla de empleados (Razor)
│   └── Shared/_Layout.cshtml       # Layout general + navbar
├── Pages/
│   ├── _Host.cshtml                # Punto de entrada de Blazor
│   ├── App.razor                   # Enrutador de Blazor
│   ├── _Imports.razor              # Usings compartidos por los componentes Blazor
│   └── Calculadora.razor           # Calculadora de nómina (Blazor)
└── Program.cs                      # Configuración de servicios y rutas
```

## Funcionalidades

### Parte 1  Lista de Empleados (`/Empleado`)
- Modelo `Empleado` con Id, Nombre, Departamento, Salario y Estado (Activo/Inactivo).
- Tabla generada con `@foreach` a partir de una lista hardcodeada en el Controller.
- Mensaje condicional (`@if`) si la lista está vacía.
- Contador total de empleados con `@Model.Count`.

### Parte 2  Calculadora de Nómina (`/calculadora`)
- Cálculo en tiempo real de:
  - **AFP** (2.87%)
  - **SFS** (3.04%)
  - **Salario neto**
- Actualización instantánea con `@bind:event="oninput"` (sin botones ni recargas).
- Aviso visual si el salario está por debajo del mínimo cotizable TSS 2026 (RD$23,223).

> **Nota técnica:** fue necesario agregar `Pages/_Imports.razor` con los `@using` de Blazor (`Microsoft.AspNetCore.Components.Routing`, etc.), ya que a diferencia de una plantilla Blazor completa, el proyecto MVC no lo genera automáticamente. Sin este archivo, `App.razor` no reconoce las etiquetas `Router`, `Found`, `RouteView` y `NotFound`.

## Cómo ejecutar el proyecto

1. Clona el repositorio:
   ```
   git clone https://github.com/luisbravobello/Sistema_de_Empleados.git
   ```
2. Ábrelo con Visual Studio 2022 (o superior), usando el archivo `.sln`/`.slnx`.
3. Presiona **F5** (o `Ctrl+F5`) para compilar y ejecutar.
4. Navega a:
   - `/Empleado` — para ver la tabla de empleados.
   - `/calculadora` — para probar la calculadora de nómina.

## Tabla de verificación TSS 2026

| Salario bruto | AFP (2.87%) | SFS (3.04%) | Neto |
|---|---|---|---|
| RD$23,223.00 | RD$666.50 | RD$706.38 | RD$21,850.12 |
| RD$35,000.00 | RD$1,004.50 | RD$1,064.00 | RD$32,931.50 |
| RD$42,000.00 | RD$1,205.40 | RD$1,276.80 | RD$39,517.80 |

## Autor

Luis Bravo Bello — ISW-311, Universidad Central del Este, San Pedro de Macorís, RD.
