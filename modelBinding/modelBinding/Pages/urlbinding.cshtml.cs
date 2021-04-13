using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace modelBinding.Pages
{
    public class urlbindingModel : PageModel
    {
        // su dung parameter binding
        //public string Message { get; set; }
        //public void OnGet(string fullName, string eMail, int age) => Message = age < 18 ?
        //    $"Sorry, {fullName}. You cannot subscribe for our site." :
        //    $"Hello, {fullName}. Thank you for your subscription. We will send email to the address '{eMail}'.";

        //---------------------------------------------------------------------------------------------------------------
        // su dung property binding doi voi url binding,mac dinh property binding chi su dung cho POST
        // nen can dieu chinh attribute [BindProperty] thanh [BindProperty(SupportsGet = true)]
        [BindProperty(SupportsGet = true)]
        public int Age { get; set; }

        [BindProperty(SupportsGet = true)]
        public string FullName { get; set; }

        [BindProperty(SupportsGet = true)]
        public string Email { get; set; }

        public string Message { get; private set; }

        public void OnGet() => Message = Age < 18 ?
               $"Sorry, {FullName}. You cannot subscribe for our site." :
               $"Hello, {FullName}. Thank you for your subscription. We will send email to the address '{Email}'.";
    }
}