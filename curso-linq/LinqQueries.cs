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

    }
}
