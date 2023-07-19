using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace _04.Pages;

public class IndexModel : PageModel
{
    public int? Media {get; set;}

    public void OnPost([FromForm] int nota1, int nota2, int nota3, int nota4){
        Media = (nota1 + nota2 + nota3 + nota4)/4;
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
