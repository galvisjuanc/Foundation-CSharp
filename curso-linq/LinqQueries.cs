using System;
using System.Collections.Generic;
using System.Linq;
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
    }
}
