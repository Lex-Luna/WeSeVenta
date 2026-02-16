# Sistema de Ventas – .NET Core 8 MVC

## Descripción
Sistema de ventas desarrollado con **.NET Core 8 (MVC)** para la capa backend. El proyecto gestiona productos, clientes, ventas y las relaciones entre estas entidades, y está diseñado para conectarse a **SQL Server** mediante **Entity Framework Core**.

## Tecnologías y Paquetes Utilizados
- **Framework:** .NET Core 8 (MVC)
- **Base de datos:** Microsoft SQL Server
- **Paquetes NuGet añadidos:**
  - `Microsoft.Data.SqlClient`
  - `Microsoft.EntityFrameworkCore`
  - `Microsoft.EntityFrameworkCore.Tools`

## Base de Datos
El proyecto se enlaza a una base de datos SQL Server. Los scripts de creación y relación de tablas se encuentran en la carpeta: SceiptsBDD

## Generación de Modelos (Database First)
Para conectar Entity Framework con la base de datos existente y generar las clases de entidad en la carpeta `Models`, se ejecutó el siguiente comando en la **Consola de Administrador de Paquetes** (PMC) de Visual Studio:

```powershell
Scaffold-DbContext "Server=localhost;Database=VentaReal;Trusted_Connection=True;TrustServerCertificate=True;" Microsoft.EntityFrameworkCore.SqlServer -OutputDir Models

## Controladores API
Los controladores se encuentran en la carpeta `Controllers`. Para comenzar a desarrollar la lógica de la aplicación, se creó un controlador de tipo **API** siguiendo estos pasos:

1. Hacer clic derecho sobre la carpeta `Controllers` en el Explorador de Soluciones.
2. Seleccionar **Agregar > Controlador**, según la versión de Visual Studio).
3. Elegir la opción **"API"** y luego **"API en blanco"**.
4. Asignar un nombre al controlador, por ejemplo `ClienteController`.  
   **Nota:** Es necesario que el nombre termine en **`Controller`** (por ejemplo, `ProductosController`), ya que así es como ASP.NET Core reconoce que la clase es un controlador de API REST.

Este proceso genera una clase base con métodos vacíos que luego se implementan para realizar las operaciones **CRUD** (Crear, Leer, Actualizar, Eliminar) sobre las entidades correspondientes.

Al crear el controlador, la clase generada hereda de ControllerBase, lo que le otorga la funcionalidad base para manejar peticiones HTTP.

Ejemplo de creación de método GET para un controlador:

csharp
[HttpGet]
public IActionResult Get()
{
    return Ok("Hola desde el controlador de cliente");
}

**importante:** 
Para que se pueda acceder a este método, es necesario configurar las rutas en el archivo `Program.cs` o `Startup.cs`, dependiendo de la versión de ASP
