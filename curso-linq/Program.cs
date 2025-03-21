﻿using curso_linq;

var queries = new LinqQueries();

ImprimirValores(queries.TodaLaColeccion());

//ImprimirGrupo(queries.LibrosDespuesdel2000AgrupadosPorAño());

void ImprimirValores(IEnumerable<Book> listdelibros)
{
    Console.WriteLine("{0, -60} {1, 15} {2, 15}\n", "Titulo", "N. Paginas", "Fecha publicacion");
    foreach (var itemBook in listdelibros)
    {
        Console.WriteLine("{0, -60} {1, 15} {2, 15}", itemBook.Title, itemBook.PageCount,itemBook.PublishedDate.ToShortDateString());
    }
}

void ImprimirGrupo(IEnumerable<IGrouping<int, Book>> ListadeLibros)
{
    foreach (var grupo in ListadeLibros)
    {
        Console.WriteLine("");
        Console.WriteLine($"Grupo: { grupo.Key}");
        Console.WriteLine("{0, -60} {1, 15} {2, 15}\n", "Titulo", "N. Paginas", "Fecha publicacion");
        foreach (var itemBook in grupo)
        {
            Console.WriteLine("{0, -60} {1, 15} {2, 15}", itemBook.Title, itemBook.PageCount, itemBook.PublishedDate.ToShortDateString());
        }
    }
}

void ImprimirDiccionario(ILookup<char, Book> list, char letra)
{
    Console.WriteLine("{0, -60} {1, 15} {2, 15}\n", "Titulo", "N. Paginas", "Fecha publicacion");
    foreach (var itemD in list[letra])
    {
        Console.WriteLine("{0, -60} {1, 15} {2, 15}", itemD.Title, itemD.PageCount, itemD.PublishedDate.ToShortDateString());
    }
}

ImprimirValores(queries.LibrosDespuesdel2000());
ImprimirValores(queries.LibrosConMasde250PagConPalabrasInAction());

//Todos los libros tienen status
Console.WriteLine($"Todos los libros tienen status? - {queries.TodosLosLibrosTienenStatus()}");

//Todos los libros tienen status
Console.WriteLine($"Algún libro fue publicado en el año 2005? - {queries.SiAlgunLibroFuePublicadoEn2005()}");

// Libros de python
ImprimirValores(queries.LibrosdePython());

// Libros de android con LINQ
ImprimirValores(queries.BuscarLibrosConAndroid());

ImprimirValores(queries.LibrosOrdenadosPorNombreJava());

Console.WriteLine("\nOtra forma usando linq");
ImprimirValores(queries.LibrosOrdenadosPorNombreJavaLinq());

Console.WriteLine("\nOrdenando libros de forma descendente pór numero de paginas");
ImprimirValores(queries.LibrosConMasDe450PaginasYOrdenadosDescendentemente());

Console.WriteLine("\nOrdenando libros de forma descendente pór numero de paginas usando LINQ");
ImprimirValores(queries.LibrosConMasDe450PaginasYOrdenadosDescendentementeLinq());

Console.WriteLine("\nOrdenando libros con Take y Skip - Primer Ejemplo");
ImprimirValores(queries.TresPrimerosLibrosOrdenadosPorFecha());

Console.WriteLine("\nOrdenando libros con Take y Skip - Segundo Ejemplo");
ImprimirValores(queries.TresYCuartoLibroDeMasDe400Pag());

Console.WriteLine("\nImprimir valores dinámicos");
ImprimirValores(queries.TresPrimerosLibrosDeLaColeccion());

//Console.WriteLine("\nCantidad de libros entre 200 y 500 Paginas");
//Console.WriteLine(queries.CantidadDeLibrosEntre200y500Pag());

//Console.WriteLine($"Esta es la fecha de publicacion menor: {queries.FechaDePublicacionMenor()}");

//Console.WriteLine($"El libro con el mayor número de paginas es de: {queries.NumeroDePaginaMayorDeLibro()}.");

//var libroMenorPag = queries.LibroConMenorNumeroDePaginas();
//Console.WriteLine($"El libro con menor numero de páginas es: {libroMenorPag.Title} - con un total de: {libroMenorPag.PageCount} paginas");

//var libroFechaMayor = queries.LibroConFechaMasReciente();
//Console.WriteLine($"El libro con la fecha más reciente es: {libroFechaMayor.Title} - con una fecha de: {libroFechaMayor.PublishedDate.ToShortDateString()}");

var cuentaLibrosPaginasDe0a500 = queries.SumaDeTodasLasPaginasLibrosEntre0y500();
Console.WriteLine($"Suma total de paginas {cuentaLibrosPaginasDe0a500}");

var librosPublicados2015 = queries.TitulosDeLibrosDespuesDel2015Concatenados();
Console.WriteLine(librosPublicados2015);

//Console.WriteLine("Otro metodo usado");
//Func<Book, bool> condicionWhereFunc = (x => x.PublishedDate.Year > 2005 && x.Title != string.Empty);

//var titulos1 = queries.TitulosSeparadosGuion(condicionWhereFunc);
//var titulos2 = queries.TitulosSeparadosGuionV2(condicionWhereFunc);

//Console.WriteLine(titulos1);
//Console.WriteLine(titulos2);

//Console.WriteLine($"Promedio de caracteres de los titulos: {queries.PromedioCaracteresTitulo()}");

//queries.PromedioNumeroPaginasMayoresACero();

var diccionarioLookup = queries.DiccionariosDeLibrosPorLetra();
//<ImprimirDiccionario(diccionarioLookup, 'A');
//ImprimirDiccionario(diccionarioLookup, 'B');
ImprimirDiccionario(diccionarioLookup, 'C');

ImprimirValores(queries.LibrosDespuesDel2005Conmasde500Pags());

