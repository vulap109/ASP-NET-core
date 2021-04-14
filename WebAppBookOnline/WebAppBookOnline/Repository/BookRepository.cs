using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAppBookOnline.Interface;
using WebAppBookOnline.Models;

namespace WebAppBookOnline.Repository
{
    public class BookRepository : IRepository
    {
        public HashSet<book> Books { get; set; } = new HashSet<book>
        {
            new book {Id = 1, Title = "ASP.NET Core for dummy",Publisher = "Apress", Year = 2018, Authors = "Donald Trump"},
            new book {Id = 2,  Title = "Professional ASP.NET Core 3",Publisher = "Manning", Year = 2019, Authors = "Bill Clinton"},
            new book {Id = 3,  Title = "ASP.NET Core Self learning",Publisher = "Wiley", Year = 2017,Authors = "Barack Obama"},
            new book {Id = 4,  Title = "ASP.NET Core quick course",Publisher = "Linda",Authors = "George Bush"},
            new book {Id = 5,  Title = "ASP.NET Core Video Course",Publisher = "Linda", Authors = "Vladimir Putin"},
        };
        public book Get(int id) => Books.SingleOrDefault(b => b.Id == id);

        public bool Delete(int id)
        {
            var book = Get(id);
            return book != null ? Books.Remove(book) :false;
        }
    }
}