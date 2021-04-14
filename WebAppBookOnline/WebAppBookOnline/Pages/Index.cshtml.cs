using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAppBookOnline.Interface;
using WebAppBookOnline.Models;

namespace WebAppBookOnline.Pages
{
    public class IndexModel : PageModel
    {
        private readonly IRepository _repository;
        public HashSet<book> books => _repository.Books;
        public int count => _repository.Books.Count;
        public IndexModel(IRepository repository)
        {
            _repository = repository;
        }
        public void OnGet()
        {

        }
    }
}
