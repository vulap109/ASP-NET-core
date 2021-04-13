using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace razorFormControl.Pages
{
    public class IndexModel : PageModel
    {
            public string Title { get; private set; }
            public string Text { get; private set; }
        //public void OnPost(string title, string text)
        //{
        //    Title = title;
        //    Text = text;
        //}
        public void OnPost()
        {
            Title = Request.Form["title"];
            Text = Request.Form["text"];
        }
    }
    }