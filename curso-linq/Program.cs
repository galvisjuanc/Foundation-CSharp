// See https://aka.ms/new-console-template for more information

using curso_linq;

LinqQueries queries = new LinqQueries();

ImprimirValores(queries.TodaLaColeccion());

void ImprimirValores(IEnumerable<Book> listdelibros)
{
    Console.WriteLine("{0, -70}, {1, 7}, {2, 11}\n", "Titulo", "N. Paginas", "Fecha publicacion");
    foreach (var itemBook in listdelibros)
    {
        Console.WriteLine("{0, -70}, {1, 7}, {2, 11}", itemBook.Title, itemBook.PageCount,itemBook.PublishedDate);
    }
}