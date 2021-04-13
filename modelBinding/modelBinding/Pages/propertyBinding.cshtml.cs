using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace modelBinding.Pages
{
    public class propertyBindingModel : PageModel
    {
        [BindProperty]
        public int Age { get; set; }
        [BindProperty]
        public string FullName { get; set; }
        [BindProperty]
        public string Email { get; set; }

        public string Message { get; private set; }

        public void OnPost() => Message = Age < 18 ?
               $"Sorry, {FullName}. You cannot subscribe for our site." :
               $"Hello, {FullName}. Thank you for your subscription. We will send email to the address '{Email}'.";
    }
}

