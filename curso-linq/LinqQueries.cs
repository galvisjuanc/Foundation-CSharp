using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.JavaScript;
using System.Text;
using System.Threading.Tasks;

namespace curso_linq
{
    internal class LinqQueries
    {
        private List<Book> librosCollection = new List<Book>();

        public LinqQueries()
        {
            using StreamReader reader = new StreamReader("books.json");
            string json = reader.ReadToEnd();
            this.librosCollection = System.Text.Json.JsonSerializer.Deserialize<List<Book>>(json, new System.Text.Json.JsonSerializerOptions() { PropertyNameCaseInsensitive = true })!;
        }

        public IEnumerable<Book> TodaLaColeccion()
        {
            return librosCollection;
        }

        public IEnumerable<Book> LibrosDespuesdel2000()
        {
            // extension method
            // return librosCollection.Where(p => p.PublishedDate.Year > 2000);

            return from l in librosCollection where l.PublishedDate.Year > 2000 select l;
        }

        public IEnumerable<Book> LibrosConMasde250PagConPalabrasInAction()
        {
            // extension method
            //return librosCollection.Where(p => p.PageCount > 250 && p.Title.Contains("in Action"));
            return from l in librosCollection where l.PageCount > 250 && l.Title.Contains("in Action") select l;
        }

        public bool TodosLosLibrosTienenStatus()
        {
            return librosCollection.All(p => p.Status != string.Empty);
        }

        public bool SiAlgunLibroFuePublicadoEn2005()
        {
            return librosCollection.Any(p => p.PublishedDate.Year == 2005);
        }

        public IEnumerable<Book> LibrosdePython()
        {
            return librosCollection.Where(p => p.Categories.Contains("Python"));
        }

        public IEnumerable<Book> BuscarLibrosConAndroid()
        {
            return from l in librosCollection where l.Categories.Contains("Android") select l;
        }

        public IEnumerable<Book> LibrosOrdenadosPorNombreJava()
        {
            return librosCollection.Where(p => p.Categories.Contains("Java")).OrderBy(p => p.Title);
        }

        public IEnumerable<Book> LibrosOrdenadosPorNombreJavaLinq()
        {
            return from l in librosCollection where l.Categories.Contains("Java") orderby l.Title select l;
        }

        public IEnumerable<Book> LibrosConMasDe450PaginasYOrdenadosDescendentemente()
        {
            return librosCollection.Where(p => p.PageCount > 450).OrderByDescending(p => p.PageCount);
        }

        public IEnumerable<Book> LibrosConMasDe450PaginasYOrdenadosDescendentementeLinq()
        {
            return from l in librosCollection where l.PageCount > 450 orderby l.PageCount descending select l;
        }

        public IEnumerable<Book> TresPrimerosLibrosOrdenadosPorFecha()
        {
            return librosCollection
                .Where(p => p.Categories.Contains("Java"))
                .OrderBy(p => p.PublishedDate)
                .TakeLast(3);
        }

        public IEnumerable<Book> TresYCuartoLibroDeMasDe400Pag()
        {
            return librosCollection
                .Where(p => p.PageCount > 400)
                .Take(4)
                .Skip(2);
        }

        public IEnumerable<Book> TresPrimerosLibrosDeLaColeccion()
        {
            return librosCollection
                .Take(3)
                .Select(p => new Book() { Title = p.Title, PageCount = p.PageCount });
        }

        public long CantidadDeLibrosEntre200y500Pag()
        {
            return librosCollection.LongCount(p => p.PageCount >= 200 && p.PageCount <= 500);
        }

        public DateTime FechaDePublicacionMenor()
        {
            return librosCollection.Min(p => p.PublishedDate);
        }

        public int NumeroDePaginaMayorDeLibro()
        {
            return librosCollection.Max(p => p.PageCount);
        }

        public Book LibroConMenorNumeroDePaginas()
        {
            return librosCollection.Where(p => p.PageCount > 0).MinBy(p => p.PageCount);
        }

        public Book LibroConFechaMasReciente()
        {
            return librosCollection.MaxBy(p => p.PublishedDate);
        }

        public int SumaDeTodasLasPaginasLibrosEntre0y500()
        {
            return librosCollection.Where(p => p.PageCount >= 0 && p.PageCount <= 500).Sum(p => p.PageCount);
        }

        public string TitulosDeLibrosDespuesDel2015Concatenados()
        {
            return librosCollection
                .Where(p => p.PublishedDate.Year > 2015)
                .Aggregate("", (TitulosLibros, next) =>
                {
                    if (TitulosLibros != string.Empty)
                        TitulosLibros += " - " + next.Title;
                    else
                        TitulosLibros += next.Title;

                    return TitulosLibros;
                });
        }

        public string TitulosSeparadosGuion(Func<Book, bool> where)
            => string.Join(" - ", this.librosCollection.Where(where).Select(x => x.Title));

        public string TitulosSeparadosGuionV2(Func<Book, bool> where)
        {
            return this.librosCollection.Where(where).Aggregate("",
                (acum, next) => acum += (!string.IsNullOrEmpty(acum) ? $" - {next.Title}" : next.Title));
        }

        public double PromedioCaracteresTitulo()
        {
            return librosCollection.Average(o => o.Title.Length);
        }

        public void PromedioNumeroPaginasMayoresACero()
        {
            var avg = librosCollection.Where(b => b.PageCount > 0).Average(b => b.PageCount);
            Console.WriteLine($"El promedio de número de páginas que son mayores a cero: {avg}");
        }

        public IEnumerable<IGrouping<int, Book>> LibrosDespuesdel2000AgrupadosPorAño()
        {
            return librosCollection.Where(p => p.PublishedDate.Year >= 2000).GroupBy(p => p.PublishedDate.Year);
        }

        public ILookup<char, Book> DiccionariosDeLibrosPorLetra()
        {
            return librosCollection.ToLookup(p => p.Title[0], p => p);
        }

        public IEnumerable<Book> LibrosDespuesDel2005Conmasde500Pags()
        {
            var LibrosDespuesDel2005 = librosCollection.Where(p => p.PublishedDate.Year > 2005);

            return LibrosDespuesDel2005;
        }
    }
}
