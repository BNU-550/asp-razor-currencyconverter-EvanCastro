using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorCurrencyConverter.Pages
{
    using Microsoft.AspNetCore.Mvc.RazorPages;
    using Microsoft.AspNetCore.Mvc;

    namespace RazorCurrencyConverter.Pages
    {
        public class CurrencyConverterModel : PageModel
        {

            public const double GBP_TO_USDT = 1.36;

            [BindProperty]
            public double InputGBP { get; set; }
            [BindProperty]
            public double OutputUSDT { get; set; }

            public void OnGet()
            {

            }

            public void OnPost()
            {
                if (double.IsNegative(InputGBP))
                {
                    ViewData["Message"] = "Invalid! Please enter a positive number";
                }
                else
                {
                    OutputUSDT = InputGBP * GBP_TO_USDT;
                }
            }
        }
    }
}