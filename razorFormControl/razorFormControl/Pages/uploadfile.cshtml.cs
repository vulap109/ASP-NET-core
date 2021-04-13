using System;
using System.IO;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace razorFormControl.Pages
{
    public class uploadfileModel : PageModel
    {
        private readonly IWebHostEnvironment _environment;
        public uploadfileModel(IWebHostEnvironment environment) => _environment = environment;

        public bool Success { get; private set; } = true;

        public void OnPost(IFormFile file)
        {
            try
            {
                var f = Path.Combine(_environment.ContentRootPath, "upload", file.FileName);
                using var fs = new FileStream(f, FileMode.Create);
                file.CopyTo(fs);
                ViewData["file"] = file.FileName;
            }
            catch (Exception)
            {
                Success = false;
            }
        }
    }
}