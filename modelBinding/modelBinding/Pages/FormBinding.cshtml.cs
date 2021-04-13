using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace modelBinding.Pages
{
    public class FormBindingModel : PageModel
    {
        public string Message { get; private set; }
        public void OnPost(string fullName, string eMail, int age) => Message = age < 18 ?
                $"Sorry, {fullName}. You cannot subscribe for our site." :
                $"Hello, {fullName}. Thank you for your subscription. We will send email to the address '{eMail}'.";
    }
}
