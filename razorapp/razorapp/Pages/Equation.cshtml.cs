using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace razorapp.Pages
{
    public class EquationModel : PageModel
    {
        public (double x1, double x2) Solutions { get; private set; }
        public (double a, double b, double c) Coefficients { get; private set; }

        public void OnGet(double a, double b, double c)
        {
            Coefficients = (a, b, c);
            var d = b * b - 4 * a * c;
            Solutions =
                ((-b + Math.Sqrt(d)) / (2 * a),
                (-b - Math.Sqrt(d)) / (2 * a));
        }
    }
}