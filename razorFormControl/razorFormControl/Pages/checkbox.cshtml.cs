using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace razorFormControl.Pages
{
    public class checkboxModel : PageModel
    {
        public List<string> languages { get; private set; }
        public void OnPost( List<string> language)
        {
            languages = language;
        }
    }
}
