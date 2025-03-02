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

Console.WriteLine("\nCantidad de libros entre 200 y 500 Paginas");
Console.WriteLine(queries.CantidadDeLibrosEntre200y500Pag());