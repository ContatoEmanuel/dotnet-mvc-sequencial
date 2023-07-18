using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace _03.Pages;

public class IndexModel : PageModel
{
    public int? Result {get; set;}

    public void OnPost([FromForm] int num1, int num2){
        Result = num1 + num2;
    }
    private readonly ILogger<IndexModel> _logger;

    public IndexModel(ILogger<IndexModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {

    }
}
