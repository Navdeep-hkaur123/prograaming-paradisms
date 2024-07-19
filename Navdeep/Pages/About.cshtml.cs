using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace aspnetcoreapp.Pages;

public class AboutModel : PageModel
{
    private readonly ILogger<AboutModel> _logger;

    public AboutModel(ILogger<AboutModel> logger)
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
            double num1 = double.Parse(Request.Form["num1"]);

            if (Request.Form["+"] == "+")
            {
                double num2 = double.Parse(Request.Form["num2"]);
                ViewData["Result"] = num1 + num2;
            }
            else if (Request.Form["-"] == "-")
            {
                double num2 = double.Parse(Request.Form["num2"]);
                ViewData["Result"] = num1 - num2;
            }
            else if (Request.Form["*"] == "*")
            {
                double num2 = double.Parse(Request.Form["num2"]);
                ViewData["Result"] = num1 * num2;
            }
            else if (Request.Form["/"] == "/")
            {
                double num2 = double.Parse(Request.Form["num2"]);
                ViewData["Result"] = num1 / num2;
            }
            else if (Request.Form["PWR"] == "PWR")
            {
                double num2 = double.Parse(Request.Form["num2"]);
                ViewData["Result"] = Math.Pow(num1, num2);
            }
            else if (Request.Form["SQR"] == "SQR")
            {
                ViewData["Result"] = num1 * num1;
            }
            else if (Request.Form["CUBE"] == "CUBE")
            {
                ViewData["Result"] = num1 * num1 * num1;
            }
        }
    }
}
