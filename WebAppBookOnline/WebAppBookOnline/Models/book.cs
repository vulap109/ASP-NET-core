using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppBookOnline.Models
{
    public class book
    {
        public int Id { get; set; }
        public string Title { get; set; } = "A new Book";
        public string Authors { get; set; } = "Authors";
        public string Publisher { get; set; } = "publisher";
        public int Year { get; set; } = DateTime.Now.Year;
        public string Description { get; set; } = "";
    }
}
