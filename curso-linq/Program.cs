using curso_linq;

var queries = new LinqQueries();

//ImprimirValores(queries.TodaLaColeccion());

void ImprimirValores(IEnumerable<Book> listdelibros)
{
    Console.WriteLine("{0, -60} {1, 15} {2, 15}\n", "Titulo", "N. Paginas", "Fecha publicacion");
    foreach (var itemBook in listdelibros)
    {
        Console.WriteLine("{0, -60} {1, 15} {2, 15}", itemBook.Title, itemBook.PageCount,itemBook.PublishedDate.ToShortDateString());
    }
}

//ImprimirValores(queries.LibrosDespuesdel2000());

ImprimirValores(queries.LibrosConMasde250PagConPalabrasInAction());

//Todos los libros tienen status
Console.WriteLine($"Todos los libros tienen status? - {queries.TodosLosLibrosTienenStatus()}");

//Todos los libros tienen status
Console.WriteLine($"Algún libro fue publicado en 2005? - {queries.SiAlgunLibroFuePublicadoEn2005()}");

// Libros de python
ImprimirValores(queries.LibrosdePython());

// Libros de android con LINQ
ImprimirValores(queries.BuscarLibrosConAndroid());

ImprimirValores(queries.LibrosOrdenadosPorNombreJava());

Console.WriteLine("\nOtra forma usando query linq");
ImprimirValores(queries.LibrosOrdenadosPorNombreJavaLinq());

Console.WriteLine("\nOrdenando libros de forma descendente pór numero de paginas");
ImprimirValores(queries.LibrosConMasDe450PaginasYOrdenadosDescendentemente());

Console.WriteLine("\nOrdenando libros de forma descendente pór numero de paginas usando LINQ");
ImprimirValores(queries.LibrosConMasDe450PaginasYOrdenadosDescendentementeLinq());

Console.WriteLine("\nOrdenando libros usando Take y Skip");
ImprimirValores(queries.TresPrimerosLibrosOrdenadosPorFecha());

ImprimirValores(queries.TresYCuartoLibroDeMasDe400Pag());