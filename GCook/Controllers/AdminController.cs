using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;

namespace GCook.Controllers;

[Authorize(Roles = "Administrador")]
public class AdminControler : Controller
{
    private readonly ILogger<AdminControler> _logger;

    public AdminControler(ILogger<AdminControler> logger)
    {
        _logger = _logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View("Error!");
    }
}