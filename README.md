# CSE325 — ASP.NET Core Learning Projects

Ejercicios académicos de C# y ASP.NET Core, organizados por semana. Este repositorio reúne prácticas de consola, Blazor, MVC y Razor Pages.

## Proyectos

| Carpeta | Contenido |
| --- | --- |
| `Week 1/CostosoPizza` | Aplicación ASP.NET Core y modelo Pizza |
| `Week 1/DotNetDebugging` | Práctica de depuración |
| `Week 1/DotNetDependencies` | Dependencias en .NET |
| `Week 1/WorkWithFiles/mslearn-dotnet-files` | Trabajo con archivos |
| `Week 2/BlazorApp` | Aplicación Blazor |
| `Week 2/MvcMovie` | Gestión de películas con MVC |
| `Week 2/RazorPagesMovie` | Gestión de películas con Razor Pages |

Las carpetas de semanas posteriores contienen marcadores para futuras actividades.

## Tecnologías

C#, ASP.NET Core 10, Entity Framework Core 10, SQLite y vistas Razor. Los proyectos MVC y Razor Pages incluyen migraciones y carga inicial de datos.

## Ejecutar MVC

Requisitos: .NET SDK 10 y herramienta `dotnet-ef` compatible con EF Core 10.

```bash
git clone https://github.com/arojases/CSE325_Project.git
cd "CSE325_Project/Week 2/MvcMovie"
dotnet restore
dotnet ef database update
dotnet run
```

Abre la dirección indicada en la terminal y visita `/Movies`.

## Ejecutar Razor Pages

Desde la raíz del repositorio:

```bash
cd "Week 2/RazorPagesMovie"
dotnet restore
dotnet ef database update
dotnet run
```

Abre la dirección indicada en la terminal y visita `/Movies`. Ejecuta cada aplicación por separado.

## Qué demuestra

- Separación entre modelos, acceso a datos y presentación.
- CRUD de películas con MVC y Razor Pages.
- Persistencia mediante Entity Framework Core y SQLite.
- Migraciones, datos iniciales y validación en formularios.

## Alcance

Repositorio de aprendizaje basado en ejercicios y tutoriales de curso. No corresponde a una aplicación de producción ni a un producto final desplegado.

## Autor

Ariel Rojas · [Portafolio](https://arojases.github.io/Portafolio/)
