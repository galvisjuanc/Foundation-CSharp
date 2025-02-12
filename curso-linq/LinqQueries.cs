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
            using (StreamReader reader = new StreamReader("books.json"))
            {
                string json = reader.ReadToEnd();
                this.librosCollection = System.Text.Json.JsonSerializer.Deserialize<List<Book>>(json);
            }
        }
    }
}
