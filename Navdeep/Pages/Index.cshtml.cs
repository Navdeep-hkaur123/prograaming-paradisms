using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace aspnetcoreapp.Pages;


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
        if (Request.Method.Equals("POST", System.StringComparison.OrdinalIgnoreCase)){
 
           
 
                ViewData["fullname"]=Request.Form["fname"]+" "+Request.Form["lname"];
 
            }
 
           
 
        }

    }

