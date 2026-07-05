# Sistema de Empleados & Calculadora de Nómina TSS 2026

Este proyecto es una aplicación web híbrida desarrollada en **ASP.NET Core** que combina la arquitectura tradicional **MVC (Model-View-Controller) con Razor** y la interactividad en tiempo real de **Blazor Server**. El sistema fue construido como parte de las asignaciones prácticas del laboratorio de desarrollo de software en la **Universidad Central del Este (UCE)**.

## 🚀 Características del Proyecto

### Parte 1: Gestión de Empleados (Razor MVC)
* **Modelado Fuertemente Tipado:** Implementación de la clase `Empleado` en la capa de modelos (`Models/`).
* **Controlador Dedicado:** Uso de un controlador (`EmpleadoController`) con una lista de datos predefinida (*hardcodeada*) para simular el almacenamiento de registros.
* **Vistas Dinámicas con Razor:** * Uso de bucles `@foreach` para la generación dinámica de filas en tablas HTML.
  * Condicionales `@if` para manejar escenarios de listas vacías.
  * Conteo exacto mediante `@Model.Count`.

### Parte 2: Calculadora de Nómina TSS 2026 (Blazor Server)
* **Componentes Interactivos:** Archivo `Calculadora.razor` integrado directamente en el pipeline de vistas de la aplicación.
* **Interactividad sin Recargas (SPA):** Uso de la directiva `@bind:event="oninput"` para capturar las pulsaciones del teclado y actualizar la interfaz al instante mediante WebSockets (SignalR).
* **Propiedades Calculadas:** Deducciones calculadas automáticamente utilizando miembros con cuerpo de expresión (`=>`) en C#.
* **Regulaciones TSS Dominicana:**
  * Alerta dinámica si el salario bruto está por debajo del mínimo cotizable estipulado para el 2026 (**RD$ 23,223.00**).
  * Deducción automatizada de **AFP (2.87%)**.
  * Deducción automatizada de **SFS (3.04%)**.

---

## 🛠️ Tecnologías y Herramientas Utilizadas

* **Framework:** .NET 6.0 / .NET 8.0 (ASP.NET Core)
* **Lenguajes:** C#, HTML5, CSS3
* **Librerías de Estilos:** Bootstrap 5
* **Entorno de Desarrollo:** Visual Studio Community

---

## 📋 Requisitos para la Ejecución

Antes de clonar y ejecutar el proyecto, asegúrate de tener instalado:
* [.NET SDK](https://dotnet.microsoft.com/download) (Versión compatible con tu instalación global).
* [Visual Studio](https://visualstudio.microsoft.com/) con la carga de trabajo **Desarrollo de ASP.NET y web** activa.

---

## 🔧 Configuración e Instalación

1. **Clonar el repositorio:**
   ```bash
   git clone [https://github.com/luisbravobello/Sistema_de_Empleados.git](https://github.com/luisbravobello/Sistema_de_Empleados.git)
