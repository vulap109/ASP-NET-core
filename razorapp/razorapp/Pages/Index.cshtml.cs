using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace razorapp.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;

        }
        public int Age { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName => $"{FirstName} {LastName}";

        public string SayGoodbye() => $"Hello, {FullName}! I'm in the model class";

        public string message { get; set; }
        public void OnGet()
        {
            //FirstName = "Donald";
            //LastName = "Trump";

            message = "this is get message";
        }

        public void OnPost()
        {
            message = "this is POST message";

        }
    }
}
