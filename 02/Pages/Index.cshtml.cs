using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace _02.Pages;

public class IndexModel : PageModel
{
    public string? MeuTexto {get; set;}

    public void OnPost([FromForm] string meuTexto){
        MeuTexto = meuTexto;
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
