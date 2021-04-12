using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace razorapp.Pages
{
    public class multiformModel : PageModel
    {
        public string mesage { get; set; } = "initial request";

        public void OnGet()
        {
        }

        public void OnPost()
        {
            mesage = "form Posted";
        }
        public void OnPostDelete()
        {
            mesage = "delete handler fired";
        }
        public void OnPostEdit(int id)
        {
            mesage = "edit handler fired";
        }
        public void OnPostView(int id)
        {
            mesage = "view handler fired";
        }
    }
}
