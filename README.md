# CSE 325 — Proyectos de C# y .NET

Repositorio académico del curso **CSE 325 de BYU–Idaho, completado en otoño de 2026**. Las cinco semanas de trabajo abarcan ejercicios de consola, APIs y aplicaciones web con ASP.NET Core, interfaces interactivas con Blazor y una introducción al desarrollo multiplataforma con .NET MAUI.

## Proyectos por semana

| Semana | Proyecto | Qué se practicó |
| --- | --- | --- |
| 1 | [CostosoPizza](Week%201/CostosoPizza) | API de pizzas con ASP.NET Core. |
| 1 | [DotNetDebugging](Week%201/DotNetDebugging), [DotNetDependencies](Week%201/DotNetDependencies) y [WorkWithFiles](Week%201/WorkWithFiles/mslearn-dotnet-files) | Depuración, dependencias y manejo de archivos en C#. |
| 2 | [BlazorApp](Week%202/BlazorApp) | Primeros componentes y páginas con Blazor. |
| 2 | [MyNewApp](Week%202/MyNewApp) | API mínima de tareas con datos en memoria, validación y middleware. |
| 2 | [MvcMovie](Week%202/MvcMovie) y [RazorPagesMovie](Week%202/RazorPagesMovie) | El mismo dominio de películas en dos modelos de ASP.NET Core. Ambos proyectos incluyen operaciones CRUD, validación de formularios, migraciones y datos iniciales con EF Core y SQLite. |
| 3 | [BlazingPizza](Week%203/BlazingPizza) | Aplicación de pedidos de pizza con Blazor Server y SQLite. |
| 4 | [ConnectFour](Week%204/ConnectFour) | Juego de cuatro en línea con un tablero interactivo, turnos y detección de victorias y empates. |
| 5 | [MyMauiApp](Week%205/MyMauiApp) y [MauiTest](Week%205/MauiTest) | Prácticas introductorias de interfaces multiplataforma con .NET MAUI y XAML. |

## Ejecutar los proyectos localmente

Clona el repositorio y ejecuta los comandos de cada ejemplo desde su raíz.

```bash
git clone https://github.com/arojases/CSE325_Project.git
cd CSE325_Project
```

### ConnectFour y BlazingPizza

Para jugar a ConnectFour, usa el SDK de .NET 10 y abre la dirección indicada en la terminal.

```bash
dotnet run --project "Week 4/ConnectFour"
```

BlazingPizza usa .NET 9 y crea su base de datos SQLite con datos iniciales al iniciarse por primera vez.

```bash
dotnet run --project "Week 3/BlazingPizza"
```

### Catálogos de películas

Ambas aplicaciones requieren el SDK de .NET 10 y `dotnet-ef` 10.x. Si aún no tienes la herramienta instalada, ejecuta:

```bash
dotnet tool install --global dotnet-ef --version 10.0.12
```

Para iniciar la versión MVC desde la raíz:

```bash
cd "Week 2/MvcMovie"
dotnet ef database update
dotnet run
```

Para iniciar la versión Razor Pages desde la raíz:

```bash
cd "Week 2/RazorPagesMovie"
dotnet ef database update
dotnet run
```

En ambos casos, abre la dirección indicada en la terminal y agrega `/Movies` a la URL. Cada aplicación usa su propia base de datos SQLite.

### Proyectos .NET MAUI

Abre el archivo `.csproj` de MyMauiApp o MauiTest en un entorno configurado para .NET MAUI con el SDK de .NET 10 y los componentes de la plataforma de destino.

## Autor

Ariel Rojas · [Portafolio](https://arojases.github.io/Portafolio/)
