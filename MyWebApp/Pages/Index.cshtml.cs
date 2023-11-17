using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace MyWebApp.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }

        public void OnPost()
        {
            if (Request.Method.Equals("POST", System.StringComparison.OrdinalIgnoreCase))
            {
                string num1 = Request.Form["number1"];
                string num2 = Request.Form["number2"];

                if (double.TryParse(num1, out var number1))
                {
                    double result = 0;

                    if (Request.Form["x2"] == "x2")
                    {
                        result = CalculateSquare(number1);
                    }

                    if (Request.Form["x3"] == "x3")
                    {
                        result = CalculateCube(number1);
                    }

                    if (Request.Form["power"] == "power" && double.TryParse(num2, out var num2))
                    {
                        result = CalculatePower(number1, number2);
                    }

                    ViewData["result"] = result;
                }
                else
                {
                    // Handle invalid input
                    ViewData["result"] = "Invalid input";
                }
            }
        }

        private double CalculateSquare(double value)
        {
            return value * value;
        }

        private double CalculateCube(double value)
        {
            return value * value * value;
        }

        private double CalculatePower(double baseValue, double exponent)
        {
            double result = 1;

            for (int i = 1; i <= exponent; i++)
            {
                result *= baseValue;
            }

            return result;
        }
    }
}