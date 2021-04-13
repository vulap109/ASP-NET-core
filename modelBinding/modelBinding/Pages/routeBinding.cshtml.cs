using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace modelBinding.Pages
{
    public class routeBindingModel : PageModel
    {
        public string Message { get; private set; }
        public void OnGet(string FullName, string Email, int Age) => Message = Age < 18 ?
               $"Sorry, {FullName}. You cannot subscribe for our site." :
               $"Hello, {FullName}. Thank you for your subscription. We will send email to the address '{Email}'.";

        // property binding cho route data
        //[BindProperty(SupportsGet = true)]
        //public int Age { get; set; }

        //[BindProperty(SupportsGet = true)]
        //public string FullName { get; set; }

        //[BindProperty(SupportsGet = true)]
        //public string Email { get; set; }

        //public string Message { get; private set; }

        //public void OnGet() => Message = Age < 18 ?
        //       $"Sorry, {FullName}. You cannot subscribe for our site." :
        //       $"Hello, {FullName}. Thank you for your subscription. We will send email to the address '{Email}'.";
    }
}