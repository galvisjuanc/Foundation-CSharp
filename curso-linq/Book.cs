using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace curso_linq
{
    internal class Book
    {
        public string Title { get; set; }
        public int PageCount { get; set; }
        public DateTime PublishedDate { get; set; }
        public string ThumbnailUrl { get; set; }
        public string ShortDescription { get; set; }
        public string Status { get; set; }
        public string[] Authors { get;set; }
        public string[] Categories { get; set; }
    }
}
